using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Polymorphism.Interface.Solution
{
    public class VoiceMode : ICommunication
    {
        public void Communicate()
        {
            // Logging

            Console.WriteLine("Voice: Message transmission via voice started...");
        }
    }
}
