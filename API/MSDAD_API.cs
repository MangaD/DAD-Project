using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace API
{
    public interface IServer
    {
        List<string> RegisterClient(string clientName, string clientRA);
        List<string> ListMeetings(string clientName);
        void CreateMeeting(string coordinatorURL, string topic, uint minAttendees,
            List<Slot> slots, List<string> invitees);
        bool JoinMeeting(string topic, string clientName, string clientRA);
        void CloseMeeting(string topic);

        //Metodos de Teste
        void ClientSaysHelloToServer(UInt16 clientPort);

    }

    public interface IClient
    {
        //Metodos de Teste
        void ServerRespondsHiToClient(UInt16 serverPort);
    }

    public interface IPCS
    {
        bool StartServer(string serverId, string serverURL,
            uint maxFaults, uint minDelay, uint maxDelay);
        bool StartClient(string username, string clientURL,
            string serverURL, string scriptFile);
        bool AddRoom(string location, uint capacity, string roomName);
        string SystemStatus();
        void Crash(string server_id);
        void Freeze(string server_id);
        void Unfreeze(string server_id);
    }

    public interface IPuppetMaster
    {
        void ReceiveMessage(string msg);
    }

    public struct Slot
    {
        public string location;
        public DateTime date;
        public Slot(string _loc, DateTime _date)
        {
            this.location = _loc;
            this.date = _date;
        }
        public static Slot FromString(string slot)
        {
            string r = @"(\w+),(\d{4})-(\d{1,2})-(\d{1,2})";
            MatchCollection mat = Regex.Matches(slot, r);
            if (mat.Count <= 0)
            {
                throw new ArgumentException();
            }
            Match m2 = mat[0];
            string location = m2.Groups[1].Value.ToString();
            int year = Int32.Parse(m2.Groups[2].Value.ToString());
            int mon = Int32.Parse(m2.Groups[3].Value.ToString());
            int day = Int32.Parse(m2.Groups[4].Value.ToString());
            //Utilities.WriteDebug($"Loc: {location}, Year: {year}, Month: {mon}, Day: {day}");
            return new Slot(location, new DateTime(year, mon, day));
        }
        public override string ToString()
        {
            return location + "," + date.ToString("yyyy-MM-dd");
        }
    }

    public struct RemotingAddress
    {
        public string address;
        public UInt16 port;
        public string channel;

        public RemotingAddress(string _address, UInt16 _port, string _channel)
        {
            this.address = _address;
            this.port = _port;
            this.channel = _channel;
        }

        public static RemotingAddress FromString(string remotingAddress)
        {
            string r = @"^tcp:\/\/([^:\s]+):(\d+)\/([^\s]+)$";
            MatchCollection mat = Regex.Matches(remotingAddress, r);
            if (mat.Count <= 0)
            {
                throw new ArgumentException();
            }
            Match m2 = mat[0];
            string address = m2.Groups[1].Value.ToString();
            int port = Int32.Parse(m2.Groups[2].Value.ToString());
            string channel = m2.Groups[3].Value.ToString();
            return new RemotingAddress(address, (UInt16) port, channel);
        }

        public override string ToString()
        {
            return "tcp://" + address + ":" + port + "/" + channel;
        }
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

        public static void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }

}
