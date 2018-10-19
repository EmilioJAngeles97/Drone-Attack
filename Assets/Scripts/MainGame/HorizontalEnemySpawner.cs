using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalEnemySpawner : MonoBehaviour {

    public float speed;

    public GameObject enemy;
    public GameObject enemyEmitter;

    //public int spawnRange;

    private Rigidbody2D rb2d;
    public static float difficulty;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        difficulty = 7f;
        InvokeRepeating("spawnEnemy", 2f, difficulty);
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(speed, 0.0f);
        //Debug.Log("Moveing Right: " + moveRight);
        //Debug.Log("Moveing Left: " + moveLeft);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "SpawnerBoundary")
        {
            speed = -speed;
        }
    }

    void spawnEnemy()
    {
        //spawnRange = Random.Range(0, 10);
        //Debug.Log(spawnRange);
        //if (spawnRange >= difficulty)
        //{
        //    GameObject tempEnemy;
        //    tempEnemy = Instantiate(enemy, enemyEmitter.transform.position, enemyEmitter.transform.rotation) as GameObject;
        //}
            Instantiate(enemy, enemyEmitter.transform.position, enemyEmitter.transform.rotation);
    }
}
