using System.Diagnostics;
using System.IO;
using System.Reflection;
using CommandLine;
using Revit.TestRunner.Console.Commands;

namespace Revit.TestRunner.Console
{
    /// <summary>
    /// Revit.TestRunner console application.
    /// Pass test request files to the service and get results.
    /// </summary>
    public class Program
    {
        public static void Main( string[] args )
        {

            Parser.Default.ParseArguments<RequestCommand, AssemblyCommand, HelloCommand>( args )
                .WithParsed<ICommand>( t => t.Execute() );

            //System.Console.ReadKey();
        }
    }
}