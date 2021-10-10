using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TrigerJ : MonoBehaviour
{
     private void OnTriggerEnter2D(Collider2D collision)
    {
        {
            var MoveFox = collision.gameObject.GetComponent<MoveFox>();
            MoveFox.isJumping = false;     
        }
    }
           private void OnTriggerExit2D(Collider2D collision)
    {
        {
            var MoveFox = collision.gameObject.GetComponent<MoveFox>();
            MoveFox.isJumping = true;     
        }
    }
}