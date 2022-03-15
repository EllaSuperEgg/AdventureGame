using System;
namespace AdventureGame
{
    public class Character
    {
        public string Name;
        public string Identity;
        public string Appearance;
        public int Point;
        ConsoleColor Color;

        public Character(string name, string identity,int point)
        {
            Name = name;
            Identity = identity;
            Point = point;
            if (Point==1)
            {
                Console.WriteLine("You become a real unicorn!!!");
            }
        }

        public void DiscoverIdentity()
        {
            Console.WriteLine("You pick up the picture and there is a {0} with {1}  standing in front of you.", Identity, Appearance);
            Console.WriteLine("There is a mirror, and you see the same person in it! ");
            Console.WriteLine("Yes, this is you. Someone you feel like never seen before.");
            Console.WriteLine("Which means, this is your apartment.");
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.WriteLine("What is this hat?");
            Console.WriteLine("Do you want to have a look under it?(type yes or no)");
            string input = Console.ReadLine().ToLower();
            if (input=="yes")
            {
                Console.WriteLine("You try to take off your hat, but the enormous pain on the forehead flows to you again...");
                Console.WriteLine("Keep doing it?");
                input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    Console.WriteLine("There is a huge BUMP on your head!");
                }

                else{
                    Console.WriteLine("Hmm, the hat feels really soft.");
                }
            }
            else{
                
            }
        }

        public void updateName(string name)
        {
            this.Name = name;
        }

        public void updateIdentity(string identity)
        {
            this.Identity = identity;
        }
    }
}
