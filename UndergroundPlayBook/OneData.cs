using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndergroundPlayBook
{
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
        public string GetStrNumbers ()
        {
            string str = "";

            switch (gameType)
            {
                case GameType.Pick3:
                    for (int i = 0; i < 3; i++ )
                    {
                        str += numbers[i]; str += ", ";
                    }
                    break;
                case GameType.Pick4:
                    for (int i = 0; i < 4; i++)
                    {
                        str += numbers[i]; str += ", ";
                    }
                    break;
                    break;
                case GameType.Pick5:
                    for (int i = 0; i < 5; i++)
                    {
                        str += numbers[i]; str += ", ";
                    }
                    break;
                case GameType.Pick6:
                    for (int i = 0; i < 6; i++)
                    {
                        str += numbers[i]; str += ", ";
                    }
                    break;
                case GameType.MegaMillions:
                    for (int i = 0; i < 5; i++)
                    {
                        str += numbers[i]; str += ", ";
                    }
                    break;
                case GameType.PowerBall:
                    for (int i = 0; i < 5; i++)
                    {
                        str += numbers[i]; str += ", ";
                    }
                    break;
            }
            return str;
        }
        public void SetNumbers(int[] numbers) { this.numbers = numbers; }
        public ExtraTime GetExtraTime() {  return extraTime; }
        public void SetExtraTime(ExtraTime extraTime) { this.extraTime = extraTime; }
        public int GetExtraNumber() {  return extraNumber; }
        public void SetExtraNumber(int extraNumber) {  this.extraNumber = extraNumber; }
        
        public string ConvertToString()
        {
            string str = "";
            str += datetime.ToString(); str += "|";
            str += gameType; str += "|";
            str += extraTime.ToString(); str += "|";
            foreach (int number in numbers)
            {
                str += number.ToString(); str += ",";
            }
            str += extraNumber.ToString(); str += "";
            return str;
        }
        public void SetDataFromString(string str)
        {
            string[] strValues = str.Split('|');

            if (strValues[0] != "") SetDateTime(DateTime.Parse(strValues[0]));
            if (strValues[1] != "") SetGameType((GameType) Enum.Parse(typeof(GameType), strValues[1]));
            if (strValues[2] != "") SetExtraTime((ExtraTime)Enum.Parse(typeof(ExtraTime), strValues[2]));
            
            string[] strNumbers = strValues[3].Split(',');
            if (strNumbers.Length > 5)
            {
                int[] nums = new int[this.numbers.Length];

                for (int i = 0; i < strNumbers.Length; i++) { 
                    if(i >= 6)
                        SetExtraNumber(int.Parse(strNumbers[i]));
                    else 
                    nums[i] = int.Parse(strNumbers[i]);
                }
            
                SetNumbers(nums);
            }
        }
    }
}
