using Assets.Scripts;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{

    public static ManagerScript Instance { get; private set; }
    public static int Counter;
    


    // Use this for initialization
    void Start()
    {
        Counter = GameManager.punkty;
        Instance = this;
        Leaderboards.ReportScore(GameManager.punkty);
    }

    public void RestartGame()
    {
        PlayGameScript3.AddScoreToLeaderboard(GPGSIds.leaderboard_highscoretable, Counter);
        

    }

}