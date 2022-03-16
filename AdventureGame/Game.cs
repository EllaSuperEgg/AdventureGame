using System;
using System.Collections.Generic;

namespace AdventureGame
{
    public class Game
    {
        string _CharacterName;
        string _CharacterIdentity;
        int _Point = 0;
  

        string[] memory;

        Memory Memory;

        List<Item> items = new List<Item>();
        
        List<string> goodDeed = new List<string>();
        ConsoleColor _CharacterColor;
        
        bool treasureBox = false;
        bool MadelienaStory = false;

        string[] BenjaminStory = new string[]{
        "This morning, like every Tuesday,",
        "Benjamin goes out to buy a chicken.",
            "But Benjamin won't buy a chicken today.",
            "He won't go any further than that telephone booth.",
            "The telephone rings as if the it is calling him.",
            "He goes in to the booth,",
            "And he finds all the memory he treasured as a child.",
            "In one second, Benjamin remembers everything...",
        "The car model he got on his 5th birthday.",
         "Aunt Josette's corselets.",
            "And, especially, that happy day, when he won all the marbles of his classmates during playtime...",
            "\nHe says,'I can't believe, what just happened to me.",
            "'It must've been my guardian angel. Can't be anything else.",
            "'I have a daughter. She must be about the age I hided these things.",
            "' We haven't spoken to each  other for years now.",
            "'I heard she has a child, a little boy.",
            "'His name is Lucas.",
            "'It's about time I went to pay them a visit. ",};


        private Character character;

        public Game()
        {
            Console.WindowWidth = 150;
            Memory = new Memory();
            Console.Title = "Unspeakable Fairytale by Minghui Luo";
            TitleScreen();
                while(_Point<3)
                {
                    StartGame();
                }

            UnicornEnding();
            EndGame();
            Console.ReadKey();
        }

