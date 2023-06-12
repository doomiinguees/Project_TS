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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;
using System.IO;

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
                    ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\dadom\OneDrive\Ambiente de Trabalho\Project_TS-main\Fase2\ChatServer\Database1.mdf';Integrated Security=True")
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
            if (VerifyLogin( username,password))
            {
                gbLogin.Visible = false;
                gbChat.Visible = true;
                lblUsername.Text = username;
                lblLastAccess.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                gbUserInfo.Visible = true;
               
            }
            else
            {
                MessageBox.Show("Utilizador inválido!");
            }

        }

        private bool VerifyLogin(string username, string password)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection();
                conn.ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\dadom\OneDrive\Ambiente de Trabalho\Project_TS-main\Fase2\ChatServer\Database1.mdf';Integrated Security=True");

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração do comando SQL
                String sql = "SELECT * FROM Utilizadores WHERE Username = @username";
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
                string confirmar = hash.ToString();
               
                VerificarSALTEDHASH(confirmar);
            
                return saltedPasswordHashStored.SequenceEqual(hash);
           
              

             

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
                return false;
            }
        }


        private void VerificarSALTEDHASH(string hash)
        {
            SqlConnection conn = null;
            try
            {
                // Configurar ligação à Base de Dados
                conn = new SqlConnection
                {
                    ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\dadom\OneDrive\Ambiente de Trabalho\Project_TS-main\Fase2\ChatServer\Database1.mdf';Integrated Security=True")
                };
                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração do comando SQL

                string confirmar = hash;


                      String sql = "SELECT * FROM Utilizadores WHERE SaltedPasswordHash = @confirmar";
                       SqlCommand cmd = new SqlCommand();
                       cmd.CommandText = sql;

                // Declaração dos parâmetros do comando SQL
                SqlParameter param = new SqlParameter("@confirmar", confirmar);

                // Introduzir valor ao parâmentro registado no comando SQL
                cmd.Parameters.Add(param);

                // Associar ligação à Base de Dados ao comando a ser executado
                cmd.Connection = conn;

                // Executar comando SQL
                SqlDataReader reader = cmd.ExecuteReader();


                // Executar comando SQL
                int lines = cmd.ExecuteNonQuery();

                if (lines == 0)
                {
                    // Se forem devolvidas 0 linhas alteradas então o não foi executado com sucesso
                    throw new Exception("PASSE ERRADA");
                }
                return ;
            }
            catch
            {
               

            }
        }


       

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtMessage.Text;
            byte[] salt = GenerateSalt(SALTSIZE);
            byte[] hash = GenerateSaltedHash(msg, salt);
            txtMessage.Clear();
            guardarmensagem(hash);

            byte[] packet = protocolSI.Make(ProtocolSICmdType.DATA, hash);
            //cria uma mensagem/pacote de um tipo específico
            networkStream.Write(packet, 0, packet.Length);
            while (protocolSI.GetCmdType() != ProtocolSICmdType.ACK)
            {
                networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
            }

           /* string username = IdentifierClient();
            byte[] msghash = buscarsalt(username,hash);

            byte[] hash1 = GenerateSaltedHash(Convert.ToBase64String(hash), msghash);

            string chave = 



            string texto = Convert.ToBase64String(hash1);
          // string enviar = Descriptografar(texto, chave); */
            lbChat.Items.Add(msg);
        }

       
    

         private string IdentifierClient()
        {
            string idcliente;

          
            if (txtRUser.Text != null)
            {
                idcliente = txtRUser.Text;
            }
            else
                {
                    idcliente = txtLUser.Text;
                }
                return idcliente;
        }

        private byte[] buscarsalt(string username, byte[] hash)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                // Configurar a conexão com o banco de dados
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\dadom\OneDrive\Ambiente de Trabalho\Project_TS-main\Fase2\ChatServer\Database1.mdf';Integrated Security=True";

                // Abrir conexão com o banco de dados
                conn.Open();

                // Declaração do comando SQL
                string sql = "SELECT Salt FROM Utilizadores WHERE UltimaMSG = @hash AND Username = @username";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Declaração dos parâmetros do comando SQL
                SqlParameter paramHash = new SqlParameter("@hash", hash);
                SqlParameter paramUsername = new SqlParameter("@username", username);

                // Adicionar parâmetros ao comando SQL
                cmd.Parameters.Add(paramHash);
                cmd.Parameters.Add(paramUsername);

                // Executar o comando SQL e obter o leitor de dados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        byte[] salt = (byte[])reader["Salt"];
                        return salt;
                    }
                    else
                    {
                        // Nenhuma linha encontrada, retornar valor nulo ou lidar com a situação adequadamente
                        return null;
                    }
                }
            }
        }


        private void guardarmensagem(byte[] hash)
        {

            string nome = IdentifierClient();

      
            SqlConnection conn = null;
            try
            {

                // Configurar ligação à Base de Dados
                conn = new SqlConnection
                {
                    ConnectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\dadom\OneDrive\Ambiente de Trabalho\Project_TS-main\Fase2\ChatServer\Database1.mdf';Integrated Security=True")
                };

                // Abrir ligação à Base de Dados
                conn.Open();

                // Declaração dos parâmetros do comando SQL
                SqlParameter paramMensagem = new SqlParameter("@ultimamsg", hash);
                SqlParameter paramNome = new SqlParameter("@user", nome);

                // Declaração do comando SQL
                string sqlUpdate = "UPDATE Utilizadores SET ULTIMAMSG = @ultimamsg WHERE Username = @user";
            
                // Preparar comando SQL para ser executado na Base de Dados
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, conn);

                // Introduzir valores aos parâmetros registrados no comando SQL
                cmdUpdate.Parameters.Add(paramMensagem);
                cmdUpdate.Parameters.Add(paramNome);

                // Executar comando SQL
                int lines = cmdUpdate.ExecuteNonQuery();

                // Fechar ligação
                conn.Close();
                if (lines == 0)
                {
                    // Se forem devolvidas 0 linhas alteradas então o não foi executado com sucesso
                    throw new Exception("Error while inserting an user");
                }
            }catch (Exception ex)
            {

               MessageBox.Show("ERRO");
            }


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






            public class LogSistema
            {
        private string nomeArquivo;

        public LogSistema(string nomeArquivo)
        {
            this.nomeArquivo = nomeArquivo;
        }

        public void RegistrarLog(string mensagem)
        {
            string dataHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string log = $"{dataHora} - {mensagem}";

            using (StreamWriter writer = File.AppendText(nomeArquivo))
            {
                writer.WriteLine(log);
            }
        }
    }









}
}
