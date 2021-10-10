using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//to remove the first platform

public class Delete_First : MonoBehaviour
{
    public GameObject Player;
    public GameObject First;
    
    



    void Update()
    {
        if (Player.transform.position.y > 1.2) Destroy(First);
    }
}
