using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraControll : MonoBehaviour
 {
    public static CameraControll Instance;
    public GameObject Player;
    public int Smoothvalue =2;
    private float up; 

    void Update()
    {
        if (up <= Player.transform.position.y){
            if (Player.transform.position.y > 0){
                Vector3 Targetpos = new Vector3(0, Player.transform.position.y + 2, -100);
                 transform.position = Vector3.Lerp(transform.position, Targetpos, Time.deltaTime * Smoothvalue);       
       }
        up = Player.transform.position.y;
        }
        if (Player.transform.position.y < transform.position.y - 5) {
            Player.GetComponent<MoveFox>().IsLive = false; 
            
        }
    }
}
