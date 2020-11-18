using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Response.Directive;

namespace VoicifyAlexa.NET.ConnectionTasks
{
    public static class IConnectionTaskExtensions
    {

        public static StartConnectionDirective ToConnectionDirective(this IConnectionTask task, string token = null)
        {
            return new StartConnectionDirective(task, token);
        }
    }
}
