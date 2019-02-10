using System;
using System.Globalization;

namespace Atlas
{
    public static class TypeExtensions
    {
        public static string GetPrimitiveName( this Type type )
        {
            //var compiler = new Microsoft.CSharp.CSharpCodeProvider();
            //var typeReference = new System.CodeDom.CodeTypeReference( type );
            //return compiler.GetTypeOutput( typeReference );

            // TODO: This switch may be a bit naive and not as robust as desired, but works for most
            // common types, and removes the references to Microsoft.CSharp, which Unity doesn't seem
            // to like much when using individual Assembly Definition files.
            // There's gotta be a way around that, but this works fine for now.
            string lowerCaseString = type.FullName.ToLower( CultureInfo.InvariantCulture ).Trim();
            switch ( lowerCaseString )
            {
                case "system.int16":
                    return "short";

                case "system.int32":
                    return "int";

                case "system.int64":
                    return "long";

                case "system.string":
                    return "string";

                case "system.object":
                    return "object";

                case "system.boolean":
                    return "bool";

                case "system.void":
                    return "void";

                case "system.char":
                    return "char";

                case "system.byte":
                    return "byte";

                case "system.uint16":
                    return "ushort";

                case "system.uint32":
                    return "uint";

                case "system.uint64":
                    return "ulong";

                case "system.sbyte":
                    return "sbyte";

                case "system.single":
                    return "float";

                case "system.double":
                    return "double";

                case "system.decimal":
                    return "decimal";
            }

            // fallback to default
            return type.FullName;
        }
    }
}