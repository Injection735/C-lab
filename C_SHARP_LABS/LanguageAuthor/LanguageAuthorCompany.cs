using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.LanguageAuthor
{
	class LanguageAuthorCompany : LanguageAuthorBase
	{
		private const string AUTHOR_TYPE = "company";

		protected List<string> founders;
		protected int foundationDate;

		public LanguageAuthorCompany(ILanguage language, string country, string companyName, int foundationDate, List<string> founders) : base(language, country, companyName)
		{
			this.founders = founders;
			this.foundationDate = foundationDate;
		}
		public override string GetData()
		{
			string result = ""; 

			foreach (string founder in founders)
				result += founder + " ";
			
			return AUTHOR_TYPE + " " + authorName + " " + language.GetData() + " " + country + " " + foundationDate + " " + result + "\n";
		}
	}
}
