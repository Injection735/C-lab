using C_SHARP_LABS.LanguageAuthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class AccessoryLanguage : LanguageBase
	{
		public ILanguage parentLanguage;

		public string formatType;
		public string standart;

		public AccessoryLanguage(string languageName, int creationYear, string formatType, string standart) : base(languageName, creationYear)
		{
			this.formatType = formatType;
			this.standart = standart;
		}

		public override string GetData() => languageName + " " + creationYear + " " + formatType + " " + standart + "\n";
		public string GetFormatType() => formatType;
		public string GetStandart() => standart;
	}
}
