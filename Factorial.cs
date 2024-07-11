using System;

class Factorial{
	public static void Main(String [] args){
		int myNumber, result = 1, i;
		Console.WriteLine("Enter a number");
		myNumber = Convert.ToInt32(Console.ReadLine());
		for (i = 1; i <=myNumber ; i++){
			result = result * i;
		}
		Console.WriteLine("The factorial of "+myNumber+" is "+result);
	}
}