        void TitleScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            center(@"
'  >=>     >=> >==>    >=>   >=>>=>   >======>   >=======>       >>       >=>   >=>         >>       >=>>=>    >=>       >=======> 
'  >=>     >=> >> >=>  >=> >=>    >=> >=>    >=> >=>            >>=>      >=>  >=>         >>=>      >>   >=>  >=>       >=>       
'  >=>     >=> >=> >=> >=>  >=>       >=>    >=> >=>           >> >=>     >=> >=>         >> >=>     >>    >=> >=>       >=>       
'  >=>     >=> >=>  >=>>=>    >=>     >======>   >=====>      >=>  >=>    >>=>>          >=>  >=>    >==>>=>   >=>       >=====>   
'  >=>     >=> >=>   > >=>       >=>  >=>        >=>         >=====>>=>   >=>  >=>      >=====>>=>   >>    >=> >=>       >=>       
'  >=>     >=> >=>    >>=> >=>    >=> >=>        >=>        >=>      >=>  >=>   >=>    >=>      >=>  >>     >> >=>       >=>       
'    >====>    >=>     >=>   >=>>=>   >=>        >=======> >=>        >=> >=>     >=> >=>        >=> >===>>=>  >=======> >=======> 
'                                                                                                                                                                                                                                                                   
");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.BackgroundColor = ConsoleColor.DarkMagenta;
            center(@"
'         _          _                    _          _    _        _        _            _                   _             _      
'        /\ \       / /\                 /\ \       /\ \ /\ \     /\_\     /\ \         / /\                _\ \          /\ \    
'       /  \ \     / /  \                \ \ \     /  \ \\ \ \   / / /     \_\ \       / /  \              /\__ \        /  \ \   
'      / /\ \ \   / / /\ \               /\ \_\   / /\ \ \\ \ \_/ / /      /\__ \     / / /\ \            / /_ \_\      / /\ \ \  
'     / / /\ \_\ / / /\ \ \             / /\/_/  / / /\ \_\\ \___/ /      / /_ \ \   / / /\ \ \          / / /\/_/     / / /\ \_\ 
'    / /_/_ \/_// / /  \ \ \           / / /    / / /_/ / / \ \ \_/      / / /\ \ \ / / /  \ \ \        / / /         / /_/_ \/_/ 
'   / /____/\  / / /___/ /\ \         / / /    / / /__\/ /   \ \ \      / / /  \/_// / /___/ /\ \      / / /         / /____/\    
'  / /\____\/ / / /_____/ /\ \       / / /    / / /_____/     \ \ \    / / /      / / /_____/ /\ \    / / / ____    / /\____\/    
' / / /      / /_________/\ \ \  ___/ / /__  / / /\ \ \        \ \ \  / / /      / /_________/\ \ \  / /_/_/ ___/\ / / /______    
'/ / /      / / /_       __\ \_\/\__\/_/___\/ / /  \ \ \        \ \_\/_/ /      / / /_       __\ \_\/_______/\__\// / /_______\   
'\/_/       \_\___\     /____/_/\/_________/\/_/    \_\/         \/_/\_\/       \_\___\     /____/_/\_______\/    \/__________/   
'                                                                                                                                 
");
            Console.ResetColor();
            center("Press Enter to Start Game...");
            Console.ReadKey();
            Console.Clear();
        }

        void StartGame()
        {
            center("Welcome to the Unspeakable Fairy game.");
            NameCharacter();
            Introduction();
            Choice1();
            BlindMan();
        }

        void NameCharacter()
        {
            center("What is your name?");
            _CharacterName = Console.ReadLine();
            center("Welcome, " + _CharacterName);
            center("What identiy do you want to be today? A a)boy, b)girl, or c)other identity?");
            string input = Console.ReadLine();
            if (input == "a")
            {
                _CharacterIdentity = "guy";
            }
            else if (input == "b")
            {
                _CharacterIdentity = "girl";
            }
            else
            {
                center("Please write your sex identity here:");
                _CharacterIdentity = Console.ReadLine();
            }

            character = new Character(_CharacterName, _CharacterIdentity, _Point);
            ChooseColor();
        }

        private void ChooseColor()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            foreach(var color in colors)
            {
                if(color != ConsoleColor.Red)
                {
                    center("-- " + color.ToString());
                }
                

            }
            center("What is your favorite color?\n");
            switch (Console.ReadLine().ToLower())
            {
                case "black":
                    _CharacterColor = ConsoleColor.Black;
                    break;
                case "blue":
                    _CharacterColor = ConsoleColor.Blue;
                    break;
                case "red":
                    _CharacterColor = ConsoleColor.DarkRed;
                    break;
                case "green":
                    _CharacterColor = ConsoleColor.Green;
                    break;
                case "yellow":
                    _CharacterColor = ConsoleColor.Yellow;
                    break;
                case "cyan":
                    _CharacterColor = ConsoleColor.Cyan;
                    break;
                case "darkblue":
                    _CharacterColor = ConsoleColor.DarkBlue;
                    break;
                case "darkcyan":
                    _CharacterColor = ConsoleColor.DarkCyan;
                    break;
                case "darkgray":
                    _CharacterColor = ConsoleColor.DarkGray;
                    break;
                case "darkgreen":
                    _CharacterColor = ConsoleColor.DarkGreen;
                    break;
                case "darkmagenta":
                    _CharacterColor = ConsoleColor.DarkMagenta;
                    break;
                case "darkyellow":
                    _CharacterColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    _CharacterColor = ConsoleColor.Gray;
                    break;
                case "magenta":
                    _CharacterColor = ConsoleColor.Magenta;
                    break;
                case "white":
                    _CharacterColor = ConsoleColor.White;
                    break;
                default:
                    center("Invalid. Please try again.");
                    ChooseColor();
                    break;
            }
        }


        void Introduction()
        {
            Console.Clear();
            center("Instruction: Press Enter to continue story. The colorful lines are dialog."+_CharacterColor + " is your lines. Red are other characters.");
            Console.ReadKey();
            Console.Clear();
            center("You wake up on the floor of a nice little apartment.");
            Console.ReadKey();
            center("You look around. Some normal furnitures. Seems like not many things are here.");
            Console.ReadKey();
            center("Where is this? You tried to remember what happened, but the dramatic pain on your forehead stopped you.");
            Console.ReadKey();
            center("You try to stand up, but the dizziness drags you down on the floor again.");
            Console.ReadKey();
            center("“Come home...You have to come through these...” A soft voice is flashing in your mind.");
            Console.ReadKey();
            center("Wait, there is an insignificant crying coming from the floor below you.");
            Console.ReadKey();
            center("You put your ears on the floor and try to listen what is going on.");
            Console.ReadKey();
            Dialog1("My life stopped in that day in the cold October...Why the fate treat me like this?... Life is miserable...", ConsoleColor.Red);

        }

