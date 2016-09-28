using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.MessageHubs
{

    public class MessageHub : IMessageHub
    {
        public void Send()
        {
            throw new NotImplementedException();
        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Send and receive (via subscription) messages via the most appropriate Q.
    /// Injected with Primary, Secondary and Tertiary message buses, only sends to secondary if Primary fails, only sends to Tertiary if Secondary fails.
    /// </summary>
    /// <remarks>Subscribers always subscribe to all Q's, so it does not matter which Q the message gets sent to.</remarks>
    public interface IMessageHub
    {
        void Send();
        void Subscribe();
    }


    /// <summary>
    /// 
    /// To be implemented by Azure Service Bus, Amazon Simple Queue etc
    /// </summary>
    public interface IMessageQueueProvider
    {
        /// <summary>
        /// Fire and forget, send message to Q.
        /// </summary>
        void Send();

        /// <summary>
        /// Poll the Q for messages.
        /// </summary>
        void Receive();

        /// <summary>
        /// 
        /// </summary>
        void SendReceive();
        void Subscribe();
    }




}
