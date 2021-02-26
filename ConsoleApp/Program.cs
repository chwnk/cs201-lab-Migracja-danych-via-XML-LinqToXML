using ClassLibrary;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Directory.GetCurrentDirectory();
            var issuesDir = new FileInfo(directory).Directory.Parent.Parent.FullName;
            var resultDir = Directory.CreateDirectory(Path.Combine(directory, "result"));
            OJSMigration.Migrate(Path.Combine(issuesDir, "issues.xml"), resultDir.FullName);
        }
    }
}
