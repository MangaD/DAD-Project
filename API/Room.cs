using System;
using System.Collections.Generic;

namespace API
{
    [Serializable]
    public class Room
    {
        public Room(string name, uint capacity)
        {
            Name = name;
            Capacity = capacity;
            bookedDates = new List<DateTime>();
        }

        public string Name { get; set; }
        public uint Capacity { get; set; }
        public List<DateTime> bookedDates;
    }
}
