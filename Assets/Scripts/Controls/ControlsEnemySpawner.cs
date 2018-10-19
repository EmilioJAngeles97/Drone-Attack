using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsEnemySpawner : MonoBehaviour {

    public GameObject enemy;
    public GameObject enemyEmitter;

    public int spawnRate;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawnEnemy", 2f, spawnRate);
    }

    void spawnEnemy()
    {
        Instantiate(enemy, enemyEmitter.transform.position, enemyEmitter.transform.rotation);
    }
}
