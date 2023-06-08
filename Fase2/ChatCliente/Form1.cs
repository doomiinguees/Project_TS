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
using System.Security.Cryptography;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace ChatCliente
{
    public partial class Form1 : Form
    {
       
        private const int PORT = 50001;

        private const int SALTSIZE = 8;
        private const int NUMBER_OF_ITERATIONS = 1000;

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
            String pass = txtRPass.Text;
            String username = txtRUser.Text;
            byte[] salt = GenerateSalt(SALTSIZE);
            byte[] hash = GenerateSaltedHash(pass, salt); 
            Register(username, hash, salt);
            gbRegistar.Visible = false;
            gbChat.Visible = true;
        }
        private void Register(string username, byte[] saltedPasswordHash, byte[] salt)
        {
          
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection
                {
                    ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\dadom\OneDrive\Ambiente de Trabalho\teste\ChatCliente\Database1.mdf';Integrated Security=True")
                };

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração dos parâmetros do comando SQL
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassHash = new SqlParameter("@saltedPasswordHash", saltedPasswordHash);
                SqlParameter paramSalt = new SqlParameter("@salt", salt);

                // Declaração do comando SQL
                String sql = "INSERT INTO Utilizadores (Username, SaltedPasswordHash, Salt) VALUES (@username,@saltedPasswordHash,@salt)";

                // Prepara comando SQL para ser executado na Base de Dados
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Introduzir valores aos parâmetros registrados no comando SQL
                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassHash);
                cmd.Parameters.Add(paramSalt);

                // Executar comando SQL
                int lines = cmd.ExecuteNonQuery();

                // Fechar ligação
                conn.Close();
                if (lines == 0)
                {
                    // Se forem devolvidas 0 linhas alteradas então o não foi executado com sucesso
                    throw new Exception("Error while inserting an user");
                }
                MessageBox.Show("Registado com sucesso!");
            }
            catch (Exception e)
            {
                    throw new Exception("Error while inserting an user:" + e.Message);
            }
        }
        private static byte[] GenerateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return buff;
        }
        private static byte[] GenerateSaltedHash(string plainText, byte[] salt)
        {
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(plainText, salt, NUMBER_OF_ITERATIONS);
            return rfc2898.GetBytes(32);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String password = txtLPass.Text;
            String username = txtLUser.Text;

            //Verificar
            if (VerifyLogin( username,pass))
            {
                MessageBox.Show("Utilizador válido!");
            }
            else
            {
                MessageBox.Show("Utilizador inválido!");
            }


            /*
            try
            {
                if (user == userhard)
                {
                    if (pass == passhard)
                    {
                        gbLogin.Visible = false;
                        gbChat.Visible = true;
                        lblUsername.Text = user;
                        lblLastAccess.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        gbUserInfo.Visible = true;
                    }
                    
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nome de Utilizador ou Palavra-passe Incorretos");
                return;
            }
            */



        }


        private bool VerifyLogin(string username, string password)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\nunosimoes\Documents\2022_2023_TopSegurança\Nocturno\Ficha8\FichaPratica8\FichaPratica8_Base\Database.mdf';Integrated Security=True");

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração do comando SQL
                String sql = "SELECT * FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;

                // Declaração dos parâmetros do comando SQL
                SqlParameter param = new SqlParameter("@username", username);

                // Introduzir valor ao parâmentro registado no comando SQL
                cmd.Parameters.Add(param);

                // Associar ligação à Base de Dados ao comando a ser executado
                cmd.Connection = conn;

                // Executar comando SQL
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.HasRows)
                {
                    throw new Exception("Error while trying to access an user");
                }

                // Ler resultado da pesquisa
                reader.Read();

                // Obter Hash (password + salt)
                byte[] saltedPasswordHashStored = (byte[])reader["SaltedPasswordHash"];

                // Obter salt
                byte[] saltStored = (byte[])reader["Salt"];

                conn.Close();

                byte[] hash = GenerateSaltedHash(password, saltStored);
                return saltedPasswordHashStored.SequenceEqual(hash);
                //TODO: verificar se a password na base de dados 
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
                return false;
            }
        }

        private void buttonGenerateSaltedHash_Click(object sender, EventArgs e)
        {
            String password = txtLPass.Text;

            byte[] salt = GenerateSalt(SALTSIZE);
            byte[] hash = GenerateSaltedHash(password, salt);

            textBoxSaltedHash.Text = Convert.ToBase64String(hash);
            textBoxSalt.Text = Convert.ToBase64String(salt);

            textBoxSizePass.Text = (hash.Length * 8).ToString();
            textBoxSizeSalt.Text = (salt.Length * 8).ToString();
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
