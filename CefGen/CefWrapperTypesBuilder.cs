using System.IO;
using CefGen.CodeDom;

namespace CefGen
{
	class CefWrapperTypesBuilder : ApiBuilderBase
	{
		public string Namespace { get; set; }

		public string BaseDirectory { get; set; }

		public CodeFile Build()
		{
			CodeFile codefile = CreateCodeFile("libcef_dll/wrapper_types.h");
			codefile.Imports.Clear();
			var ns = new CodeNamespace(Namespace);
			codefile.Namespaces.Add(ns);
			CreateEnum(ns);
			return codefile;
		}

		private void CreateEnum(CodeNamespace ns)
		{
			var decl = new CodeEnum("CefWrapperType");
			decl.Type = "int";
			decl.Attributes = CodeAttributes.Public;
			decl.Comments.AddVSDocComment("CEF wrapper types", "summary");

			bool inEnum = false;
			foreach (string line in File.ReadLines(Path.Combine(BaseDirectory, "libcef_dll", "wrapper_types.h")))
			{
				string s = line.Trim();
				if (inEnum)
				{
					if (s.Length == 0)
						continue;

					decl.Members.Add(new CodeEnumItem(s.Substring(3, s.Length - (s.EndsWith(',') ? 4 : 3)).ToLowerInvariant().ToUpperCamel(true), null));
					if (s == "WT_LAST")
						break;
				}
				else
				{
					if (s.StartsWith("WT_BASE_REF_COUNTED"))
					{
						inEnum = true;
						decl.Members.Add(new CodeEnumItem("BaseRefCounted", s.Split('=')[1].TrimStart().TrimEnd(',')));
					}
				}
			}

			ns.Types.Add(decl);
		}
	}
}
