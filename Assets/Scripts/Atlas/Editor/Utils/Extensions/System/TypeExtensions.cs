using Microsoft.CSharp;
using System;
using System.CodeDom;

namespace Atlas
{
    public static class TypeExtensions
    {
        public static string GetPrimitiveName( this Type type )
        {
            var compiler = new CSharpCodeProvider();
            var typeReference = new CodeTypeReference( type );

            return compiler.GetTypeOutput( typeReference );
        }
    }
}