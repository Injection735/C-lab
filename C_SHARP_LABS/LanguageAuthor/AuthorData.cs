using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.LanguageAuthor
{
	static class AuthorData
	{
		private static List<IAuthor> authorList;

		public static void init()
		{
			authorList = new List<IAuthor>();

			List<ILanguage> languageList = LanguageData.languages;

			authorList.Add(new LanguageAuthor(languageList[2], "Denmark", "Straustrup", 1950, new List<string>(new string[] { "Faraday Medal", "Charles Stark Draper Prize" })));
			authorList.Add(new LanguageAuthor(languageList[1], "USA", "Douglas Crockford", 1955, new List<string>(new string[] { })));
			authorList.Add(new LanguageAuthor(languageList[4], "France", "Alain Colmerauer", 1941, new List<string>(new string[] { })));

			authorList.Add(new LanguageAuthorCompany(languageList[0], "USA", "Internet Engineering Task Force", 1986, new List<string>(new string[] { "Jari Arkko" })));
			authorList.Add(new LanguageAuthorCompany(languageList[3], "USA",  "Microsoft", 1975, new List<string>(new string[] { "Paul Allen", "Bill Gates" })));
		}

		public static List<IAuthor> authors
		{
			get
			{
				if (authorList == null)
					init();
				return authorList;
			}
			set
			{
				authorList = value;
			}
		}
	}
}
