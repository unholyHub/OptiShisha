using System.Net.Sockets;

namespace ClientFormApplication
{
    public static class Client
    {
        static TcpClient socketForServer;

        static NetworkStream networkStream;

        public static bool StartClient()
        {
            bool result = false;

            try
            {
                socketForServer = new TcpClient("localHost", 10);
                result = true;

                return result;
            }
            catch
            {
                return result;
            }
        }

        public static void SendMessage(string messageToSend)
        {
            string outputString;

            networkStream = socketForServer.GetStream();
            System.IO.StreamReader streamReader = new System.IO.StreamReader(networkStream);
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);

            try
            {
                //while (true)
                //{

                //}

                // read the data from the host and display it
                streamWriter.WriteLine(messageToSend);
                streamWriter.Flush();
            }
            catch
            {
            }

            // tidy up
            //networkStream.Close();
        }

    }
}
