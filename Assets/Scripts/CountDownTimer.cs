using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour
{

    public float currentTime = 0f;
    public float startTime = 15f;


    [SerializeField] Text countdownText;
    // Use this for initialization
    void Start()
    {

        currentTime = startTime;
    }



    void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0.0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene(3);
        }



    }

}

