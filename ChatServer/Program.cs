using EI.SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ChatServer
{
    internal class Program
    {
       
            //criar novamente uma constante tal como feito do lado do cliente
            private const int PORT = 10000;

            static void Main(string[] args)
            {
                //definição de variaveis na funçao principal
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, PORT);
                TcpListener listener = new TcpListener(endPoint);

                //iniciar o listenner; apresentaçao da primeira mensagem na linha de comandos e inicialização do contador
                listener.Start();
                Console.WriteLine("SERVER READY");
                int clientCounter = 0;

                //criaçao do ciclo infinito de forma a que este esteja sempre em execuçao ate ordem em contrario
                while (true)
                {
                    //definiçao da variavel client do tipo TcpClient
                    TcpClient client = listener.AcceptTcpClient();

                    //incrementaçao do contador, de forma a que va sempre somadno 1 (+1)
                    clientCounter++;

                    //apresentaçao da mensagem indicativa do nº do cliente na linha de comandos
                    Console.WriteLine("Client {0} connected", clientCounter);

                    //definiçao da variavel clientHandler do tipo ClientHandler
                    ClientHandler clientHandler = new ClientHandler(client, clientCounter);
                    clientHandler.Handle();

                }
            }
        }

        class ClientHandler
        {
            //definiçao das variaveis client e clientID
            private TcpClient client;
            private int clientID;
            public ClientHandler(TcpClient client, int clientID)
            {
                this.client = client;
                this.clientID = clientID;
            }

            public void Handle()
            {
                //definicao da variavel thread e arranque da mesma. para relembrar: threads sao unidades de execuçao dentro de um processo; um conjunto de instruçoes
                Thread thread = new Thread(ThreadHandler);
                thread.Start();

            }

            private void ThreadHandler()
            {
                //definiçao das variaveis networkStream e protocolSI
                NetworkStream networkStream = this.client.GetStream();
                ProtocolSI protocolSI = new ProtocolSI();

                //ciclo a ser executado ate ao fim da transmissao
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

                    //"alteraçao"/mudança entre a apresentaçao da mensagem e o fim da transmissao
                    switch (protocolSI.GetCmdType())
                    {
                        case ProtocolSICmdType.DATA:
                            Console.WriteLine("Client " + clientID + ": " + protocolSI.GetStringFromData());
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

                //fecho do networkStream e do cliente (TcpClient)
                networkStream.Close();
                client.Close();
            }
        }
    }
