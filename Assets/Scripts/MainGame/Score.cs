using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour { 

    public static int enemiesDestroyedNumber;
    public bool enemyHit;

    public Text enemiesDestroyedText;

    // Use this for initialization
    void Start () {
        enemiesDestroyedNumber = 0;
        LaserMover.numOfEnemiesDestroyed = 0;
        enemyHit = false;
        SetEnemiesDestroyedText();
    }
	
	// Update is called once per frame
	void Update () {
        enemiesDestroyedNumber = LaserMover.numOfEnemiesDestroyed;

        if (LaserMover.enemyDestroyed == true)
        {
            SetEnemiesDestroyedText();
        }
    }

    void SetEnemiesDestroyedText()
    {
        enemiesDestroyedText.text = "Enemies Destroyed: " + enemiesDestroyedNumber.ToString();
    }

}
