
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreText : MonoBehaviour {
    private Text SText;
    private GameController MyGameController;

    void Start()
    {
        SText = GetComponent<Text>();
        MyGameController = GameController.Instance;
    }
    void Update()
    {
            if (MyGameController.Score > 0){
               SText.text = "score:" + MyGameController.Score.ToString();
            }    
        }
    }
