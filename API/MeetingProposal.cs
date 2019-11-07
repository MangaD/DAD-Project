using System;
using System.Collections.Generic;

namespace API
{
    [Serializable]
    public class MeetingProposal
    {
        public MeetingProposal(string coordinatorUser, string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            CoordinatorUsername = coordinatorUser;
            CoodinatorURL = coordinatorURL;
            Topic = topic;
            MinAttendees = minAttendees;
            Slots = slots;
            Invitees = invitees;
            ClientsJoined = new Dictionary<string, string>();
            ClientSlots = new Dictionary<string, List<Slot>>();
            State = 0;
        }

        public string CoordinatorUsername { get; set; }
        public string CoodinatorURL { get; set; }
        public string Topic { get; set; }
        public uint MinAttendees { get; set; }
        public List<Slot> Slots { get; set; }
        public List<string> Invitees { get; set; }
        public Dictionary<string, string> ClientsJoined { get; set; }
        public Dictionary<string, List<Slot>> ClientSlots { get; set; }
        public int State { get; set; } //0 - open, 1- closed, ...

        public void AddSlotToSlots(Slot s) { Slots.Add(s); }
        public void AddInviteeToInvitees(string i) { Invitees.Add(i); }
        public void JoinClientToMeeting(string clientName, string clientURL, int slotCount, List<Slot> slots) { 
            ClientsJoined.Add(clientName, clientURL);
            ClientSlots.Add(clientName, slots);
            for(int i=0; i<slotCount; i++)
            {
                Slots.Add(slots[i]);
            }
        }
    }
}
