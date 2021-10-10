using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
  public int Score = 0;
    private static GameController _instance;
    public GameObject Player; 
    public static GameController Instance
    {
        get
        {
            if (_instance == null)
            {
                var obj = GameObject.FindGameObjectWithTag("GameController");
                if (obj != null)
                {
                    _instance = obj.GetComponent<GameController>();
                }
            }
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }

    void Awake()
    {
        GameController.Instance = this;
    }
}
