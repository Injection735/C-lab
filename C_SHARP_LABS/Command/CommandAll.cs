using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	class CommandAll : CommandBase
	{
		public CommandAll() : base("all", new List<string>())
		{
		}

		public override List<ILanguage> Excecute(List<ILanguage> languages = null)
		{
			return LanguageData.GetAllLanguages();
		}
	}
}

