﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag== "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
