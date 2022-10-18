using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Polymorphism.Interface.Solution
{
    public class TextMode : ICommunication
    {
        public void Communicate()
        {
            // Logging

            Console.WriteLine("Text: Message transmission via text started...");
        }
    }
}
