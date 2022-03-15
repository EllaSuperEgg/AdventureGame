using System;
namespace AdventureGame
{
    public class Memory
    {
        private int Order;
        string[] Conclusion;
        string[] Intro;
        private string[] memory;
        
        public Memory()
        {
           
            Order = 0;
            memory = new string[5];
            Conclusion = new string[5];
            Intro = new string[5];
            
            memory[3] = "Unicorn...I was a unicorn...Yes! You are a unicorn fairy! \nAll the young unicorns have to experience a good-deed test in the human world to become a real unicorn fairy and go back to the unicorn world. ";
            memory[1] = "You come to the human world to complete a really important mission.\nSeem like everytime you help someone will get you some memeory back.";
            memory[4] = "You could only go back home if you help people secretly without using your magic. ";
            memory[2] = "Colorful...yeah home is colorful...";
            memory[0] = "Help others... will get you back...";

            Conclusion[0] = "Helping others is the way to get you home. ";
            Conclusion[1] = "You come to the human world to complete a really important mission.";
            Conclusion[2] = "The world you come from is a colorful place ";
            Conclusion[3] = "You are a unicorn fairy! All the young unicorns have to experience a good-deed test in the human world to become a real unicorn fairy and go back to the unicorn world. ";
            Conclusion[4] = "You could only go back home if you help people secretly without using your magic.";
        }

        public void ReturnNewMemory(int order)
        {
           center("A new piece of memory comes to you:" + memory[order] );
        }

        public void ReturnConclusion(int order)
        {
            centerLong(Intro[order]);
        }

        public void ReturnMemory(int order)
        {
            center(memory[Order]);
        }

        public void ReturnAllMemories(int count)
        {
            for(int i = 0; i < count; i++)
            {
                centerLong(Conclusion[i]);
            }
        }

        void center(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (Console.WindowWidth / 2) + (stringWidth / 2);

            Console.WriteLine(message.PadLeft(spaces));
        }

        void centerLong(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (Console.WindowWidth / 2) + (stringWidth / 2);

            Console.Write(message.PadLeft(spaces));
        }


    }

}
