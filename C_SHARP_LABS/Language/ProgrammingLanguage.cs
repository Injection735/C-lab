using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class ProgrammingLanguage : LanguageBase
	{
		public string paradigm;

		public ProgrammingLanguage(string title, string paradigm, string date) : base(title, date)
		{
			this.paradigm = paradigm.ToLower();
		}

		public override string GetData => title + " " + paradigm + " " + date;
	}
}
