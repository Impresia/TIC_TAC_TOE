
using System;
using TIC_TAC_TOE;



Game newGame = new Game();
Console.WriteLine($" {1}  | {2}  | {3} ");
Console.WriteLine(" ---+----+---");
Console.WriteLine($" {4}  | {5}  | {6} ");
Console.WriteLine(" ---+----+---");
Console.WriteLine($" {7}  | {8}  | {9} ");

Console.WriteLine();

Console.WriteLine("(choose numbers between 1-9 !)");




while (true)
{
    Console.Write($"It's {Game.O}-s turn to play which square do you want to play? ");
    string answer = Console.ReadLine();
    int result;
    
    //Only converting to int if response is number!
    while(!int.TryParse(answer,out result))
    {
        Console.Write("Please use numbers: ");
        answer = Console.ReadLine();
    }
    
        result = Convert.ToInt32(answer);
         Console.WriteLine();





    newGame.chooseSquare_O(newGame.squares, result);
    if (Conditions.HasWon(newGame.squares, Game.O) || Conditions.Draw(newGame.squares))
        break;





    Console.Write($"It's {Game.X}-s turn to play which square do you want to play? ");
    answer = Console.ReadLine();

    //Only converting to int if response is number!
    while (!int.TryParse(answer, out result))
    {
        Console.Write("Please use numbers: ");
        answer = Console.ReadLine();
    }
        result = Convert.ToInt32(answer);

    Console.WriteLine();






    newGame.chooseSquare_X(newGame.squares, result);
    if (Conditions.HasWon(newGame.squares, Game.X) || Conditions.Draw(newGame.squares))
        break;



}