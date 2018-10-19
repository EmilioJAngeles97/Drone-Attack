using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour {

    public void PlayAgain ()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void MainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }
}