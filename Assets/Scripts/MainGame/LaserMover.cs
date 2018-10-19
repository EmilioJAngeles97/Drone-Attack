using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMover : MonoBehaviour {

    public float laserSpeed;
    public float laserTimeLimit;

    public static int numOfEnemiesDestroyed;
    public static bool enemyDestroyed;

    public GameObject explosionAnimation;

    // Use this for initialization
    void FixedUpdate ()
    {
        this.transform.Translate(Vector2.up * laserSpeed * Time.deltaTime);
	}

    void Start()
    {
        StartCoroutine(DestroyLaser());
        enemyDestroyed = false;
    }

    IEnumerator DestroyLaser()
    {
        yield return new WaitForSeconds(laserTimeLimit);
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            numOfEnemiesDestroyed += 1;
            enemyDestroyed = true;
            Instantiate(explosionAnimation, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            if (Score.enemiesDestroyedNumber == 6)
            {
                HorizontalEnemySpawner.difficulty--;
                EnemyLaserMover.enemyLaserSpeed++;
            }
            if (Score.enemiesDestroyedNumber == 12)
            {
                HorizontalEnemySpawner.difficulty--;
                EnemyLaserMover.enemyLaserSpeed++;
            }
            if (Score.enemiesDestroyedNumber == 20)
            {
                HorizontalEnemySpawner.difficulty--;
                EnemyLaserMover.enemyLaserSpeed++;
            }
            if (Score.enemiesDestroyedNumber == 30)
            {
                HorizontalEnemySpawner.difficulty--;
                EnemyLaserMover.enemyLaserSpeed++;
            }
            if (Score.enemiesDestroyedNumber == 40)
            {
                HorizontalEnemySpawner.difficulty--;
                EnemyLaserMover.enemyLaserSpeed++;
            }
        }
    }
}
