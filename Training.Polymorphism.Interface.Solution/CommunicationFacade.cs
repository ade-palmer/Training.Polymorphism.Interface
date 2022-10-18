using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Polymorphism.Interface.Solution
{
    public class CommunicationFacade
    {
        public void StartCommunication(ICommunication communication)
        {
            communication.Communicate();
        }

        //public void StartCommunication(VoiceMode voiceMode)
        //{
        //    voiceMode.Communicate();
        //}

        //public void StartCommunication(TextMode textMode)
        //{
        //    textMode.Communicate();
        //}
    }
}