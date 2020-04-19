using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int ScoreValue;
    public static int nazwadodatkowa;
    Text score2;

    // Use this for initialization
    void Start()
    {
        score2 = GetComponent<Text>();
        ScoreValue = GameManager.punkty;
        score2.text = "Score: " + ScoreValue;

    }

    // Update is called once per frame
    void Update()
    {
        score2.text = "Score: " + ScoreValue;
    }
}
