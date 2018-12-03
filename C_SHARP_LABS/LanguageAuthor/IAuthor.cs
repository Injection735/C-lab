using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.LanguageAuthor
{
	interface IAuthor
	{
		string GetData();
		ILanguage CreateLanguage(string languageName, int creationYear, Object data);
	}
}
