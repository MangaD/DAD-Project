using System;
using System.Collections.Generic;

namespace API
{
    [Serializable]
    public class MeetingProposal
    {
        public string CoordinatorUsername { get; set; }
        public RemotingAddress CoodinatorRA { get; set; }
        public string Topic { get; set; }
        public uint MinAttendees { get; set; }
        public List<Slot> Slots { get; set; }
        public List<string> Invitees { get; set; }

        public Dictionary<string, RemotingAddress> ClientsJoined { get; set; }
        public Dictionary<string, string> ClientsAccepted { get; set; }
        public Dictionary<Slot, List<string>> ClientPerSlot { get; set; }
        public enum StatusEnum
        {
            Open,
            Closed,
            Cancelled
        }
        public StatusEnum Status = StatusEnum.Open;
        public List<Slot> ChosenSlots { get; set; }
        public Slot BookedSlot { get; set; }
        public Room BookedRoom { get; set; }

        public MeetingProposal(string coordinatorUsername, RemotingAddress coordinatorRA, string topic,
            uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            CoordinatorUsername = coordinatorUsername;
            CoodinatorRA = coordinatorRA;
            Topic = topic;
            MinAttendees = minAttendees;
            Slots = slots;
            Invitees = invitees;
            ClientsJoined = new Dictionary<string, RemotingAddress>();
            ChosenSlots = new List<Slot>();
        }

        public void AddClientToMeeting(string clientName, RemotingAddress clientRA, List<Slot> chosenSlots)
        { 
            ClientsJoined.Add(clientName, clientRA);

            foreach(Slot s in chosenSlots)
            {
                ChosenSlots.Add(s);
            }
        }
    }
}
