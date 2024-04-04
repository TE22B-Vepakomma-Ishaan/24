
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
                }

                fightingSystem.combatScene();



                Console.ReadKey();

                
            }
            

        static bool IsChallenging()
            {

                string choice;
                

                Console.WriteLine("Announcer: Welcome to Big Lotto's Fun-tastic Fighting Function!");
                System.Console.WriteLine("Our annual tournament is about to start, deadline for application is in 48min, would you like to apply for a position?");
                System.Console.WriteLine("");
                System.Console.WriteLine("a) YES. I shall!! I will challenge the Man; no more will we be under his thumb!");
                System.Console.WriteLine("b) NO. I will not partake in such foolish activities.I will leave.");
            
                            
                
                do
                {
                    choice = Console.ReadLine().ToLower();;
                    if((choice != "a" && choice != "b")){
                        System.Console.WriteLine("pick a or b");

                    }
                    
                } while ((choice != "a" && choice != "b"));

                if(choice == "a"){
                    
                    System.Console.WriteLine("okay CONTINUE");
                    return true;
                }
                else{
                    System.Console.WriteLine("Announcer: Very well then! leave");
                    return false;
                }
            }

        static void NameSelect()
        {
              System.Console.WriteLine("great! continue");

                Console.WriteLine("what is your name?");
                


                do
                {
                    System.Console.WriteLine("input your name here down below: ");
                    currentPlayer.name = Console.ReadLine();

                    if (currentPlayer.name == "")
                    {
                        System.Console.WriteLine("Announcer: If you continue to joke, security will be called. Big Lotto's establishment will not be sullied.");
                        Console.ReadKey();
                        System.Console.WriteLine("");
                        System.Console.WriteLine("System: Current security on duty: Vannessa.");
                        System.Console.WriteLine("Time employed: 2years 7months 13days");
                        System.Console.WriteLine("Preferred method of dispatch: Castration.");
                        System.Console.WriteLine("Average customer rating: 2/5");
                        System.Console.WriteLine("Latest review: User Bootlicker23_2 gave a 1/5");
                        System.Console.WriteLine("    Review Comment: \"Dear god is she scary i almost pissed myself! And this wench had the gall to laugh at me, said i was 'too tiny to enjoy tormenting' or some bullshit. Never have i been so humiliatedd in my life i hope this Vanessa hag gets fired!! However, her domineering tone did remind me of my ex-wife. I plan on returning once she's learnt some manners to see if she would like to go on a date.\"");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("      VannyFanny replies: \"HA u pig i'll crush you if i see your tiny ass here again!\"");
                        System.Console.WriteLine("");
                    }

                    if (currentPlayer.name.Length > 8)
                    {
                        System.Console.WriteLine("Announcer: Your mother truly gave you an unfortunate name, one too foolish even for our enterprise. Please consider using a nickname or even your girlfriends name, assuming a sad man like you would have one.");
                        System.Console.WriteLine("");
                    }
                } while (currentPlayer.name == "" || currentPlayer.name.Length > 8);


                System.Console.WriteLine($"Announcer: Welcome, {currentPlayer.name}, to the tournament! Your fight will begin in 30min, please spin the lotto to determine your sparring partner.");
                System.Console.WriteLine("");
                System.Console.WriteLine("As you wait, ...");
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

        






        
        }
    }








