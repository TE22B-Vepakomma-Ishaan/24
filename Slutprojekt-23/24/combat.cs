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
            System.Console.WriteLine($"Enemy health:  {currentEnemy.hp}");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Please select your move");
            Console.WriteLine("-+--------------------------------------+--------------------------------------+-");
            Console.WriteLine(" |				   	|				       |");
            Console.WriteLine($" |  1) {currentPlayer.moves[0].attackName}	  	  ({currentPlayer.moves[0].minDamage}-{currentPlayer.moves[0].maxDamage})        |  2) {currentPlayer.moves[1].attackName}	     	({currentPlayer.moves[1].minDamage}-{currentPlayer.moves[1].maxDamage})        |");
            Console.WriteLine(" |				   	|		       		       |");
            Console.WriteLine($" |        Cost: {currentPlayer.moves[0].moveCost}     Total: {currentPlayer.moves[0].moveTotal}/5       	|	 Cost: {currentPlayer.moves[1].moveCost}     Total: {currentPlayer.moves[1].moveTotal}/5	       |");
            Console.WriteLine(" |				   	|		       		       |");
            Console.WriteLine("-+--------------------------------------¤--------------------------------------+-");
            Console.WriteLine(" |				   	|				       |");
            Console.WriteLine($" |  3) {currentPlayer.moves[2].attackName} 	 ({currentPlayer.moves[2].minDamage}-{currentPlayer.moves[2].maxDamage})        |  4) {currentPlayer.moves[3].attackName}	     	  ({currentPlayer.moves[3].minDamage}-{currentPlayer.moves[3].maxDamage})        |");
            Console.WriteLine(" |				   	|				       |");
             Console.WriteLine($" |        Cost: {currentPlayer.moves[2].moveCost}     Total: {currentPlayer.moves[2].moveTotal}/5       	|	 Cost: {currentPlayer.moves[3].moveCost}     Total: {currentPlayer.moves[3].moveTotal}/5	       |");
            Console.WriteLine(" |				   	|				       |");
            Console.WriteLine("-+--------------------------------------+--------------------------------------+-");
           
           int enemyDamageDealt;
           bool enemyIsBlocking;
        
            int playerDamageDealt;
            bool playerIsBlocking;



            playerDamageDealt = PlayerAttack(out playerIsBlocking);
           enemyDamageDealt = EnemyRandomAttack(currentEnemy, out enemyIsBlocking);
            if (enemyIsBlocking){
                if(playerDamageDealt > 0)
                {
                    System.Console.WriteLine("Your damage is nullified");
                }
                playerDamageDealt = 0;
            }

            if (playerIsBlocking){
                if (enemyDamageDealt > 0)
                {
                    System.Console.WriteLine("Your opponent's damage is nullified");
                    
                }
                enemyDamageDealt = 0;

            }
           currentPlayer.hp -= enemyDamageDealt;
            currentEnemy.hp -= playerDamageDealt; 

            
            
            if(currentEnemy.hp <= 0){

                System.Console.WriteLine($"{currentEnemy.name} has been knocked down! {currentPlayer.name} has won!!");

                currentPlayer.hp = 100;
                currentEnemyIndex++;
                round = 1;
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
        

        public int getValidMove()
        {
            int choice;
            Moveset selectedMove;
            bool isValidChoice;

            while (true){
                
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                isValidChoice = int.TryParse(input, out choice) && choice >= 1 && choice <= 4;
                
                if (isValidChoice)
                {
                    selectedMove = currentPlayer.moves[choice - 1];
                    if(selectedMove.moveCost <= selectedMove.moveTotal)
                    {
                        return choice;
                    }
                    else
                    {
                        
                        System.Console.WriteLine("Unable to choose this move, on cooldown pick another");
                    }
                }
                else{

                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                }
            }
              
        }
        public int PlayerAttack( out bool playerIsBlocking)
        { 

        

            int selectedIndex = getValidMove();
            Moveset selectedMove = currentPlayer.moves[selectedIndex -1];
            playerIsBlocking = selectedMove == currentPlayer.moves[3];
            selectedMove.moveTotal -= selectedMove.moveCost;
            foreach (var move in currentPlayer.moves)
            {
               if(move != selectedMove && move.moveTotal < 5){
                move.moveTotal++;
               } 
            }
            int damage = random.Next(selectedMove.minDamage, selectedMove.maxDamage + 1);

            if (playerIsBlocking)
            {
                System.Console.WriteLine("You blocked.");
            }
            else
            {
                Console.WriteLine($"You used {selectedMove.attackName} and dealt {damage} damage.");

            }

            return damage;
        }

        public int EnemyRandomAttack(Combatant enemy, out bool enemyIsBlocking)
        {

            Moveset currentMove;
            do
            { 
                currentMove = enemy.moves[random.Next(enemy.moves.Count)]; 
                
            } while (currentMove.moveCost > currentMove.moveTotal);

            enemyIsBlocking = currentMove == enemy.moves[3];

            currentMove.moveTotal -= currentMove.moveCost;
            int damage = random.Next(currentMove.minDamage, currentMove.maxDamage + 1);

            foreach (var move in enemy.moves)
            {
                if(move != currentMove && move.moveTotal < 5)
                {
                    move.moveTotal++;
                }

            }
            
            if(enemyIsBlocking)
            {
                Console.WriteLine($"{enemy.name} is blocking!");
            }
            else{
                Console.WriteLine($"{enemy.name} used {currentMove.attackName} and dealt {damage} damage.");

            }
            
            return damage;
        }



    }

}