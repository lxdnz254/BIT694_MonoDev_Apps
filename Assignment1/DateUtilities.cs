using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment1
{
	public static class DateUtilities
	{
		static String DateRegEx(String date)
		{
			// remove any day suffixes (st, nd, rd, th) - only if follows number!
			String pattern = @"\b(\d+)(?:st|nd|rd|th)\b";
			Regex rgx = new Regex (pattern);
			return rgx.Replace (date, "$1");
		}
		
		public static String DateFormat (String date)
		{
			// Check the date format for st, nd, rd, th at end of day numbers and remove
			String rDate = DateRegEx(date);
			// Try and parse the the rDate into a DateTime object
			if (DateTime.TryParse (rDate, out DateTime parsedDate)) {
				return parsedDate.Day + "/" + String.Format ("{0:D2}", parsedDate.Month) + "/" + parsedDate.Year;
			} else {
				// There must be something else wrong with the date format
				Console.WriteLine ("Error trying to parse date: " + rDate);
				return rDate;
			}
		}

		public static Boolean IsLeapYear(String date)
		{
			// Check the date format for st,nd,rd,th at end of day numbers and remove
			String rDate = DateRegEx (date);
			// Try and parse the rDate into a DateTime object
			if (DateTime.TryParse (rDate, out DateTime parsedDate)) 
			{
				int year = parsedDate.Year;
				if (((year % 400) == 0) || (((year % 4) == 0) && ((year % 100) != 0)))
				{
					return true;
				}
				return false;
			} else {
				// There mus be something else wrong with the date format
				Console.WriteLine ("Error trying to parse date: " + rDate);
				return false;
			}
		}

		public static Boolean IsBirthday(String date)
		{
			// Check the date format for st, nd, rd, th at end of day numbers and remove
			String rDate = DateRegEx (date);
			// Try and parse the rDate into  DateTime object
			if (DateTime.TryParse (rDate, out DateTime parsedDate)) 
			{
				if (parsedDate.DayOfYear.Equals (DateTime.Now.DayOfYear)) {
					return true;
				}
				return false;
			} else {
				// There must be something else wrong with the date format
				Console.WriteLine ("Error trying to parse date: " + rDate);
				return false;
			}
		}

		public static int GetYoungest(Customer[] array)
		{
			int pos = 0;
			for (int i = 1; i < array.Length; i++) 
			{
				String iDate = DateRegEx(array[i].AccessDob);
				String posDate = DateRegEx (array [pos].AccessDob);
				if (DateTime.TryParse (iDate, out DateTime parsedDate)) {
					if (DateTime.TryParse (posDate, out DateTime posParsedDate)) 
					{
						int diff = parsedDate.CompareTo (posParsedDate);
						if (diff > 0) {
							pos = i;
						}
							
					} else {
						Console.WriteLine("Error trying to parse date: " +posDate);
					}

				} else {
					Console.WriteLine ("Error trying to parse date: " + iDate);
				}
			}

			return pos;
		}

		public static String GetZodiac(String date)
		{
			String zDate = DateRegEx (date);
			String zodiacSign = "";
			if (DateTime.TryParse (zDate, out DateTime parsedDate))
				{
					int day = parsedDate.Day;
					int month = parsedDate.Month;
					switch (month) 
					{
				case 1:
					if (day <= 19) {
						zodiacSign = "Capricorn";
					} else {
						zodiacSign = "Aquarius";
					}
					break;
				case 2:
					if (day <= 18) {
						zodiacSign = "Aquarius";
					} else {
						zodiacSign = "Pisces";
					}
					break;
				case 3:
					if (day <= 20) {
						zodiacSign = "Pisces";
					} else {
						zodiacSign = "Aries";
					}
					break;
				case 4:
					if (day <= 19) {
						zodiacSign = "Aries";
					} else {
						zodiacSign = "Taurus";
					}
					break;
				case 5:
					if (day <= 20) {
						zodiacSign = "Taurus";
					} else {
						zodiacSign = "Gemini";
					}
					break;
				case 6:
					if (day <= 20) {
						zodiacSign = "Gemini";
					} else {
						zodiacSign = "Cancer";
					}
					break;
				case 7:
					if (day <= 22) {
						zodiacSign = "Cancer";
					} else {
						zodiacSign = "Leo";
					}
					break;
				case 8:
					if (day <= 22) {
						zodiacSign = "Leo";
					} else {
						zodiacSign = "Virgo";
					}
					break;
				case 9:
					if (day <= 22) {
						zodiacSign = "Virgo";
					} else {
						zodiacSign = "Libra";
					}
					break;
				case 10:
					if (day <= 22) {
						zodiacSign = "Libra";
					} else {
						zodiacSign = "Scorpio";
					}
					break;
				case 11:
					if (day <= 21) {
						zodiacSign = "Scorpio";
					} else {
						zodiacSign = "Saggitarius";
					}
					break;
				case 12:
					if (day <= 21) {
						zodiacSign = "Saggitarius";
					} else {
						zodiacSign = "Capricorn";
					}
					break;
					}
				}
				else {
					Console.WriteLine ("Error trying to parse date: " + zDate);
					zodiacSign = "";
				}
			return zodiacSign;
		}
	}
}

