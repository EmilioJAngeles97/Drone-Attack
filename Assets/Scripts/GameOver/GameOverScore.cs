using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

    public Text finalScoreText;
    public int finalScore;

    void Start()
    {
        finalScore = Score.enemiesDestroyedNumber;
        finalScoreText.text = "You destroyed\n" + finalScore.ToString() + " Drones!";
    }
}