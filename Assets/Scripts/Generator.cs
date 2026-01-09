/*
    this script is responsible for generating levels with good paths 

    @author: wek56ur@gmail.com
    @date: 2026-01-08

*/

using UnityEngine;
using System.Collections.Generic;

public class Generator : MonoBehaviour
{
    //takes models wall4 - wall2 & tile and generates usable path with it 

    [SerializeField] GameObject wall4; 
    [SerializeField] GameObject wall3; 
    [SerializeField] GameObject wall2; 
    [SerializeField] GameObject tile; 

    [SerializeField] GameObject finish; //path that should be reached

    [SerializeField] GameObject start; //beginning of path


    private void generatePath(string seed)
    {
        /* 
            calc size (AxB) 
            create array 
            generate correct path 
            insert walls 
            extend walls and add tiles
        */
        
        float size = (finish.transform.position.x - start.transform.position.x) * (finish.transform.position.y - start.transform.position.y ) * 2; //to make the field thiccer 
        List <int[]> coords = new List<int[]>(); //x first, y last

        for(int i = 0; i < (finish.transform.position.x - start.transform.position.x); i++)
        {
            for(int j = 0; j < (finish.transform.position.y - start.transform.position.y)*2; j++)
            {   
                int[] ray = {i,j};
                coords.Add(ray); 
            }    
        }
    
        //lists contain all possible x and y values -> deleted from the list after being chosen to ensure integrity 

        GameObject[] field = new GameObject[20]; 
        
    }
 
    
}