using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Bridge
{
    /// The 'Bridge/Implementor' interface 
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

}
