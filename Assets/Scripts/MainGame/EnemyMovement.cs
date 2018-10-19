using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyMovement : MonoBehaviour {

    public Transform target;

    public float speed;

    public GameObject enemyLaser;
    public GameObject enemyLaserTurret;
    public GameObject explosionAnimation;

    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("fireLaser", 2f, 2f);
    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        transform.right = target.position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if (Input.GetKey(KeyCode.Space))
        {
            fireLaser();
        }
    }

    void fireLaser()
    {
        Instantiate(enemyLaser, enemyLaserTurret.transform.position, enemyLaserTurret.transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(explosionAnimation, other.gameObject.transform.position, other.gameObject.transform.rotation);
            Instantiate(explosionAnimation, this.gameObject.transform.position, this.gameObject.transform.rotation);
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
