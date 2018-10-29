using C_SHARP_LABS.Command;
using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	abstract class CommandBase : ICommand
	{
		public const string ERROR = "ERROR";

		public string type
		{
			get => _type == "" ? ERROR : _type; 
			set
			{
				_type = value;
			}
		}

		protected string _type;
		protected List<string> parameters;

		public CommandBase(string type, List<string> parameters)
		{
			this.type = type;	
			this.parameters = parameters;
		}

		public abstract List<ILanguage> Excecute(List<ILanguage> languages);
	}
}
