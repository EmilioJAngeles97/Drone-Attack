using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldWrap : MonoBehaviour { 

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            var newPosition = transform.position;

            if (other.gameObject.transform.position.y > 46)
            {
                newPosition.y = -other.gameObject.transform.position.y + 6;
                newPosition.x = other.gameObject.transform.position.x;
            }

            if (other.gameObject.transform.position.y < -42)
            {
                newPosition.y = -other.gameObject.transform.position.y;
                newPosition.x = other.gameObject.transform.position.x;
            }

            if (other.gameObject.transform.position.x > 61) 
            {
                newPosition.x = -other.gameObject.transform.position.x + 2;
                newPosition.y = other.gameObject.transform.position.y;
            }

            if (other.gameObject.transform.position.x < -61)
            {
                newPosition.x = -other.gameObject.transform.position.x - 3;
                newPosition.y = other.gameObject.transform.position.y;
            }

            other.gameObject.transform.position = newPosition;
        }
    }
}
