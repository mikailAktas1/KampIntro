using System;

namespace GameProject
{
    class Program:GameSalesProject
    {
        static void Main(string[] args)
        {
           Members GameMembers1 = new Members();
            GameMembers1.AdiSoyadi = "Mikail Aktas ";
            GameMembers1.TcNo = 1234567890;
            GameMembers1.DogumYili =1987;


            Members GameMembers2 = new Members();
            GameMembers2.AdiSoyadi = "Seda Aktas ";
            GameMembers2.TcNo = 222222222;
            GameMembers2.DogumYili = 1985;

            Members GameMembers3 = new Members();
            GameMembers3.AdiSoyadi = "Gönenç Aktas ";
            GameMembers3.TcNo = 111111111;
            GameMembers3.DogumYili = 2021;

            Members GameMembers4 = new Members();
            GameMembers4.AdiSoyadi = "Mia Aktas ";
            GameMembers4.TcNo = 333333333;
            GameMembers4.DogumYili = 2018;

            Members[] GameMembers = new Members[] {GameMembers1,GameMembers2,GameMembers3,GameMembers4 };
            
            Console.WriteLine("----------------Members Added-------------");
            GameMembers1.Add(GameMembers1);
            GameMembers2.Add(GameMembers2);
            GameMembers3.Add(GameMembers3);
            GameMembers4.Add(GameMembers4);
            Console.WriteLine("----------------Members Removed -------------");
            GameMembers1.Remove(GameMembers1);
            GameMembers2.Remove(GameMembers2);
            GameMembers3.Remove(GameMembers3);
            GameMembers4.Remove(GameMembers4);
            Console.WriteLine("----------------Members Updated-------------");
            GameMembers1.Update(GameMembers1);
            GameMembers2.Update(GameMembers2);
            GameMembers3.Update(GameMembers3);
            GameMembers4.Update(GameMembers4);

            Console.WriteLine("Games is Added." + "games1");
            Console.WriteLine("Games is Removed." + "games2");
            Console.WriteLine("Games is Updated." + "games3");


        }

        
     
    }
   
}
    
