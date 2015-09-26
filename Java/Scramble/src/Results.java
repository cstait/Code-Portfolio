/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.io.PrintWriter;

/**
 *
 * @author Xaxas
 */
public class Results 
{
    
    private int wins = 0;
    private int losses = 0;
    private int guesses = 0;
    private int rounds = 0;
    private final String filePath;
    
    
    Results(String path, int w, int l, int g)
    {
        this.filePath = path;
        wins = w;
        losses = l;
        guesses = g;
        rounds = w + l;  
        
    }
    
    public void won()
    {
        wins++;
        rounds++;
    }
    
    public void lost()
    {
        losses++;
        rounds++;
    }
    
    public void guesses()
    {
        guesses++;
 
    }
    
    public void save()
    {
        try
        {
            PrintWriter input = new PrintWriter(filePath);
            input.println(rounds);
            input.println(wins);
            input.println(losses);
            input.println(guesses);
            input.println();           
            input.close();                     
        }
        catch (Exception E)
        {
            System.out.println("Error: Could not open file");
        }       
    }
    
    public String toString()
    {
        return ("\nRounds tried: " + rounds + "\n" + "Rounds won: " + wins + "\n" 
                + "Rounds lost: " + losses + "\n" + "Rounds guess: " + guesses
                + "\n");
    }
}
