using System;

namespace API
{
    [Serializable]
    public class Room
    {
        public Room(string name, uint capacity)
        {
            Name = name;
            Capacity = capacity;
            Available = true;
        }

        public string Name { get; set; }
        public uint Capacity { get; set; }
        public bool Available { get; set; }
    }
}
