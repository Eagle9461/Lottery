using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectLuckyNumber
{
    enum ExtraTime
    {
        Morning,
        Midday,
        Evening,
        Night
    }
    enum GameType 
    {
        Pick3,
        Pick4,
        Pick5,
        Pick6,
        MegaMillions,
        PowerBall,
    }

    internal class OneData
    {
        private DateTime datetime;
        private ExtraTime extraTime;
        private int[] numbers;
        
        public OneData()
        {
            numbers = new int[6];
        }

        public DateTime GetDateTime () { return datetime; }
        public void SetDateTime(DateTime datetime) { this.datetime = datetime; }
        public int[] GetNumbers () { return numbers;}
        public void SetNumbers(int[] numbers) { this.numbers = numbers; }
        public ExtraTime GetExtraTime() {  return extraTime; }
        public void SetExtraTime(ExtraTime extraTime) { this.extraTime = extraTime; }
    }
}
