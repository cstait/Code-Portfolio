/**
 * Homework 3: ATM
 * Course: CIS 357
 * Due date: 2-23-2015
 * Name: Cameron Tait
 * Instructor Il-Hyung Cho
 * Program description:
 * Program simulates an ATM machine by accessing accounts and enabling
 * users to deposit and withdraw money
 */

/**
 * @author Cameron Tait
 * @version 1.0
 * 
 * This class is the main driver of the program
 * it initializes an array of account classes
 * and then hands the data off to the ATM class
 * which emulates the function of an ATM
 */

public class CSTAIT_HW3 {
    
    /**
     * Main driver function
     * 
     * @param args the command line arguments
     * @returns void
     */
    
    public static void main(String[] args) {
         
    ATM mainATM = new ATM();  
    Account[] accountId = new Account[10];
    
    //sets each account in the array to have 0-9 id
    //and 100 inital balance
    
    for (int i = 0; i < 10; i++)
    {
        accountId[i] = new Account(i, 100);
    }
    
    mainATM.mainMenu(accountId);
    
    }    
}