        void Choice1()
        {
            center("A woman is crying below you. Would you want to see what is going on? ");
            center("a)Yes. b)Go explore the room alone.");
            center("Please enter your choice");
            string input = Console.ReadLine().ToLower();
            if (input == "a")
            {
                MadeLeine();
            }

            else
            {
                ExploreRoom();
            }
        }

        void MadeLeine()
        {
            Console.Clear();
            center("You knocked on the door. A middle-aged woman, in an extremely young cute red dot dress that does not suit her age, and with a red bowknot on her messy hair.");
            Dialog1("Oh, " +_CharacterName+ " from the 5th floor.", ConsoleColor.DarkRed);
            if (treasureBox)
            {

                Dialog("Excuse me, do you know who lived in my room many years ago? I found his stuff I think...");
                Dialog1("For that business of yours, Go and ask the blind man downstairs.He has lived here the longest.", ConsoleColor.DarkRed);
                Dialog("Thank you MadeLeine.");
            }

            else
            {
                Dialog("Do you know me?");
                Dialog1("Oh of course. Although you don't usually come down to talk. But I could see the pure heart down there from your eyes.", ConsoleColor.Red);
            }
            if(!MadelienaStory)
            {
                Dialog1("Come in and have a Masseto first. I bet you know my story already.", ConsoleColor.DarkRed);
                Dialog("Not really.");
                center("1)Stay to listen to what she have been through.2)Make an excuse to leave.");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    _Point++;
                    Memory.ReturnNewMemory(_Point);
                    goodDeed.Add("Listen to Madeleina's story.");
                    center("");
                    Dialog1(@"
        My husband used to work at Coccinelle Insurance.
        People liked to gossip about the affair between he and his secretary.
        And then my husband started to stoled 5 million from his company.And fled away together to the South America.
        Then on they July 2nd in 1974, the door bell rings.
        The one came was not him, but the news about his death in a plane crash.
        My life just froze from then…", ConsoleColor.DarkRed);
                    center("You could write down what you want to say. Or press enter to continue...");
                    Console.ReadLine();
                    Dialog1(@"
        That is really nice of you hearing my story.
        These days not many people spare time to hear other people's story.
        I'll read his letters to you:
        “Mado my love.” My name is Madeleine.
        “I can't sleep. I can't eat.
        “I left my only reason of life in Paris.
        “I will see her again on Friday    
        “ when I'll see my beloved darling at the station, 
        “ in her blue dress with straps.
        “Love.” 
        My name is Madeleine Walace. They say that “cry like Madeleine.”
        And Walace.The Walace Fountains.
        You see, tears are my destiny!
        ", ConsoleColor.DarkRed);
                    MadelienaStory = true;
                }
            
                
                center("Before you leave, do you want to 1)comfort her 2)make a fake letter of his husband. 3)Later.");
                input = Console.ReadLine();
                if (input == "1")
                {

                    _Point++;
                    goodDeed.Add("Comforted the sad lady.");
                    Dialog("It is okay... Everything will be fine.");
                    Dialog1("Thank you darling. You will get good luck. Trust me", ConsoleColor.DarkRed);
                    //Memory Madeleina2 = new Memory(_Point);
                    Memory.ReturnNewMemory(_Point);

                    CheckPoint();

                }
                else if (input == "2")
                {
                    center(@"
        You secretly steal several letters from her and copied them.
        After back home, you read them for hours to learn her husband's flirting style.
        Finally you cut all the lovely words from the old letters,
        and make a fake letter 
        and send it to Madeline.");
                    Console.ReadKey();

                    center(@"
        The letter says:
        “Dear Mrs.Walace, 
        ”Recently we found a lost package on the missing plane BO704 around the Mt.Himalaya ,
        “We found this letter sending to you and we feel honor to send this  to you.
        “We apologize for this delayed mail.
        “Janell Gary, Administrator form Public Relationship 
        “is said found on the lost and found package of the crashed plane,
        “Mado my dear, your absence gets more painful every day.
        ”I made the biggest mistake 
        “that is run away from my wife.
        “Good news. I am saving up money.
        “And I give up that woman and those money.
        “I'll be able to come home soon.
        “I think of you all the time. 
        “Your Adrien.
        ");
                    Console.ReadKey();
                    center("Madeleina got the letter and she read it with tears.");
                    Console.ReadKey();
                    center("She sees you and ask: ");
                    Dialog1("“Do you believe in miracle?", ConsoleColor.DarkRed);
                    Dialog1("“A climing explidition has discovered  the evidence of my husband loved me!”", ConsoleColor.DarkRed);
                    Console.ReadKey();
                    center("The headache comes again, seem like some more memories are coming, are you ready?");
                    _Point++;
                    //Memory Madeleina2 = new Memory(_Point);
                    Memory.ReturnMemory(_Point);
                    CheckPoint();
                }

                else
                {
                    Choice1();
                }
            }

            else
            {
                center("You excuse that you need to get an important mail and run upstairs.She seems really disappointed.");
                ExploreRoom();
            }
        }



        void ExploreRoom()
        {
            Console.Clear();
            string input;
            string Appearance;
            center("Not many things are here. Only few things got your attention.");
            center("There is a interesting picture on the table, a little hoodle ball  on the floor, a classic galss windows on the other side of the room.");
            center("Which one do you want to look first? 1)picture2)hoodle ball3)the window");
            input = Console.ReadLine();
            if (input == "1")
            {
                if (_CharacterIdentity == "girl")
                {
                    Appearance = "a plaid dark red skirt and a classic English red hat";
                    //CharacterColor=;
                }

                else
                {
                    Appearance = "An old fashion blue brown plaid shirt, a pair of light brown casual jeans and a funny English hat";
                }
                Console.WriteLine("You pick up the picture and there is a {0} with {1}  standing in front of you.", _CharacterIdentity, Appearance);
                center("There is a mirror, and you see the same person in it! ");
                center("Yes, this is you. Someone you feel like never seen before.");
                center("Which means, this is your apartment.");
                center("Press enter to continue...");
                Console.ReadKey();

                center("What is this hat?");
                center("Do you want to have a look at it?(type yes or no)");
                input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    center("You try to take off your hat, the enormous pain on the forehead flow to you again...");
                    Console.ReadKey();
                    center("Keep doing it?");
                    center("type yes or no");
                    input = Console.ReadLine().ToLower();
                    if (input == "yes")
                    {
                        center("You see a huge BUMP under the hat and on your head!");
                        center("Press enter to continue explore..");
                        ExploreRoom();
                    }

                    else
                    {
                        center("Hmm, the hat feels really soft.");
                    }
                }
                else
                {
                    ExploreRoom();
                }
            }

            if (input == "2")
            {
                TreasureBox();
            }

            else
            {
                center("A old man is begging for money on the street. He seems like blind.");
                center("Press 1 to talk to him. Press 2 to ignore. ");
                input = Console.ReadLine();
                if (input == "1")
                {
                    BlindMan();
                }

                else
                {
                    ExploreRoom();
                }
            }
            void TreasureBox()
            {
                Console.Clear();
                center("You pick up the little hoodle on the floor");
                center("“Did I fell on this and lost my memory?” you murmur.");
                center("Ahh...");
                center("Your head hurt agian. You drop the hoodle unintentionally, and it rolls to the wall.");
                center("Ding. A brick fell down. ");
                center("There is a hole on the wall.");
                center("Hit enter to explore in the hole");
                Console.ReadKey();
                center("You take the brick off, ");
                center("You put your hand in the hole.");
                center("There is a iron box covered in dirt.");
center("You opened the box, there are a picture of a little boy kicking soccer, a pack of pocker card, some more hoodles, a mini toy car...");
                center("You discovered a treasure box that a little boy hid here many years ago.");
                center("He must be really missing this little box that stores all his childhood memory.");
                center("What do you want to do with it?");
                center("1)Put it back to its hole and forget about it.");
                center("2)Give it back to whoever it belongs to.");
                center("3)Sell them and get the money.");
input = Console.ReadLine().ToLower();
                if (input == "1")
                {
                    center("The pain is over. The hoodle doesn't seem attractive to you anymore.");
                    ExploreRoom();
                }

                else if (input == "2")
                {
                    treasureBox = true;
                    //Memory TreasureBox1 = new Memory(_Point);
                    Memory.ReturnMemory(_Point);
                    center("The question is, how could you find this owner?");
                    center("Maybe go ask the lady downstairs?");
                    center("Press 1 to go downstairs. Press 2 to continue explore the room.");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        MadeLeine();
                    }

                    else
                    {
                        Console.Clear();
                        ExploreRoom();
                    }

                }

                else
                {
                    GetHelpEnding();

                }

            }
        }

        void BlindMan()
        {
            Console.Clear();
            center("On the busy noisy street, the blind old man is hesitating in the corner, trying to cross.");
            center("The bowl he is holding for money is not that lucky today, with only one lonely coin in it. ");
            center("You reach your hand to your pocket. As unlucky as the man, there is only one coin there too.");
            center("You did not see any money at home either.");
            center("So, you are going to:1)Give the only coin to him. 2)Save it to yourself.");
            string input = Console.ReadLine();
            if (input == "1")
            {
                center("There is something else in his bowl!");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Magenta;
                center("A colorful fur!");
                Console.ReadKey();
                Console.ResetColor();
                _Point++;
                //Memory BlindMan1 = new Memory(_Point);
                Memory.ReturnNewMemory(_Point);

                Console.ReadKey();
                goodDeed.Add("Donate your only coin to the blind man.");
                Dialog1("Thank you darling. ", ConsoleColor.Red);
                Dialog1("What a lovely day, but I could never see it again", ConsoleColor.Red);
                Dialog1("But I wish you enjoy!", ConsoleColor.Red);
               
                Console.ReadKey();
                while (treasureBox)
                {
                    center("Press Enter to ask him about who used to live in the apartment ");
                    Console.ReadLine();
                    Dialog("Excuse me, I live in the 501 room in the LOFT apartment. Do you know anything who used to live there?");
                    Dialog1("Yes of course! The kind Benjamin used to live there when he was a sweet little boy", ConsoleColor.Red);
                    Dialog("Where can I find him?");
                    Dialog1("He goes to the fair every Tuesday morning! He always remembers to give me a roasted chicken breast!", ConsoleColor.Red);
                    center("1)Wait till the Tuesday morning. 2)Go back home to explore.3)Company this old man.");
                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        Benjamin();
                    }

                    else if (input == "3")
                    {
                        break;
                    }

                    else
                    {
                        Choice1();
                    }
                }

                center("Now what do you want to do?1)Leave 2)Help him cross and give him a tour.");
                input = Console.ReadLine();
                if (input == "2")
                {
                    _Point++;
                    //Memory BlindMan2 = new Memory(_Point);
                    Memory.ReturnNewMemory(_Point);
                    goodDeed.Add("Give a vivid visual tour to the old blind man.");
                    center("You grab his arm and help him cross. You are saying: ");
                    center(@"I'll help you. We go down and there we go!
Be careful, there is the kerb.
You could see the neon of the horse-butcher's shop reflected in the gutter.
There's the widow of the drummer of the brass band.
Hey, the horse statue lost one ear!
She looks like a little girl made up to be n old lady.
Can you smell the scent of the roses?
They are blossoming in the sunshine by the street!
We're passing in front of the butcher's.
Ham on the bone costs $99!
There is a baby's looking at a dog, and the dog is looking at the chicken.
Here you are, now we're at the metro station.
I'll leave you here, goodbye.");
                    Dialog1("Thank you angel. I could see the angel and the brightness of  life again.", ConsoleColor.Red);                   
                    CheckPoint();
                    center("Hit enter to go back home to explore.");
                    Console.ReadKey();
                    Choice1();
                }


            }

            else
            {
                center("Understand.");
                while (treasureBox)
                {
                    center("Press Enter to ask him about who used to live in the apartment ");
                    Console.ReadLine();
                    Dialog("Excuse me, I live in the 501 room in the LOFT apartment. Do you know anything who used to live there?");
                    Dialog1("Yes of course! The kind Boneur used to live there when he was a sweet little boy", ConsoleColor.Red);
                    Dialog("Where can I find him?");
                    Dialog1("He goes to the fair every Tuesday morning! He always remembers to give me a roasted chicken breast!", ConsoleColor.Red);
                    center("1)Wait till the Tuesday morning. 2)Go back home to explore.");
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        Benjamin();
                    }

                    else
                    {
                        Choice1();
                    }
                    center("He looks like a kind and warm person. But cannot get any useful information standing far away. Hit enter to go back home to explore.");
                    Choice1();
                }
            }

        }

