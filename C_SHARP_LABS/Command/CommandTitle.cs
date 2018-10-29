using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	class CommandTitle : CommandBase
	{
		public const string TITLE = "title";
		public CommandTitle(string type, List<string> parameters) : base(type, parameters)
		{
		}

		public override List<ILanguage> Excecute(List<ILanguage> languages)
		{
			List<ILanguage> languageList = new List<ILanguage>();
			for (int i = 0; i < languages.Count; i++)
			{
				for (int j = 0; j < parameters.Count; j++)
				{
					if (parameters[j].Length > (languages[i] as LanguageBase).title.Length)
						continue;

					if (parameters[j].ToLower() == (languages[i] as LanguageBase).title.Substring(0, parameters[j].Length).ToLower())
						languageList.Add(languages[i]);
				}
			}

			return languageList;
		}
	}
}
