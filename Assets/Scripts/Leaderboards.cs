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
    static class Leaderboards
    {
        public static void Init()
        {
            PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();

            // Enable debugging output (recommended)
            PlayGamesPlatform.DebugLogEnabled = true;

            // Initialize and activate the platform
            PlayGamesPlatform.InitializeInstance(config);
            PlayGamesPlatform.Activate();
            PlayGamesPlatform.Instance.Authenticate(SignInCallback, true);
        }

        private static void SignInCallback(bool success)
        {
            if (success)
            {
                Debug.Log("(PandaUp) Signed in!");
            }
            else
            {
                Debug.Log("(PandaUp) Sign-in failed...");
            }
        }

        public static void ReportScore(int finalScore)
        {
            if (!PlayGamesPlatform.Instance.localUser.authenticated)
            {
                return;
            }

            PlayGamesPlatform.Instance.ReportScore(finalScore, GPGSIds.leaderboard_highscoretable, callback);
        }

        public static void callback(bool a)
        {
            Debug.Log("Stan operacji: " + a);
        }
    }
}
