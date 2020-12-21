﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove the object
        if(transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!!");
            Destroy(this.gameObject);
        }
    }
}
