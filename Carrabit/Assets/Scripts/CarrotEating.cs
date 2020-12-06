using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotEating : MonoBehaviour
{
    public GameObject hedgehog;
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
            Destroy(gameObject);

        else if (collision.gameObject.tag == "groundbase")
        {
            thorns();
        }
        else if (collision.gameObject.tag == "Thorns")
        {
             Destroy(gameObject);
        }

        void thorns()
        {
            Instantiate(hedgehog, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

   
}
