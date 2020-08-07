using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //get user IP
            inputMyIP.Text = GetLocalIP();
            inputFriendIP.Text = GetLocalIP();
        }

        private void startCommunication_Click(object sender, EventArgs e)
        {
            //binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(inputMyIP.Text), Convert.ToInt32(inputMyPort.Text));
            sck.Bind(epLocal);
            //connecting to remote IP
            epRemote = new IPEndPoint(IPAddress.Parse(inputFriendIP.Text), Convert.ToInt32(inputFriendPort.Text));
            sck.Connect(epRemote);
            //Listening the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try { 
                byte[] reciveData = new byte[1500];
                reciveData = (byte[])aResult.AsyncState;
                //Converting byte to string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string recivedMessage = aEncoding.GetString(reciveData);
                //Adding this message into Listbox
                listMessage.Items.Add("Friend: " + recivedMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            //convert string to byte
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(newMessage.Text);
            //Sending the Encoded message
            sck.Send(sendingMessage);
            //adding to the listbox
            listMessage.Items.Add("Me: " + newMessage.Text);
            newMessage.Text = "";
        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
    }
}
