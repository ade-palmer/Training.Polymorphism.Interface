namespace Training.Polymorphism.Interface.Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VoiceMode voiceMode = new VoiceMode();
            //TextMode textMode = new TextMode();

            CommunicationFacade facade = new CommunicationFacade();

            Console.WriteLine("Please enter the type of communication you want to start (Voice mode = 1, Text mode =2)");

            var mode = int.Parse(Console.ReadLine());

            // Use the Factory to create the instance
            var factory = CommunicationFactory.Create(mode);

            Console.WriteLine("Communication started...");

            // This is not polymorphic as you may have another requirements i.e for email
            // and the change has to be made in multiple places
            //if (mode == 1)
            //{
            //    Thread.Sleep(1000);
            //    facade.StartCommunication(voiceMode);
            //}
            //else if (mode == 2)
            //{
            //    Thread.Sleep(1000);
            //    facade.StartCommunication(textMode);
            //}

            // Single line to start comms based on result returned from factory
            Thread.Sleep(1000);
            facade.StartCommunication(factory);

            Console.ReadKey();
        }
    }
}