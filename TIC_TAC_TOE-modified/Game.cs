using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE
{
    
    public class Game
    {
        Conditions conditions = new Conditions();

        public static  string X { get; } = "X";
        public static string O { get; } = "O";

        public List<string> squares = new List<string>() { " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };



        //Player O choosing square !
        public void chooseSquare_O(List<string> square, int number)
        {
            
            
              number=  conditions.GetValidNumber(number);
            



            while (Conditions.SquareIsOccupied(square, number))
            {
                Console.Write("Square is occupied, try another! ");
                string answer = Console.ReadLine();
                while (!int.TryParse(answer, out number))
                {
                    Console.Write("Please use numbers: ");
                    answer = Console.ReadLine();
                }
                
                    number = Convert.ToInt32(answer);
                    number = conditions.GetValidNumber(number);
                
                Console.WriteLine();
            }
           
            
            
            
            if (!Conditions.SquareIsOccupied(square, number))
            {

                square[number] = O;
                GetBoard();


                if (Conditions.HasWon(square, "X"))
                {
                    Console.WriteLine("X won!");

                }

                if (Conditions.HasWon(square, "O"))
                {
                    Console.WriteLine("O won!");


                }
                if (Conditions.Draw(square))
                {
                    Console.WriteLine("It's a draw!");

                }

            }



        }

        //Player X Choosing square!
        public void chooseSquare_X(List<string> square, int number)
        {

            number=conditions.GetValidNumber(number);




            while (Conditions.SquareIsOccupied(square, number))
            {
                Console.Write("Square is occupied, try another! ");
                string answer = Console.ReadLine();
                while (!int.TryParse(answer, out number))
                {
                    Console.Write("Please use numbers: ");
                    answer = Console.ReadLine();
                }
                
                    number = Convert.ToInt32(answer);
                   number= conditions.GetValidNumber(number);
                
                Console.WriteLine();
            }
           

            
            
            
            
            if (!Conditions.SquareIsOccupied(square, number))
            {

                square[number] = X;
                GetBoard();



                if (Conditions.HasWon(square, "X"))
                {
                    Console.WriteLine("X won!");
                }

                if (Conditions.HasWon(square, "O"))
                {
                    Console.WriteLine("O won!");
                }
                
                if (Conditions.Draw(square))
                {
                    Console.WriteLine("It's a draw!");
                }

            }



        }


        public void GetBoard()
        {
            Console.WriteLine($" {squares[1]}  | {squares[2]}  | {squares[3]} ");
            Console.WriteLine(" ---+----+---");
            Console.WriteLine($" {squares[4]}  | {squares[5]}  | {squares[6]} ");
            Console.WriteLine(" ---+----+---");
            Console.WriteLine($" {squares[7]}  | {squares[8]}  | {squares[9]} ");
        }


    }
}
