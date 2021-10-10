using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Lava_Move : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float movement = 320f;
    private Vector2 Vec;
    public GameObject Player; 
    public AudioSource AudioSource;
    
    
    
    void Start()
    {
    rigidBody = GetComponent<Rigidbody2D>();
    Vec= new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.transform.position.y > -3)  rigidBody.velocity = Vec * movement * Time.deltaTime; 
        if (Player.transform.position.y > transform.position.y + 16)  rigidBody.velocity = Vec * 1000 * Time.deltaTime; 
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
        if(collision.gameObject.tag == "Player"){
            var MoveFox = Player.GetComponent<MoveFox>();
            MoveFox.IsLive = false; 
            AudioSource.Play();
            Invoke("backmenu", 0.5f);
            
         }
    }
    void backmenu(){
        SceneManager.LoadScene("Menu");
    }
}