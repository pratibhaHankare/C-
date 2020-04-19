using System;

namespace HelloWord
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Console.WriteLine("Hello World!");
			Console.ReadLine();

			int x= 5;
			int y;
			y = x + 3;
			Console.WriteLine("x+y=" + y);
			Console.ReadLine();*/

			/* Console.WriteLine("What is your name?");
			Console.Write("Type your first name:");
			String firstName;
			firstName=Console.ReadLine();

			Console.Write("Type your last name:");
			String lastName;
			lastName = Console.ReadLine();

			Console.WriteLine("The complete name is"+ firstName+" "+ lastName);
			Console.ReadLine();*/

			/*Console.WriteLine("Choose the number within 1,2,3");
			String userValue = Console.ReadLine();
			String  message = " ";
			if (userValue == "1")
				message = "Dog";
			else if (userValue == "2")
				message = "Cat";
			else if (userValue == "3")
				message = "Kitten";
			else
				message = "Nothing";

				Console.WriteLine("you chose the value {0} and so you won {1}.", userValue,message);
			    Console.ReadLine();*/

			/** conditional operator works same as other lang**/

			/** Array declairation is different in C#**/

			/*int[] numbers = new int[5]; // when size is declared before hand
			numbers[0] = 1;
			numbers[1] = 2;
			numbers[2] = 3;
			numbers[3] = 4;
			numbers[4] = 5;
			Console.WriteLine(numbers[4]);
			Console.ReadLine();

			int[] numberArryTwo = new int[] { 1, 3, 4, 5, 6, 7, 8 };
			Console.WriteLine(numberArryTwo[4]);
			Console.ReadLine();*/

			/*String[] names = new string[] { "hi", "this", "is", "string", "array" };
			Console.WriteLine(names[2]);
			Console.ReadLine();*/

			// Reversing the string 
			String zig = "Hello,Bob.How are you?";
			Console.WriteLine(zig);
			char[] charArrayOfZig = zig.ToCharArray();
			Array.Reverse(charArrayOfZig);
			foreach ( char item in charArrayOfZig)
			{
				Console.Write(item);
			}
			Console.ReadLine();






































		}
	}
}
