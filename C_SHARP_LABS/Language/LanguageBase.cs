using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class LanguageBase : ILanguage
	{
		public string title;
		public string date;

		public LanguageBase(string title, string date = "")
		{
			this.title = title;
			this.date = date;
		}

		public virtual string GetData => title + " " + date;
	}
}
