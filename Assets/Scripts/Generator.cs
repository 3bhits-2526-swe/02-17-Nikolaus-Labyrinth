/*
    this script is responsible for generating levels with good paths 

    @author: wek56ur@gmail.com
    @date: 2026-01-08

*/

using UnityEngine;
using System.Collections.Generic;
using Unity.Mathematics;

public class Generator : MonoBehaviour
{
    //takes models wall4 - wall2 & tile and generates usable path with it 


    [SerializeField] GameObject wall4; 
    [SerializeField] GameObject wall3; 
    [SerializeField] GameObject wall2; 
    [SerializeField] GameObject wall1; 
    [SerializeField] GameObject tile; 

    [SerializeField] GameObject finish; //path that should be reached

    [SerializeField] GameObject start; //beginning of path

    void Start()
    {
        generatePath(0);     
    }

    private void generatePath(int seed)
    {
        Debug.Log("generating initialized"); 
        /* 
            calc size (AxB) 
            create array 
            generate correct path 
            insert walls 
            extend walls and add tiles
        */

        
        //remove list approach -> replace with structured randomly generated approach 
        //borders that the randomly generated coords cant cross!
        int widthX = (int) math.abs(finish.transform.position.x - start.transform.position.x); 
        int borderX1 = (int) finish.transform.position.x + widthX;
        int borderX2 = (int) start.transform.position.x - widthX; //watch out: which one is bigger which one isnt

        int widthY = (int) math.abs(finish.transform.position.y - start.transform.position.y); 
        int borderY1 = (int) finish.transform.position.y + widthY;
        int borderY2 = (int) start.transform.position.y - widthY; //watch out: which one is bigger which one isnt


        UnityEngine.Random.InitState(seed);
        //finding one perfect path (maybe little variation in coords?)

        int startX = (int) start.transform.position.x;
        int startZ = (int) start.transform.position.z;

        Vector3 pos = new Vector3(startX, fix, startZ); 
        //first pos -> place obj and then move random step (width of obj)

        //Instantiate(originalObject);
        //creating obj with coords 

        //float randomSpeed = Random.Range(0.5f, 5.0f);

        
        //Debug.Log(Random.Range(0, 100)); 

        // Returns 1, 2, or 3. It will NEVER return 4.
        //int randomChoice = Random.Range(1, 4);

        // Returns a Vector3 inside a sphere with radius 1
        //Vector3 randomPos = Random.insideUnitSphere * 5f; // Radius 5

        //select random item in list 
        //make closest points to start and finish to tiles

    
        //some algorithm to check if some tiles are next to each other in order to ensure walkable paths 

        //lists contain all possible x and y values -> deleted from the list after being chosen to ensure integrity 
        
        
    }
 
    
}