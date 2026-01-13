/*
    this script manages the santa event, which circles over the map and waits to do something 

    @author: wek56ur@gmail.com
    @date: 2026-01-08

*/

using UnityEngine;

public class santas : MonoBehaviour
{
    [SerializeField] GameObject santa2; 
    [SerializeField] GameObject santa3; 
    [SerializeField] GameObject santa4; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private float accumulator = 0; 
    void Update()
    {
        float deltaTime = Time.deltaTime; 
        transform.Translate(Vector3.left * deltaTime * 7);
        santa2.transform.Translate(Vector3.left * deltaTime * 7);
        santa3.transform.Translate(Vector3.left * deltaTime * 7);
        santa4.transform.Translate(Vector3.left * deltaTime * 7);
        transform.rotation = Quaternion.Euler(accumulator, 0f, 0f);
        santa2.transform.rotation = Quaternion.Euler(accumulator, 0f, 0f);
        santa3.transform.rotation = Quaternion.Euler(accumulator, 0f, 0f);
        santa4.transform.rotation = Quaternion.Euler(accumulator, 0f, 0f);
        accumulator += deltaTime*20;         
    }
}
