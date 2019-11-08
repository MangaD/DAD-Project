using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Channels;
using System.Net;

// https://stackoverflow.com/questions/527676/identifying-the-client-during-a-net-remoting-invocation

namespace PCS
{
    public class ClientIPServerSinkProvider :
        IServerChannelSinkProvider
    {
        public ClientIPServerSinkProvider()
        {
        }

        public ClientIPServerSinkProvider(
            IDictionary properties,
            ICollection providerData)
        {
        }

        public IServerChannelSinkProvider Next { get; set; } = null;

        public IServerChannelSink CreateSink(IChannelReceiver channel)
        {
            IServerChannelSink nextSink = null;

            if (Next != null)
            {
                nextSink = Next.CreateSink(channel);
            }
            return new ClientIPServerSink(nextSink);
        }

        public void GetChannelData(IChannelDataStore channelData)
        {
        }
    }


    public class ClientIPServerSink :
        BaseChannelObjectWithProperties,
        IServerChannelSink,
        IChannelSinkBase
    {
        public ClientIPServerSink(IServerChannelSink next)
        {
            NextChannelSink = next;
        }

        public IServerChannelSink NextChannelSink { get; set; }

        public void AsyncProcessResponse(
            IServerResponseChannelSinkStack sinkStack,
            Object state,
            IMessage message,
            ITransportHeaders headers,
            Stream stream)
        {
            IPAddress ip = headers[CommonTransportKeys.IPAddress] as IPAddress;
            CallContext.SetData("ClientIPAddress", ip);
            sinkStack.AsyncProcessResponse(message, headers, stream);
        }

        public Stream GetResponseStream(
            IServerResponseChannelSinkStack sinkStack,
            Object state,
            IMessage message,
            ITransportHeaders headers)
        {

            return null;

        }

        public ServerProcessing ProcessMessage(
            IServerChannelSinkStack sinkStack,
            IMessage requestMsg,
            ITransportHeaders requestHeaders,
            Stream requestStream,
            out IMessage responseMsg,
            out ITransportHeaders responseHeaders,
            out Stream responseStream)
        {
            if (NextChannelSink != null)
            {
                IPAddress ip =
                    requestHeaders[CommonTransportKeys.IPAddress] as IPAddress;
                CallContext.SetData("ClientIPAddress", ip);
                ServerProcessing spres = NextChannelSink.ProcessMessage(
                    sinkStack,
                    requestMsg,
                    requestHeaders,
                    requestStream,
                    out responseMsg,
                    out responseHeaders,
                    out responseStream);
                return spres;
            }
            else
            {
                responseMsg = null;
                responseHeaders = null;
                responseStream = null;
                return new ServerProcessing();
            }
        }
    }
}
