
namespace BigLottosTournament
{
    class Program
        {
            public static Intro introInstance = new();
            public static EnemyLists enemyFunctions =new();

            
            static void Main(string[] args)
            {
                introInstance.IsChallenging();
                introInstance.NameSelect();
                

                Console.ReadKey();

                
            }

            
        }
    }








