using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Debug.Log("Hello");
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("*quits*");
        Application.Quit();
    }
}
