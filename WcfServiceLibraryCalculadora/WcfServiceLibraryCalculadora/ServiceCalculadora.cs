using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibraryCalculadora
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class ServiceCalculadora : IServiceCalculadora
	{
		public int suma(int num1, int num2)
		{
			int res;

			res = num1 + num2;
			return res;
		}
	}
}
