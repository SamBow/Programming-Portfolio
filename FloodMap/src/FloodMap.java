import java.util.Random;
/**
 * 
 * <h1>Flood Map</h1>
 * 
 * This program simulates the generation of a random terrain
 * with different heights per location and the flooding of 
 * said terrain with incrementing water levels.
 * 
 * @author Kanishka R and Sam C
 * @version 0.1.0
 * @since 04-11-2016
 *
 */

public class FloodMap {

	 /**
	  * WIDTH is the number of elements wide the 2d array heights is and has the value {@value} {@value #FINAL_FIELD}
	  */
	final static int WIDTH = 10;
	
	 /**
	  * HEIGHT is the number of elements tall the 2d array heights is and has the value {@value} {@value #FINAL_FIELD}
	  */
	final static int HEIGHT = 10;

	/**
	 * This is the main method that declares and initializes a 2d array of heights and utilizes the printFloodMap method
	 * @param args
	 * @return nothing
	 */
	public static void main(String[] args) {
		
		//Declares random number generator
		Random rand = new Random();

		//2D array that has width WIDTH and height HEIGHT
		int[][] heights = new int[WIDTH][HEIGHT];
		
		//For loop that generates the numbers for the terrain
		for (int i = 0; i < WIDTH; i++) {

			for (int j = 0; j < HEIGHT; j++) {

				heights[i][j] = rand.nextInt(101);
				System.out.print(heights[i][j] + " ");

			}
			System.out.println();
		}

		//For loop that increments water value by 10
		for (int i = 0; i <= 100; i += 10) {
			System.out.println("Water level is : " + i);
			System.out.println("Flooded areas have *");
			
			//Tests to see if water level is greater than height of location
			for (int j = 0; j < WIDTH; j++) {

				for (int k = 0; k < HEIGHT; k++) {

					if(printFloodMap(i,heights[j][k])){
						System.out.print("* ");
					} else {
						System.out.print("  ");						
					}
					
				}
				System.out.println();
			}
			
			//Catch an error if one is generated from Thread.sleep()
			try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
		
	}
	
	/**
	 *
	 * @param waterLevel is value that simulates water level
	 * @param height is value of the height of the locations
	 * @return whether height is greater than water level
	 */
	public static boolean printFloodMap(int waterLevel, int height) {

		if (height <= waterLevel) {
			return true;
		} else {
			return false;
		}
	}

}
