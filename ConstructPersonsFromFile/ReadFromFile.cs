using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConstructPersonsFromFile
{
	public static class ReadFromFile
	{
		public static Person[] personList(){
			
			Person[] personArray = new Person[10];
			int counter = 0;
			String myLine;
			String[] words; 
			// The task of this program is to read the file line by line
			try
			{
				TextReader tr = new StreamReader(new FileStream("/home/alex/Temp/personlist.txt", FileMode.Open, FileAccess.Read)); // Make sure you added "using System.IO"

				while ((myLine = tr.ReadLine()) != null)
				{
					
					words = myLine.Split(' '); 

					String firstName = words[0];
					String lastName = words[1];
					String dob = words[2];
					int id = int.Parse(words[3]);

					Person p = new Person(firstName, lastName, dob, id);
					personArray[counter] = p;

					counter++;
				} //end of reading the file
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine(e.Message);
			}
			return personArray;
		}
	}
}

