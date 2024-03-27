

using System.Security.Cryptography.X509Certificates;
namespace BigLottosTournament
{

    public class EnemyObject
    {

        public string name;
        public int hp;

        public List<Move> moves = new();


    }

    public class Move
    {
        public string name;
        public int damageAmount;
    }

    public class EnemyLists
    {

        public static EnemyObject Martin = new();






        public List<EnemyObject> EnemiesList = new(){
            new(){name = "Martin", hp = 100},
            new(){name = "Bartin", hp = 100},
            new(){name = "Snake", hp = 85},
            new(){name = "Piston", hp = 150},

           
        };

        Random random = new();
        

        
        


    }



}
