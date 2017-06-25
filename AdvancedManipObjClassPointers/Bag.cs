using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedManipObjClassPointers
{
	public class Bag
	{
		private String brand;
		private double price;
		private double capacity;
		private double volume;
		public Person owner;

		public Bag(String brand, double price, double capacity, double volume, Person p)
		{
			this.brand = brand;
			this.price = price;
			this.capacity = capacity;
			this.volume = volume;
			owner = p;
		} // End of second constructor
			
		public void displayInfo()
		{
			Console.WriteLine(" The information related to this person");
			Console.WriteLine(" Brand: " +brand);
			Console.WriteLine(" Price: " +price);
			Console.WriteLine(" Capacity: " +capacity);
			Console.WriteLine(" Volume: " +volume);
			Console.WriteLine(" The first name of the owner: " + owner.AccessFirstName); //Writing the first name of the owner
		} // End of the displayInfo method
	}
}

