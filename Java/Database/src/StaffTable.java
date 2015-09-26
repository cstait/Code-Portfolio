import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.*;

/**
 * This class serves as an interface to view, update and insert 
 * records into the staff table
 * @author Cameron Tait
 */

public class StaffTable extends JFrame {
    
    private ResultSet resultSet;
    private Statement stmt;
    private Connection conn;
    
    StaffTable()
    {
        JFrame frame = new JFrame ("Staff Table");
        setLayout(new FlowLayout(FlowLayout.LEFT, 10, 20));
        JTextField id = new JTextField(5);
        JTextField lastName = new JTextField(15);
        JTextField firstName = new JTextField(15);
        JTextField initial = new JTextField(2);
        JTextField address = new JTextField(15);
        JTextField state = new JTextField(2);
        JTextField city = new JTextField(15);
        JTextField telephone = new JTextField(15);
        JButton view = new JButton("View");
        JButton insert = new JButton("Insert");
        JButton update = new JButton("Update");
        JButton clear = new JButton("Clear");
        JLabel output = new JLabel("Welcome!");
        conn = null;
        stmt = null;

        frame.setSize(500, 300);
        frame.setLocationRelativeTo(null);

        frame.setVisible(true);
        
        JPanel panel = new JPanel();
        
        panel.add(new JLabel("Staff Information"));
        panel.add(new JLabel("ID"));
        panel.add(id);
        panel.add(new JLabel("Last Name"));
        panel.add(lastName);
        panel.add(new JLabel("first Name"));
        panel.add(firstName);
        panel.add(new JLabel("mi"));
        panel.add(initial);    
        panel.add(new JLabel("Address"));
        panel.add(address);
        panel.add(new JLabel("City"));
        panel.add(city);
        panel.add(new JLabel("State"));
        panel.add(state);
        panel.add(new JLabel("Telephone number"));
        panel.add(telephone);
        panel.add(view);
        panel.add(insert);
        panel.add(update);
        panel.add(clear);
        panel.add(output);

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
   
   //This try block checks to see if the staff table exists and if it has records
   //if it doesn't exists or has no records it drops the table and creates a new one
   try
   {
      resultSet = stmt.executeQuery("select * from Staff");          
      
      if (!resultSet.next())
         {
             System.out.print("Query returned no results, creating database");
             stmt.executeUpdate("drop table staff");
             System.out.println("Staff dropped");
             stmt.executeUpdate
     ("create table staff (id char(9) not null, lastName varchar(15), firstName varchar(15), mi char(1), address varchar(20),"
             + "city varchar(20), state char(2), telephone char(10), email varchar(40), primary key (id))");
             System.out.print("Database created!");
         }
                
   }
   catch (Exception ex)
   {
       ex.printStackTrace();
   }
        view.addActionListener(new ActionListener()
        {
            @Override
            /**
             * This actionListener views the table based off
             * the ID by performing an SQL query to retrieve 
             * data from the table
             * @arg Action Event e
             */
            public void actionPerformed(ActionEvent e)
            {
               if (!id.getText().equals(""))
               {
               try
               {
                resultSet = stmt.executeQuery("select lastName,firstName,"
                        + " mi,address, city, state, telephone from "
                        + "Staff where id = '" + id.getText() +"'");
                
                if (resultSet.next())
                {
                        lastName.setText(resultSet.getString(1));
                        firstName.setText(resultSet.getString(2));
                        initial.setText(resultSet.getString(3));
                        address.setText(resultSet.getString(4));
                        city.setText(resultSet.getString(5));
                        state.setText(resultSet.getString(6));
                        telephone.setText(resultSet.getString(7));  
                }
                else
                {
                    output.setText("No records found, check ID");
                }
                }
                catch (Exception ex)
                {
                ex.printStackTrace();
                }
                }
                else
                {
                   output.setText("ID field is empty!");
                }       
            }
        });

            insert.addActionListener(new ActionListener()
            {
             @Override
            /**
             * This actionListener attempts to insert data from
             * the text field into the SQLDatabase 
             * @arg Action Event e
             */
             public void actionPerformed(ActionEvent e)     
             {
                if (!id.getText().equals(""))
                {
                    try
                    {
                stmt.executeUpdate("insert into staff (id, lastName,"
                        + " firstName, mi, address, city, state, telephone)"
                        + " values ('"+id.getText()+"','"+lastName.getText()+"',"
                        + "'"+firstName.getText()+"','"+initial.getText()+"',"
                        + " '"+address.getText()+"','"+city.getText()+"','"
                        + ""+state.getText()+"','"+telephone.getText()+"')");
                          output.setText("Transaction complete!");
                        }
                    catch (Exception ex)
                    {
                        output.setText("Could not insert data"
                                + ", ensure that fields are full and record doesn't"
                                + " already exist");
                    }
                }
                else
                {
                    output.setText("ID Field must be filled before inserting");
                }
            }
            });
            
            
        update.addActionListener(new ActionListener()
        {
            @Override
            /**
             * This action listener updates a current existing record
             * based off the primary key of the ID.
             * @arg ActionEvent e
             */
            public void actionPerformed(ActionEvent e)
            {
               if (!id.getText().equals(""))
                {
                    try
                    {
                stmt.executeUpdate("update staff set lastName = '"+lastName.getText()+"',"
                        + "firstName = '"+firstName.getText()+"', mi = '"+initial.getText()+"',"
                        + "address = '"+address.getText()+"', city = '"+city.getText()+"',"
                        + "state = '"+state.getText()+"', telephone = '"+telephone.getText()+"'"
                        + "where id = '"+id.getText()+"';");
                output.setText("Transaction complete!");
                
                    }
                    catch (Exception ex)
                    {
                        output.setText("Could not update data"
                                + ", ensure that fields are full and record exists");
                        ex.printStackTrace();
                    }
                }
                else
                {
                    output.setText("ID Field must be filled before updating");
                }
                      
            }
        });
                
                 clear.addActionListener(new ActionListener()
        {
            @Override
            /**
             * This action listener clears all the text fields
             * @arg Action Event e
             */
            public void actionPerformed(ActionEvent e)
            {
               id.setText("");
               lastName.setText(""); 
               firstName.setText(""); 
               initial.setText(""); 
               address.setText(""); 
               state.setText("");
               city.setText(""); 
               telephone.setText("");  
            }
        });
        frame.add(panel);
    }
}
