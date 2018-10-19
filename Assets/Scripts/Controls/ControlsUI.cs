using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsUI : MonoBehaviour {

	public void Back ()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
