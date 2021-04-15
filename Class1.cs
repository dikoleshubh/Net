using System;
using System.Collections.Generic;
using System.Text;

namespace NewWorksop
{
        


        class GamePlay
        {
        const int STILL = 0;
        const int LADDER = 1;
        const int SNAKE = 2;
        static Boolean Turn = true;

        //Actual Execution
        /// <summary>
        /// 
        /// </summary>
        static public void Execution()
        {
            int Player_1 = 0, Player_2 = 0, DiceRolled = 0;

            while (Player_1 < 100 && Player_2 < 100)
            {
                DiceRolled++;
                Console.WriteLine("No. Of times Dice Rolled" + DiceRolled);
                if(Turn)
                {
                    Player_1= PlayerGamePlay(Player_1, "Player-1");
                }
                else
                {
                    Player_2 = PlayerGamePlay(Player_2, "Player-1");
                }
                Turn = !Turn;
            }
            if (Player_1 == 100)

            {
                Console.WriteLine ("Winner Is Player 1");

            }
                else 
            {
                Console.WriteLine("Winner Is Player 2");
            }
        }
        
        /// <summary>
        /// 
        /// Player Gameplay
                
        /// <param name="Initialposition"></param>
        /// <param name="PlayerName"></param>
        /// <returns></returns>

         static public int PlayerGamePlay(int Initialposition , string PlayerName)
            {
           
            int InitialPosition = 0;
            // Random Funtion Generation
            Console.WriteLine("Starting Position" + InitialPosition);

                Random random = new Random();
                int Player = random.Next(0, 3);
                int diceNumber = random.Next(1, 7);
                Console.WriteLine("Number on the Dice  " + diceNumber);


            PlayerOption(Player, diceNumber, InitialPosition);
            return Initialposition;
            }
        
        /// <summary>
        /// PlAYER CASES
        /// </summary>
        /// <param name="Player"></param>
        /// <param name="diceNumber"></param>
        /// <param name="Initialposition"></param>
        static  void PlayerOption(int Player, int diceNumber, int Initialposition)
        {

            switch (Player)
            {
                case STILL:
                    Console.WriteLine("Halt to your Position " + Initialposition);
                    break;

                case LADDER:
                    
                    Initialposition = Initialposition + diceNumber;
                    if( Initialposition > 100)
                    {
                        Initialposition = Initialposition - diceNumber;
                    }
                    else
                    {
                        Console.WriteLine("You have got a Ladder " + Initialposition);
                    }
                    
                    break;

                case SNAKE:
                    
                    Initialposition = Initialposition - diceNumber;
                    if (Initialposition < 0)
                    {
                        Initialposition = Initialposition + diceNumber;
                    }
                    else
                    {
                        Console.WriteLine("You have got a Snake " + Initialposition);
                    }
                    break;

            }
            

        }

        }
    
}
