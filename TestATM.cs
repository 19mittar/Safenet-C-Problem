using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace Bank_Account_Problem
{
    
	class TestATM {

	static void Main(string[] args) {
		var machine = new ATM();
		
		int finish = 0;
		while (finish == 0) {

			Console.WriteLine("R - Restocks the cash machine to the original pre-stock levels");
			Console.WriteLine("W <dollar amount> - Withdraws that amount from the cash machine");
			Console.WriteLine(
					"I <denominations> - Displays the number of bills in that denomination present in the cash machine");
			Console.WriteLine("Q - Quits the application");

			string command1 = Console.ReadLine();
			String []command=command1.Split(" ");
			if (command[0].Equals("R")) {
				Console.WriteLine(machine.restock());
			}


             else if (command[0].Equals("W")){
                    
				     if (command[1].Contains("$")) {
                          int number = Int32.Parse(command[1].Substring(1));
					      Console.WriteLine(machine.Withdraw((number)));

			        }  else {
					    int number2 = Int32.Parse(command[1]);
					    Console.WriteLine(machine.Withdraw(number2));

				}

			} else if (command[0].Equals("I")){
				
				int rn = 0;
				foreach (string x in command) {
					if (x.Contains("$")) {
						rn = Int32.Parse(x.Substring(1));
						Console.WriteLine(machine.Denominations(rn));
					}

				}
			} else if (command.Equals("Q")) {
				finish = 1;
			}
			

	else {
				Console.WriteLine("Invalid Command");
			}

		}

	}
}
}
