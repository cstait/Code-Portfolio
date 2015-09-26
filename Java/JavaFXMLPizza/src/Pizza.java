import javafx.beans.property.SimpleStringProperty;

/**
 * Pizza datamodel that houses data for orders
 * and binds with the table view
 * @author Cameron
 */
public class Pizza {
    private final SimpleStringProperty lastName  = new SimpleStringProperty("");
    private final SimpleStringProperty total  = new SimpleStringProperty("");
    private final SimpleStringProperty type  = new SimpleStringProperty("");
    private final SimpleStringProperty size  = new SimpleStringProperty("");
    private final SimpleStringProperty topping  = new SimpleStringProperty("");
    
    /**
     * Default class initializer for no values
     */
   public Pizza() {
        this("", "", "", "", "");
    }
   
    /**
     * Class initializer
     * @param a lastName initialized value
     * @param b total initialized value
     * @param c type initialized value
     * @param d size initialized value
     * @param e topping initialized value
     */
   public Pizza(String a, String b, 
         String c, String d, String e)
    {
        lastName.set(a);
        total.set(b);
        type.set(c);
        size.set(d);
        topping.set(e);
    }
            
     /**
     * lastName accessor
     * @return class lastName 
     */
    public String getLastName()
    {
        return lastName.get();
    }
    
     /**
     * lastName accessor
     * @return class total 
     */
    public String getTotal()
    {
        return total.get();
    }
     
    /**
     * lastName accessor
     * @return class type
     */
    public String getType()
     {
        return type.get();
    }
      
    /**
     * lastName accessor
     * @return class size
     */
    public String getSize()
    {
        return size.get();
    }
    /**
     * lastName accessor
     * @return class topping
     */   
    public String getTopping()
    {
        return topping.get();
    }
    /**
     * lastName mutator
     * @param fName sets lastName
     */    
    public void setLastName(String fName) {
        lastName.set(fName);
    }
    /**
     * lastName mutator
     * @param fName sets type
     */
    public void setType(String fName) {
        type.set(fName);
    }
    
    /**
     * lastName mutator
     * @param fName sets topping
     */
    public void setTopping(String fName) {
        topping.set(fName);
    }
    
    /**
     * lastName mutator
     * @param fName sets size
     */
    public void setSize(String fName) {
        size.set(fName);
    }
    /**
     * lastName mutator
     * @param fName sets total
     */
    public void setTotal(String fName) {
        total.set(fName);
    }
}
