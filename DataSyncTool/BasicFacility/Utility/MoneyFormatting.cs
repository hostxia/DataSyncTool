/// <copyright from='2003' to='2010' company='Bizsolution'>
///    Copyright(c) Bizsolution All rights reserved
/// </copyright>
//******************************************************************************
// File Name: MoneyFormatting.cs
//  Function: 处理格式
//    coder:Jone(2010-04-23)
//      Date: 2010-04-21
//******************************************************************************
using System;

namespace BasicFacility.Utility
{
    public class MoneyFormatting
    {
        /// <summary>
        /// Convert Chinese Capital chars
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        static public string ToChineseWords(decimal inputNumber)
        {
            string sInput = Math.Round(inputNumber, 2).ToString();
            string sRe = "";
            if (sInput.Length == 0) return "";
            string sMinus = "";
            if (System.Convert.ToDecimal(sInput) < 0)
            {
                sMinus = "负";
                sInput.Replace("-", "");
            }
            sInput = sInput.Replace(".", "");
            sInput = sInput.Replace(",", "");
            int j = 1;

            for (int i = 0; i < sInput.Length; i++)
            {
                string sMyNum = NumberToChineseCapital(sInput[i].ToString());
                string sUnit = "";
                switch (sInput.Length + 1 - j)
                {
                    case 1:
                        sUnit = sMyNum + "分";
                        break;
                    case 2:
                        sUnit = sMyNum + "角";
                        break;
                    case 3:
                        sUnit = sMyNum + "元";
                        if (sUnit == "零元")
                        {
                            sUnit = "元";
                        }
                        break;
                    case 4:
                        sUnit = sMyNum + "拾";
                        if (sUnit == "零拾")
                        {
                            sUnit = "零";
                        }
                        break;
                    case 5:
                        sUnit = sMyNum + "佰";
                        if (sUnit == "零佰")
                        {
                            sUnit = "零";
                        }
                        break;
                    case 6:
                        sUnit = sMyNum + "仟";
                        if (sUnit == "零仟")
                        {
                            sUnit = "零";
                        }
                        break;
                    case 7:
                        sUnit = sMyNum + "万";
                        break;
                    case 8:
                        sUnit = sMyNum + "拾";
                        break;
                    case 9:
                        sUnit = sMyNum + "佰";
                        break;
                    case 10:
                        sUnit = sMyNum + "仟";
                        break;
                }
                sRe = sRe + sUnit;
                j++;
            }
            sRe = sMinus + sRe;
            sRe = sRe.Replace("零角零分", "");
            sRe = sRe.Replace("零零零零零", "零");
            sRe = sRe.Replace("零零零零", "零");
            sRe = sRe.Replace("零零零", "零");
            sRe = sRe.Replace("零零", "零");
            //if (sRe.IndexOf("角") == -1 && sRe.IndexOf("分") == -1)
            {
                sRe = sRe + "整";
            }
            return sRe;
        }

        /// <summary>
        /// Get number capital (0 -- 9)
        /// </summary>
        /// <param name="sNumber"></param>
        /// <returns></returns>
        static private string NumberToChineseCapital(string sNumber)
        {
            switch (sNumber)
            {
                case "0":
                    return "零";
                case "1":
                    return "壹";
                case "2":
                    return "贰";
                case "3":
                    return "叁";
                case "4":
                    return "肆";
                case "5":
                    return "伍";
                case "6":
                    return "陆";
                case "7":
                    return "柒";
                case "8":
                    return "捌";
                case "9":
                    return "玖";
            }
            return "";
        }

        // Single-digit and small number names
        static private string[] _smallNumbers = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        // Tens number names from twenty upwards
        static private string[] _tens = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        // Scale number names for use during recombination
        static private string[] _scaleNumbers = new string[] { "", "Thousand", "Million", "Billion" };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        static public string ToEnglishWords(decimal inputNumber)
        {
            string sInput = Math.Round(inputNumber, 2).ToString();
            if (sInput.Length == 0) return "";

            string[] sInputArr = sInput.Split(new char[] {'.'});
            if (sInputArr.Length == 0) return "";

            string dollarNum = "", centNum = "";
            
            if(sInputArr[0].Length > 0)
                dollarNum = NumberToWords(Convert.ToInt32(sInputArr[0]));

            if (sInputArr.Length == 2 && sInputArr[1].Length > 0)
                centNum = NumberToWords(Convert.ToInt32(sInputArr[1]));

            if ((dollarNum != "" && dollarNum != "Zero") && (centNum != "" && centNum != "Zero"))
            {
                return string.Format("{0}, and {1} Cent(s) Only", dollarNum, centNum);
            }
            else if((dollarNum != "" && dollarNum != "Zero") && (centNum == "" || centNum == "Zero"))
            {
                return string.Format("{0} Only", dollarNum);
            }
            else if((dollarNum == "" || dollarNum == "Zero") && (centNum != "" && centNum != "Zero"))
            {
                return string.Format("{0} Cent(s) Only", centNum);
            }

            else
            {
                return "";
            }
        }

        /// <summary>
        /// Converts an integer value into English words
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static private string NumberToWords(int number)
        {
            // Zero rule
            if (number == 0)
                return _smallNumbers[0];

            // Array to hold four three-digit groups
            int[] digitGroups = new int[4];

            // Ensure a positive number to extract from
            int positive = Math.Abs(number);

            // Extract the three-digit groups
            for (int i = 0; i < 4; i++)
            {
                digitGroups[i] = positive % 1000;
                positive /= 1000;
            }

            // Convert each three-digit group to words
            string[] groupText = new string[4];

            for (int i = 0; i < 4; i++)
                groupText[i] = ThreeDigitGroupToWords(digitGroups[i]);

            // Recombine the three-digit groups
            string combined = groupText[0];
            bool appendAnd;

            // Determine whether an 'and' is needed
            appendAnd = (digitGroups[0] > 0) && (digitGroups[0] < 100);

            // Process the remaining groups in turn, smallest to largest
            for (int i = 1; i < 4; i++)
            {
                // Only add non-zero items
                if (digitGroups[i] != 0)
                {
                    // Build the string to add as a prefix
                    string prefix = groupText[i] + " " + _scaleNumbers[i];

                    if (combined.Length != 0)
                        prefix += appendAnd ? " and " : ", ";

                    // Opportunity to add 'and' is ended
                    appendAnd = false;

                    // Add the three-digit group to the combined string
                    combined = prefix + combined;
                }
            }

            // Negative rule
            if (number < 0)
                combined = "Negative " + combined;

            return combined;
        }

        /// <summary>
        /// Converts a three-digit group into English words
        /// </summary>
        /// <param name="threeDigits"></param>
        /// <returns></returns>
        static private string ThreeDigitGroupToWords(int threeDigits)
        {
            // Initialise the return text
            string groupText = "";

            // Determine the hundreds and the remainder
            int hundreds = threeDigits / 100;
            int tensUnits = threeDigits % 100;

            // Hundreds rules
            if (hundreds != 0)
            {
                groupText += _smallNumbers[hundreds] + " Hundred";

                if (tensUnits != 0)
                    groupText += " and ";
            }

            // Determine the tens and units
            int tens = tensUnits / 10;
            int units = tensUnits % 10;

            // Tens rules
            if (tens >= 2)
            {
                groupText += _tens[tens];
                if (units != 0)
                    groupText += " " + _smallNumbers[units];
            }
            else if (tensUnits != 0)
                groupText += _smallNumbers[tensUnits];

            return groupText;
        }
    }
}