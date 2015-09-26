import java.awt.*;
import java.awt.event.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.*;

/**
 * This class uses the JDBC connection find a student's courses and
 * grades
 * @author Cameron Tait
 */
public class Grades extends JFrame {
   
    private Connection conn;
    private Statement stmt;
    private Statement stmt2;
    private ResultSet resultSet;
    private ResultSet courseId;
    
    public Grades()
    {
        //basic Gui building
       JFrame frame = new JFrame ("Find Grades");
       JPanel panel = new JPanel();
       JTextArea jta;
       int numCourses = 0;
       JLabel result = new JLabel(numCourses + " courses found");
       JButton query = new JButton ("Show Grade");
       JTextField ssn = new JTextField(20);
       JScrollPane output = new JScrollPane(jta = new JTextArea());
       setLayout(new FlowLayout(FlowLayout.LEFT, 10, 20));
       output.setPreferredSize(new Dimension(500, 200));
       jta.setWrapStyleWord(true);
       jta.setLineWrap(true);

       frame.setSize(550, 350);
       frame.setLocationRelativeTo(null);
        
       panel.add(new JLabel("SSN"));
       panel.add(ssn);
       panel.add(query);
       panel.add(output);
       panel.add(result);      
       frame.add(panel);
       conn = null;
       stmt = null;
       stmt2 = null;
    
   //establishes a connection to the database    
   try
   {
      Class.forName("com.mysql.jdbc.Driver");
     
      System.out.println("Connecting to database...");
      conn = DriverManager.getConnection(CSTaitHW6.DB_URL,CSTaitHW6.USER,CSTaitHW6.PASS);
      stmt = conn.createStatement();
      stmt2 = conn.createStatement();
   }
   catch(Exception ex)
   {
      ex.printStackTrace();
   }
      frame.setVisible(true);
        
        query.addActionListener(new ActionListener()
        {
            @Override
            @SuppressWarnings("CallToPrintStackTrace")
            public void actionPerformed(ActionEvent e)
            {
            String name = "";
            String course = "";
            String grade = "";
            int numRecords = 0;
            
            jta.setText("");

            //This try box executes three different sql statements, one to 
            //retrieve the studen'ts name where the request SSN is the same,
            //another to retreive the course Id and the grade
            //and a final one to retrieve the course title from the id
            
            try
            {
            resultSet = stmt.executeQuery("SELECT firstName, mi, lastName from Student WHERE ssn = '"+ ssn.getText() +"'");
            while(resultSet.next())
            {
            name = resultSet.getString(1) + " " + resultSet.getString(2) + ". " + resultSet.getString(3);
            }
            resultSet = stmt.executeQuery("select courseId, grade from Enrollment where ssn = '"+ssn.getText()+"'");
            while(resultSet.next())
            {
            course = resultSet.getString(1);
            grade = resultSet.getString(2); 
            courseId = stmt2.executeQuery("select title from Course where courseId = '"+course+"'");
            
            while(courseId.next())
            {
                course = courseId.getString(1);
            }
            jta.setText( jta.getText()  + name + "'s grade on course " + course + " is " + grade + "\n");
            numRecords++;
            }
            result.setText(numRecords + " courses found");
            }
            catch(Exception ex)
            {
                ex.printStackTrace();
                result.setText("0 results found, check SSN");
            }
            }});
    }
}
