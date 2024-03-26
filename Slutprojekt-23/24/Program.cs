
namespace BigLottosTournament
{
    class Program
        {
            public static Intro introInstance = new();

            
            static void Main(string[] args)
            {
                introInstance.IsChallenging();
                introInstance.NameSelect();
                Console.ReadKey();

                
            }

            
        }
    }








