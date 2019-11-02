using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace API
{
    [Serializable]
    public class NotImplementedRemotingException : Exception, ISerializable
    {
        public NotImplementedRemotingException() : base()
        {

        }
        public NotImplementedRemotingException(string message) : base(message)
        {

        }
        public NotImplementedRemotingException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        [SecurityPermissionAttribute(SecurityAction.Demand,SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

    }
}
