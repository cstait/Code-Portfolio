import java.awt.Color;
import javax.swing.*;
import java.awt.Graphics;

/**
 * Class mostly animates and draws the Gui, some ball logic is handled
 by the Gui
 * @author Cameron Tait
 * @version 1.0
 */

public class Gui extends JPanel
{
    /**
     * newBall - flag that determines if a new ball is in play or not
     * gameUI - game class used for generating game logic
     * slotArray - array that determines how many balls
     * are in which slots
     * curPosX - the current ball's x location
     * curPosY - the current ball's y location
     */
    
    private boolean newBall = true;
    private Game gameUI = new Game();
    private int[] slotArray = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    private int curPosX = (gameUI.generateStart(5));
    private int curPosY = 25;
    private int userChoice;
    
    /**
     * Method that changes the balls location depending on factors
     * uses the game class to determine path
     */
    public void updateBallLocation()
    {
        //checks to see if there is a new ball at play
        //if there is it sets the current position to aunit below
        if (newBall)
        {
            newBall = false;
            curPosY += 25;
        }
        //if the current ball is just above the slot
        //it converts it into the proper slot number
        //by using game and then increments that slot number
        //in the array
        else if (curPosY == 225)
        {
            //signifies the next ball is a new ball so it doesn't shift
            //x coordinates
            newBall = true;
            //getSlotNum converts the X coordinates into a 0-7 slot integer
            int slotNum = Game.getSlotNum(curPosX);
            slotArray[slotNum] += 1;
            //resets ball position to top
            curPosY = 25;
            curPosX = (gameUI.generateStart(userChoice));
        }
        //checks to see if the ball is near the border of the frame
        //then either slides it down and right or down and left
        else if ((curPosX == 8) || (curPosX == (((userChoice - 1) * 50) + 8)))
        {
            if ((curPosX == 8))
                curPosX += 25;
            else
                curPosX -= 25;
           
            curPosY += 25;
        }
        else
        //standard situation where the ball shifts left and down or right
        //and down based on if the random number generator returns 1 or
        //2
        {
        if (gameUI.Path() == 1)
            curPosX -= 25;
        else
            curPosX += 25;
        
        curPosY += 25;
        }         
    }
    
    
    
     /**
      * Standard paintComponent override in order to use graphics functions
      * draws the pegs, slots, current ball and previous balls
      * @param g - the graphics object to perform functions with
      */
     protected void paintComponent(Graphics g) 
  {	
       
    super.paintComponent(g);
    int x = 0;
    int y = 0;
    
    //provides a white backdrop
    g.clearRect(0, 0, userChoice * 50, 440);
    
    //this draws the even rows of pegs
    for (int j = 0; j < 4; j++)
    {
        y += 50;
        x = 12;
        
        for (int i = 0; i < userChoice; i++)
        {
             g.drawOval(x, y, 7, 7);
             x+= 50;
        }
    }
    //sets the spacing between peg rows
    y = 25;
    //Draw the odd row of pegs
    for (int j = 0; j < 4; j++)
    {
        y += 50;
        x = 37;
    
        for (int i = 0; i < (userChoice - 1); i++)
        {
             g.drawOval(x, y, 7, 7);
             x+= 50;
        }      
  }
    
    //sets the location and padding of the slot borders
    x = 36;
    y = 250;
    //draws the slot borders
    for (int i = 0; i < (userChoice - 1); i++)
    {
        g.setColor(Color.red);
        g.fillRect(x, y, 10, 150);
       
        x += 50;
    }

    //draws the current ball
    g.setColor(Color.BLUE);
    g.fillOval(curPosX, curPosY, 15, 15);
    
    
    //Navigates through the array to find
    //the number of balls and what slot they are in
    //to properly animate them on screen
    
    for (int i = 0; i < userChoice; i++)
    {
        int numBalls = slotArray[i];
        if (numBalls != 0)
        {
            for (int j = 0; j < numBalls; j++)
            {
                g.fillOval(((i * 50) + 8), (385 - (j * 15)), 15, 15);
            }
        }
    }
    g.dispose();   
} 
     /**
      * sets the number of pegs used in the gui and other factors
      * that revolve around it
      * @param choice int - the user's choice for number of pegs
      */
     public void setChoice(int choice)
     {
         userChoice = choice;
     }
}
