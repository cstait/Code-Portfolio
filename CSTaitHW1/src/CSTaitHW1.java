/*
 * @author Cameron Tait
 * date: 9/16/2015
 * description: A pizza ordering application that allows the user
 * to view and order pizzas with certain toppings, sizes and types
 */

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.stage.Stage;
import javafx.scene.layout.GridPane;
import javafx.geometry.Pos;
import javafx.geometry.Insets;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.layout.FlowPane;
import javafx.collections.ObservableList;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.collections.FXCollections;
import java.text.DecimalFormat;

/**
 *
 * @author Cameron Tait
 * Description: The gui portion of the program, launches the application
 * and sets the gui for three different scenes
 * @var various nodes for use on the gui, sum keeps track of the current orders total
 * 
 */
public class CSTaitHW1 extends Application {
    
    private Label total;
    private double sum;
    private ComboBox pizzaType;
    private ComboBox pizzaSize;
    private ComboBox pizzaTop;
    private TableView table;
    private TextField lastName;
    private ObservableList<Pizza> pizzaList;
 
    @Override
    /**
     * Description: the function initializes the gui upon start up of the application
     * @param primaryStage - initial stage generated
     */   
    public void start(Stage primaryStage) {
        
        Button orderPizza = new Button();
        Button viewOrder = new Button();
        Button orderPizza2 = new Button();
        Button viewOrder2 = new Button();
        Button placeOrder = new Button();
        Button add = new Button();
        Button newOrder = new Button();
        
        pizzaType = new ComboBox();
        pizzaSize = new ComboBox();
        pizzaTop = new ComboBox();
        
        table = new TableView();
        total = new Label("$5.00");
        sum = 5.0;
        
        lastName = new TextField();
        pizzaList = FXCollections.observableArrayList();
        
        //filling out combo boxes with default values       
        pizzaType.getItems().addAll("Pepperoni", "Hawaiian", "Veggie", "Meat", 
               "Special");
        pizzaSize.getItems().addAll("Small", "Medium", "Large");
        pizzaTop.getItems().addAll("No Toppings", "Extra Cheese", "Green Pepper",
               "Onion", "Mushroom", "Black Olive", "Tomato", "Jalapeno Pepper");
        //setting default value selected for each box
        pizzaType.setValue("Pepperoni");
        pizzaSize.setValue("Small");
        pizzaTop.setValue("No Toppings");
       
       
        //setting default text for buttons
        orderPizza.setText("Order Pizza");
        viewOrder.setText("View Orders");
        orderPizza2.setText("Order Pizza");
        viewOrder2.setText("View Orders");
        placeOrder.setText("Place Order");
        add.setText("Add Pizza");
        newOrder.setText("New Order");
        
        //setting width for textbox
        lastName.setPrefColumnCount(12);
        

        //setting pane values for order scene
        FlowPane viewPage = new FlowPane();
        viewPage.setAlignment(Pos.TOP_CENTER);	// position it to the center
        viewPage.setPadding(new Insets(11.5, 12.5, 13.5, 14.5));
        viewPage.setHgap(5.5); viewPage.setVgap(5.5);
        
        //adding buttons to order scene
        viewPage.getChildren().add(orderPizza2);
        viewPage.getChildren().add(viewOrder2);
        
        
        table.setEditable(true);
 
        //setting up table columns
        TableColumn lastNameCol = new TableColumn("Last Name");
        TableColumn flavorCol = new TableColumn("Type");
        TableColumn sizeCol = new TableColumn("Size");
        TableColumn toppingCol = new TableColumn("Topping");
        TableColumn priceCol = new TableColumn("Price");
        //adding to table view
        table.getColumns().addAll(lastNameCol, flavorCol, sizeCol, toppingCol,
                                  priceCol);
 
        //binding table columns to Pizza class fields
        lastNameCol.setCellValueFactory(
                new PropertyValueFactory<Pizza,String>("lastName"));
        flavorCol.setCellValueFactory(
                new PropertyValueFactory<Pizza,String>("type"));
        sizeCol.setCellValueFactory(
                new PropertyValueFactory<Pizza,String>("size"));
        toppingCol.setCellValueFactory(
                new PropertyValueFactory<Pizza,String>("topping"));
        priceCol.setCellValueFactory(
                new PropertyValueFactory<Pizza,String>("total"));
        
        //binding table to an observable list
        table.setItems(pizzaList);
        viewPage.getChildren().add(table);
       
        
        //setting up the order page
        GridPane orderPage = new GridPane();
        orderPage.setAlignment(Pos.TOP_CENTER);	// position it to the center
        orderPage.setPadding(new Insets(11.5, 12.5, 13.5, 14.5));
        orderPage.setHgap(5.5); orderPage.setVgap(5.5);
        
        //adding various nodes to order page & setting status at start
        orderPage.add(orderPizza, 0, 0);
        orderPage.add(viewOrder, 1, 0);
        orderPage.add(new Label("Last Name:"), 0, 1);
        orderPage.add(lastName, 1, 1);
        orderPage.add(pizzaType, 0, 2);
        orderPage.add(pizzaSize, 1, 2);
        orderPage.add(pizzaTop, 2, 2);       
        orderPage.add(total, 3, 2);
        orderPage.add(add, 0, 4);
        orderPage.add(placeOrder, 1, 4);
        orderPage.add(newOrder, 2, 4);
        orderPizza.setDisable(true);
        viewOrder.setDisable(true);
        placeOrder.setDisable(true);
        newOrder.setDisable(true);
        
        //binds panes to scenes
        Scene orderScene = new Scene(orderPage, 500, 250 );
        Scene viewScene = new Scene(viewPage, 500, 600);
         
        //sets stage to the order screen
        primaryStage.setTitle("Order Pizza");
        primaryStage.setScene(orderScene);
        orderScene.getStylesheets().add 
        (CSTaitHW1.class.getResource("CSTaitHW1.css").toExternalForm());
        primaryStage.show();
        
        
        /**
         * Sets the orderPizza button's action
         * to switch the scene to the orderPage
         * @param e actionevent recieved
         */
        orderPizza.setOnAction(e -> {
                viewOrder.setDisable(false);
                viewOrder2.setDisable(false);
                orderPizza.setDisable(true);
                orderPizza2.setDisable(true);
                primaryStage.setScene(orderScene);
                orderScene.getStylesheets().add 
                (CSTaitHW1.class.getResource("CSTaitHW1.css").toExternalForm());
                primaryStage.setTitle("Order Pizza");           
        });
        
        /**
         * Sets the viewOrder button's action
         * to switch the scene to the viewPage
         * @param e actionevent recieved
         */
         viewOrder.setOnAction(e -> {
                viewOrder.setDisable(true);
                orderPizza.setDisable(false);
                viewOrder2.setDisable(true);
                orderPizza2.setDisable(false);
                primaryStage.setScene(viewScene);
                viewScene.getStylesheets().add 
                (CSTaitHW1.class.getResource("CSTaitHW1.css").toExternalForm());
                primaryStage.setTitle("View Orders");
        });
         
        /**
         * Sets the orderPizza2 button's action
         * to switch the scene to the orderPage
         * @param e actionevent recieved
         */
          orderPizza2.setOnAction(e -> {
                viewOrder.setDisable(false);
                viewOrder2.setDisable(false);
                orderPizza.setDisable(true);
                orderPizza2.setDisable(true);
                primaryStage.setScene(orderScene);
                orderScene.getStylesheets().add 
                (CSTaitHW1.class.getResource("CSTaitHW1.css").toExternalForm());
                primaryStage.setTitle("Order Pizza");       
        });
        
        /**
         * Sets the orderPizza button's action
         * to switch the scene to the viewpage
         * @param e actionevent recieved
         */ 
         viewOrder2.setOnAction(e -> {
                viewOrder.setDisable(true);
                orderPizza.setDisable(false);
                viewOrder2.setDisable(true);
                orderPizza2.setDisable(false);
                primaryStage.setScene(viewScene);
                viewScene.getStylesheets().add 
                (CSTaitHW1.class.getResource("CSTaitHW1.css").toExternalForm());
                primaryStage.setTitle("View Orders");
        });

        /**
         * Sets the pizzaType combobox's action
         * to call the calculate function
         * @param e actionevent recieved
         */
         pizzaType.setOnAction(e -> {
             calculate();
         });
       
         /**
         * Sets the PizzaTop combobox's action
         * to call the calculate function
         * @param e actionevent recieved
         */         
         pizzaTop.setOnAction(e -> {
             calculate();
         });
       
         /**
         * Sets the pizzaSize combobox's action
         * to call the calculate function
         * @param e actionevent recieved
         */         
         pizzaSize.setOnAction(e -> {
             calculate();
         });
         
        /**
         * Sets the placeOrder button's action
         * to generate a new form similar to
         * a dialog box where it confirms or
         * denies the order
         * @param e actionevent recieved
         */         
        placeOrder.setOnAction(e -> {
            Stage confirmation = new Stage();
            FlowPane warningBox = new FlowPane();
            Button confirm = new Button("Yes");
            Button cancel = new Button("No, Forget My Orders");
            warningBox.setAlignment(Pos.TOP_CENTER);	
            warningBox.setPadding(new Insets(11.5, 12.5, 13.5, 14.5));
            warningBox.setHgap(5.5); orderPage.setVgap(5.5);
             
            warningBox.getChildren().add(new Label("Would you like to place order? Pizza's added will be forgotten if not."));
            warningBox.getChildren().add(confirm);
            warningBox.getChildren().add(cancel);            
            Scene warningScene = new Scene(warningBox, 400, 100);

            confirmation.setTitle("Order Pizza Confirmation");
            confirmation.setScene(warningScene);
            confirmation.show();
            
            /**
             * Sets the confirm button's action
             * to activate viewOrder's action and 
             * closes the stage
             * @param e actionevent recieved
             */
            confirm.setOnAction(b -> {
                viewOrder.fireEvent(e);
                add.setDisable(true);
                placeOrder.setDisable(true);
                confirmation.close();
                viewOrder.setDisable(true);
                newOrder.setDisable(false);
                });
        
             /**
             * Sets the cancel button's action
             * to clear the observable list and
             * closes the stage
             * @param e actionevent recieved
             */
             cancel.setOnAction(b -> {
                pizzaList.clear();
                confirmation.close();
                placeOrder.setDisable(true);
                });
         });
         
        /**
         * Sets the add button's action
         * to retrieve the values from the combobox's
         * and add to the observable list
         * @param e actionevent recieved
         */
         add.setOnAction(e -> {
            String tempType = pizzaType.getValue().toString();
            String tempSize = pizzaSize.getValue().toString();
            String tempTop = pizzaTop.getValue().toString();
            
            pizzaList.add(new Pizza(lastName.getText(), 
                    ("$" + new DecimalFormat("#.##").format(sum * 1.06) + "0"),
                    tempType, tempSize, tempTop));
            placeOrder.setDisable(false);
         });

        /**
         * Sets the onewOrder button's action
         * to clear the pizzaList and reset the button fields
         * to default
         * @param e actionevent recieved
         */         
         newOrder.setOnAction(e -> {
             pizzaList.clear();
             newOrder.setDisable(true);
             add.setDisable(false);
             placeOrder.setDisable(true);
             viewOrder.setDisable(true);
         });
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
    
    /**
     * Calculates the total sum based on the combination of
     * the pizza, size and topping selected and set the total's text
     */
    public void calculate()
    {
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
}
