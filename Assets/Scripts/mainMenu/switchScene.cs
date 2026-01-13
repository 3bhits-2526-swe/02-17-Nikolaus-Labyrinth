/*
    scene switcher

    @author: wek56ur@gmail.com
    @date: 2026-01-08

*/

using UnityEngine;
using UnityEngine.SceneManagement; 

public class switchScene : MonoBehaviour
{
    public void GoToScene(string scene)
    {
        //maybe add some effect while changing scene
        SceneManager.LoadScene(scene);
    }   
}