﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotEating : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.instance.IncrementScore();
          
        }
        else if (collision.gameObject.tag == "groundbase")
        {
            Destroy(gameObject);
            //missiedexplosion particle effects
            GameManager.instance.DecrementScore();
        }




    }

   
}