        void Benjamin()
        {
            Console.Clear();
            center("Tuesday comes. What is your plan?");
            center("1)Call him secretly from the public telephone booth and give it back to him 2)Rob him");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {

                case 1:
                    foreach (string s in BenjaminStory)
                    {
                        Dialog1(s, ConsoleColor.DarkRed);
                    }
                    _Point++;
                    goodDeed.Add("Give the treasure box back to Benjamin. You encouraged him to put more love in life.");
                    //Memory TreasureBox2 = new Memory(_Point);
                    Memory.ReturnNewMemory(_Point);
                    Console.ReadKey();
                    CheckPoint();
                    center("You may need more good deeds to get back  unicorn magic and go home..");
                    center("Press enter to go back to apartment...");
                    Choice1();
                    break;

                case 2:
                    ForgiveEnding();

                    break;


            }
        }

        void GetHelpEnding()
        {
            Console.Clear();
            Memory.ReturnMemory(4);
            center("The pain is getting more dramatic, like a drill onto your head. Finally you cannot hold it anymore...");
            center("Press Enter to see what happened...");
            Console.ReadKey();
            center("You wake up. In a cute warm room with flowers by your bed.");
            Console.ReadKey();
            center("A woman come in. She is so happy to see you awake.");
            Console.ReadKey();
            center("You learnt that she is actually the lady crying downstairs. ");
            Console.ReadKey();
            center("She found you knock over on the floor, took you home and gave you the best service.");
            Console.ReadKey();
            center("Knowing you lost all your memory, she adpoted you  and you start a new happy life together.");
            Console.ReadKey();
            center("Even though you never know who you are and where you come from, that doesn't matter to you anymore...");
        }

