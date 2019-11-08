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
            ClientsAccepted = new Dictionary<string, string>();
            ClientPerSlot = new Dictionary<Slot, List<string>>();
            IsClosed = false;
        }

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

        public void AddSlotToSlots(Slot s) { Slots.Add(s); }
        public void AddInviteeToInvitees(string i) { Invitees.Add(i); }
        public void JoinClientToMeeting(string clientName, string clientURL, List<Slot> slots) { 
            ClientsJoined.Add(clientName, clientURL);
            for(int i = 0; i < slots.Count; i++)
            {
                Slot slot = slots[i];
                if (!ClientPerSlot.ContainsKey(slot)) ClientPerSlot.Add(slot, new List<string>());

                ClientPerSlot[slot].Add(clientName);

                if (!Slots.Contains(slot)) Slots.Add(slot);
            }
        }
    }
}
