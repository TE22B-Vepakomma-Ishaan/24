namespace BigLottosTournament{

    public class FightingSystem{

        public static Random random = new();

        public List<Combatant> selectedEnemies = new();

        public Combatant currentPlayer = new();

        public void combatScene(){

            int currentEnemyIndex = 0;
            int round = 1;


           while (currentPlayer.hp > 0 && currentEnemyIndex < selectedEnemies.Count)
           {

            Combatant currentEnemy = selectedEnemies[currentEnemyIndex];

            System.Console.WriteLine("---------------------------------------------------------------------------------------------------");
            System.Console.WriteLine($"Round {round} begins!");  
            System.Console.WriteLine("");
            System.Console.WriteLine($"Player health: {currentPlayer.hp}");
            System.Console.WriteLine($"Enemy health:   {currentEnemy.hp}");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please select your move:");
            Console.WriteLine("+-----------------------------------+");
            Console.WriteLine("|                 |                 |");
            Console.WriteLine($"| 1) {currentPlayer.moves[0].attackName}        | 2) {currentPlayer.moves[1].attackName}         |");
            Console.WriteLine("|                 |                 |");
            Console.WriteLine("+-----------------+-----------------+");
            Console.WriteLine("|                 |                 |");
            Console.WriteLine($"| 3) {currentPlayer.moves[2].attackName} | 4) {currentPlayer.moves[3].attackName}        |");
            Console.WriteLine("|                 |                 |");
            Console.WriteLine("+-----------------------------------+");
            // string choice;
            // choice = Console.ReadLine();
            
           int enemyDamageDealt = PerformRandomAttack(currentEnemy);

           currentPlayer.hp -= enemyDamageDealt;


            
            if(currentEnemy.hp <= 0){

                System.Console.WriteLine($"{currentEnemy.name} has been knocked down! {currentPlayer.name} has won!!");

                currentPlayer.hp = 100;
                currentEnemyIndex++;
            }


    


            round++;
            Console.ReadKey();
           } 

        }

        public bool isPlayerAlive(){

            if(currentPlayer.hp > 0)
            {
                return true;

            }
            else{
                return false;
            }

        }
        

        public static int PerformRandomAttack(Combatant enemy)
        {

            Moveset currentMove;
            do
            { 
                currentMove = enemy.moves[random.Next(enemy.moves.Count)]; 
                
            } while (currentMove.moveCost > currentMove.moveTotal);

            currentMove.moveTotal -= currentMove.moveCost;
            int damage = random.Next(currentMove.minDamage, currentMove.maxDamage + 1);

            foreach (var move in enemy.moves)
            {
                if(move != currentMove || move.moveTotal < 5)
                {
                    move.moveTotal++;
                }

                System.Console.WriteLine(move.moveCost);
                System.Console.WriteLine(move.moveTotal);
            }
            
            Console.WriteLine($"{enemy.name} used {currentMove.attackName} and dealt {damage} damage.");

            
            
            return damage;
        }



    }

}