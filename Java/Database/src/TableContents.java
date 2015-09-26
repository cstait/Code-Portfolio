
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import javax.swing.*;


/**
 * This class takes a table name and does a SQL search
 * and retrieves all information and displays it to the user
 * @author Cameron Tait
 */
public class TableContents extends JFrame {
    
       private Connection conn = null;
       private Statement stmt = null;
       private ResultSet resultSet;
       private ResultSetMetaData meta;
       
    public TableContents()
    {
       JFrame frame = new JFrame ("Choose Table to Display");
       JPanel panel = new JPanel();
       JTextArea jta = new JTextArea();
       setLayout(new FlowLayout(FlowLayout.LEFT, 10, 20));
       JTextField tableName = new JTextField(15);
       JScrollPane output = new JScrollPane(jta);
       JButton query = new JButton("Show Contents");
       output.setPreferredSize(new Dimension(600, 200));
       jta.setWrapStyleWord(false);
       jta.setLineWrap(false);
       conn = null;
       stmt = null;

       frame.setSize(700, 300);
       frame.setLocationRelativeTo(null);
      
      
       panel.add(new JLabel("Table Name"));
       panel.add(tableName);
       panel.add(query);
       panel.add(output);
       frame.add(panel);
 
    try
    {
      Class.forName("com.mysql.jdbc.Driver");
      System.out.println("Connecting to database...");
      conn = DriverManager.getConnection(CSTaitHW6.DB_URL,CSTaitHW6.USER,CSTaitHW6.PASS);
      stmt = conn.createStatement();
    }
    catch(Exception ex)
    {
       ex.printStackTrace();
    }
        frame.setVisible(true);
        

        query.addActionListener(new ActionListener()
        {
            @Override
            /**
            * This actionListener does a query based on the textfield input
            * and displays the table data
            * @arg Action Event e
            */
            public void actionPerformed(ActionEvent e)
            {
              
              jta.setText("");
              
              try
              {
              resultSet = stmt.executeQuery("select * from "+ tableName.getText() + "");
              meta = resultSet.getMetaData();
              
                for (int i = 1; i <= meta.getColumnCount(); i++)
                {
                    jta.append(meta.getColumnName(i) + "\t");
                }
                jta.append("\n");
              
            while (resultSet.next()) 
            {
            for (int i = 1; i <= meta.getColumnCount(); i++)
             {
              jta.append(resultSet.getObject(i) + "\t");
             }
            jta.append("\n");
             }
              }
              catch (Exception ex)
              {
                 ex.printStackTrace();
              }                      
            }
        });
    }
}
