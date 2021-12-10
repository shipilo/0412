using System;

namespace Les_0412
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount(100);
            bankAccount1.PutInBalance(100);
            Console.WriteLine(bankAccount1[0]);

            BuildingArray buildings = new BuildingArray();
            buildings[0] = new Building();

            Console.ReadLine();
        }
    }
}
