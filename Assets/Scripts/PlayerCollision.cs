using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

