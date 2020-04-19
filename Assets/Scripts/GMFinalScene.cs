using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMFinalScene : MonoBehaviour
{

    int punktydowyswietlenia;
    public Text punktydotekstu;
    public Text OpisPunktow;

    // Use this for initialization
    void Start()
    {

        // punktydotekstu = GetComponent<Text>();
        punktydowyswietlenia = GameManager.punkty;
        Debug.Log(punktydowyswietlenia);
    }

    // Update is called once per frame
    void Update()
    {
        punktydotekstu.text = "Score: " + punktydowyswietlenia;

        if(punktydowyswietlenia < 100)
        {
            OpisPunktow.text = "Good Work!";
        }
        else if(punktydowyswietlenia < 200)
        {
            OpisPunktow.text = "Amazing Work!";
        }
    }
}
