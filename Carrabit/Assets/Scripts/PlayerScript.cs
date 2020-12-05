using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float speed = 0f;
    SpriteRenderer sp;
    [SerializeField] float maxPos=0f;
    bool isMove = true;
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isMove)
        {
            Move();
        }
        
        void Move()
        {
            float inputX = Input.GetAxis("Horizontal");
             transform.position += Vector3.right * inputX * speed * Time.deltaTime;

            float cl=Mathf.Clamp(transform.position.x, -maxPos, maxPos);
            transform.position=new Vector3(cl,transform.position.y, transform.position.z);

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                sp.flipX = true;
            else
                sp.flipX = false;
        }


    }
}
