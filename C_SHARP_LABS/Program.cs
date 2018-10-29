using C_SHARP_LABS.Command;
using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS
{
	class Program
	{
		static void Main(string[] args)
		{
			LanguageData.init();
			while(true)
			{
				string command = Console.ReadLine();
				CommandParser.Parse(command);
			}
		}
	}
}