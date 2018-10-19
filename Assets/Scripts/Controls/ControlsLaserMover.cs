using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsLaserMover : MonoBehaviour {
    
    public float laserSpeed;
    public float laserTimeLimit;

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
            enemyDestroyed = true;
            Instantiate(explosionAnimation, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
