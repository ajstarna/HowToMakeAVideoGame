﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log(collision.collider.name);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
