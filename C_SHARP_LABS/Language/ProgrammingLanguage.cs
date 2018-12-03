using C_SHARP_LABS.LanguageAuthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class ProgrammingLanguage : LanguageBase
	{
		public ILanguage parentLanguage;

		public string paradigm;
		public string typification;

		public ProgrammingLanguage(string languageName, int creationYear, string paradigm, string typification) : base(languageName, creationYear)
		{
			this.paradigm = paradigm;
			this.typification = typification;
		}

		public override string GetData() => languageName + " " + creationYear + " " + paradigm + " " + typification + "\n";
		
		public string GetTypification() => typification;
		public string GetParadigm() => paradigm;
	}
}
