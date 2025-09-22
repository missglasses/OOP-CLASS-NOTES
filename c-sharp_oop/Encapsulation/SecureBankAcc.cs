
using System; 
public class SecureBankAccount{
    string accountNumber;
    double balance;
    string pin;
    bool isLocked;
    
    public SecureBankAccount(string accountNumber, double initialBalance, string pin){
        this.accountNumber=accountNumber;
        this.balance=initialBalance;
        this.pin=pin;
        this.isLocked=false;

    }
    
    public string GetAccountNumber(){
        return accountNumber;
    }
    
    public double GetBalance(){
        return balance;
    }
    
    public void Deposit(double amount){
        if(!isLocked&&amount>0){
            balance+=amount;
        }
    }
    
    public string Withdraw(double amount, string enteredPin){
        if(isLocked){
            // Console.WriteLine("Account is locked. Withdrawal not allowed.");
           return "Account is locked. Withdrawal not allowed.";
           
        }
        
        if(enteredPin!=pin){
            // Console.WriteLine("\nResult: Incorrect PIN.");
              return "Incorrect PIN.";
        }
        
        if(amount<=0){
            
        // Console.WriteLine("Invalid amount");
        return "Invalid amount";
        }
        
        if(amount>balance){
           return "Insufficient balance for withdrawal.";
        }
        
        balance-=amount;
        return $"Withdrawal successful. New balance: {balance:F2}";
    }
    
    public void LockAccount(){
        isLocked=true;
    }
    
    public string ToString(){
        return $"{accountNumber} - P{balance:F2} - {isLocked}";
    }

}
