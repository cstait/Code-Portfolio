/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package hw2.cstait;
import java.io.PrintWriter;
import java.io.IOException;
import java.util.Arrays;
/**
 *
 * @author Xaxas
 */





public class HW2CSTAIT {
    
    
   public static int totalFullHouse = 0;
   public static int totalHighCard = 0;
   public static int totalTwoPair = 0;
   public static int totalFlush = 0;
   public static int totalStraight = 0;
   public static int totalTriple = 0;
   public static int totalFourCard = 0;
   public static int totalPair = 0;
   public static int numC, numD, numH, numS = 0;
   public static boolean rankFound = false;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) 
    {
    int[] deck = new int[52];
    String[] suits = {"S", "H", "D", "C"};
    String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
      "10", "J", "Q", "K"};
    int[] hand = new int[5];
    
    try
    {
    PrintWriter pw = new PrintWriter("hw2output.txt");

        
    // Initialize cards
    for (int i = 0; i < deck.length; i++)
      deck[i] = i;
    
    // Shuffle the cards
    for (int j = 0; j < 100; j++)
    {
        
    for (int i = 0; i < deck.length; i++) 
    {
      // Generate an index randomly
      int index = (int)(Math.random() * deck.length);
      int temp = deck[i];
      deck[i] = deck[index]; 
      deck[index] = temp;
    }

    // Display the first five cards
    
    
    
    for (int i = 0; i < 5; i++) 
    {
      String suit = suits[deck[i] / 13];
      String rank = ranks[deck[i] % 13];
      checkSuit(suit);
      hand[i] = (deck[i] % 13);
      pw.print(rank + "" + suit + " ");
      
    }
    Arrays.sort(hand);
    checkFour(pw, hand, ranks);
    checkFullHouse(pw, hand);
    checkFlush(pw, deck);
    checkStraight(pw, hand);
    checkTriple(pw, hand);
    checkTwoPair(pw, hand);
    checkPair(pw, hand);
    highCard(pw, hand);
    
    
    resetCounters();
    pw.println();
    
    }
    printTotals(pw);
    
 
    pw.close();
    }
    catch (IOException e) {}
}
    
    
    
    
    
    
    
    public static void printTotals(PrintWriter pw)
    {
    pw.println();
    pw.println();
    pw.println("High Card:" + " " + totalHighCard);
    pw.println("Pair:" + " " + totalPair);
    pw.println("Two Pair:" + " " + totalTwoPair);
    pw.println("Triple:" + " " + totalTriple);
    pw.println("Straight:" + " " + totalStraight);
    pw.println("Flush:" + " " + totalFlush);
    pw.println("Full House:" + " " + totalFullHouse);
    pw.println("Four Cards:" + " " + totalFourCard);
    }
    
    public static void checkSuit(String suit)
    {
    if (suit.equals("S"))
        numS += 1;
    else if (suit.equals("H"))
        numH += 1;
    else if (suit.equals("C"))
        numC += 1;
    else
        numD += 1;
    }
    
    public static void checkFour(PrintWriter pw, int[] hand, String[] ranks)
    {
        if (numH >= 1 && numS >=1 && numC >=1 && numD >= 1)
        {
        int counterFour = 0;
        int tempRank = 0;
        
        
        
     
        for (int i = 0; i < 4; i++)
        {
            if ((hand[i] == hand[i + 1]))
                counterFour +=1;
            if (counterFour == 2)
                tempRank = hand[i];
        }
        if (counterFour == 3)
        {
            pw.print("- Four Cards of " + ranks[tempRank] + "s!");
            totalFourCard += 1;
            rankFound = true;
        }
          
        }
      
        
               
    }
    
    public static void checkFullHouse(PrintWriter pw, int[] hand)
    {
    if (rankFound == false)
    {
   
        int pair = 0;
     
         for (int i = 0; i < 4; i++)
        {
         if (hand[i] == hand[i + 1])
         {
             pair += 1;
         }
        }
         if (pair == 3)
         {
             pw.print("- A Full house!");
             totalFullHouse += 1;
             rankFound = true;
         }
    }
    }
    
    
      public static void checkFlush(PrintWriter pw, int[] deck)
      {
          if (rankFound == false)
          {
              String[] suits = {"Spades", "Hearts", "Diamonds", "Clubs"};
              String suit = suits[deck[0] / 13];
              
              if (numC == 5 || numD == 5 || numH == 5 || numS == 5)
              {
                  pw.print("- A Flush of " + suit +"!");
                  totalFlush += 1;
                  rankFound = true;
              }
          }
      }        
    
       public static void checkStraight(PrintWriter pw, int[] hand)
       {
           if (rankFound == false)
           {
               int straight = 0;
               String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
      "10", "J", "Q", "K"};
               
               
               for (int i = 0; i < 4; i++)
               {
                   if ((hand[i] + 1 == hand[i +1]) || (hand[i] == 12 && hand[i + 1] == 0))
                       straight += 1;
                           
                }
               
               if (straight == 4)
               {
                   pw.print("- A straight of " + ranks[hand[0]] + " " + ranks[hand[1]] + " "
                           + ranks[hand[2]] + " " + ranks[hand[3]] + " " + ranks[hand[4]]);
                   totalStraight += 1;
                   rankFound = true;
                   
               }
               
               
           
           }
       }
       
       
       public static void checkTriple(PrintWriter pw, int[] hand)
       {
           if (rankFound == false)
           {
               int pairThree = 0;
               int pairTemp = 0;
               String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
      "10", "J", "Q", "K"};
               
               for (int i = 0; i < 4; i++)
               {
                   if ((hand[i] == hand[i + 1]) && pairThree == 0)
                   {
                       pairThree += 1;
                       pairTemp = hand[i];
                   }
                   else if ((hand[i] == hand[i + 1]) && (hand[i] == pairTemp))
                   {
                       pairThree +=1;
                   }
               }
               
              if (pairThree == 2)
              {
                  pw.print("- A triple " + ranks[pairTemp]);
                  totalTriple +=1;
                  rankFound = true;
              }
           }
       
       }
       
       public static void checkTwoPair(PrintWriter pw, int[] hand)
       {
           if (rankFound == false)
           {
               int twoPair = 0;
               int pairTemp = 0;
               int pairTemp2 = 0;
               String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
      "10", "J", "Q", "K"};
               
                 for (int i = 0; i < 4; i++)
                 {
                     if (twoPair == 0)
                     {
                         if (hand[i] == hand[i + 1])
                         {
                             twoPair += 1;
                             pairTemp = hand[i];   
                         }
                     }
                     else if (twoPair == 1)
                     {
                         if ((hand[i] == hand[i + 1]) && (hand[i] != pairTemp))
                         {
                             twoPair += 1;
                             pairTemp2 = hand[i];
                             
                         }
                     }
                 }
                 
                 if (twoPair == 2)
                 {
                     pw.print(" - Two pair found of " + ranks[pairTemp] + "s and " + ranks[pairTemp2] + "s");
                     totalTwoPair +=1;
                     rankFound = true;
                     
                 }
           }
               
       }
       
       
       
       
       
      
         public static void checkPair(PrintWriter pw, int[] hand)
         {
              if (rankFound == false)
           {
               boolean pair = false;
               int pairTemp = 0;
               String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
      "10", "J", "Q", "K"};
               
               for (int i = 0; i < 4; i++)
               {
                   if (hand[i] == hand[i + 1])
                   {
                       pair = true;
                       pairTemp = hand[i];
                       break;
                   }
               }
  
               
              if (pair == true)
              {
                  pw.print("- A pair of " + ranks[pairTemp] + "s");
                  totalPair +=1;
                  rankFound = true;
              }
           }
       
         }
         
          public static void highCard(PrintWriter pw, int[] hand)
          {
              int max = 0;
              String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9",
      "10", "J", "Q", "K"};
              
              if (rankFound == false)
              {
                  for (int i = 0; i < 5; i++)
                  {
                      if (hand[i] == 0)
                      {
                          max = 0;
                          break;
                      }
                      else 
                      {
                          if (hand[i] > max)
                              max = hand[i];
                      }
                  }
                  pw.print("- the high card is " + ranks[max] );
                  totalHighCard += 1;
                  rankFound = true;
              }
          }
         
      
    
    public static void resetCounters()
    {
        numC = 0; 
        numD = 0; 
        numH = 0;
        numS = 0;
        rankFound = false;
    }
    }
    
    


