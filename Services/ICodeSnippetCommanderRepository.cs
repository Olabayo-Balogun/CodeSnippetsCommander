using CodeSnippetsCommander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSnippetsCommander.Services
{
    public interface ICodeSnippetCommanderRepository
    {
        IEnumerable<CodeSnippetCommand> GetAppCodeSnippetCommand();
        CodeSnippetCommand GetCodeSnippetCommandById(int id);

    }
}
