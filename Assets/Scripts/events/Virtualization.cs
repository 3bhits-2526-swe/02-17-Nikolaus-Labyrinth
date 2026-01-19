/*
    this script manages the virtualization event, which marks an area on the map 

    @author: wek56ur@gmail.com
    @date: 2026-01-08

*/

using System.Collections.Generic;
using UnityEngine;

public class Virtualization : MonoBehaviour
{

    // takes in generated map and updates material of tiles in zone
    private float range = 5f; 
    float totPassedTime = 0f; 


    void Start()
    {

    }

    
    
    void Update()
    {
       //updates the virtualization zone every few seconds
        
        totPassedTime += Time.deltaTime; 
    }

    private void checkForNearbies()
    {
        
    }

    private void applyVirtualization(List<GameObject> ls)
    {
        
    }
    
}