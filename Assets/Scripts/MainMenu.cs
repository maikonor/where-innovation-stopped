using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame ()
    {
        SceneManager.LoadScene("Character Creator");
        Debug.Log("Play game");
    }

    public void QuitGame ()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }

}
