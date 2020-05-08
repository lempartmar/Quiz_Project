using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    public static UIScript Instance { get; private set; }

    // Use this for initialization
    void Start()
    {
        Instance = this;
    }



    public void Restart()
    {
        ManagerScript.Instance.RestartGame();
    }

    public void ShowLeaderboards()
    {
        PlayGameScript3.ShowLeaderboardsUI();
    }

}
