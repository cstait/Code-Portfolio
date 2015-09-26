import java.sql.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Homework 06: JDBC
 * COURSE: CIS357
 * Due Date: 4/23/2015
 * Completed Date: 4/22/2015
 * Name: Cameron Tait
 * Instructor: Il-Hyung Cho
 * Program Description: Uses JDBC to connect to campus network's mySql database
 * and performs search, insert, view and update operations on the database
 */

/**
 * This class servers as a launchpad for the other classes, it also
 * tests to make sure the database connection is secured.
 * @author Xaxas
 */
public class CSTaitHW6 extends JApplet{
    
   
   // JDBC driver name and database URL
   static final String JDBC_DRIVER = "com.mysql.jdbc.Driver";  
   static final String DB_URL = "jdbc:mysql://csis.svsu.edu/cstait?zeroDateTimeBehavior=convertToNull";

   //  Database credentials
   static final String USER = "cstait";
   static final String PASS = "cstait123";
   
   /**
    * Tests to access the database connection, then launches the gui
    * @param args - commmand line arguments 
    */
   public static void main(String[] args) {

   Connection conn = null;
   Statement stmt = null;
   
   try{
      //STEP 2: Register JDBC driver
      Class.forName("com.mysql.jdbc.Driver");
      System.out.println("Connecting to database...");
      conn = DriverManager.getConnection(DB_URL,USER,PASS);
      stmt = conn.createStatement();
   }
   catch(Exception ex)
   {
       ex.printStackTrace();
   }
      
       CSTaitHW6 mainWindow = new CSTaitHW6(); 
}//end main
   
   /**
    * Constructor that builds the UI and defines event listeners for the 
    * buttons, which launch instances of the other windows
    */
public CSTaitHW6()
{
    setLayout(new FlowLayout(FlowLayout.LEFT, 10, 20));
    JFrame frame = new JFrame();
    frame.setTitle("HW6 Program");
    frame.setSize(300, 150);
    frame.setLocationRelativeTo(null);
    frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    
    JButton programOne = new JButton("Problem 1");
    JButton programTwo = new JButton("Problem 2");
    JButton programThree = new JButton("Problem 3");
    JButton programFour = new JButton("Problem 4");
   
    programOne.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {
                StaffTable p1Window = new StaffTable();
            }
        });
 
    programTwo.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {
                Graph p2Window = new Graph();
            }
        });
  
    programThree.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {
                Grades p3Window = new Grades();
            }
        });
   
    programFour.addActionListener(new ActionListener()
        {
            public void actionPerformed(ActionEvent e)
            {
                TableContents p4Window = new TableContents();                    
            }
        });
    
    
   JPanel panel = new JPanel();
   
   frame.add(panel);
   panel.add(programOne);
   panel.add(programTwo);
   panel.add(programThree);
   panel.add(programFour);
   frame.setVisible(true);
}       
}
