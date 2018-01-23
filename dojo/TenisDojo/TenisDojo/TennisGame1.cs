using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TenisDojo
{

    public class TennisGame1 : ITennisGame
    {
        List<Player> PlayerList = new List<Player>();
        Player playerOne = new Player();
        Player playerTwo = new Player();
        List<string> scoreList = new List<string>() { "Love", "Fifteen", "Thirty", "Forty" };


        public string Logic(int score1, int score2)
        {


            return "aasd";
        }

        public TennisGame1(string player1Name, string player2Name)
        {
            PlayerList.Add(playerOne);
            PlayerList.Add(playerTwo);
            this.playerOne.Name = player1Name;
            this.playerTwo.Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            PlayerList.Where(p => p.Name == playerName).ToList().ForEach(p => p.Score += 1);
        }

        public string GetScore()
        {
            string score = "";
            var tempScore = 0;
            if (playerOne.Score == playerTwo.Score)
            {
                if (playerOne.Score <= 2)
                {
                    score = (scoreList.ElementAt(playerOne.Score)) + "-All";
                }
                else
                {
                    score = "Deuce";
                }
            }
            else if (playerOne.Score >= 4 || playerTwo.Score >= 4)
            {
                var minusResult = playerOne.Score - playerTwo.Score;
                if (minusResult == 1) score = "Advantage player1";
                else if (minusResult == -1) score = "Advantage player2";
                else if (minusResult >= 2) score = "Win for player1";
                else score = "Win for player2";
            }
            else
            {
                for (var i = 1; i < 3; i++)
                {
                    if (i == 1) tempScore = playerOne.Score;
                    else { score += "-"; tempScore = playerTwo.Score; }
                    score += (scoreList.ElementAt(tempScore));
                }
            }
            return score;
        }
    }
}
