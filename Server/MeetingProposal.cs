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
        private int state; //0 - open, 1- closed, ...

        private string coodinatorURL;
        private string topic;
        private uint minAttendees;
        private List<Slot> slots;
        private List<string> invitees;
        private Dictionary<string, string> clientsJoined;

        public MeetingProposal(string coordinatorURL, string topic, uint minAttendees, List<Slot> slots, List<string> invitees)
        {
            CoodinatorURL = coodinatorURL;
            Topic = topic;
            MinAttendees = minAttendees;
            Slots = slots;
            Invitees = invitees;
            ClientsJoined = new Dictionary<string, string>();
            State = 0;
        }

        public string CoodinatorURL { get => coodinatorURL; set => coodinatorURL = value; }
        public string Topic { get => topic; set => topic = value; }
        public uint MinAttendees { get => minAttendees; set => minAttendees = value; }
        public List<Slot> Slots { get => slots; set => slots = value; }
        public List<string> Invitees { get => invitees; set => invitees = value; }
        public Dictionary<string, string> ClientsJoined { get => clientsJoined; set => clientsJoined = value; }
        public int State { get => state; set => state = value; }

        public void addSlotToSlots(Slot s) { Slots.Add(s); }
        public void addInviteeToInvitees(string i) { Invitees.Add(i); }
        public void joinClientToMeeting(string clientName, string clientURL, int n_slots, List<Slot> locationDates) { 
            ClientsJoined.Add(clientName, clientURL);
            for(int i=0; i<n_slots; i++)
            {
                Slots.Add(locationDates[i]);
            }
        }
    }
}
