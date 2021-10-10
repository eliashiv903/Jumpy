using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Vanish_Platform : MonoBehaviour
{
    public GameObject BluePlatform;
    public ParticleSystem ps; 
    public GameObject Player;

   void Start()
    {   
       var MoveFox = Player.GetComponent<MoveFox>();
       Invoke("destroyplatform", 3.5f);
}

void destroyplatform()
    {
              ps.Play();
              Destroy(BluePlatform, 2);
       }
    }

