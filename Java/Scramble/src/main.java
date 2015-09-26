/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.awt.FlowLayout;
import java.util.Scanner;
import javax.swing.*;
import java.awt.event.*;


/**
 *
 * @author Xaxas
 */
public class main {
    
   private String name;
   private boolean nameEntered;
   private int numGuesses = 3;
   private String realAnswer;
   private String scrambledWord;

    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
           
        String gui;
        
        Scanner input = new Scanner(System.in);

        System.out.println("Would you like to play in command line? (Y/N)");
        gui = input.nextLine();
        gui = gui.toLowerCase();
        main guiRun = new main();
        
        

        
        if (gui.equals("y"))
            commandLine(input);
        else
             guiRun.guiProgram();
        
        
    }
     static public void commandLine(Scanner input)
    {
        
        boolean streak;
        String round = "y";
        String name;
        String answer;
        String realAnswer;
        String scrambled;
        int guesses = 3;
        Scramble scramble = new Scramble ("scramwords.txt");
        Results result = new Results ("results.txt", 0, 0, 0);
        result.save();
        streak = false;  
        
        
        
        System.out.println("Welcome to the Scrambler!");
        System.out.print("Please enter your name:");
        name = input.nextLine();
        
        
        
        
        System.out.println(name + ", you have " + guesses
                           + " guesses to get the Scramble");
        System.out.println("Good Luck!");
        
  
        
        while (round.equals("y"))
        {             
            
            
         if (streak == false)
         {
         guesses = 3;
         }
        
        realAnswer = scramble.getRealWord();
        scrambled = scramble.getScrambledWord();
        
        if (realAnswer == null)
         {
             System.out.println("There are no more words available!");
             break;
         }
        
        
        while ((guesses != 0) && (realAnswer != null))
        {
       
            System.out.println("Scramble: " + scrambled);
            System.out.print("Your guess: ");
            answer = input.nextLine();   
            answer = answer.toLowerCase();
            
            if (answer.equals(realAnswer))
            {
                System.out.println("Congratulations you won!");
                result.won();
                result.guesses();
                streak = true;
                break;
            }
            else
            {
                guesses -= 1;
                System.out.println("Sorry, " + name + ", that is not correct");
                System.out.println("You have " + guesses + " guess(es) remaining");                
                result.guesses();
            }                             
        }
        
        if (guesses == 0)
        {
            
            result.lost();
            System.out.println("Round over!  Better luck next time " + name);
            System.out.println("The actual word was " + realAnswer);
            
        }
        
         System.out.print("Would you like to play again? (Y/N)");
         round = input.nextLine();
         round = round.toLowerCase();      
        
        }
              
        System.out.println("Thanks for playing " + name);
        System.out.println(result);
        result.save();
        input.close();
    }
     
     
     public void guiProgram()
    {
        
      
        JFrame frame = new JFrame("The Scrambler");
        frame.setLayout(new FlowLayout(FlowLayout.LEFT, 10, 20));
        frame.setSize(400, 400);
        frame.setLocationRelativeTo(null); // Center the frame
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Scramble scramble = new Scramble("scramwords.txt");
        Results result = new Results ("results.txt", 0, 0, 0);
        
        
        JLabel prompt = new JLabel ("Welcome to the scrambler!");
        JLabel guesses = new JLabel ("Enter your last name!");
        JTextField input = new JTextField();
        JButton button = new JButton("Enter");
        JButton startOver = new JButton("Start Over");
        JButton stop = new JButton("Stop");
        
        input.setColumns(15);
         
        frame.add(prompt);
        frame.add(guesses);
        frame.add(input);
        frame.add(button);
        frame.add(startOver);
        frame.add(stop);
        
        stop.setVisible(false);
        startOver.setVisible(false);
   
        
        
        frame.setVisible(true);
        
        
        frame.setVisible(true);frame.setVisible(true);
        
       
        
        button.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {     
               if (nameEntered == false)
               {
                   name = input.getText();
                   prompt.setText(name + ", you have " + numGuesses + " guesses left");
                   realAnswer = scramble.getRealWord();
                   scrambledWord = scramble.getScrambledWord();
                   guesses.setText(scrambledWord);     
                   nameEntered = true;
                   
               }
  
               else if ((nameEntered == true) && (numGuesses != 1))
               {
                   if (realAnswer.equals(input.getText()))
                   {
                       result.won();
                       result.guesses();
                       realAnswer = scramble.getRealWord();
                       scrambledWord = scramble.getScrambledWord();
                       
                       if (realAnswer!= null)
                       {
                        prompt.setText("Correct, here is your next word!");
                        guesses.setText(scrambledWord); 
                       }
                       else
                       {
                       prompt.setText("Ran out of words!");
                       stop.setVisible(true);
                       guesses.setVisible(false);
                       button.setVisible(false);
                       input.setVisible(false);    
                       }
                   }
                   else 
                   {       
                       result.guesses();
                       numGuesses--;
                        prompt.setText("Wrong! Try again " + numGuesses 
                        + " number of guesses left");
                   }  
               }
               else
               {
                   result.lost();
                   prompt.setText("You lost!");
                   guesses.setVisible(false);
                   startOver.setVisible(true);
                   stop.setVisible(true);
                   button.setVisible(false);
                   input.setVisible(false);
               }
             
            }
        });
       
     startOver.addActionListener(new ActionListener() 
     {
          public void actionPerformed(ActionEvent e)
          {
              numGuesses = 3;
              stop.setVisible(false);
              startOver.setVisible(false);
              button.setVisible(true);
              input.setVisible(true);
              guesses.setVisible(true);
             
             prompt.setText(name + ", you have " + numGuesses + " guesses left");
             
             guesses.setText(scrambledWord);
          }
     });
     
     
       stop.addActionListener(new ActionListener() 
     {
          public void actionPerformed(ActionEvent e)
          {
              result.save();
              System.exit(0);
          }
     });
}
}