        void ForgiveEnding()
        {
            Console.Clear();
            Memory.ReturnMemory(4);
            center("The pain is getting more dramatic, like a drill onto your head. Finally you cannot hold it anymore...");
            center("Press Enter to see what happened...");
            Console.ReadKey();
            center("You wake up. In a cute warm room with flowers by your bed.");
            Console.ReadKey();
            center("A man come in. He looks so happy to see you awake.");
            Console.ReadKey();
            center("You learnt that he is actually Benjamin that you planned to rob. ");
            Console.ReadKey();
            center("He found you knock over on the floor, so he took you home and gave you the best service.");
            //Console.ReadKey();
            //center("You got forgive from this great man and become his child!");
            Console.ReadKey();
            center("Knowing you lost all your memory, he decided to adpot you  and you start a new happy life together.");
            Console.ReadKey();
            center("Even though you never know who you are and where you come from, that doesn't matter to you anymore...");
        }

        void UnicornEnding()
        {
            Console.Clear();
            center("Coming through all the difficulties, you never forget to help people with your beautiful heart and your wise mind...");
            center("Press enter to see your award...");
            Console.ReadLine();
            center("It turns out your headache is because you are growing a colorful horn! ");
            Console.ReadLine();
            center("All your memory comes back to you. They are so happy and colorful... You are a unicorn for your whole life...");
            Console.ReadLine();
            center("You fly back home to the unicorn families and get a huge unicorn feast to celebrate!");
            //center("Here is your magic wand!");
            Console.ReadLine();
            center("You become a real unicorn fairy now!");
            Console.ReadLine();
            center("Enjoy your magic!");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            center(@"             
'   `                                                                                                 
'   ` `                                                                                              
'     ````                                                                                           
'         ..`                                                                                        
'          ....                `                                                                     
'            `..-.   `.````  ``.``                                                                   
'              `.`.-..:-`.--.---...```                                                               
'               `.-.-......-...--.-.--.                                                              
'              `.`.-.`..-..-...-::-...-.                                                             
'                 `:--.:.--..--.-`.-----.`                                                           
'                 `-..-...-...-.-...-.-...```                                                        
'                `...---..-..`.-..-........`.                                                        
'                ..-.:.---``.-----......-.`.-.                                                       
'               ..---..-.`  `.----...-.--....-`                                                      
'              `.:--.``      `-...--..--.`....                                                       
'               `...`        `:--.-----:----:.                                                       
'                            .-.---.-:-----.-..```                          ``````                   
'                           ...`----...----.-....-.``.`.-.`-.-..`..``    `..........`                
'                          `........--.-.----..-.-..------.--...`...-.``.............`               
'                         `.-.......---..-:....-.-...-..:---..........-..---........-.`  .           
'                         ..........-.``..`-:.`-::-........--..-....-.-.``....``.-.--.....           
'                         .......--....`.`.-..-..:-......`.-.-......-.-`.``...`..-..`.-.-`           
'                        `.-....-..`-......`....---.--....-.-.`.----.-... `.`...-....---..`         
'                          .....`.......-...-.-..`-.`-..`--......-....`.`..`...`.-.....-....`        
'               `.....`..`..-...----`.---.`--..`.`...-.`-----...---:..--.-.` `......-.-...-`.        
'              `-.:--..-.--..-...-...--...............`.-`--.-..---------.-`   ````..--.....`        
'              .--.  ```...`.-`-...---.-.........-.--..--:.`.-......---.----       ``.-....-.`     `.
'             .--`         ` ``` `-...-..`.-......---......-...  ``.:-:--...`        .---`..-........
'            `...                 .`---..`-`......```.---.-...      `.----..`         ...`..-..`--.` 
'           `...`                 ``--.`              `.-.`.``         .--`.-.          ``..--.```.-`
'            ..``                 .`-``                `.....           ```..-.             `     `.`
'            `-..                 ....                  -..`.              `.-..`                  .`
'             .`.                `.--`                  `..-.`              `.`..                  ` 
'                               ....`                    ``...               `..-.                   
'                              `..-`                      ..-..                ...                   
'                              `...                        `....                `..`                 
'                              .-`                         `-.`                  ..`                 
'                             ..`                          `-``                   ..-                
'                            ```                           ..-                    ``-.               
'                           ``-.                          `-.                      `-.:.`            
'                          .`.`                          `..                        `----.           
'                        `-..-                         ..-.`                         `.-.`           
'                        ```.`                        ..--`                                          
");

            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.White;
            center("Press enter to see your game conclusion.");
            Console.Clear();
            EndGame();
        }
        void Narrative(string message)
        {

            Console.WriteLine(message);
        }

        void Dialog(string message)
        {
            Console.ForegroundColor = _CharacterColor;
            center(message);
            Console.ResetColor();
        }

        void Dialog1(string message, ConsoleColor color)
        {

            Console.ForegroundColor = color;
            center(message);
            Console.ResetColor();
        }


        void center(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (Console.WindowWidth / 2) + (stringWidth / 2);

            Console.WriteLine(message.PadLeft(spaces));
        }

        void EndGame()
        {
            Console.Clear();
            Console.ReadKey();
            Console.Clear();
            //center("End of story text here.....");
            center("Here is a conclusion of  all the memory you have found back in the human world:");
            Console.ReadKey();
            Memory.ReturnAllMemories(_Point);

            //center("Here is a conclusion of items you collected:");
            //foreach (string i in items)
            //{
            //    center(i);
            //}

            center("Here is a conclusion of all the deeds you did:");
            foreach (string d in goodDeed)
            {
                center(d);
            }
            Console.ReadKey();
            center("Press enter to exit.");
        }

        void CheckPoint()
        {
            Console.ReadKey();
            if (_Point >= 3)
            {
                UnicornEnding();
            }

        }
        
    }
}