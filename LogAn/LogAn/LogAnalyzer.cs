using System;
namespace LogAn
{
    public class LogAnalyzer
    {
        public LogAnalyzer()
        {
        }

		public bool IsValidLogFileName(string fileName){

   
			if (String.IsNullOrEmpty(fileName))
			{
				throw new ArgumentException("filename should not be empty or null.");
			}
			if (!fileName.EndsWith(".SLF",StringComparison.CurrentCultureIgnoreCase))
			{
				return false;
			}

			return true;
		}
	}
}
