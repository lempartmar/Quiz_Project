using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScroreSend : MonoBehaviour
{
    string CreateUserURL = "http://spofily.pl/InsertUser2.php";
    public static int ScoreValue2;
    public InputField namefield;
    public string charname;
    public static int randomnumber2;

    Text score3;

    // Use this for initialization
    void Start()
    {
        score3 = GetComponent<Text>();
        ScoreValue2 = GameManager.punkty;
    }


    // Update is called once per frame
    void Update()
    {
        // score3.text = "Score: " + ScoreValue2;

    }

    public void User()
    {
        randomnumber2 = Random.Range(1, 1000000000);
        charname = namefield.text;
        CreateUser(ScoreValue2, charname, randomnumber2);

        //Application.LoadLevel(5);     
    }

    public void CreateUser(int punkciki, string name, int uzytk)
    {
        WWWForm form = new WWWForm();
        form.AddField("scorePost", punkciki);
        form.AddField("usernamePost", name);
        form.AddField("uzytkownikPost", uzytk);


        WWW www = new WWW(CreateUserURL, form);
    }

    public void NextSceneWebpage()
    {
        Application.LoadLevel(3);
    }

    public void HyperlinkWebPage()
    {
        Application.OpenURL("https://www.spofily.pl");

    }

    //metoda reprezentująca możliwość przejścia do pierwszej sceny + reset ustawień

    public void Restarttofirstscene()
    {

        Application.LoadLevel(0);
    }

}