

import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import java.io.*;
import static java.lang.System.out;
import java.text.DecimalFormat;
import javafx.scene.control.TableView;
/**
 * Controls the FXMLDocument's nodes functions
 * @author Cameron
 */
public class FXMLDocumentController implements Initializable {
    
    private double sum;

    @FXML
    private Label total;
    @FXML
    private Button orderPizza;
    @FXML
    private Button viewPizza;
    @FXML
    private Button addOrder;
    @FXML
    private TextField lastName;
    @FXML
    private ComboBox pizzaType;
    @FXML
    private ComboBox pizzaSize;
    @FXML
    private ComboBox pizzaTop;


    /**
     * switch's view by retrieving the button's stage source
     * and switches to the viewOrder fxml page
     * @param event recieved by clicking
     */
    @FXML
    private void switchToView(ActionEvent event)  throws IOException{
     Stage stage; 
     Parent root;
     if(event.getSource()== viewPizza){
        //get reference to the button's stage         
        stage=(Stage)viewPizza.getScene().getWindow();
        //load up OTHER FXML document
    
        root = FXMLLoader.load(getClass().getResource("viewOrder.fxml"));
        out.println("error");
        Scene scene = new Scene(root);
        stage.setScene(scene);
        stage.setTitle("Viewing Orders");
        stage.show();
      }
    }
    
    /**
     * adds order from combobox's and input box into
     * global list for pizza
     * @param event recieved by clicking
     */
    @FXML
    private void addPizza(ActionEvent event) {

     String tempType = pizzaType.getValue().toString();
     String tempSize = pizzaSize.getValue().toString();
     String tempTop = pizzaTop.getValue().toString();

     CSTaitHW.pizzaList.add(new Pizza(lastName.getText(), 
             ("$" + new DecimalFormat("#.##").format(sum * 1.06) + "0"),
             tempType, tempSize, tempTop));

    }

    /**
     * dynamically changes sum based on values
     * from combo box's and updates total text
     * to reflect the sum
     * @param event recieved
     */
    @FXML
       private void calculate(ActionEvent event) {
         sum = 0;
        
        if (pizzaType.getValue().equals("Pepperoni"))
                sum += 5.50;
        if (pizzaType.getValue().equals("Hawaiian"))
                sum += 7.50;
        if (pizzaType.getValue().equals("Veggie"))
                sum += 6.50;
        if (pizzaType.getValue().equals("Meat"))
                sum += 7.50;
        if (pizzaType.getValue().equals("Special"))
                sum += 8.50;
       
        if (pizzaSize.getValue().equals("Medium") && 
                (!pizzaTop.getValue().equals("No Toppings")))
                sum += 2.50;
        else if (pizzaSize.getValue().equals("Medium"))
                sum += 2.00;
        
        if (pizzaSize.getValue().equals("Large") && 
                (!pizzaTop.getValue().equals("No Toppings")))
                sum += 5.00;
        else if (pizzaSize.getValue().equals("Large"))
                sum += 4.00;
          
        if (pizzaTop.getValue().equals("No Toppings"))
            sum -= .50;

        total.setText("$" + sum + "0"); 
    }
    
    /**
     * function called when xml form is loaded
     * @param url
     * @param rb 
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        sum = 5;
    }    
    
}
