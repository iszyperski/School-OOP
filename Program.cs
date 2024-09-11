using System;
public class program()
{
    public static int Main()
    {
        Random RNG = new Random();
        int[] board = new int[100];
        for (int i = 0; i < 100; i++)
        {
            board[i] = RNG.Next(-100, 100);
        }
        foreach (var a in board)
        {
            Console.WriteLine(a);
        }
  System.Console.WriteLine("reverse");      
		for (int i = board.Length -1; i >= 0; i--)
        {
            Console.WriteLine(board[i]);
        }
		foreach(var a in board){
			if(a > 0)
			System.Console.WriteLine(a);
		}

		foreach(var a in board){
			if(a < 0)
			System.Console.WriteLine(a);
		}
		System.Console.WriteLine('e');
		foreach(var a in board){
			if(a > 0)
			System.Console.WriteLine(a);
		}

		foreach(var a in board){
			if(a < 0)
			System.Console.WriteLine(a);
		}
			int suma = 0;
		for(int a = 0 ; a < board.Length; a++){
		suma+=board[a];	
		}
		System.Console.WriteLine(suma);
		int avg(int[] beard)
		 return 0;
            }
}