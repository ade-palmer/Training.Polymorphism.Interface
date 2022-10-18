using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Polymorphism.Interface.Solution
{
    public class CommunicationFactory
    {
        // Factory created as Static class to instatiate instance based on selection
        public static ICommunication Create(int mode)
        {
            if (mode == 1)
            {
                return new VoiceMode();
            }
            else if (mode == 2)  
            {
                return new TextMode();
            }
            else
            {
                return new EmailMode();
            }
        }
    }
}
