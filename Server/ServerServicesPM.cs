using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using API;

namespace Server
{
    partial class ServerServices : MarshalByRefObject, IServerPM
    {
        public void AddRoom(string location, uint capacity, string roomName)
        {
            Server.AddRoom(location, capacity, roomName);
        }

        public void SystemStatus()
        {
            Server.PrintStatus();
        }

        public void Crash()
        {
            Environment.Exit(0);
        }

        public void Freeze()
        {
            Server.freezeHandle.Reset();
        }

        public void Unfreeze()
        {
            Server.freezeHandle.Set();
        }

        public void Ping()
        {
            // does nothing
        }
        public List<string> GetLocationsPM()
        {
            List<string> loc = new List<string>();
            foreach (string s in Server.locationRooms.Keys)
            {
                loc.Add(s);
            }
            return loc;
        }

        public void SendExistingServersList(List<Tuple<string, RemotingAddress>> serverList)
        {
            foreach(Tuple<string, RemotingAddress> serv in serverList){
                if (Server.serverID != serv.Item1)
                {
                    IServerS servChannel = (IServerS)Activator.GetObject(typeof(IServerS), serv.Item2.ToString());
                    Server.otherServers.Add(new OtherServer(servChannel, serv.Item1, serv.Item2));
                    ConcurrentBag<MeetingProposal> rMeets = servChannel.GetMeetingPropList();
                    foreach(MeetingProposal m in rMeets)
                    {
                        Server.meetingPropList.Add(m);
                    } 
                    ConcurrentBag<Tuple<string, RemotingAddress>> sC = servChannel.GetClientsList();
                    foreach(Tuple<string, RemotingAddress> s in sC)
                    {
                        IClient cliChannel = (IClient)Activator.GetObject(typeof(IClient), s.Item2.ToString());
                        Client nClient = new Client(cliChannel, s.Item1, s.Item2);
                        Server.clients.Add(nClient);

                        cliChannel.RegisterServerReplica(Server.serverID, Server.serverRAForClients);
                    }
                }
            }
        }

        public void BroadcastNewServer(Tuple<string, RemotingAddress> newServer)
        {
            if (Server.serverID != newServer.Item1)
            {
                IServerS newServerChannel = (IServerS)Activator.GetObject(typeof(IServerS), newServer.Item2.ToString());
                Server.otherServers.Add(new OtherServer(newServerChannel, newServer.Item1, newServer.Item2));
            }
        }
    }
}
