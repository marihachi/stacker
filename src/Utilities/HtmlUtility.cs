using Sgml;
using System.IO;
using System.Xml.Linq;

namespace Stacker.Utilities
{
	public static class HtmlUtility
	{
		public static XDocument Parse(TextReader reader)
		{
			using (var sgmlReader = new SgmlReader { DocType = "HTML", CaseFolding = CaseFolding.ToLower, InputStream = reader })
			{
				return XDocument.Load(sgmlReader);
			}
		}
	}
}
