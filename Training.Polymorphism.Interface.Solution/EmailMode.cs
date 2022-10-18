using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Polymorphism.Interface.Solution
{
    public class EmailMode : ICommunication
    {
        public void Communicate()
        {
            // Logging

            Console.WriteLine("Email: Message transmission via email started...");
        }
    }
}
