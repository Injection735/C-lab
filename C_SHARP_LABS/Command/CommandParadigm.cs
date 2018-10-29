using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	class CommandParadigm : CommandBase
	{
		public CommandParadigm(string type, List<string> parameters) : base(type, parameters)
		{
		}

		public override List<ILanguage> Excecute(List<ILanguage> languages)
		{
			List<ILanguage> languageList = new List<ILanguage>();
			for (int i = 0; i < languages.Count; i++)
			{
				if (!(languages[i] is ProgrammingLanguage))
					continue;

				if (parameters.Contains((languages[i] as ProgrammingLanguage).paradigm) || parameters.Count == 0)
					languageList.Add(languages[i]);
			}

			return languageList;
		}
	}
}
