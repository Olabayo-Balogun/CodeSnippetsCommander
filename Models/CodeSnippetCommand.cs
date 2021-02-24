using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSnippetsCommander.Models
{
    public class CodeSnippetCommand
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLineSnippet { get; set; }
        public string ApplicationPlatform { get; set; }

    }
}
