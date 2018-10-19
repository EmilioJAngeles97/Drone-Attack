using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyLaserMover : MonoBehaviour
{
    public static float enemyLaserSpeed;
    public float enemyLaserTimeLimit;

    public GameObject explosionAnimation;

    // Use this for initialization
    void Start()
    {
        enemyLaserSpeed = 10;
        StartCoroutine(DestroyLaser());
    }

    void FixedUpdate()
    {
        this.transform.Translate(Vector2.up * enemyLaserSpeed * Time.deltaTime);
    }

    IEnumerator DestroyLaser()
    {
        yield return new WaitForSeconds(enemyLaserTimeLimit);
        Destroy(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(explosionAnimation, other.gameObject.transform.position, other.gameObject.transform.rotation);
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
            Invoke("WaitForExplosion", 1f);
        }
    }

    void WaitForExplosion()
    {
        SceneManager.LoadScene("GameOver");
    }
}
