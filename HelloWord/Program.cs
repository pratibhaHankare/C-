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

			Console.WriteLine("Choose the number within 1,2,3");
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
			    Console.ReadLine();




		}
	}
}
