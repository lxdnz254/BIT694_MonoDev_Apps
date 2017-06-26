using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
	public static class ReadFromFile
	{
		public static Customer[] customerList(String fileLocation, int fileLines)
		{
			Customer[] customerArray = new Customer[fileLines];
			int counter = 0;
			String myLine;
			String[] words;

			try 
			{
				TextReader tr = new StreamReader(fileLocation);

				while ((myLine = tr.ReadLine()) != null)
				{
					words = myLine.Split(',');
					String firstName = words[0];
					String lastName = words[1];
					String dob = words[2];
					int id = int.Parse(words[3]);
					double balance = double.Parse(words[4]);
					if (words.Length > 5) {
						if ((words[5] != null) && (words[5].Equals("VIP")))
						{
							customerArray[counter] = new VIPCustomer(firstName, lastName, dob, id, balance);
						} 
					}
					else
						{
							customerArray[counter] = new Customer(firstName, lastName, dob, id, balance);
						}
						
						counter++;
				} // end of reading file
			}
			catch (FileNotFoundException e) 
			{
				Console.WriteLine (e.Message);
			}

			return customerArray;
		}
	}
}

