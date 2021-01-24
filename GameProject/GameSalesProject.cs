using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSalesProject 
    {
        public void Add(GameSalesProject gameSales)
        {
            Console.WriteLine("Games is Added.");

        }

        public void Remove(GameSalesProject gameSales)
        {
            Console.WriteLine("Games is Removed." );
        }

        public void Update(GameSalesProject gameSales)
        {
            Console.WriteLine("Games is Update." );
        }

        void main(string[] args)
        {
            GameSalesProject games1 = new GameSalesProject();
            games1.GamesName = "Gta5";
            games1.Id = 1;
            games1.Type = "Actions";

            GameSalesProject games2 = new GameSalesProject();
            games2.GamesName = "CallOfDuty";
            games2.Id = 2;
            games2.Type = "FirstPersonShooter";

            GameSalesProject games3 = new GameSalesProject();
            games3.GamesName = "Dirt4";
            games3.Id = 3;
            games3.Type = "CarRace";

            
        }

        public string GamesName { get; set; }

        public int Id { get; set; }
        public string Type { get; set; }


    }
    
}
