using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class ProgrammingLanguageBase : ILanguage
	{
		public string title;
		public string paradigm;
		public string date;

		public ProgrammingLanguageBase(string title, string paradigm, string date)
		{
			this.title = title.ToLower();
			this.paradigm = paradigm.ToLower();
			this.date = date.ToLower();
		}

		public string GetData => title + " " + paradigm + " " + date;
	}
}
