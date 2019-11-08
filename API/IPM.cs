namespace API
{
    public interface IPM
    {
        void InformServerExited(string serverID);
        void InformClientExited(string clientID);
    }
}
