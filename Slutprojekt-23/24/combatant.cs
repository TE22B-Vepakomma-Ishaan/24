

using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace BigLottosTournament
{

    public class Combatant
    {

        public string name;
        public int hp;

        public List<Moveset> moves = new();


    }

    public class Moveset
    {
        public string attackName;
        public int minDamage;
        public int maxDamage;
        public int moveTotal;
        public int moveCost;
        
    }
      
    public class EnemyListSetup
    {
        public static List<Combatant> EnemiesList = new();
        public static void createEnemyList(){
        string EnemyStats = "statfile.txt";
        string[] lines = File.ReadAllLines(EnemyStats);
        foreach (string line in lines)
        {
            string[] combatantEntry = line.Split(",");

            Combatant newCombatant = new(){name = combatantEntry[0], hp = int.Parse(combatantEntry[1]),
             moves = new(){
                new(){attackName = combatantEntry[2], minDamage = int.Parse(combatantEntry[3]),maxDamage = int.Parse(combatantEntry[4]), moveCost = int.Parse(combatantEntry[5]), moveTotal = 5},
                new(){attackName = combatantEntry[6], minDamage = int.Parse(combatantEntry[7]),maxDamage = int.Parse(combatantEntry[8]), moveCost = int.Parse(combatantEntry[9]), moveTotal = 5},
               new(){attackName = combatantEntry[10], minDamage = int.Parse(combatantEntry[11]),maxDamage = int.Parse(combatantEntry[12]), moveCost = int.Parse(combatantEntry[13]), moveTotal = 5},
               new(){attackName = combatantEntry[14], minDamage = int.Parse(combatantEntry[15]),maxDamage = int.Parse(combatantEntry[16]), moveCost = int.Parse(combatantEntry[17]), moveTotal = 5},
            }
            };

            EnemiesList.Add(newCombatant);

        }

        }

    }


        // public static Random random = new();
        // public static int getRandomDamage(int minDamage, int maxDamage)
        // {
        //     return random.Next(minDamage, maxDamage + 1);
        // }

        //  public static void PerformRandomAttack(Combatant enemy)
        // {
        //     Moveset randomMove = enemy.moves[random.Next(enemy.moves.Count)]; 
        //     int damage = getRandomDamage(randomMove.minDamage, randomMove.maxDamage);
            
        //     Console.WriteLine($"{enemy.name} used {randomMove.attackName} and dealt {damage} damage.");
        // }



}
