using C_SHARP_LABS.LanguageAuthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	static class LanguageData
	{
		public const int NONE = -1;
		
		private static List<ILanguage> languageList;

		public static void init()
		{
			languageList = new List<ILanguage>();

			languageList.Add(new AccessoryLanguage("HTML", 1993, "Markup language", "W3C HTML 5.2"));
			languageList.Add(new AccessoryLanguage("JSON", 2000, "Data exchange", "RFC 8259"));

			languageList.Add(new ProgrammingLanguage("C++", 1983, "OOP", "static strong"));
			languageList.Add(new ProgrammingLanguage("C#", 2000, "OOP", "static strong"));
			languageList.Add(new ProgrammingLanguage("Prolog", 1972, "Functional", "no typefication"));
		}

		public static List<ILanguage> languages
		{
			get
			{
				if (languageList == null)
					init();
				return languageList;
			}
			set
			{
				languageList = value;
			}
		}

		public static int findIndexByName(string name)
		{
			for (int i = 0; i < languageList.Count; i++)
				if (languageList[i].GetName() == name)
					return i;

			return NONE;
		}
	}
}
