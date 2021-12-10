namespace Les_0412
{
	class BankAccount
	{
		public enum Type
		{
			Current,
			Saving
		}

		private int index;
		private Type accountType;
		private int balance;
		private string cardHolder;

		static int indexer = 0;

		public int Index { get => index; }
		public Type AccountType { get => accountType; }
		public int Balance { get => balance; }
		public string CardHolder { get => cardHolder; set => cardHolder = value; }

		private BankTransaction[] bankTransactions;
		static private int transIndex = 0;

		public BankTransaction this[int index]
		{
			get
			{
				return bankTransactions[index];
			}
			set
			{
				bankTransactions[index] = value;
			}
		}

		public bool Withdraw(int sum)
		{
			if (sum <= balance)
			{
				balance -= sum;
				bankTransactions[transIndex++] = new BankTransaction(-sum);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool PutInBalance(int sum)
		{
			if (sum > 0)
			{
				balance += sum;
				bankTransactions[transIndex++] = new BankTransaction(sum);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool MakeTransfer(BankAccount accPaymentReceiver, int sum)
		{
			if (Withdraw(sum))
			{
				accPaymentReceiver.PutInBalance(sum);
				return true;
			}
			else
			{
				return false;
			}
		}

		public BankAccount()
		{
			index = indexer++;
			bankTransactions = new BankTransaction[20];
		}

		public BankAccount(int balance)
		{
			index = indexer++;
			this.balance = balance;
			bankTransactions = new BankTransaction[20];
		}

		public BankAccount(Type accountType)
		{
			index = indexer++;
			this.accountType = accountType;
			bankTransactions = new BankTransaction[20];
		}

		public BankAccount(Type accountType, int balance) : this(accountType)
		{
			this.balance = balance;
		}

		public static bool operator ==(BankAccount bankAccount1, BankAccount bankAccount2)
		{
			return bankAccount1.AccountType == bankAccount2.AccountType
				&& bankAccount1.Balance == bankAccount2.Balance;
		}

		public static bool operator !=(BankAccount bankAccount1, BankAccount bankAccount2)
		{
			return !(bankAccount1.AccountType == bankAccount2.AccountType
				&& bankAccount1.Balance == bankAccount2.Balance);
		}

		public override bool Equals(object obj)
		{
			if (obj is BankAccount)
			{
				return this == (obj as BankAccount);
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return $"{Index}. Тип: {AccountType}, баланс: {Balance}";
		}
	}
}
