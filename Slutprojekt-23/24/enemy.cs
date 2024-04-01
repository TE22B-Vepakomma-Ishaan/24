

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
        public string attackName;
        public int damageAmount;
    }

    public class EnemyLists
    {

        public List<EnemyObject> EnemiesList = new(){
            new(){name = "Martin", hp = 100, 
            moves = new(){
                new(){attackName = "punch", damageAmount = 20},
                new(){attackName = "kick", damageAmount = 30},
                new(){attackName = "A brother's love", damageAmount = 35},
            }},

            new(){name = "Bartin", hp = 100,
            moves = new(){
                new(){attackName = "punch", damageAmount = 20},
                new(){attackName = "kick", damageAmount = 30},
                new(){attackName = "A brother's love", damageAmount = 35},
            }},

            new(){name = "Snake", hp = 85,
            moves = new(){
                new(){attackName = "punch", damageAmount = 15},
                new(){attackName = "kick", damageAmount = 40},
                new(){attackName = "jab", damageAmount = 30},
            }},

            new(){name = "Piston", hp = 150,            
            moves = new(){
                new(){attackName = "punch", damageAmount = 30},
                new(){attackName = "kick", damageAmount = 15},
                new(){attackName = "smash", damageAmount = 50},
            }},

        };



    }



}
