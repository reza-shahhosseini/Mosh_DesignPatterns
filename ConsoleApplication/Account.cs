namespace ConsoleApplication{
    internal class Account{
        public float Balance{get;private set;}

        public void Deposit(float amount){
            if(amount>0) Balance+=amount;
        }

        public void Withdraw(float amount){
            if(amount>0) Balance-=amount;
        }
    }
}