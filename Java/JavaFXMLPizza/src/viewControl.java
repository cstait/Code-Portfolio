
import java.io.IOException;
import static java.lang.System.out;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.scene.control.Button;
import javafx.scene.control.TableView;


public class viewControl implements Initializable {

    @FXML
    private Button orderPizza2;
    @FXML
    private Button viewPizza2;
    @FXML
    private TableView<Pizza> tableView;
    
    
    @FXML
    private void switchToView(ActionEvent event)  throws IOException{
        Stage stage; 
        Parent root;
   
        
        stage=(Stage)orderPizza2.getScene().getWindow();
    
        root = FXMLLoader.load(getClass().getResource("FXMLDocument.fxml"));
        out.println("error");
        Scene scene = new Scene(root);
        stage.setScene(scene);
        stage.setTitle("Viewing Orders");
        stage.show();
        
      }

 
    
    
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        
        tableView.setItems(CSTaitHW.pizzaList);

    }    
}