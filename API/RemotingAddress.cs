using System;
using System.Text.RegularExpressions;

namespace API
{
    public struct RemotingAddress
    {
        public string address;
        public UInt16 port;
        public string channel;

        public RemotingAddress(string _address, UInt16 _port, string _channel)
        {
            this.address = _address;
            this.port = _port;
            this.channel = _channel;
        }

        public static RemotingAddress FromString(string remotingAddress)
        {
            string r = @"^tcp:\/\/([^:\s]+):(\d+)\/([^\s]+)$";
            MatchCollection mat = Regex.Matches(remotingAddress, r);
            if (mat.Count <= 0)
            {
                throw new ArgumentException();
            }
            Match m2 = mat[0];
            string address = m2.Groups[1].Value.ToString();
            int port = Int32.Parse(m2.Groups[2].Value.ToString());
            string channel = m2.Groups[3].Value.ToString();
            return new RemotingAddress(address, (UInt16)port, channel);
        }

        public override string ToString()
        {
            return "tcp://" + address + ":" + port + "/" + channel;
        }

        public static bool operator ==(RemotingAddress lhs, RemotingAddress rhs)
        {
            return lhs.address == rhs.address && lhs.port == rhs.port
               && lhs.channel == rhs.channel;
        }
        public static bool operator !=(RemotingAddress lhs, RemotingAddress rhs)
        {
            return lhs.address != rhs.address || lhs.port != rhs.port
               || lhs.channel != rhs.channel;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is RemotingAddress))
            {
                return false;
            }

            RemotingAddress ra = (RemotingAddress)obj;

            return this.address.Equals(ra.address) && this.channel.Equals(ra.channel)
                && this.port.Equals(ra.port);
        }

        // https://www.loganfranken.com/blog/692/overriding-equals-in-c-part-2/
        public override int GetHashCode()
        {
            unchecked
            {
                // Choose large primes to avoid hashing collisions
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;

                int hash = HashingBase;
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, address) ? address.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, port) ? port.GetHashCode() : 0);
                hash = (hash * HashingMultiplier) ^ (!Object.ReferenceEquals(null, channel) ? channel.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
