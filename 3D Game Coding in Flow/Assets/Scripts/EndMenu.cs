using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame(string scenename)
    {
        SceneManager.LoadScene("Start Scene");
    }
}
