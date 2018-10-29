using C_SHARP_LABS.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	static class CommandParser
	{
		private const string ERROR = "ERROR";

		public static void Parse(string command)
		{
			List<ICommand> commands = new List<ICommand>();

			for (int i = 0; i < command.Length; i++)
			{
				if (command[i] == ' ')
					continue;

				if (command[i] == '-')
				{
					i++;
					string parsedCommand = ReadCommand(command, ref i);
					List<string> parameters = ReadParameters(command, ref i);

					commands.Add(CommandData.GetCommand(parsedCommand, parameters));
					i--;
				}
			}
			CommandData.ExcecuteCommand(commands);
		}

		private static string ReadCommand(string commands, ref int i)
		{
			string command = "";

			while (i < commands.Length && commands[i] != ' ')
			{
				command += commands[i];
				i++;
			}
			return command.ToLower();
		}

		private static List<string> ReadParameters(string commands, ref int i)
		{
			string param = "";
			List<string> parameters = new List<string>();

			while (i < commands.Length && commands[i] != '-')
			{
				if (commands[i] == ' ' && param != "")
				{
					parameters.Add(param);
					param = "";
					continue;
				}
				if (commands[i] != ' ')
					param += commands[i];
				i++;
			}
			if (param != "")
				parameters.Add(param.ToLower());
			return parameters;
		}
	}
}
