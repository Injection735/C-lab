using C_SHARP_LABS.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Command
{
	interface ICommand
	{
		List<ILanguage> Excecute(List<ILanguage> languages);
	}
}
