using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudu.Core.Jobs
{
    class CSharpScriptHost : ScriptHostBase
    {
        private static readonly string[] Supported = { ".cs" };

        public CSharpScriptHost()
            : base("cmd.exe", "/c WebJobSdkHost.exe {0}{1}")
        {
        }

        public override IEnumerable<string> SupportedExtensions
        {
            get { return Supported; }
        }
    }
}
