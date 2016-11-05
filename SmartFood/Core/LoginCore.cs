using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core
{
    public sealed class LoginCore
    {
        private static readonly Lazy<LoginCore> lazy = new Lazy<LoginCore>(() => new LoginCore());
        public static LoginCore instance {get { return lazy.Value; }}
        private LoginCore()
        {

        }
    }
}
