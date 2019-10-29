using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API;

namespace Server
{
    public class MeetingProposal
    {
        private int coodinatorPort;
        private string topic;
        private uint minAttendees;
        private List<Slot> slots;
        private List<string> invitees;

        public MeetingProposal(int coordinatorPort, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            CoodinatorPort = coodinatorPort;
            Topic = topic;
            MinAttendees = minAttendees;
            Slots = slots;
            Invitees = invitees;
        }

        public int CoodinatorPort { get => coodinatorPort; set => coodinatorPort = value; }
        public string Topic { get => topic; set => topic = value; }
        public uint MinAttendees { get => minAttendees; set => minAttendees = value; }
        public List<Slot> Slots { get => slots; set => slots = value; }
        public List<string> Invitees { get => invitees; set => invitees = value; }
        
        public void addSlotToSlots(Slot s) { Slots.Add(s); }
        public void addInviteeToInvitees(string i) { Invitees.Add(i); }
    }
}
