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
			Customer[] customerArray = new Customer[fileLines]; // makes an array of Customers, length given by fileLines in constructor
			int counter = 0; //used to assign an array pointer for each line of the file to the customerArray 
			String myLine; // pointer to a line in the file
			String[] words; // an array for splitting each line

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
						if ((words[5] != null) && (words[5].Equals("VIP"))) // handles a line for a VIP customer
						{
							// creates a VIPCustomer object if conditionals are true
							customerArray[counter] = new VIPCustomer(firstName, lastName, dob, id, balance);
						} 
					}
					else
						{
							// otherwise a Customer object is created and added to the array
							customerArray[counter] = new Customer(firstName, lastName, dob, id, balance);
						}
						
						counter++;
				} // end of reading file
			}
			// If the file is not found an error will be displayed.
			catch (FileNotFoundException e) 
			{
				Console.WriteLine (e.Message);
			}

			return customerArray;
		}
	}
}

