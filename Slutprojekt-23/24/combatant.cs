

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
        string[] lines = File.ReadAllLines("statfile.txt");
        int i = 1;
        foreach (string line in lines)
        {
            string[] combatantEntry = line.Split(",");

            if(i == 1)
            {
                Program.currentPlayer.name = combatantEntry[0];
                Program.currentPlayer.hp = int.Parse(combatantEntry[1]);
                Program.currentPlayer.moves = new(){
                new(){attackName = combatantEntry[2], minDamage = int.Parse(combatantEntry[3]),maxDamage = int.Parse(combatantEntry[4]), moveCost = int.Parse(combatantEntry[5]), moveTotal = 5},
                new(){attackName = combatantEntry[6], minDamage = int.Parse(combatantEntry[7]),maxDamage = int.Parse(combatantEntry[8]), moveCost = int.Parse(combatantEntry[9]), moveTotal = 5},
               new(){attackName = combatantEntry[10], minDamage = int.Parse(combatantEntry[11]),maxDamage = int.Parse(combatantEntry[12]), moveCost = int.Parse(combatantEntry[13]), moveTotal = 5},
               new(){attackName = combatantEntry[14], minDamage = int.Parse(combatantEntry[15]),maxDamage = int.Parse(combatantEntry[16]), moveCost = int.Parse(combatantEntry[17]), moveTotal = 5},
            };

            i = 0;
            }
            else{

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

    }



}
