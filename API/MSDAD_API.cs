using System;
using System.Collections.Generic;

namespace API
{

    public interface IServer
    {
        List<string> RegisterClient(string clientPort);
        List<string> listMeetings();
        void createMeeting(string topic, uint minAttendees,
            List<KeyValuePair<string, string>> slots, List<string> invitees);
    }

    public interface IClient
    {
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
    }

}
