
namespace Bank_Account_Problem{

public class ATM {
	private int hundred;
	private int fifty;
	private int twenty;
	private int ten;
	private int five;
	private int one;
	private int sum;

        public int Hundred { get => hundred; set => hundred = value; }

        public ATM() {
		hundred = 10;
		fifty = 10;
		twenty = 10;
		ten = 10;
		five = 10;
		one = 10;
		sum = 1860;
	}

	public ATM(int xhundred, int xfifty, int xtwenty, int xten, int xfive, int xone) {
		hundred = xhundred;
		fifty = xfifty;
		ten = xten;
		five = xfive;
		one = xone;

	}

	public string restock() {
		hundred = 10;
		fifty = 10;
		twenty = 10;
		ten = 10;
		five = 10;
		one = 10;
		sum = 1860;
		string reply = "The balance is 1860";
		return reply;
	}

	public string Withdraw(int amount) {
		if (amount <= sum) {
			sum -= amount;
			int amount2 = 0;
			int yhundred = (int) (amount / 100);
			if ((amount / 100) > 10) {
				yhundred = 10;
				amount2 = amount - 1000;
				int yfifty = (int) (amount2 / 50);
				amount2 = amount2 % 50;
				int ytwenty = (int) (amount2 / 20);
				amount2 = amount2 % 20;
				int yten = (int) (amount2 / 10);
				amount2 = amount2 % 10;
				int yfive = (int) (amount2 / 5);
				amount2 = amount2 % 5;
				int yone = (int) (amount2 / 1);
				hundred -= yhundred;
				fifty -= yfifty;
				twenty -= ytwenty;
				ten -= yten;
				five -= yfive;
				one -= yone;
				string response = "Success: Dispensed " + '\n' + "$100 - " + hundred + '\n' + "$50 - " + fifty + '\n'
						+ "$20 - " + twenty + '\n' + "$10 - " + ten + '\n' + "$5 - " + five + '\n' + "$1 - " + one;
			return response;
			}
			
			else {

				amount2 = amount % 100;
				int yfifty = (int) (amount2 / 50);
				amount2 = amount2 % 50;
				int ytwenty = (int) (amount2 / 20);
				amount2 = amount2 % 20;
				int yten = (int) (amount2 / 10);
				amount2 = amount2 % 10;
				int yfive = (int) (amount2 / 5);
				amount2 = amount2 % 5;
				int yone = (int) (amount2 / 1);
				hundred -= yhundred;
				fifty -= yfifty;
				twenty -= ytwenty;
				ten -= yten;
				five -= yfive;
				one -= yone;
				string response = "Success: Dispensed " + '\n' + "$100 - " + hundred + '\n' + "$50 - " + fifty + '\n'
						+ "$20 - " + twenty + '\n' + "$10 - " + ten + '\n' + "$5 - " + five + '\n' + "$1 - " + one;

				return response;
			
		} 
		} else {
			string xresponse = "Insufficient Funds";
			return xresponse;
		}
		}
	

	public string Denominations(int denomination) {

		if (denomination == 100) {
			string response = "$100 - " + hundred;
			return response;
		}
		if (denomination == 50) {
			string response = "$50 - " + fifty;
			return response;
		}
		if (denomination == 20) {
			string response = "$20 - " + twenty;
			return response;
		}
		if (denomination == 10) {
			string response = "$10 - " + ten;
			return response;
		}
		if (denomination == 5) {
			string response = "$5 - " + five;
			return response;
		}
		if (denomination == 1) {
			string response = "$1 - " + one;
			return response;
		} else {
			string response = "Invalid denomination";
			return response;
		}
	}
}

}
