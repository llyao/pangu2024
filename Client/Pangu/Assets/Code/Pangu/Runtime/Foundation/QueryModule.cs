// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------
namespace Pangu.Foundation
{
    public abstract class QI<I> where I : IModule
    {
        private static I _instance = default;

        public static I Instance
        {
            get
            {
                if (_instance == null)
                {
                    var app = Assembler.Instance;
                    if (app != null)
                    {
                        _instance = app.Resolve<I>();
                    }
                }
                return _instance;
            }
        }
    }

}

