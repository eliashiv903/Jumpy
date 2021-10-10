using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveFox : MonoBehaviour
{
   public float speed = 16f;
  public float jumpSpeed = 14f;
  private float movement = 0f;
  private Rigidbody2D rigidBody;
  public bool isJumping = false;
  private int SideRotate = 1; 
  private GameController MyGameController;
  public bool IsLive; 
  private int ScoreM;

  public static int delay; // delay to remove platform
  public int d;
  private float CreateLimitUp = 0;
  private float CreateLimitDown = -0.4f;
  public GameObject Platform;
  public GameObject PinkPlatform;
  public GameObject RedPlatform;

  private float x = 1;

  public AudioSource AudioSource;

  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
    MyGameController = GameController.Instance;
    IsLive = true;
    float y = -5;
    for (int i = 0 ; i<5; i++){
      var randX = Random.Range(-2.20f, 2.20f);
      var randomPos = new Vector2(randX, y + 2f + (float)2*i);
      Instantiate(Platform, randomPos, Quaternion.identity);
      }
    }

  void Update() {

   if (IsLive) GameRun(); 

  }
    void GameRun(){
    movement = Input.GetAxis ("Horizontal");
    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
      if (SideRotate == 2){
        transform.Rotate(0, 180 , 0);
        SideRotate = 1;
      }
      
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
      if (SideRotate == 1){
        transform.Rotate(0, 180 , 0);
        SideRotate = 2;
      }
    } 
    
      if(Input.GetButtonDown ("Jump")){
     if (isJumping == false || transform.position.y < -3) {
        rigidBody.velocity = new Vector2(0,jumpSpeed);
        AudioSource.Play();
        isJumping = true;
    }
    }
    if(transform.position.x < -2.83) transform.localPosition= new Vector3(2.80f,transform.position.y,0);
    if(transform.position.x > 2.83) transform.localPosition= new Vector3(-2.80f,transform.position.y,0);
    
    ScoreM = (int)transform.position.y * 125; 
    if(MyGameController.Score <ScoreM) MyGameController.Score = ScoreM;
      


     if (transform.position.y <= CreateLimitUp && CreateLimitDown <= transform.position.y){
     for (int i = 0 ; i<5; i++){
        
        var randX = Random.Range(-2.20f, 2.20f);
        int randkind = Random.Range(0, 20);
        GameObject draw; 
        if (i == 0 || i == 1){
        if (randkind > 10) draw = Platform;
        else { 
            if (randkind < 3) draw = PinkPlatform;
                else draw = RedPlatform;
        }
        }
        else{
            if (randkind > 7) draw = Platform;
            else draw = PinkPlatform;
        }
        
        var randomPos = new Vector2(randX, transform.position.y + 8f + (float)2*i);
        Instantiate(draw, randomPos, Quaternion.identity);
        }

      CreateLimitUp+= 10f;
      CreateLimitDown+= 10f;
    }
  }  
}
