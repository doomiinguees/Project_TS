using EI.SI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    internal class Program
    {
        // criar novamente uma constante tal como feito do lado do cliente
        private const int PORT = 50001;
        private static List<ClientHandler> clients = new List<ClientHandler>();

        static void Main(string[] args)
        {
            // definição de variáveis na função principal
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, PORT);
            TcpListener listener = new TcpListener(endPoint);

            // iniciar o listener; apresentação da primeira mensagem na linha de comandos e inicialização do contador
            listener.Start();
            Console.WriteLine("SERVER READY");
            int clientCounter = 0;

            // criação do ciclo infinito de forma a que este esteja sempre em execução até ordem em contrário
            while (true)
            {
                // definição da variável client do tipo TcpClient
                TcpClient client = listener.AcceptTcpClient();

                // incrementação do contador, de forma a que vá sempre somando 1 (+1)
                clientCounter++;
                Logg.Connected("Cliente" + clientCounter);
                // apresentação da mensagem indicativa do nº do cliente na linha de comandos
                Console.WriteLine("Client {0} connected", clientCounter);

                // definição da variável clientHandler do tipo ClientHandler
                ClientHandler clientHandler = new ClientHandler(client, clientCounter);
                clientHandler.Handle();

                // adicionar o clientHandler à lista de clientes
                clients.Add(clientHandler);
            }
        }
        class ClientHandler
        {
            // definição das variáveis client e clientID
            private TcpClient client;
            private int clientID;
            private RSACryptoServiceProvider rsa;

            public ClientHandler(TcpClient client, int clientID)
            {
                this.client = client;
                this.clientID = clientID;
            }

            public void Handle()
            {
                // definição da variável thread e arranque da mesma. para relembrar: threads são unidades de execução dentro de um processo; um conjunto de instruções
                Thread thread = new Thread(ThreadHandler);
                thread.Start();
            }

            public void Broadcast(string message)
            {
                foreach (var client in clients)
                {
                    //  string messageToSend = client.EncryptData(message);
                    //client.SendMessage(messageToSend);
                    Console.WriteLine("Ending Thread from Client {0}", clientID);
                }
            }

            private void ThreadHandler()
            {
                // definição das variáveis networkStream e protocolSI
                NetworkStream networkStream = this.client.GetStream();
                ProtocolSI protocolSI = new ProtocolSI();

                // ciclo a ser executado até ao fim da transmissão
                while (protocolSI.GetCmdType() != ProtocolSICmdType.EOT)
                {
                    try
                    {
                        int bytesRead = networkStream.Read(protocolSI.Buffer, 0, protocolSI.Buffer.Length);
                    }
                    catch (Exception)
                    {
                        return;
                        throw;
                    }

                    byte[] ack;

                    // "alteração"/mudança entre a apresentação da mensagem e o fim da transmissão
                    switch (protocolSI.GetCmdType())
                    {
                        case ProtocolSICmdType.PUBLIC_KEY:
                            rsa.FromXmlString(protocolSI.GetStringFromData());
                            Console.WriteLine("Chave publica criada", clientID);
                            break;

                        case ProtocolSICmdType.DATA:
                            Logg.WriteLog(clientID.ToString(), "Client " + clientID + " sent a message.");
                            Console.WriteLine("Client " + clientID + " sent a message.");
                            Broadcast(protocolSI.GetStringFromData());
                            ack = protocolSI.Make(ProtocolSICmdType.ACK);
                            networkStream.Write(ack, 0, ack.Length);
                            break;

                        case ProtocolSICmdType.EOT:
                            Console.WriteLine("Ending Thread from Client {0}", clientID);
                            ack = protocolSI.Make(ProtocolSICmdType.ACK);
                            networkStream.Write(ack, 0, ack.Length);
                            break;
                    }
                }

                // fecho do networkStream e do cliente (TcpClient)
                networkStream.Close();
                client.Close();
            }
        }

    }
}








