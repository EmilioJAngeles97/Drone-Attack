using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float fireRate;
    public float timeUntilFire;

    public GameObject laser;
    public GameObject laserTurret;

    private Rigidbody2D rb2d;

    public static bool playerDestroyed;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
        speed = 10;
        playerDestroyed = false;
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(0.0f, 0.0f);

        //Press the W key to move the RigidBody up
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(0.0f, speed);
        }

        //Press the S key to move the RigidBody down
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(0.0f, -speed);
        }

        //Press the A key to move the RigidBody Left
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-speed, 0.0f);
        }

        //Press the D key to move the RigidBody Right
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(speed, 0.0f);
        }

        //Press the D key + W key to move the RigidBody Up and Right
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(speed, speed);
        }

        //Press the D key + S key to move the RigidBody Down and Right
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(speed, -speed);
        }

        //Press the A key + W key to move the RigidBody Up and Left
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = new Vector2(-speed, speed);
        }

        //Press the A key + S key to move the RigidBody Down and Left
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            rb2d.velocity = new Vector2(-speed, -speed);
        }

        if (Input.GetMouseButtonDown(0) && Time.time > timeUntilFire)
        {
            timeUntilFire = Time.time + 1 / fireRate;
            ShootLaser();
        }

        //Debug.Log("Player X: " + gameObject.transform.position.x);
        //Debug.Log("Player Y: " + gameObject.transform.position.y);
    }

    void ShootLaser()
    {
       Instantiate(laser, laserTurret.transform.position, laserTurret.transform.rotation);
    }
}
