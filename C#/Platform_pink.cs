using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Platform_pink : MonoBehaviour
 {
    public float speed = 100f;
    private Rigidbody2D PRigidbody; 
    private Vector2 VecL;
    private Vector2 VecR;
    private int round = 1;
    
 
       // Start is called before the first frame update
    void Start()
    {
        PRigidbody = GetComponent<Rigidbody2D>();
        VecL= new Vector2(-1, 0);
        VecR= new Vector2(1, 0);
    }

    private void FixedUpdate()
    {
        if(transform.position.x > 2.4) round = 0; 
        if(transform.position.x < -2.4)  round = 1;

        if(round==0) PRigidbody.velocity = VecL * speed * Time.deltaTime;
        if(round==1) PRigidbody.velocity = VecR * speed * Time.deltaTime;
    }
   /*   private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            var MoveFox = collision.gameObject.GetComponent<MoveFox>();
            MoveFox.isJumping = false;     
        }
    }
           private void OnCollisionExit2D(Collision2D collision)
    {
        {
            var MoveFox = collision.gameObject.GetComponent<MoveFox>();
            MoveFox.isJumping = true;     
        }
    }
    */
}

