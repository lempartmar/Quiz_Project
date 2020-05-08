using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text factText;


    public GameObject Szansa1;
    public GameObject Szansa2;

    public GameObject Szansa1Resume;
    public GameObject Szansa2Resume;

    public Text LiczbaPunktow;
    public Text LiczbaPunktowResume;
    public Text LiczbaLevel;
    public Text LiczbaLevelResume;

    public float currentTime = 0f;
    public float startTime;
    public bool isactive = false;
    [SerializeField] Text countdownText;

    public Question[] questions_1;
    public Question[] questions_2;
    public Question[] questions_3;
    public Question[] questions_4;
    public Question[] questions_5;
    public Question[] questions_6;

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;


    private Question currentQuestion;


    public int punktyL = 0;
    string punktyL2;
    int level = 1;
    int szanse = 1;

    public static int punkty = 0;
    //public int punkty = 0;
    string punkty2;



    void Reset()
    {
        punkty = 0;
    }

    void Start()
    {
        SetCurrentQuestion();
        currentTime = startTime;
        Reset();



        Debug.Log("Liczba szans to: " + szanse);
    }



    // Update is called once per frame
    void Update()
    {

        if (isactive)
        {
            currentTime = 9f;
        }
        isactive = false;
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0.0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene(5);
        }



    }



    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, 8);
        if (level == 1)
        {
            currentQuestion = questions_1[randomQuestionIndex];
            // Debug.Log("pytanie: " + currentQuestion.fact);
            factText.text = currentQuestion.fact;
            LiczbaPunktow.text = "Points: " + punkty.ToString();
            LiczbaPunktowResume.text = "Points: " + punkty.ToString();
            LiczbaLevel.text = "Level: " + level.ToString();
            LiczbaLevelResume.text = "Level: " + level.ToString();
        }

        else if (level == 2)
        {
            currentQuestion = questions_2[randomQuestionIndex];
            // Debug.Log("pytanie: " + currentQuestion.fact);
            factText.text = currentQuestion.fact;
            LiczbaPunktow.text = "Points: " + punkty.ToString();
            LiczbaPunktowResume.text = "Points: " + punkty.ToString();
            LiczbaLevel.text = "Level: " + level.ToString();
            LiczbaLevelResume.text = "Level: " + level.ToString();
        }
        else if (level == 3)
        {
            currentQuestion = questions_3[randomQuestionIndex];
            // Debug.Log("pytanie: " + currentQuestion.fact);
            factText.text = currentQuestion.fact;
            LiczbaPunktow.text = "Points: " + punkty.ToString();
            LiczbaPunktowResume.text = "Points: " + punkty.ToString();
            LiczbaLevel.text = "Level: " + level.ToString();
            LiczbaLevelResume.text = "Level: " + level.ToString();
        }

        else if (level == 4)
        {
            currentQuestion = questions_4[randomQuestionIndex];
            // Debug.Log("pytanie: " + currentQuestion.fact);
            factText.text = currentQuestion.fact;
            LiczbaPunktow.text = "Points: " + punkty.ToString();
            LiczbaPunktowResume.text = "Points: " + punkty.ToString();
            LiczbaLevel.text = "Level: " + level.ToString();
            LiczbaLevelResume.text = "Level: " + level.ToString();
        }
        else if (level == 5)
        {
            currentQuestion = questions_5[randomQuestionIndex];
            // Debug.Log("pytanie: " + currentQuestion.fact);
            factText.text = currentQuestion.fact;
            LiczbaPunktow.text = "Points: " + punkty.ToString();
            LiczbaPunktowResume.text = "Points: " + punkty.ToString();
            LiczbaLevel.text = "Level: " + level.ToString();
            LiczbaLevelResume.text = "Level: " + level.ToString();
        }
    }

    public void DodawaniePunktowdoLeveli()
    {

        punktyL++;
        punktyL2 = punktyL.ToString();
        Debug.Log("Liczba punktow: " + punktyL);
        if (punktyL == 7)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }

        else if (punktyL == 14)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }
        else if (punktyL == 21)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }
        else if (punktyL == 28)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }
        else if (punktyL == 35)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }
        else if (punktyL == 42)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }
        else if (punktyL == 49)
        {
            level++;
            PojawienieEkranuPrzerwy();
        }
        Debug.Log("Level gry: " + level);
        SetCurrentQuestion();
    }


    public void UserSelectTrue()
    {
        if (currentQuestion.isTrue)
        {
            // Debug.Log("Correct!");
            punkty = punkty + 50;
            DodawaniePunktowdoLeveli();
        }
        else
        {

            //SceneManager.LoadScene(2);
            szanse--;
        }
        zarzadzanieszansami();
        zakonczeniegry();

        isactive = true;
        SetCurrentQuestion();
        //        isactive = true;
        Debug.Log("Liczba szans to: " + szanse);
    }


    public void UserSelectFalse()
    {
        if (!currentQuestion.isTrue)
        {
            punkty = punkty + 50;
            DodawaniePunktowdoLeveli();

        }
        else
        {
            //SceneManager.LoadScene(2);
            szanse--;
        }
        zarzadzanieszansami();
        zakonczeniegry();
        isactive = true;
        SetCurrentQuestion();
        //      isactive = true;
        Debug.Log("Liczba szans to: " + szanse);
    }

    public void zakonczeniegry()
    {

        if (szanse == 0)
        {
            SceneManager.LoadScene(5);
        }

    }

    public void zarzadzanieszansami()
    {
        if (szanse == 1)
        {
            Szansa2.SetActive(false);
        }
    }

    public void Przerwa()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    void PojawienieEkranuPrzerwy()
    {

        if (GameIsPaused)
        {
            Przerwa();
        }
        else
        {
            Pause();
        }



    }







}