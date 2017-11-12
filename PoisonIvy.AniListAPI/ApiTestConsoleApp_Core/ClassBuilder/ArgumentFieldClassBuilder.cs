using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using SwitchAppDesign.AniListAPI.v2.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace ApiTestConsoleApp_Core.ClassBuilder
{
    public class ArgumentFieldClassBuilder
    {
        private const string PropertySuffix = "QueryField";
        private const string ModelNamespace = "SwitchAppDesign.AniListAPI.v2.Models";
        private const string FieldClassNamespace = "SwitchAppDesign.AniListAPI.v2.Graph.Fields";
        //private const string OutputDir = @"C:\PrivateDev\Private Repos\AniListApi\PoisonIvy.AniListAPI\SwitchAppDesign.AniListAPI.v2\Graph\Fields";
        private const string OutputDir = @"D:\PrivateDev\Private Repos\AniListApi\PoisonIvy.AniListAPI\SwitchAppDesign.AniListAPI.v2\Graph\Fields";

        private static StringBuilder _builder;
        private static Type _type;
        private static XmlDocument _assemblyDocument;

        public static void BuildGraphFieldClassesForModels()
        {
            var dir = Path.Combine(Environment.CurrentDirectory, "Fields");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            var assembly = Assembly.GetAssembly(typeof(SwitchAppDesign.AniListAPI.v2.AniListApi));

            var xmlDir = Path.Combine(Environment.CurrentDirectory, "bin\\Debug\\netcoreapp2.0\\SwitchAppDesign.AniListAPI.v2.xml");

            if (File.Exists(xmlDir))
            {
                _assemblyDocument = new XmlDocument();
                _assemblyDocument.Load(xmlDir);
            }

            var types = assembly.GetTypes().Where(x => x.Namespace == ModelNamespace);

            if (types.Any())
            {
                foreach (var type in types)
                {
                    _builder = new StringBuilder();
                    _type = type;

                    AddUsings();
                    AddNameSpaceAndClass();
                    BuildPropertGetters();
                    BuildProperties();
                    BuildPropertyInitializers();
                    EndClass();

                    File.WriteAllText(Path.Combine(OutputDir, $"{_type.Name}QueryFields.cs"), _builder.ToString());
                }
            }
        }

        private static void AddUsings()
        {
            Usings.ForEach(s =>
            {
                _builder.AppendLine(s);
            });
            _builder.AppendLine("");
        }

        private static void AddNameSpaceAndClass()
        {
            _builder.AppendLine($"namespace {FieldClassNamespace}");
            _builder.AppendLine("{");

            _builder.AppendLine($"\tinternal class {_type.Name}QueryFields");
            _builder.AppendLine("\t{");

            _builder.AppendLine($"\t\tpublic {_type.Name}QueryFields()");
            _builder.AppendLine("\t\t{");
            _builder.AppendLine("\t\t\tInitializeProperties();");
            _builder.AppendLine("\t\t}");
            _builder.AppendLine("");
        }

        private static void BuildPropertGetters()
        {
            foreach (var prop in _type.GetProperties())
            {
                if (_assemblyDocument != null)
                {
                    var propSummary = GetPropertySummarySummary(prop);
                    if (!string.IsNullOrWhiteSpace(propSummary))
                    {
                        _builder.AppendLine("\t\t/// <summary>");
                        _builder.AppendLine($"\t\t/// {propSummary}");
                        _builder.AppendLine("\t\t/// </summary>");
                    }

                    _builder.AppendLine($"\t\tpublic GraphQLQueryField {prop.Name.ToPascalCase()}{PropertySuffix}()");
                    _builder.AppendLine("\t\t{");
                    _builder.AppendLine($"\t\t\treturn {prop.Name.ToPascalCase()};");
                    _builder.AppendLine("\t\t}");
                    _builder.AppendLine("");
                }
            }
        }

        private static void BuildProperties()
        {
            foreach (var prop in _type.GetProperties())
            {
                _builder.AppendLine($"\t\tprivate GraphQLQueryField {prop.Name.ToPascalCase()} {{ get; set; }}");
            }
            _builder.AppendLine("");
        }

        private static void BuildPropertyInitializers()
        {
            _builder.AppendLine("\t\tprivate void InitializeProperties()");
            _builder.AppendLine("\t\t{");

            foreach (var prop in _type.GetProperties())
            {
                _builder.AppendLine($"\t\t\t{prop.Name.ToPascalCase()} = new GraphQLQueryField(\"{prop.Name}\", new FieldRules(false));");
            }

            _builder.AppendLine("\t\t}");
        }

        private static readonly List<string> Usings = new List<string>
        {
            "using SwitchAppDesign.AniListAPI.v2.Types;",
            "using System.Collections.Generic;",
            "using SwitchAppDesign.AniListAPI.v2.Graph.Common;"
        };

        private static void EndClass()
        {
            _builder.AppendLine("\t}");
            _builder.AppendLine("}");
        }

        private static string GetPropertySummarySummary(MemberInfo prop)
        {
            var path = "P:" + prop.DeclaringType.FullName + "." + prop.Name;

            var xmlProp = _assemblyDocument.SelectSingleNode("//member[starts-with(@name, '" + path + "')]");

            return xmlProp?.InnerText.Replace("\n", string.Empty).Replace("\r", string.Empty).Trim();
        }
    }
}
