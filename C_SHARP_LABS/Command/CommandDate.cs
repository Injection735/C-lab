using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	class CommandDate : CommandBase
	{
		public CommandDate(string type, List<string> parameters) : base(type, parameters)
		{
		}

		public override List<ILanguage> Excecute(List<ILanguage> languages)
		{
			List<ILanguage> languageList = new List<ILanguage>();
			for (int i = 0; i < languages.Count; i++)
			{
				if (!(languages[i] is LanguageBase))
					continue;
				if (parameters.Contains((languages[i] as LanguageBase).date))
					languageList.Add(languages[i]);
			}

			return languageList;
		}
	}
}
