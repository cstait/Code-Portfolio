/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.io.File;
import java.util.Scanner;
import java.util.ArrayList;
import java.util.Random;


/**
 *
 * @author Xaxas
 */
public class Scramble {
    
    private boolean scrambledFlag = true;
    private ArrayList<String> wordArray = new ArrayList<>();
    private Random generate = new Random();
    private int randomInt;
    private String currentWord;
    private String currentsWord;

    
    
    Scramble (String fileName)
    {
        
    File inputFile = new File(fileName); 
    
    try
     {
     Scanner input = new Scanner(inputFile);        
      
    while (input.hasNextLine())
     {
         wordArray.add(input.next());
     }
    
     input.close();
     }
     catch(Exception e)
     {
      e.printStackTrace();
     }
    }
    
    
    public String getRealWord()
    {
        if ((wordArray.isEmpty() == false) && (scrambledFlag == true))
        {
            scrambledFlag = false;
            randomInt = generate.nextInt(wordArray.size());
            currentWord = wordArray.get(randomInt);
            wordArray.remove(randomInt);
            return currentWord;
            
        }
        else if ((wordArray.isEmpty() == false) && (scrambledFlag == false))
        {
        
            return currentWord;
        }
        else if (wordArray.isEmpty())
        {
            currentWord = null;
            return null;
        }
        else
        {
            return null;
        }
        
    }
    
    public String getScrambledWord()
    {
       if ((currentWord != null) && (scrambledFlag == false))
       {
           scrambledFlag = true;
           
           char sWord[] = currentWord.toCharArray();
           
           
            for( int i=0 ; i<sWord.length-1 ; i++ )
             {
              int j = generate.nextInt(sWord.length-1);
                 // Swap letters
                 char temp = sWord[i];
                 sWord[i] = sWord[j];  
                 sWord[j] = temp;
               }
           
            currentsWord = new String(sWord);
           return currentsWord;
       }
       else if ((currentWord != null) && (scrambledFlag == true))
       {
            return currentsWord;
       }
       else
       {
           return null;
       }
       
       
       
       
    }
    
    
    
    
}
