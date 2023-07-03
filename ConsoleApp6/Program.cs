// See https://aka.ms/new-console-template for more information


using System.ComponentModel;

namespace BankCards
{
    public abstract class BankCard
    {
        public string OwnerFullName { get;  set; }
        public string CardNumber { get; set; }
        public int CVV { get; private set; }
        public decimal Balance { get; set; }
        public BankCard(string ownerfullname,string cardnumber,int cvv,decimal balance)
        {
            OwnerFullName = ownerfullname;
            CardNumber = cardnumber;
            CVV = cvv;
            Balance = balance;
        }
        public abstract void Deposit(decimal amount);
        public abstract void WithDraw(decimal amount);
    }
      public class UniBankCard : BankCard
    {
        public UniBankCard(string ownerfullname,string cardnumber,int cvv,decimal balance) : base( ownerfullname, cardnumber, cvv, balance)
        {
            
        }
        public override string ToString()
        {
            return  "UniBankCard Information:" + "OwnerFullName:" +  OwnerFullName + " " + "CardNumber: " + CardNumber + " " + "CVV:" + CVV + " "+ "Balance:" + Balance;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(amount +  "AZN deposited to your UniBankCard");
        }
        public override void WithDraw(decimal amount)
        {
           
            if(amount <= Balance)
            {
                Balance -=   amount - (amount * 0.015m);
                Console.WriteLine($"Withdraw {amount} AZN from your UniBankCard");
            }
            else
            {
                Console.WriteLine("You haven't enough money in your UniBankCard");
            }
                
        }
       
    }
    public class AccessBankCard : BankCard
    {
        public AccessBankCard(string ownerfullname, string cardnumber, int cvv, decimal balance) : base(ownerfullname, cardnumber, cvv, balance)

        {

        }
        public override string ToString()
        {
            return "AcessBankCard Information:" + "OwnerFullName:" + OwnerFullName + " " + "CardNumber: " + CardNumber + " " + "CVV:" + CVV + " "+ "Balance:" + Balance;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount - (amount * 0.003m);
            Console.WriteLine(amount + "AZN deposted to your AccesBankCard");
        }
        public override void WithDraw(decimal amount)
        {
            
            if (amount <= Balance)
            {
                Balance -= amount - (amount * 0.016m);
                Console.WriteLine($"Withdraw {amount} AZN from your AcessBankCard");
            }
            else
            {
                Console.WriteLine("You haven't enough money in your AcessBankCard");
            }
        }
    }
    public class PashaBankCard : BankCard
    {
        public PashaBankCard(string ownerfullname, string cardnumber, int cvv, decimal balance) : base(ownerfullname, cardnumber, cvv, balance)

        {

        }
        public override string ToString()
        {
            return "PashaBankCard Information:" + "OwnerFullName:" + OwnerFullName + " " + "CardNumber: " + CardNumber + " " + "CVV:" + CVV + " " + "Balance:" + Balance;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount - (amount * 0.006m);
            Console.WriteLine(amount  +  "AZN deposited to your PashaBankCard");
        }
        public override void WithDraw(decimal amount)
        {
            
            if (amount<=Balance)
            {
                Balance -= amount - (amount * 0.011m);
                Console.WriteLine($"Withdraw {amount} from your PashaBankCard ");
            }
            else
            {
                Console.WriteLine("You haven't enough money in your PashaBankCard");
            }
        }
    }
    public class LeoBankCard : BankCard
    {
        public LeoBankCard(string ownerfullname, string cardnumber, int cvv, decimal balance) : base(ownerfullname, cardnumber, cvv, balance)
        {
            
        }
        public override string ToString()
        {
            return "LeoBankCard Information:" + "OwnerFullName:" + OwnerFullName + " " + "CardNumber: " + CardNumber + " " + "CVV:" + CVV + " " + "Balance:" + Balance;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(amount +  "AZN deposited to your LeoBankCard");
        }
        public override void WithDraw(decimal amount)
        {
            
            if (amount <= Balance)
            {
                Balance-= amount;
                Console.WriteLine($"WithDraw {amount} from your LeoBankCard");
            }
            else
            {
                Console.WriteLine("You haven't enough money in your LeoBankCard");
            }
        }
    }
    public class Program 
    {
        public static void Main(string[] args)
        {
            UniBankCard uniBankCard = new UniBankCard("Abdullah Manafli", "2356-8904-7812-2789", 202, 900m);
            Console.WriteLine(uniBankCard);
            AccessBankCard accessBankCard = new AccessBankCard("Abdullah Manafli", "4567-9067-1256-5734", 800, 800m);
            Console.WriteLine(accessBankCard);
            PashaBankCard pashaBankCard = new PashaBankCard("Abdullah Manafli", "5678-1256-2378-9012",750,120m);
            Console.WriteLine(pashaBankCard);
            LeoBankCard leoBankCard = new LeoBankCard("Abdullah Manafli", "4098-1256-7890-3489", 230, 1000m);
            Console.WriteLine(leoBankCard);


            uniBankCard.Deposit(200m);
            Console.WriteLine( "My UniBankCard balance after deposited:" + uniBankCard.Balance);
            uniBankCard.WithDraw(300m);
            Console.WriteLine( "My UniBankCard balance after wihtdrawed:" + uniBankCard.Balance);

            pashaBankCard.Deposit(340m);
            Console.WriteLine("My PashaBankCard balance after deposited:" +  pashaBankCard.Balance);
            pashaBankCard.WithDraw(100m);
            Console.WriteLine("My PashaBankCard balance after wihtdrawed:" + pashaBankCard.Balance);

            leoBankCard.Deposit(2000m);
            Console.WriteLine("My LeoBankCard balance after deposited:" + leoBankCard.Balance);
            leoBankCard.WithDraw(400);
            Console.WriteLine("My LeoBankCard balance after withdrawed:" + leoBankCard.Balance);

            accessBankCard.Deposit(200m);
            Console.WriteLine("My AccessBankCard balance after deposited:" + accessBankCard.Balance);
            accessBankCard.WithDraw(400m);
            Console.WriteLine("My AccessBankCard balance after withdrawed:" + accessBankCard.Balance);

        }
}

}
