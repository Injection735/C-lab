using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	class CommandHelp : CommandBase
	{
		private Dictionary<string, string> commands = new Dictionary<string, string>()
		{
			{ "-title, -t", "Поиск по имени или по первым символам"},
			{ "-paradigm, -p", "Поиск по парадигме"},
			{ "-date, -d", "Поиск дате создания"},
		};

		public CommandHelp() : base("help", new List<string>())
		{
		}

		public override List<ILanguage> Excecute(List<ILanguage> languages = null)
		{
			foreach (string command in commands.Keys)
				Console.WriteLine(command + " " + commands[command]);
			
			return new List<ILanguage>();
		}
	}
}
