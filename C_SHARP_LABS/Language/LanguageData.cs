using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	static class LanguageData
	{
		private static List<ILanguage> languageList;

		public static void init()
		{
			languageList = new List<ILanguage>();

			languageList.Add(new AccessoryLanguage("Z2", "01"));
			languageList.Add(new AccessoryLanguage("X2", "02"));
			languageList.Add(new AccessoryLanguage("Y2", "03"));
			languageList.Add(new AccessoryLanguage("Z1", "04"));
			languageList.Add(new AccessoryLanguage("X1", "05"));
			languageList.Add(new AccessoryLanguage("Y1", "06"));

			languageList.Add(new ProgrammingLanguageBase("A1", "OOP", "1987"));
			languageList.Add(new ProgrammingLanguageBase("A2", "Logic", "1985"));
			languageList.Add(new ProgrammingLanguageBase("A3", "Functional", "1977"));
			languageList.Add(new ProgrammingLanguageBase("A4", "OOP", "1989"));
			languageList.Add(new ProgrammingLanguageBase("A5", "Logic", "1999"));
			languageList.Add(new ProgrammingLanguageBase("A6", "Functional", "1995"));
			languageList.Add(new ProgrammingLanguageBase("A7", "OOP", "2003"));
			languageList.Add(new ProgrammingLanguageBase("B1", "Logic", "2005"));
			languageList.Add(new ProgrammingLanguageBase("B2", "Functional", "2011"));
			languageList.Add(new ProgrammingLanguageBase("B3", "OOP", "1983"));
			languageList.Add(new ProgrammingLanguageBase("B4", "Logic", "2006"));
			languageList.Add(new ProgrammingLanguageBase("B5", "Functional", "2015"));
			languageList.Add(new ProgrammingLanguageBase("B6", "OOP", "1990"));
			languageList.Add(new ProgrammingLanguageBase("B7", "Logic", "1984"));
			languageList.Add(new ProgrammingLanguageBase("B8", "Functional", "1997"));
		}

		public static List<ILanguage> GetAllLanguages()
		{
			if (languageList == null)
				init();

			return languageList;			
		}
	}
}
