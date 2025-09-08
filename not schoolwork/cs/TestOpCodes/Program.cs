using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length < 1)
            {
                throw new ArgumentException("Not enough arguments.");
            }

            string exePath = args[0];

            if (!File.Exists(exePath))
            {
                throw new FileNotFoundException(exePath);
            }

            // Output file in the same directory
            string outPath = Path.Combine(
                Path.GetDirectoryName(exePath),
                Path.GetFileNameWithoutExtension(exePath) + "_Decompiled.cs"
            );

            try
            {
                var decompiler = new CSharpDecompiler(exePath, new DecompilerSettings());

                // Decompile the whole module into C# code
                string code = decompiler.DecompileWholeModuleAsString();

                Console.WriteLine($"Decompiled code written to: {outPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decompilation failed: {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return;
        }
    }
}