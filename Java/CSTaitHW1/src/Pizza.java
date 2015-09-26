import javafx.beans.property.SimpleStringProperty;

/**
 * Pizza datamodel that houses data for orders
 * and binds with the table view
 * @author Cameron
 */
public class Pizza {
    private final String lastName;
    private final String total;
    private final String type;
    private final String size;
    private final String topping;
    
    /**
     * Class initializer
     * @param a lastName initialized value
     * @param b total initialized value
     * @param c type initialized value
     * @param d size initialized value
     * @param e topping initialized value
     */
    Pizza(String a, String b, 
         String c, String d, String e)
    {
        lastName = a;
        total = b;
        type = c;
        size = d;
        topping = e;
    }
            
    /**
     * lastName accessor
     * @return class lastName 
     */
    public String getLastName()
    {
        return lastName;
    }
    
    /**
     * total accessor
     * @return class lastName 
     */
     public String getTotal()
    {
        return total;
    }
     
    /**
     * type accessor
     * @return class lastName 
     */
      public String getType()
     {
        return type;
    }
      
    /**
     * size accessor
     * @return class lastName 
     */      
       public String getSize()
    {
        return size;
    }
       
    /**
     * topping accessor
     * @return class lastName 
     */       
        public String getTopping()
    {
        return topping;
    }
}
