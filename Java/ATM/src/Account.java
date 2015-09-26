


import java.util.Date;

/**
 * This class simulates a bank account with basic information
 * 
 * @author Cameron Tait
 * @version 1.0
 */

public class Account 
{   
    private int id;
    private double balance;
    private double annualInterestRate;
    private Date DateCreated;
    
    /**
     * Default class constructor that sets default 
     * values
     */
    
    public  Account()
    {
     id = 0;
     balance = 0;
     annualInterestRate = 0;
     DateCreated = new Date();
    }
    
    /**
     * Overloaded class constructor that sets id number
     * and balance
     * @param idNo - sets id number
     * @param balNo - sets initial balance value
     */
    
    public Account(int idNo, int balNo)
    {
     id = idNo;
     balance = balNo;
     annualInterestRate = 0;
     DateCreated = new Date();             
    }
    
    /**
     * Basic accessor that returns id number 
     * @return int
     */
    
    public int getId()
    {
     return id;
    }
    
    /**
     * Basic mutator that sets id value of class instance
     * @param x 
     */
    
    public void setId(int x)
    {
     this.id = x;
    }
    
    /**
     * Accessor that returns balance of the account 
     * @return double
     */
    
    public double getBalance()
    {
      return balance;
    }

    /**
     * Mutator that sets balance of the account
     * @param x new balance of account
     */
    
    public void setBalance(double x)
    {
      this.balance = x;
    }
    
    /**
     * accessor that returns the interest rate of the account
     * @return double
     */
    
    public double getInterest()
    {
      return annualInterestRate;
    }
    
    /**
     * mutator that sets interest rate of the account
     * @param x new interest rate
     */
    
     public void setInterest(double x)
    {
      this.annualInterestRate = x;
    }
    
     /**
      * Accessor that retrieves the date of the account 
      * @return Date
      */
     
     public Date getDate()
    {
      return DateCreated;
    }
     
     /**
      * Accessor that calculates the monthly interest rate of the account
      * @return double
      */
     
     public double getMonthlyInterestRate()
    {
      return (this.annualInterestRate / 12);
    }
    
     /**
     * Accessor that calculates the monthlyInterest of the account
     * @return double
     */
     
     public double getMonthlyInterest()
    {
      return (((this.annualInterestRate / 100) / 12) * balance );
    }
     
     /**
      * Withdraws from the account balance
      * @param x amount to withdraw
      */
     
     public void withdraw(double x)
    {
      balance = balance - x;
    }
     
     /**
      * Deposits into the account's balance
      * @param x amount to deposit
      */
     
     public void deposit(double x)
    {
      balance = balance + x;
    }
     
    
}

