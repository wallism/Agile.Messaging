using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.MessageHubs
{
    /// <summary>
    /// Send and receive (iva subscription) messages via the most appropriate Q.
    /// Injected with Primary, Secondary and Tertiary message buses, only sends to secondary if Primary fails, only sends to Tertiary if Secondary fails.
    /// </summary>
    /// <remarks>Subscribers always subscribe to all Q's, so it does not matter which Q the message gets sent to.</remarks>
    public interface IMessageHub
    {
        void Send();
        void Subscribe();
    }


    /// <summary>
    /// Send a message to a specific Q.
    /// To be implemented by Azure Service Bus, Amazon Simple Queue etc
    /// </summary>
    public interface IMessageSender
    {
        void Send();
    }

    public interface IMessageReceiver
    {
        void Subscribe();
    }


}
