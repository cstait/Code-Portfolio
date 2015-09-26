
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.*;

/**
 * Class draws a pie chart and hisogram based on information
 * collected from the database
 * @author Cameron Tait
 */
public class Graph extends JPanel {
    
    private Statement stmt;
    private Connection conn;
    private ResultSet resultSet;
    
    /**
     * Constructor sets up the frame it will be added to
     */
    public Graph()
    {
      JFrame frame = new JFrame ("Graph");
      setLayout(new FlowLayout(FlowLayout.LEFT, 10, 20));          
      conn = null;
      stmt = null;
      
      frame.setSize(400, 300);
      frame.setLocationRelativeTo(null);
      
      frame.setVisible(true);
      frame.add(this);
      
      frame.repaint();
        
    }
        /**
         * Paints on the panel the pie chart and histogram 
         * @param g graphics 
         */
            protected void paintComponent(Graphics g) 
    {
        super.paintComponent(g);
        
        int startAngle = 0;
        int stopAngle = 0;
        String[] department = new String[10];
        double[] num = new double[10];
        int n = 0;
        double total = 0;
        
        //retrieves data from database regarding the number of students
        //in what departments
        try
        {
        Class.forName("com.mysql.jdbc.Driver");
        System.out.println("Connecting to database...");
        conn = DriverManager.getConnection(CSTaitHW6.DB_URL,CSTaitHW6.USER,CSTaitHW6.PASS);
        stmt = conn.createStatement();
        resultSet = stmt.executeQuery("select deptId, count(*)"
                + " from Student"
                + " where deptId is not null"
                + " group by deptId");
        
        while(resultSet.next())
        {
            department[n] = resultSet.getString(1);
            num[n] = resultSet.getInt(2);
            n++;
        }
       
        for (int i = 0; i < 4; i++)
        {
            total = total + num[i];            
        }
        
        }
       catch(Exception ex)
        {
        ex.printStackTrace();
        }
       
        //each little segment of code draws an arc filling
        //out the pie chart, it converts each arc angle from
        //the percentage of people attending each class converted
        //into an interger
        //also draws the part of the histogram it represents.
        g.setColor(Color.BLUE);
        stopAngle = (int)((num[0] / total) * 360);
        g.fillArc( 15, 15, 150, 150, startAngle, stopAngle);
        g.drawString(department[0], 75, 200);
        g.fillRect(170, 200, 20, (int)(-(num[0] * 15)));
        
        g.setColor(Color.RED);
        startAngle += stopAngle;
        stopAngle = (int)((num[1] / total) * 360);
        g.fillArc( 15, 15, 150, 150, startAngle, stopAngle);
        g.drawString(department[1], 75, 215);
        g.fillRect(190, 200, 20, (int)(-(num[1] * 15)));
        
        g.setColor(Color.cyan);
        startAngle += stopAngle;
        stopAngle = (int)((num[2] / total) * 360);      
        g.fillArc( 15, 15, 150, 150, startAngle, stopAngle);
        g.drawString(department[2], 75, 230);
        g.fillRect(210, 200, 20, (int)(-(num[2] * 15)));
        
        g.setColor(Color.GREEN);
        startAngle += stopAngle;
        stopAngle = (int)((num[3] / total) * 360);
        g.fillArc( 15, 15, 150, 150, startAngle, stopAngle);
        g.drawString(department[3], 75, 245);       
        g.fillRect(230, 200, 20, (int)(-(num[3] * 15)));
        
        g.dispose();
        
    }
}
