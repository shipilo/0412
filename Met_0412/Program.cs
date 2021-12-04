using System;

namespace Met_0412
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.1");
            BankAccount a = new BankAccount(BankAccount.Type.Current, 1000);
            BankAccount b = new BankAccount(BankAccount.Type.Saving, 1000);
            Console.WriteLine(a != b);
            Console.WriteLine(a.Equals(b));

            Console.WriteLine("Упражнение 12.2");
            Rational r1 = new Rational(4, 8);
            Console.WriteLine(r1.Equals(0.5));
            Console.WriteLine(++r1);
            Console.WriteLine($"({17.0/21} < {15.0/19})? {new Rational(17, 21) < new Rational(15, 19)}");
            Console.WriteLine((Rational)0.125);
            Console.WriteLine(r1 % new Rational(5, 4));

            Console.WriteLine("Домашнее задание 12.1");
            Complex c1 = new Complex(20, -7);
            Complex c2 = new Complex(1, 1);
            Console.WriteLine(c1 * c2);

            Console.ReadKey();
        }
    }
}
