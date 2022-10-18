using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Polymorphism.Interface
{
    public class CommunicationFacade
    {
        public void StartCommunication(VoiceMode voiceMode)
        {
            voiceMode.Communicate();
        }

        public void StartCommunication(TextMode textMode)
        {
            textMode.Communicate();
        }
    }
}