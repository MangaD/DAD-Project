using System;

using API;

namespace PM
{
    class PMService : MarshalByRefObject, IPM
    {
        public void InformClientExited(string clientID)
        {
            // nothing to do so far
        }

        public void InformServerExited(string serverID)
        {
            Program.RemoveServerFromList(serverID);
        }
    }
}
