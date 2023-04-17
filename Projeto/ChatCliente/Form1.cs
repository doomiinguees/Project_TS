using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            //Enviar Mensagem
            string message = txtMessage.Text;

            lbChat.Items.Add(message);
            txtMessage.Clear();
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
        }
    }
}
