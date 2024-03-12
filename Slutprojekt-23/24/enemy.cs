class EnemyStats{

    string name;
    int hp;

    static public void EnemyStatsList(string[] args)
    {
        EnemyStats enemyOne = new();
        enemyOne.name = "Martin";
        enemyOne.hp = 100;
        
        EnemyStats enemyTwo = new();
        enemyTwo.name = "Bartin";
        enemyTwo.hp = 100;

        EnemyStats enemyThree = new();
        enemyThree.name = "Snake";
        enemyThree.hp = 75;

        EnemyStats enemyFour = new();
        enemyFour.name = "Piston";
        enemyFour.hp = 150;

    }
}