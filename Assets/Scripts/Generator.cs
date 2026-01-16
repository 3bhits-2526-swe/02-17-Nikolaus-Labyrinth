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
        //for testing purposes
        //testGenerate();

        //generatePath(0);     
        testGemini(); 
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

        //Vector3 pos = new Vector3(startX, fix, startZ); 
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
 
    private void testGenerate()
    {
        //TEST COMPLETE: PASSED
        float steps = 10; 

        float posX = start.transform.position.x; 
        float posY = start.transform.position.y; 
        float posZ = start.transform.position.z; 

        float incX = (finish.transform.position.x - start.transform.position.x) / steps;
        float incY = (finish.transform.position.y - start.transform.position.y)/steps;
        float incZ = (finish.transform.position.z - start.transform.position.z)/steps;
        
        for(int i = 0; i <= steps; i++)
        {
            Instantiate(tile, new Vector3(posX, posY, posZ), Quaternion.Euler(0f, 0f, 0f));
            posX += incX; 
            posY += incY;
            posZ += incZ; 
        }

    }

    private void testGemini()
    {
    UnityEngine.Random.InitState(12);
    int width = 21; 
    int height = 21; 
    
    if (width % 2 == 0) 
        width++;
    if (height % 2 == 0) 
        height++;

    // Initialize grid with Walls (1)
    int [,] mazeGrid = new int[width, height];
    for (int x = 0; x < width; x++)
    {
        for (int y = 0; y < height; y++)
        {
            mazeGrid[x, y] = 1;
        }
    }

        // Recursive Backtracker Data
    Stack<Vector2Int> stack = new Stack<Vector2Int>();
    
    // Start at (1, 1)
    Vector2Int startPos = new Vector2Int(1, 1);
    mazeGrid[startPos.x, startPos.y] = 0;
    stack.Push(startPos);

    while (stack.Count > 0)
    {
        Vector2Int current = stack.Peek();
        List<Vector2Int> neighbors = GetUnvisitedNeighbors(current);

        if (neighbors.Count > 0)
        {
            // 1. Choose random neighbor
            Vector2Int chosen = neighbors[UnityEngine.Random.Range(0, neighbors.Count)];

            // 2. Remove the wall between current and chosen
            // We are jumping 2 steps, so the wall is at the midpoint
            Vector2Int wallPos = current + (chosen - current) / 2;
            mazeGrid[wallPos.x, wallPos.y] = 0;

            // 3. Mark chosen neighbor as floor
            mazeGrid[chosen.x, chosen.y] = 0;

            // 4. Push chosen to stack
            stack.Push(chosen);
        }
        else
        {
            // Dead end -> Backtrack
            stack.Pop();
        }
    }


    List<Vector2Int> GetUnvisitedNeighbors(Vector2Int p)
    {
        List<Vector2Int> list = new List<Vector2Int>();

        // Check Up, Down, Left, Right (2 steps away)
        Vector2Int[] directions = { Vector2Int.up * 2, Vector2Int.down * 2, Vector2Int.left * 2, Vector2Int.right * 2 };

        foreach (var dir in directions)
        {
            Vector2Int neighbor = p + dir;

            // Check bounds (ensure we don't go off the grid)
            if (neighbor.x > 0 && neighbor.x < width - 1 && neighbor.y > 0 && neighbor.y < height - 1)
            {
                // If it's a Wall (1), it hasn't been visited as a path yet
                if (mazeGrid[neighbor.x, neighbor.y] == 1)
                {
                    list.Add(neighbor);
                }
            }
        }
        return list;
    }

    
    
    // Loop through the array and instantiate prefabs
    for (int x = 0; x < width; x++)
    {
        for (int y = 0; y < height; y++)
        {
            Vector3 pos = new Vector3(x, 0, y);
            GameObject prefab = (mazeGrid[x, y] == 1) ? tile : wall4;
            
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
    }
}