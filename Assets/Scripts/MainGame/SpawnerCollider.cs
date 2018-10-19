using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCollider : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.tag == "HorSpawner")
        //{
        //    Debug.Log("CONTACT MADE");
        //    if (HorizontalEnemySpawner.moveRight)
        //    {
        //        HorizontalEnemySpawner.moveRight = false;
        //        HorizontalEnemySpawner.moveLeft = true;
        //    }
        //    if (HorizontalEnemySpawner.moveLeft)
        //    {
        //        HorizontalEnemySpawner.moveLeft = false;
        //        HorizontalEnemySpawner.moveRight = true;
        //    }
        //}
    }
}
