/*
    This script uses the maze obj to handle each and every event happening on it

    @author: wek56ur@gmail.com
    @date: 2025-12-17

*/
using UnityEngine; 

public class EventManager
{
    [SerializeField] int width; 
    [SerializeField] int length; 
   
    [SerializeField] int aggressiveness; //scales timing

    [SerializeField] GameObject santa; 
    [SerializeField] GameObject gift; 

    //option to spawn new scene
    //option to spawn new scene2

    //array with good coords of maze

    private float totTimePassed = 0; 
    void Start()
    {
        //gen maze done by Generator.cs
        //maybe check if santa + gift scene are initialized and can be loaded
    }

    void Update()
    {   
        totTimePassed += Time.deltaTime; 
        //inits event after random time passed
    }
}