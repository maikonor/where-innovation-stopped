using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // method loads character creator
    public void PlayGame ()
    {
        SceneManager.LoadScene("Character Creator");
        Debug.Log("Play game");
    }
    // method quits game
    public void QuitGame ()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }

}
