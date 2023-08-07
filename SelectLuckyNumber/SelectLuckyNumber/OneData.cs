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
        private GameType gameType;
        private DateTime datetime;
        private ExtraTime extraTime;
        private int extraNumber;
        private int[] numbers;
        
        public OneData()
        {
            numbers = new int[6];
        }

        public OneData(GameType gameType) { numbers = new int[6]; }
        public GameType GetGameType() { return gameType; }
        public void SetGameType(GameType gameType) {  this.gameType = gameType; }
        public DateTime GetDateTime () { return datetime; }
        public void SetDateTime(DateTime datetime) { this.datetime = datetime; }
        public int[] GetNumbers () { return numbers;}
        public void SetNumbers(int[] numbers) { this.numbers = numbers; }
        public ExtraTime GetExtraTime() {  return extraTime; }
        public void SetExtraTime(ExtraTime extraTime) { this.extraTime = extraTime; }
        public int GetExtraNumber() {  return extraNumber; }
        public void setExtraNumber(int extraNumber) {  this.extraNumber = extraNumber; }
        
        public string convertToString()
        {
            string str = "";
            str += datetime.ToString(); str += " ";
            str += gameType; str += " ";
            str += extraTime.ToString(); str += " ";
            foreach (int number in numbers)
            {
                str += number.ToString(); str += ", ";
            }
            str += extraNumber.ToString(); str += " ";
            return str;
        }
    }
}
