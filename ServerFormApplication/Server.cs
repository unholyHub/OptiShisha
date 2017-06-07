using System;
using System.Net.Sockets;
using System.Threading;

namespace ServerFormApplication
{
    static class Server
    {
        private static int tableCounter = 0;

        static TcpListener tcpListener = new TcpListener(10);

        //static void Listeners()
        //{

        //    Socket socketForClient = tcpListener.AcceptSocket();
        //    if (socketForClient.Connected)
        //    {
        //        Console.WriteLine("Client now connected to server.");
        //        NetworkStream networkStream = new NetworkStream(socketForClient);
        //        System.IO.StreamWriter streamWriter =
        //        new System.IO.StreamWriter(networkStream);
        //        System.IO.StreamReader streamReader =
        //        new System.IO.StreamReader(networkStream);

        //        //here we send message to client
        //        Console.WriteLine("type your message to be recieved by client:");
        //        string theString = GetData();
        //        streamWriter.WriteLine(theString);
        //        //Console.WriteLine(theString);
        //        streamWriter.Flush();

        //        //here we recieve client's text if any.
        //        theString = streamReader.ReadLine();
        //        Console.WriteLine("Message recieved by client:" + theString);
        //        streamReader.Close();
        //        networkStream.Close();
        //        streamWriter.Close();
        //    }
        //    socketForClient.Close();
        //    Console.WriteLine("Press any key to exit from server program");
        //    Console.ReadKey();
        //}


        static void Listeners()
        {
            Socket socketForClient = tcpListener.AcceptSocket();
            if (socketForClient.Connected)
            {
                var remoteEndPoint = socketForClient.RemoteEndPoint.ToString();
                Console.WriteLine("Client:" + remoteEndPoint + " now connected to server.");
                NetworkStream networkStream = new NetworkStream(socketForClient);
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
                System.IO.StreamReader streamReader = new System.IO.StreamReader(networkStream);

                //here we are adding the client to the server
                tableCounter++;
                MainServerForm mf = FormFunctions.GetOpenedForm("MainServerForm") as MainServerForm;
                mf.AddRow(tableCounter.ToString(), remoteEndPoint);

                ////here we send message to client
                //Console.WriteLine("type your message to be recieved by client:");
                //string theString = Console.ReadLine();
                //streamWriter.WriteLine(theString);
                ////Console.WriteLine(theString);
                //streamWriter.Flush();

                //while (true)
                //{
                //here we recieve client's text if any.
                while (true)
                {
                    string recievedMessage = streamReader.ReadLine();
                    
                    Communication.ProcessRecievedMessage(recievedMessage, remoteEndPoint);

                    if (recievedMessage == "exit")
                        break;
                }
                streamReader.Close();
                networkStream.Close();
                streamWriter.Close();
                //}

            }
            socketForClient.Close();
            Console.WriteLine("Press any key to exit from server program");
            Console.ReadKey();
        }

        public static void Start()
        {
            tcpListener.Start();

            int numberOfClientsYouNeedToConnect = Properties.Settings.Default.NumberOfTables;
            for (int i = 0; i < numberOfClientsYouNeedToConnect; i++)
            {
                Thread newThread = new Thread(new ThreadStart(Listeners));
                newThread.Start();
            }
        }

    }
}
