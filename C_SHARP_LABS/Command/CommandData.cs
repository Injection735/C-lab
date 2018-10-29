using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	static class CommandData
	{
		public const string TITLE = "title";
		public const string PARADIGM = "paradigm";
		public const string DATE = "date";
		public const string HELP = "help";   
		public const string ALL = "all";

		public static void init()
		{
		}

		public static void ExcecuteCommand(List<ICommand> commands)
		{
			if (commands.FindLast((command) => (command as CommandBase).type == CommandBase.ERROR) != null || commands.Count == 0)
			{
				new CommandError().Excecute();
				return;
			}

			List<ILanguage> languages = LanguageData.GetAllLanguages();

			foreach (ICommand command in commands)
				languages = command.Excecute(languages);
			
			foreach (ILanguage language in languages)
				Console.WriteLine(language.GetData);
		}
		
		public static ICommand GetCommand(string type, List<string> parameters)
		{
			switch(type)
			{
				case "t":
				case TITLE:
					return new CommandTitle(type, parameters);
				case "p":
				case PARADIGM:
					return new CommandParadigm(type, parameters);
				case "d":
				case DATE:
					return new CommandDate(type, parameters);
				case "h":
				case HELP:
					return new CommandHelp(type);
				case ALL:
					return new CommandAll(type);
				default:
					return new CommandError();
			}
		}
	}
}
