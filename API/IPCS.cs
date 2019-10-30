namespace API
{
    public interface IPCS
    {
        bool StartServer(string serverId, string serverURL,
            uint maxFaults, uint minDelay, uint maxDelay);
        bool StartClient(string username, string clientURL,
            string serverURL, string scriptFile);
        bool AddRoom(string location, uint capacity, string roomName);
        string SystemStatus();
        void Crash(string server_id);
        void Freeze(string server_id);
        void Unfreeze(string server_id);
    }
}
