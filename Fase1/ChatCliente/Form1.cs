using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using EI.SI;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        private const int PORT = 50001;
        NetworkStream networkStream;
        ProtocolSI protocolSI;
        TcpClient tcpClient;
        public Form1()
        {
            InitializeComponent();
            InitializeComponent();
            gbHome.Visible = true;
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, PORT);
            tcpClient = new TcpClient();
            tcpClient.Connect(endPoint);
            networkStream = tcpClient.GetStream();
            protocolSI = new ProtocolSI();

        }
       
        private void btnHomeRegistar_Click(object sender, EventArgs e)
        {
            gbHome.Visible = false;
            gbRegistar.Visible = true;

        }

        private void btnHomeLogin_Click(object sender, EventArgs e)
        {
            gbHome.Visible = false;
            gbLogin.Visible = true;
        }

        private void CreateIPS(string user)
        {
            //criação tcp ip, port e ligação ao server

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            //Registo de novo cliente
            string user = txtRUser.Text;
            string pass = txtRPass.Text;
            string success = "Sucesso!";

            MessageBox.Show("Registo efetuado\n" + "Bem-vind@, " + user, success, MessageBoxButtons.OK);
            lblUsername.Text = user;
            lblLastAccess.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            gbUserInfo.Visible = true;

            
            gbRegistar.Visible = false;
            gbChat.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Login cliente já existente
            string user = txtLUser.Text;
            string pass = txtLPass.Text;
            gbLogin.Visible = false;


            gbChat.Visible = true;
            lblUsername.Text = user;
            lblLastAccess.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            gbUserInfo.Visible = true;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtMessage.Text;
            txtMessage.Clear();
            byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, msg);
            //cria uma mensagem/pacote de um tipo específico
            networkStream.Write(packet, 0, packet.Length);
            while (protocolSI.GetCmdType() != ProtocolSICmdType.ACK)
            {
                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            }

            lbChat.Items.Add(msg);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Fecha a sessão do utilizador e retorna à página de Login/Sign In
            //Termina sessões IP e ligações ao Server
            gbChat.Visible = false;
            gbUserInfo.Visible = false;
            gbHome.Visible = true;

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //confirmação de saída da aplicação
            string message = "Deseja mesmmo sair da aplicação?";
            string title = "Confirmar Saída";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                //Termina sessões IP e ligações ao Server
                //Fecha a Aplicação

                Close();
            }
            else
            {
                return;
            }
            ClosecClient();
        }
        private void ClosecClient()
        {
            byte[] eot = protocolSI.Make(ProtocolSICmdType.EOT);
            networkStream.Write(eot, 0, eot.Length);
            networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            networkStream.Close();
            tcpClient.Close();
        }
    }
}
