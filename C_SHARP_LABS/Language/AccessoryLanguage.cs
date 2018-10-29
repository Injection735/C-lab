using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class AccessoryLanguage : ILanguage
	{
		public readonly string paradigm = "NONE";

		public string title;
		public string date;

		public AccessoryLanguage(string title, string date = "")
		{
			this.title = title;	
			this.date = date;
		}

		public string GetData => title + " " + date;
		
	}
}
