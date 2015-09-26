/**
 * Homework 05: Plinko Machine
 * COURSE: CIS357
 * Due Date: 4/1/2015
 * Completed Date: 3/22/2015
 * Name: Cameron Tait
 * Instructor: Il-Hyung Cho
 * Program Description: Simulates a plinko machine by dropping a users 
 * choice of balls (times 2) into the machine and randomly landing in 
 * each slot
 */

import javax.swing.*;
import java.awt.event.*;
import java.util.Scanner;

/**
 * CSTaitHW5 description
 * the main class hosts the frame for which the panel is drawn on
 * it activates the timer and manages how long it runs for
 * @author Cameron Tait
 * @version 1.0
 */

    public class CSTaitHW5 extends JFrame
    {
    /**
     * canvas - the panel onto which the program is drawn upon
     * timerCount - a counter that keeps track of how many times the timer has
     * been fired
     * timer - a timer that updates the Gui which includes the ball and slot
     * statuses
     * userChoice - the user's choice of ball numbers
     */
    
    private Gui canvas = new Gui();
    private int timerCount = 0;
    private Timer timer = new Timer(500, new TimerListener());
    private int userChoice;
    
    /**
     * Constructor that adds the panel when the frame is generated
     */
    
    public CSTaitHW5() 
    {
    add(canvas);
    }

    /**
     * Main driver of the program, generates frame and retrieves
     * user input
     * @param args - command line arguments 
     */

    public static void main(String[] args) 
    {
    CSTaitHW5 frame = new CSTaitHW5();
    frame.getNumBalls();
    frame.timer.start();
    frame.setTitle("Plinko!");
    frame.setSize(frame.userChoice * 50, 440);
    frame.setLocationRelativeTo(null); 
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    frame.setVisible(true); 
    }
    
    /**
     * Timer Listener, fires every period that the timer
     * variable was set to
     */
    
    private class TimerListener implements ActionListener 
    {
        
    /**
     * Updates the ball location and redraws the Gui everytime
     * the timer fires. Stops after a complete ball cycle 
     * times the user's choice of balls to drop
     * @param e actionEvent parameter it recieves, the timer firing
     */
        
    @Override
    public void actionPerformed(ActionEvent e) 
    {
        canvas.updateBallLocation();
        canvas.repaint();
        timerCount += 1;
         
       if (timerCount == (9 * (userChoice * 2)))
            timer.stop();   
    }
    }

    /**
     * Retrieves the number of balls the user
     * desires from the command line input
     */
    
    public void getNumBalls()
    {
    Scanner scan = new Scanner(System.in);
    int temp = 0;
    while ((temp > 10) || (temp < 5))
    {
    System.out.println("Choose how many pegs, between 5-10");
    temp = scan.nextInt();
    }
    this.userChoice = temp;
    canvas.setChoice(temp);
    
    }  
    }

