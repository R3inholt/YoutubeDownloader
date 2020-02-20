using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    static class ExtensionMethods
    {
        public static void SynchronizedInvoke(this ISynchronizeInvoke sync, Action method)
        {
            if (!sync.InvokeRequired)
            {
                method();
                return;
            }
            sync.Invoke(method, new object[] { });
        }
    }
}
