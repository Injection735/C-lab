using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	class CommandError : CommandBase
	{
		public CommandError() : base("", new List<string>())
		{
		}

		public override List<ILanguage> Excecute(List<ILanguage> languages = null)
		{
			Console.WriteLine("ERROR WRONG COMMAND TYPE");
			return new List<ILanguage>();
		}
	}
}
