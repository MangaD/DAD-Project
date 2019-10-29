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
        private string topic;
        private uint minAttendees;
        private List<Slot> slots;
        private List<string> invitees;

        public MeetingProposal(string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            this.topic = topic; this.minAttendees = minAttendees; this.slots = slots;   this.invitees = invitees;
        }

        public string getTopic() { return this.topic; }
        public uint getMinAttendees() { return this.minAttendees; }
        public List<Slot> getSlots() { return this.slots; }
        public List<string> getInvitees() { return this.invitees; }

        public void setTopic(string tc) { this.topic = tc; }
        public void setMinAttendees(uint ma) { this.minAttendees = ma; }
        public void setSlots(List<Slot> s) { this.slots = s; }
        public void setInvitees(List<string> i) { this.invitees = i; }

        public void addSlotToSlots(Slot s) { this.slots.Add(s); }
        public void addInviteeToInvitees(string i) { this.invitees.Add(i); }
    }
}
