using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delete_Platform : MonoBehaviour
{
    public GameObject CameraControll;
    private Rigidbody2D rigidBody;
      private float movement = 500f;
      private Vector2 Vec;
      private Vector2 Vec1;

    // Start is called before the first frame update
    void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>();
       Vec= new Vector2(0, 1);
       Vec1= new Vector2(0, 0);
    }

   void Update() {
     if (CameraControll.transform.position.y - 5< transform.position.y) rigidBody.velocity = Vec1 * movement * Time.deltaTime;
     if (CameraControll.transform.position.y - 5> transform.position.y) rigidBody.velocity = Vec * movement * Time.deltaTime; 
  }

  private void  OnTriggerEnter2D(Collider2D collision){

    if(collision.gameObject.tag == "Block")
  {  
      Destroy(collision.gameObject);    
  }
    if(collision.gameObject.tag == "Respawn")
  {  
      Destroy(collision.gameObject);    
  }
  }
}
