
namespace BigLottosTournament
{
    class Program
        {
            public static Combatant currentPlayer = new();
            static Random random = new();
            public static FightingSystem fightingSystem = new();

            
            
            static void Main(string[] args)
            { 

                EnemyListSetup.createEnemyList();
                
                if(IsChallenging() == true)
                {
                    NameSelect();
                    fightingSystem.currentPlayer = currentPlayer;

                    enemySelection();
                    fightingSystem.combatScene();
                    if(fightingSystem.isPlayerAlive())
                    {
                        AfterFight();
                    }
                }
                // fightingSystem.currentPlayer = currentPlayer;
                // enemySelection();
                // fightingSystem.combatScene();

                
            }
            

            // All story related code goes here-------------------------------

        static bool IsChallenging()
            {

                string choice;
                System.Console.WriteLine("(Note: playing in full screen would be most ideal. gets rid of word splitting.)");
                

                Console.WriteLine("Announcer: Welcome to Big Lotto's Fun-tastic Fighting Function!");
                System.Console.WriteLine("Our annual tournament is about to start, deadline for application is in 48min, would you like to apply for a position?");
                System.Console.WriteLine("");
                System.Console.WriteLine("a) YES. I shall!! I will challenge the Man (Big Lotto); no more will we be under his thumb!");
                System.Console.WriteLine("b) NO. I will not partake in such foolish activities. This establishment is in ruins.");
            
                            
                
                do
                {
                    choice = Console.ReadLine().ToLower();;
                    if((choice != "a" && choice != "b")){
                        System.Console.WriteLine("pick a or b");

                    }
                    
                } while ((choice != "a" && choice != "b"));

                if(choice == "a"){
                    
                    System.Console.WriteLine("Announcer: ..haha yes The Man (fighter) is truly a formidable opponent, fortunately for you, he is currently somewhere in the Amazonian rainforest and will not participate this year.");
                    
                    return true;
                }
                else{
                    
                    System.Console.WriteLine("Announcer: Uhh...very well then! Then may i suggest you leave, lest we bring security. As you know, tarnishing Big Lotto's name is punishable by death.");
                    System.Console.WriteLine("You leave in a panic, the security here is known for their cruel and gruesome methods of keeping the peace.");
                    Console.ReadKey();
                    return false;
                }
            }

        static void NameSelect()
        {
              

                Console.WriteLine("Announcer: Nevertheless, since you have decided to register, may i ask you for your name?");
                


                do
                {
                    System.Console.WriteLine("input your name here down below: ");
                    currentPlayer.name = Console.ReadLine();

                    if (currentPlayer.name == "")
                    {
                        System.Console.WriteLine("Announcer: If you wish to joke security will be called. Big Lotto's establishment will not be sullied.");
                        Console.ReadKey();
                        System.Console.WriteLine("");
                        System.Console.WriteLine("System: Current security on duty: Vannessa.");
                        System.Console.WriteLine("Time employed: 2years 7months 13days");
                        System.Console.WriteLine("Preferred method of dispatch: Castration.");
                        System.Console.WriteLine("Average customer rating: 2/5");
                        System.Console.WriteLine("Latest review: User Bootlicker23_2 gave a 1/5");
                        System.Console.WriteLine("  Comment: \"Dear god is she scary i almost pissed myself! And this wench had the gall to laugh at me, said i was 'too tiny to enjoy tormenting' or some bullshit. Never have i been so humiliatedd in my life i hope this Vanessa hag gets fired!! However, her domineering tone did remind me of my ex-wife. I plan on returning once she's learnt some manners to see if she would like to go on a date.\"");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("      VannyFanny replies: \"HA u pig i'll crush you if i see your tiny ass here again!\"");
                        System.Console.WriteLine("");
                    }

                    if (currentPlayer.name.Length > 8)
                    {
                        System.Console.WriteLine("Announcer: Your mother truly gave you an unfortunate name, one too foolish even for our enterprise. Please consider using a nickname or even your partners name, assuming a person of your state has one.");
                        System.Console.WriteLine("");
                    }
                } while (currentPlayer.name == "" || currentPlayer.name.Length > 8);


                System.Console.WriteLine($"Announcer: Welcome, {currentPlayer.name}, to the tournament! Please spin the lotto to determine your opponent.");
                System.Console.WriteLine("");
                Console.ReadKey();
                System.Console.WriteLine("As you spin the lotto, a sense of unease washes over you. You recall the articles talking of the dangerous and life threatening fights that go on here. While killing is forbidden, everything short of it is fair game.");
                System.Console.WriteLine("");
                System.Console.WriteLine("Announcer: Great! Your fight is set to begin in 30 minutes.");
                Console.ReadKey();
                System.Console.WriteLine("      30 Minutes later.");
                Console.ReadKey();

        }


        static void enemySelection(){
            
            int index = random.Next(EnemyListSetup.EnemiesList.Count);
            int indexTwo;

            do
            {
            
                indexTwo = random.Next(EnemyListSetup.EnemiesList.Count);
                
            } while (indexTwo == index);



            var firstEnemy = EnemyListSetup.EnemiesList[index];
            var secondEnemy = EnemyListSetup.EnemiesList[indexTwo];
            fightingSystem.selectedEnemies.Add(firstEnemy);
            fightingSystem.selectedEnemies.Add(secondEnemy);

            System.Console.WriteLine("Announcer: Greetings dear ladies and gentlefreaks, the first round of the annual [name] tournament will begin!");
            System.Console.WriteLine($"To start us off, the first fight will be between the fan favorite, {firstEnemy.name}, versus the never before heard: {currentPlayer.name}!!");
            Console.ReadKey();


            

        }
        
        public static void SecondFight(){

            System.Console.WriteLine($"Announcer: AMAZING PERFORMANCE, it seems we have an underdog in our midst!! {currentPlayer.name} has taken down {fightingSystem.selectedEnemies[0].name} valiantly and will move on the the semi-finals!!");
            System.Console.WriteLine($"The semi-finals will begin shortly where our new hero will face last year's champion, {fightingSystem.selectedEnemies[1].name}! This is sure to be an exhilarating match!");
            System.Console.WriteLine("");
            System.Console.WriteLine("(note: this is the same as our modern day finals. In respect, or fear, of Big Lotto, tournaments are prohibited of using the the term 'finals' or 'finale' as such success and status is seen as a mockery of their ruler Big Lotto)");
            Console.ReadKey();
            System.Console.WriteLine("");
            System.Console.WriteLine("");

        }

        static void AfterFight(){

            System.Console.WriteLine($"Announcer: A NEVER BEFORE SEEN FEAT, {fightingSystem.selectedEnemies[1].name.ToUpper()} HAS BEEN KNOCKED OUT AND {currentPlayer.name.ToUpper()} HAS SECURED VICTORY!!!!!");
            Console.ReadKey();
            System.Console.WriteLine("");
            System.Console.WriteLine("You feel the rush of adrenaline in your blood. You did it. Through all the odds you did it, you have won. The thrill of the fight has not left you. Instead, you feel something else; something stronger.");
            Console.ReadKey();
            System.Console.WriteLine("...Something more sinister courses through your veins.");
            Console.ReadKey();
            System.Console.WriteLine("You want blood. You want carnage. You want to slay the Hand that rules.");
            System.Console.WriteLine("a) Submit to these feelings. Let your rage consume you.");
            System.Console.WriteLine("b) Resist with all your might. This is not the time.");

            
        }
        






        
        }
    }








