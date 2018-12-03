using C_SHARP_LABS.Language;
using C_SHARP_LABS.LanguageAuthor;
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
			AuthorData.init();

			Console.WriteLine(LanguageData.languages[0].GetData());
			Console.WriteLine(LanguageData.languages[2].GetData());

			Console.WriteLine(AuthorData.authors[0].GetData());
			Console.WriteLine(AuthorData.authors[2].GetData());

			AccessoryLanguageData dataAccessory = new AccessoryLanguageData("Markup language", "W3C HTML 5.2");
			ProgrammingLanguageData dataProgramming = new ProgrammingLanguageData("OOP", "static strong");

			LanguageData.languages.Add((AuthorData.authors[2] as LanguageAuthorBase).CreateLanguage("NEW NAME", 2018, dataAccessory));
			LanguageData.languages.Add((AuthorData.authors[3] as LanguageAuthorBase).CreateLanguage("NEW NAME", 2018, dataProgramming));



			Console.Read();
		}
	}
}