using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static float scorevalue = 0;
    public Text ScoreText;

    void Start()
    {
        scorevalue = 0f;
        
    }

    void Update ()
    {

         ScoreText.text = scorevalue.ToString("0");

	}
}
