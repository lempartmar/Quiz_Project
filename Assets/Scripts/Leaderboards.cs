using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Leaderboards: MonoBehaviour
    {

        public static Leaderboards Instance;

        private void Awake()
        {
            if (Instance == null) {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);
        }

        public  void Init()
        {

            // Enable debugging output (recommended)
            PlayGamesPlatform.DebugLogEnabled = true;

            PlayGamesPlatform.Activate();
            LogIn();

        }
        public void LogIn()
        {
            Social.localUser.Authenticate((bool success) =>
            {
                if (success)
                {
                    Debug.Log("Login Sucess");
                }
                else
                {
                    Debug.Log("Login failed");
                }
            });
        }



        public void OnShowLeaderBoard()
        {
            //        Social.ShowLeaderboardUI (); // Show all leaderboard

            if (!Social.localUser.authenticated)
            {
                LogIn();
            }

                ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI(GPGSIds.leaderboard_highscoretable); // Show current (Active) leaderboard
        }
        /// <summary>
        /// Adds Score To leader board
        /// </summary>
        public void OnAddScoreToLeaderBorad(int score)
        {
            if (Social.localUser.authenticated)
            {
                Social.ReportScore(score, GPGSIds.leaderboard_highscoretable, (bool success) =>
                {
                    if (success)
                    {
                        Debug.Log("Update Score Success");

                    }
                    else
                    {
                        Debug.Log("Update Score Fail");
                    }
                });
            }
        }
    }
}
