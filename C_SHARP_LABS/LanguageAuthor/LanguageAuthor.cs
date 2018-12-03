using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.LanguageAuthor
{
	class LanguageAuthor : LanguageAuthorBase
	{
		private const string AUTHOR_TYPE = "single author";

		private List<string> awards;
		private int birthYear;

		public LanguageAuthor(ILanguage language, string country, string authorName, int birthYear, List<string> awards) : base(language, country, authorName)
		{
			this.awards = awards;
			this.birthYear = birthYear;
		}

		public override string GetData() 
		{
			string result = "";

			foreach(string award in awards)
				result += award + " ";	

			return AUTHOR_TYPE + " " + authorName + " " + GetLanguagesData() + " " + country + " " + birthYear + " " + result + "\n";
		}

		public void GetAward(string award)
		{
			awards.Add(award);
		}

		public void GetAward(List<string> awards)
		{
			foreach (string aw in awards)
				this.awards.Add(aw);
		}
	}
}