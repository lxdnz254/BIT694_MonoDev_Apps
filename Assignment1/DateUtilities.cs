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
		static String dateRegEx(String date)
		{
			// remove any day suffixes (st, nd, rd, th) - only if follows number!
			String pattern = @"\b(\d+)(?:st|nd|rd|th)\b";
			Regex rgx = new Regex (pattern);
			return rgx.Replace (date, "$1");
		}
		
		public static String dateFormat (String date)
		{
			// Check the date format for st, nd, rd, th at end of day numbers and remove
			String rDate = dateRegEx(date);
			// set up a DateTime object
			DateTime parsedDate;
			// Try and parse the the rDate into the DateTime object
			if (DateTime.TryParse (rDate, out parsedDate)) {
				return parsedDate.Day + "/" + String.Format ("{0:D2}", parsedDate.Month) + "/" + parsedDate.Year;
			} else {
				// There must be something else wrong with the date format
				Console.WriteLine ("Error trying to parse date: " + rDate);
				return rDate;
			}
		}

		public static Boolean isLeapYear(String date)
		{
			// Check the date format for st,nd,rd,th at end of day numbers and remove
			String rDate = dateRegEx (date);
			// set up a DateTime object
			DateTime parsedDate;
			// Try and parse the rDate into the DateTime object
			if (DateTime.TryParse (rDate, out parsedDate)) 
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

		public static Boolean isBirthday(String date)
		{
			// Check the date format for st, nd, rd, th at end of day numbers and remove
			String rDate = dateRegEx (date);
			// set up a DateTime object
			DateTime parsedDate;
			// Try and parse the rDate into the DateTime object
			if (DateTime.TryParse (rDate, out parsedDate)) 
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

		public static int getYoungest(Customer[] array)
		{
			int pos = 0;
			for (int i = 1; i < array.Length; i++) 
			{
				String iDate = dateRegEx(array[i].AccessDob);
				String posDate = dateRegEx (array [pos].AccessDob);
				DateTime posParsedDate;
				DateTime parsedDate;
				if (DateTime.TryParse (iDate, out parsedDate)) {
					if (DateTime.TryParse (posDate, out posParsedDate)) 
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

		public static String getZodiac(String date)
		{
			String zDate = dateRegEx (date);
			String zodiacSign = "";
			DateTime parsedDate;
			if (DateTime.TryParse (zDate, out parsedDate))
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

