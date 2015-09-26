

import java.util.Scanner;

/**
 * Class simulates an ATM machine by taking input from the user
 * and altering the account, running a permanent loop
 * 
 * @author Cameron Tait
 * @version 1.0
 */

public class ATM {
 
/**
 * This method selects an account from the array
 * based on user input
 * @param accountId array of accounts
 */    
    
public void mainMenu(Account[] accountId)
{
    int tempNum = 100;
    Scanner scan = new Scanner(System.in);

    
    while (true)
    {
       System.out.println("Enter an id:");
       
       try
       {
       tempNum = scan.nextInt();
       }
       catch (Exception e)
       {
       System.out.println("Error, make sure to type in an integer 0-9");
       scan.next();
       }
      
       if (tempNum >= 0 && tempNum <= 9)
           subMenu(accountId[tempNum], tempNum, scan);       
    }
}

/**
 * This class offers the user options to modify the selected account
 * they can check the balance, deposit or withdraw from the account
 * or alternatively exit to the main menu
 * @param accountId the account selected from the main menu
 * @param tempNum the user inputed number for the sub menu
 * @param scan the scanner variable to read in data from user
 */
public void subMenu(Account accountId, int tempNum, Scanner scan)
{
    tempNum = 0;
    //Balance stores the amount of the transaction to and from
    //the account
    double balance = 0;
    
    while (tempNum != 4)
    {
        System.out.println("Main Menu");
        System.out.println("1: check balance");
        System.out.println("2: withdraw");
        System.out.println("3: deposit");
        System.out.println("4: exit");
        System.out.println("Enter a choice:");
        
        
        try
        {
        tempNum = scan.nextInt();
        }
        catch(Exception e)
        {
        System.out.println("Error, make sure to type in an integer 1-4");
        scan.next();            
        }
        
        switch (tempNum)
        {
                case 1:
                balance = accountId.getBalance();
                System.out.println("The balance is: " + balance);
                break;
                
                case 3:
                System.out.println("Enter the amount you would like to deposit:");
                
                try
                {
                balance = 0;
                balance = scan.nextDouble();
                }
                catch (Exception e)
                {
                System.out.println("Invalid input");
                scan.next();
                }
                
                accountId.deposit(balance);
                balance = accountId.getBalance();
                System.out.println("Your current balance is " + balance);
                break;
                
                case 2:
                System.out.println("Enter the amount you would like to withdraw:");
                
                try
                {
                balance = 0;    
                balance = scan.nextDouble();
                }
                catch (Exception e)
                {
                System.out.println("Invalid input");
                scan.next();
                }
                
                accountId.withdraw(balance);
                balance = accountId.getBalance();
                
                if (balance < 0)
                {
                System.out.println("Warning your account is overdrawn!");
                }
                
                System.out.println("Your current balance is " + balance);
                break;    
               
                case 4:
                System.out.println("Returning to main menu");
                break;
                    
                default:
                System.out.println("Invalid number!");
                break;                 
        }               
    System.out.println();
    }
}    
}
    
    

