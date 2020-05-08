using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    public void Start()
    {
        Leaderboards.Init();
    }

    public void NextScene1()
    {



    Application.LoadLevel(1);
        
    }

    public void NextScene2()
    {

        Application.LoadLevel(2);
    }


    public void NextScene3()
    {

        Application.LoadLevel(3);
    }

    public void NextScene4()
    {

        Application.LoadLevel(4);
    }

    public void NextScene5()
    {

        Application.LoadLevel(5);
    }

    public void NextScene6()
    {

        Application.LoadLevel(6);
    }

    public void NextScene7()
    {

        Application.LoadLevel(7);
    }

    public void NextScene8()
    {

        Application.LoadLevel(8);
    }

    public void NextScene9()
    {

        Application.LoadLevel(9);
    }

    public void ExitGame()
    {

        Application.Quit();
    }

    public void NextScene0()
    {



        Application.LoadLevel(0);

    }

    public void RestartGame()
    {

        Application.LoadLevel(0);
        int punktyL = 0;
        string punktyL2;
        int level = 1;
        int szanse = 2;
        int punkty = 0;
    
    }

}

