using System;
using System.Collections.Generic;
using System.Text;

namespace TenisDojo
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
    }
}
