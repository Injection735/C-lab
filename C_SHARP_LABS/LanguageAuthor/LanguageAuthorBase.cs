using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.LanguageAuthor
{
	abstract class LanguageAuthorBase : IAuthor
	{
		protected List<ILanguage> languages;
		protected string country;
		protected string authorName;

		public LanguageAuthorBase(ILanguage language, string country, string authorName)
		{
			this.country = country;	
			this.authorName = authorName;
			languages = new List<ILanguage>();
			languages.Add(language);
		}

		public LanguageAuthorBase(List<ILanguage> languages, string country, string authorName)
		{
			this.country = country;
			this.authorName = authorName;
			this.languages = languages;
		}

		public string GetLanguagesData()
		{
			string result = "";

			foreach(ILanguage language in languages)
				result += language.GetData() + "\n";
			
			return result;
		}

		public ILanguage CreateLanguage(string languageName, int creationYear, Object data)
		{
			if (data.GetType() == typeof(ProgrammingLanguageData))
				return CreateLanguage(languageName, creationYear, (ProgrammingLanguageData) data);
			else if (data.GetType() == typeof(AccessoryLanguageData))
				return CreateLanguage(languageName, creationYear, (AccessoryLanguageData) data);

			return null;
		}

		public ILanguage CreateLanguage(string languageName, int creationYear, ProgrammingLanguageData data)
		{
			return new ProgrammingLanguage(languageName, creationYear, data.paradigm, data.typification);
		}

		public ILanguage CreateLanguage(string languageName, int creationYear, AccessoryLanguageData data)
		{
			return new AccessoryLanguage(languageName, creationYear, data.formatType, data.standart);
		}

		public ProgrammingLanguage InheritanceLanguage(ProgrammingLanguage language, string languageName, int creationYear, ProgrammingLanguageData data)
		{
			ProgrammingLanguage inheritLanaguage = new ProgrammingLanguage
			(
				languageName: languageName == "" ? language.GetName() : languageName,
				creationYear: creationYear == 0 ? language.GetDate() : creationYear,
				paradigm: data.paradigm == "" ? language.GetParadigm() : data.paradigm,
				typification: data.typification == "" ? language.GetTypification() : data.typification
			);

			inheritLanaguage.parentLanguage = language;

			LanguageData.languages.Add(inheritLanaguage);

			return inheritLanaguage;
		}

		public AccessoryLanguage InheritanceLanguage(AccessoryLanguage language, string languageName, int creationYear, AccessoryLanguageData data)
		{
			AccessoryLanguage inheritLanaguage = new AccessoryLanguage
			(
				languageName: languageName == "" ? language.GetName() : languageName,
				creationYear: creationYear == 0 ? language.GetDate() : creationYear,
				formatType: data.formatType == "" ? language.GetFormatType() : data.formatType,
				standart: data.standart == "" ? language.GetStandart() : data.standart
			);

			inheritLanaguage.parentLanguage = language;

			LanguageData.languages.Add(inheritLanaguage);

			return inheritLanaguage;
		}

		public void ChangeCountry(string country)
		{
			this.country = country;
		}

		abstract public string GetData();
	}
}
