/*
    This script handles any player action, such as movement or other sort of input 

    @author: wek56ur@gmail.com
    @date: 2025-12-17

*/
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{
    
    InputAction moveUp; 
    InputAction moveDown; 
    InputAction moveRight; 
    InputAction moveLeft; 

    [SerializeField] private float playerSpeed; //speed
    [SerializeField] public bool isTurn = true; 

    private float jumpTime = .5f; 
    private float timer = 0; 

    //private int points = 0; //points the player collects
    //array with items of player 
    //sike
    

    private bool Jump(float deltaTime)
    {
        if(this.direction == Vector3.zero)
            return false; 

        if (timer == 0)
        {
            //initiates timer
            timer = jumpTime; 
            //1 - timer = passed time (0-0.5)
            return true; 
        }
        if (timer > 0.5f)
        {
            //first half of timer
            float passedTime = 1 - timer; 
            transform.Translate(new Vector3(0f,passedTime,0f));
            transform.Translate((direction/(2*jumpTime))*deltaTime);
            timer -= deltaTime; 
        }
        else if(timer > 0 && timer < 0.5f)
        {
            transform.Translate((direction/(2*jumpTime))*deltaTime);
            float passedTime = 0.5f - timer; 
            transform.Translate(new Vector3(0f,-passedTime,0f));

            timer -= deltaTime; 
        }
        else if (timer < 0)
        {
            //reset of timer
            this.direction = Vector3.zero; 
            timer = 0; 
        }
        else
        {
            //another reset
            isTurn = true; 
            this.direction = Vector3.zero; 
        }
            
        return false;         
    }

    private void Teleport(float deltaTime)
    {
        if (timer <= 0)
        {
            transform.Translate(direction); 
            timer = jumpTime; 
            direction = Vector3.zero; 
        }
        else
        {
            timer -= deltaTime; 
        }
    }

    void Start()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene("GUI"); 
        // one way of getting input, not sure if its the best 
        moveUp = InputSystem.actions.FindAction("JumpUp");
        moveDown = InputSystem.actions.FindAction("JumpDown"); 
        moveRight = InputSystem.actions.FindAction("JumpRight"); 
        moveLeft = InputSystem.actions.FindAction("JumpLeft"); 
    }

    // Update is called once per frame
    private Vector3 direction = Vector3.zero; 
    // if vec == zero -> jump possible 
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        Teleport(Time.deltaTime);
        if (moveUp.ReadValue<float>() > 0 & direction == Vector3.zero)
        {
            direction = Vector3.forward;     // (0,0,1)
        }
        if (moveDown.ReadValue<float>() > 0 & direction == Vector3.zero)
        {
            direction = Vector3.back;   // (0,0,-1)
        }
        if (moveRight.ReadValue<float>() > 0 & direction == Vector3.zero)
        {
            direction = Vector3.right;  // (1,0,0)
        }
        if (moveLeft.ReadValue<float>() > 0 & direction == Vector3.zero)
        {
            direction = Vector3.left;   // (-1,0,0)
        }

    }

    void FixedUpdate()
    {
        
    }
}
