namespace API
{
    public interface IPCS
    {
        void StartServer(string serverId, RemotingAddress serverRA,
            uint maxFaults, uint minDelay, uint maxDelay);
        void StartClient(string username, RemotingAddress clientRA,
            RemotingAddress serverRA, string scriptFile);
        void AddRoom(string location, uint capacity, string roomName);
        string SystemStatus();
        void Crash(string server_id);
        void Freeze(string server_id);
        void Unfreeze(string server_id);
    }
}
