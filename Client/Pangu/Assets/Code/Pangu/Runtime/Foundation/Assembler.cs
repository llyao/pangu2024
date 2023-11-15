// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Pangu.Foundation
{
    public abstract class Assembler : IModuleContainer
    {
        private Dictionary<Type, Type> _moduleTypes = new Dictionary<Type, Type>(); 

        private Dictionary<Type, IModule> _roslveModules = new Dictionary<Type, IModule>();

        public IModuleContainer Register<I, T>(bool resolveInstantly)
            where I : IModule where T : I
        {
            return (this);
        }

        public I Resolve<I>() where I : IModule
        {
            throw new System.NotImplementedException();
        }
    }
}

