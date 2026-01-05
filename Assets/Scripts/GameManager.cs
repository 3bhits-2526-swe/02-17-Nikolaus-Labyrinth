using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int zahl = 0; 
    [SerializeField] Text text; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
