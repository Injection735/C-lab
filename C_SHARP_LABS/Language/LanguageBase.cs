using C_SHARP_LABS.LanguageAuthor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_LABS.Language
{
	abstract class LanguageBase : ILanguage
	{
		private const string NO_UPDATES = "Language have no updates";
		protected string languageName; 
		protected int creationYear;
		protected List<ChangeLog> changeLogs;
 
		public LanguageBase(string languageName, int creationYear)
		{
			this.languageName = languageName;
			this.creationYear = creationYear;
		}

		abstract public string GetData();

		public int GetDate() => creationYear;

		public string GetName() => languageName;

		public string GetAllChangeLogs()
		{
			if (changeLogs.Count == 0)
				return NO_UPDATES;
			else
			{
				string result = ""; 

				foreach(ChangeLog log in changeLogs)
					result += log.GetLog() + "\n";
			
				return result;
			}
		}

		public string GetLastUpdate()
		{
			if (changeLogs.Count == 0)
				return NO_UPDATES;
			return changeLogs[changeLogs.Count - 1].GetLog();
		}

		public void UpdateLanguage(ChangeLog log)
		{
			changeLogs.Add(log);
		}
	}
}
