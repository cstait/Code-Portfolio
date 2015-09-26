/*
 * @author Cameron Tait
 * date: 9/16/2015
 * description: A pizza ordering application that allows the user
 * to view and order pizzas with certain toppings, sizes and types
 */

import javafx.application.Application;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

/**
 * the model portion of the MVC, launches the visual component of the program
 * @author Cameron
 */
public class CSTaitHW extends Application {
    //global list to be used between controllers
    public static ObservableList<Pizza>pizzaList = FXCollections.observableArrayList();
    @Override
    public void start(Stage stage) throws Exception {
        Parent root = FXMLLoader.load(getClass().getResource("FXMLDocument.fxml"));
        
        Scene scene = new Scene(root);
        
        stage.setScene(scene);
        stage.setTitle("Order Pizza");
        stage.show();
    }

    /**
     * main function that takes in command line arguments when 
     * the application launches
     * @param args the command line arguments
     * 
     */
    public static void main(String[] args) {
        launch(args);
    }
    
    
}
