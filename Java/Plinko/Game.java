import java.util.Random;

/**
 * Class contains the game logic to determine the ball path
 * and other tools to convert data
 * @author Xaxas
 */

public class Game{

    private Random rand;

    /**
     * Simple funciton that returns either a 1 or a 2
     * @return int
     */
    
    public int Path()
    {
        rand = new Random();
        int path = rand.nextInt(2) + 1;
        
        return path;
    }

    /**
     * Converts the x coordinate of the current slot the ball is 
     * "hovering" over into a simple number for use in an array
     * @param slotNum - the xCordinate of the slot the ball will
     * drop into
     * @return int
     */
    
    public static int getSlotNum(int slotNum)
    {
  
            if (slotNum == 8) 
                return 0;
            else if (slotNum == 58)
                return 1;
            else if (slotNum == 108)
                return 2;
            else if (slotNum == 158)
                return 3;
            else if (slotNum == 208)
                return 4;
            else if (slotNum == 258)
                return 5;
            else if (slotNum == 308)
                return 6;
            else if (slotNum == 358)
                return 7;
            else if (slotNum == 408)
                return 8;
            else if (slotNum == 458)
                return 9;
           else
             {
                 //error checking the x coordinates
                System.out.println("Wrong numbers");
                return 0;
             }
    }
    
    /**
     * Generates x coordinates for a new ball to start at based on slot
     * location
     * @return int 
     */
    
    public int generateStart(int userChoice)
    {
        rand = new Random();
        int startLocation = rand.nextInt(userChoice - 1) + 1;
        
        if (startLocation == 1)
            return 33;
        else if (startLocation == 2)
            return 83;
        else if (startLocation == 3)
            return 133;
        else if (startLocation == 4)
            return 183;
        else if (startLocation == 5)
            return 233;
        else if (startLocation == 6)
            return 283;
        else if (startLocation == 7)
            return 333;
        else if (startLocation == 8)
            return 383;
        else if (startLocation == 9)
            return 433;
        else
            return 0;
    }   
}
