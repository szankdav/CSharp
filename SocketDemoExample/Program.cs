using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocketDemoExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uj szal a szervernek
            Thread serverThread = new Thread(StartServer);
            serverThread.Start();

            // Varunk egy masodpercet, hogy a szerver beallitasai ervenyesuljenek
            Thread.Sleep(1000);

            // Uj szal a kliensnek
            Thread clientThread = new Thread(StartClient);
            clientThread.Start();

            Console.ReadKey();

            /* Halozati programozas:
             *  1. socket
             *  2. HTTP es webclientek mukodese
             *  3. WCF (windows communication foundation) technologia: teljeskoru es alapos keretrendszer, ami kulonbozo kommunikacios         protokollokat es formakat tamogat. Tavoli szolgaltatsok keszitese. Remote Service. 
             *  4. ASP.NET (szukseges elozetes ismeretek: web mukodese (kliens - szerver kommunikacio, HTML, CSS))
             *  5. REST API es HTTP mukodes
             */
        }

        private static void StartServer()
        {
            // Szerver socket letrehozasa
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Szerver cimenek es portjanak beallitasa
            //IPAddress ipAdress = new IPAddress(long.Parse("127.0.0.1"));
            IPAddress ipAdress = IPAddress.Parse("127.0.0.1");
            int port = 8888;
            IPEndPoint endPoint = new IPEndPoint(ipAdress, port);

            // Szerver socket osszekotese a beallitasokkal (IP cimmel, es porttal)
            serverSocket.Bind(endPoint);

            // Szerver socket hallgatasanak elinidtasa (maximalis varakozo kapcsolatok szama)
            serverSocket.Listen(10);
            Console.WriteLine("A szerver varakozik a kapcsolatra...");

            // Csatlakozas elfogadasa
            Socket clientSocket = serverSocket.Accept();
            Console.WriteLine("Kliens csatlakozott!");

            // Adatok fogadasa a klienstol
            byte[] buffer = new byte[1024];
            int bytesRead = clientSocket.Receive(buffer);
            string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Kliens uzenete: {receivedData}");

            // Kapcsolat lezarasa
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            serverSocket.Close();
        }

        private static void StartClient()
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            int port = 8888;
            IPEndPoint endPoint = new IPEndPoint(iPAddress, port);

            // Kliens csatlakozik a szerverhez
            clientSocket.Connect(endPoint);
            Console.WriteLine("Kapcsolodva a szerverhez...");

            // Adatok atalakitasa es kuldese
            string message = "Hello szerver!";
            byte[] data = Encoding.ASCII.GetBytes(message);
            clientSocket.Send(data);

            // Kapcsolat lezarasa
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }
}
