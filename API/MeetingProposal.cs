using System;
using System.Collections.Generic;

namespace API
{
    [Serializable]
    public class MeetingProposal
    {
        public string CoordinatorUsername { get; set; }
        public string CoodinatorURL { get; set; }
        public string Topic { get; set; }
        public uint MinAttendees { get; set; }
        public List<Slot> Slots { get; set; }
        public List<string> Invitees { get; set; }
        public Dictionary<string, string> ClientsJoined { get; set; }
        public Dictionary<string, string> ClientsAccepted { get; set; }
        public Dictionary<Slot, List<string>> ClientPerSlot { get; set; }
        public bool IsClosed { get; set; }
        public List<Slot> ChoosedSlots { get; set; }
        public Slot BookedSlot { get; set; }
        public Room BookedRoom { get; set; }

        public MeetingProposal(string coordinatorUsername, string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            CoordinatorUsername = coordinatorUsername;
            CoodinatorURL = coordinatorURL;
            Topic = topic;
            MinAttendees = minAttendees;
            Slots = slots;
            Invitees = invitees;
            ClientsJoined = new Dictionary<string, string>();
            IsClosed = false;
            ChoosedSlots = new List<Slot>();
        }

        public void AddSlotToSlots(Slot s) { Slots.Add(s); }
        public void AddInviteeToInvitees(string i) { Invitees.Add(i); }
        public void JoinClientToMeeting(string clientName, string clientURL, List<Slot> slots) { 
            ClientsJoined.Add(clientName, clientURL);

            foreach(Slot s in slots)
            {
                ChoosedSlots.Add(s);
            }
        }
    }
}
