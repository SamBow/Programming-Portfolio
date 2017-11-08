/**
 * <h1>World Population Simulator </h1>
 * 
 * This program simulates the population of earth every fifty years
 * during either a time of peace or during a zombie apocalypse with the user
 * playing as God.
 * 
 * @author Kanishka R and Sam C
 * @version 0.1.0
 * @since 01-11-2016
 * 
 */

//Import statements
import java.util.Random;
import java.util.Scanner;

public class WorldPopulation {
  
 /**
  * ROWS is the number of continents with people and has the value {@value} {@value #FINAL_FIELD}
  */
  final static int ROWS = 6;
  
 /**
  * COLUMNS is the number of attempts the user has to destroy the world and has the value {@value} {@value #FINAL_FIELD}
  */
  final static int COLUMNS = 100;
  
  /**
  * This is the main method that makes use of the zombieWar and peaceTime methods
  * @param args
  * @return nothing
  */  
  public static void main(String[] args) {
    
    //Declare and initialize variables
    int arrayLocationColumn =0;
    int year = 2000;
    int randValForCalc = 0;
    char entry = ' ';
    
    //Uses the Random class for generating the effects of peace or war
    Random rand = new Random();
    
    //Scanner class for taking in user input
    Scanner scanner = new Scanner(System.in);
    
    //Creates the populations 2d array for Earth's population and gives the first row values
    int[] populationStartVals =  {767, 3634, 30, 729, 307, 511};
    int[][] populations = new int[ROWS][COLUMNS];
    for(int i=0; i<ROWS; i++){
      populations[i][0] = populationStartVals[i];
    }
    
    //Continents names
    String[] continents = { "Africa ", "Asia ", "Australia ", "Europe ", "North America ", "South America " };
    
    // Start of UI, tests if North America's population is 10<population<1000
    while (populations[4][(year - 2000) / 50] < 1000 && populations[4][(year - 2000) / 50] > 10) {
      
      //Sets variable to be used later and reduces chance of mistyping
      arrayLocationColumn = (year-2000)/50;
      
      //Sets variable to store a value for the percent range
      randValForCalc = rand.nextInt(21);
      
      
      System.out.println("It is the year " + year + ", the populations of continents are (in millions) :");
      
      for (int i = 0; i < ROWS; i++) {
        // Print the ith row
        System.out.printf("%20s", continents[i]);
        
        System.out.printf("%5d", populations[i][arrayLocationColumn]);
        
        System.out.println(); // Start a new line at the end of the row
      }
      
      System.out.println("Is it a zombie apocalypse or peacetime? (z/p) (you may have to enter it twice)");
      
      //Checks the user input for two cases
      entry = scanner.nextLine().charAt(0);
      if(entry == 'z'){
        
        for(int i=0; i<ROWS; i++){
          populations[i][arrayLocationColumn+1] = zombieWar(populations[i][arrayLocationColumn], randValForCalc);
        }
        
      } else if (entry == 'p'){
        
        for(int i=0; i<ROWS; i++){
          populations[i][arrayLocationColumn+1] = peaceTime(populations[i][arrayLocationColumn], randValForCalc);
        }
        
      } else {
        System.out.println("Error has occurred with entry, please restart!");
        System.exit(0);
      }

      //Increments variables
      year += 50;
      arrayLocationColumn ++;
    }
    
    scanner.close();
    System.out.println("Either zombies have destroyed the earth or it was overpopulated.  Congrats!");
  }
  
 /**
  * @param entryVal The population before the apocalypse
  * @param randVal The random element for the range of human percent loss
  * @return The new population of the entryVal
  */
  public static int zombieWar(int entryVal, int randVal) {
    return (int) (entryVal*(60-randVal)*(.01));
  }
  
 /**
  * @param entryVal The population before the peace
  * @param randVal The random element for the range of human percent gain
  * @return The new population of the entryVal
  */
  public static int peaceTime(int entryVal, int randVal) {
    return (int) (entryVal*(115+randVal)*(.01));
  }
}
