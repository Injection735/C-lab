using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	struct ProgrammingLanguageData
	{
		public string paradigm;
		public string typification;

		public ProgrammingLanguageData(string paradigm, string typification)
		{
			this.paradigm = paradigm;
			this.typification = typification;
		}
	}
}
