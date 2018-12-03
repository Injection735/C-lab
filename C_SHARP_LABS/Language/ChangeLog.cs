using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	class ChangeLog
	{
		private List<string> features;
		private string description;
		private string version;

		public ChangeLog(List<string> features, string description, string version)
		{
			this.features = features;
			this.description = description;
			this.version = version;
		}

		public string GetLog()
		{
			string result = "version " + version + " " + description + "\n";
			
			foreach(string feature in features)
				result += "- " + feature + "\n";
			
			return result;
		}
	}
}
