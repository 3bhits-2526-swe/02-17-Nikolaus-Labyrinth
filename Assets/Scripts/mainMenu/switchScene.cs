using UnityEngine;
using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class switchScene : MonoBehaviour
{
    public void GoToScene(string scene)
    {
        //load singlePlayerScene
        SceneManager.LoadScene(scene);
    }   
}