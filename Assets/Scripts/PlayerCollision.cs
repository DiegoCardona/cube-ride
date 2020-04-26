using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
 
    // Update is called once per frame
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
