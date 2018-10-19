using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsLaserSpawner : MonoBehaviour {

    public GameObject laser;
    public GameObject laserEmitter;

    public int spawnRate;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("spawnLaser", 2f, spawnRate);
    }

    void spawnLaser()
    {
        Instantiate(laser, laserEmitter.transform.position, laserEmitter.transform.rotation);
    }
}
