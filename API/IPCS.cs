namespace API
{
    public interface IPCS
    {
        void StartServer(string serverId, RemotingAddress serverRA,
            uint maxFaults, uint minDelay, uint maxDelay);
        void StartClient(string username, RemotingAddress clientRA,
            RemotingAddress serverRA, string scriptFile);
    }
}
