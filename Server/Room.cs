namespace Server
{
    public class Room
    {
        public Room(string name, uint capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public uint Capacity { get; set; }
    }
}
