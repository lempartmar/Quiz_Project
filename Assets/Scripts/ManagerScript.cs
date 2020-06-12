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
        Debug.Log(Counter);
        Instance = this;
        //Leaderboards.Instance.ReportScore(GameManager.punkty);
        Leaderboards.Instance.OnAddScoreToLeaderBorad(GameManager.punkty);
        PlayGameScript3.AddScoreToLeaderboard(GPGSIds.leaderboard_highscoretable, Counter);
    }

    public void RestartGame()
    {
        PlayGameScript3.AddScoreToLeaderboard(GPGSIds.leaderboard_highscoretable, Counter);
        

    }

    public void ShowScores()
    {
        RestartGame();
        Leaderboards.Instance.OnShowLeaderBoard();
    }
}