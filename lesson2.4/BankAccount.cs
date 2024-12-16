namespace lesson2._4;

public class BankAccount
{
	private int _accountNumber;

	public int AccounNumber
	{
		get { return _accountNumber; }
        set { _accountNumber = value; }
    }
		
	private double _balance;

	public double Balance
	{
		get { return _balance; }
		set { _balance = value; }
	}
	public void Deposit (double amount)
	{
		_balance += amount;
	}
}	
