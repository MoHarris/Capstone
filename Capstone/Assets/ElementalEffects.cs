﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalEffects : MonoBehaviour
{

    public float liftForce = 10;
    private Rigidbody2D rb;
       
    // Start is called before the first frame update
    void Start()
    {         
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerStay2D(Collider2D other)
    {

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        var player = other.gameObject.GetComponent<PlayerMovement>();

        if (other.tag == "Player" && player.isGliding)
        {
            Debug.Log("Trigger Occured");
            rb.velocity = Vector2.up * liftForce;
        }    
    }
}
