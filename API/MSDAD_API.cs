using System;
using System.Collections.Generic;
using System.Threading;

namespace API
{

    public interface IServer
    {
        List<string> RegisterClient(int clientPort, string clientName);
        List<string> listMeetings();
        void createMeeting(string topic, uint minAttendees,
            List<KeyValuePair<string, DateTime>> slots, List<string> invitees);
        void joinMeeting(string topic);
        void closeMeeting(string topic);


        //Metodos de Teste
        void clientSaysHelloToServer(int clientPort);

    }

    public interface IClient
    {
        //Metodos de Teste
        void serverRespondsHiToClient(int serverPort);
    }

    public interface IPCS
    {
        bool StartServer(string serverId, string serverURL,
            uint maxFaults, uint minDelay, uint maxDelay);
        bool StartClient(string username, string clientURL,
            string serverURL, string scriptFile);
        bool AddRoom(string location, uint capacity, string roomName);
        string SystemStatus();
        void Crash(string id);
        void Freeze(string id);
        void Unfreeze(string id);
    }

    public interface IPuppetMaster
    {
        void receiveMessage(string msg);
    }

    public class Utilities
    {
        public static void WriteDebug(string debug)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(debug);
            Console.ResetColor();
        }

        public static void WriteError(string err)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine(err);
            Console.ResetColor();
        }

        public static void Wait(string milliseconds)
        {
            Thread.Sleep(Int32.Parse(milliseconds));
        }
    }

}
