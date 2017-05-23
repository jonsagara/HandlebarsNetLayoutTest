using System;
using HandlebarsDotNet;

namespace HandlebarsNetLayoutTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate handlebars with custom configuration.
            var handlebars = Handlebars.Create(new HandlebarsConfiguration
            {
                FileSystem = new DiskFileSystem()
            });

            // Get the render function for our FileReady view.
            var fileReadyRenderer = handlebars.CompileView("Views/EmailTemplates/FileReady.hbs");

            // Render the view.
            var html = fileReadyRenderer(new
            {
                SiteUrl = "http://dev.example.com",
                FileName = "SomeFile.pdf"
            });

            Console.WriteLine(html);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
