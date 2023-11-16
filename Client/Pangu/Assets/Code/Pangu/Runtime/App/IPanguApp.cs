// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------
using Pangu.Foundation;
using System.Collections;

namespace Pangu.App
{
    public interface ICoroutine
    {

    }
    public struct MonoCoroutine : ICoroutine
    {
        private readonly object _coroutine;

        public MonoCoroutine(object coroutine)
        {
            _coroutine = coroutine;
        }

        public object CoroutineObject
        {
            get
            {
                return _coroutine;
            }
        }
    }
    public interface IPanguApp : IModule
    {

        public ICoroutine StartCoroutineNew(IEnumerator enumerator);
    }

    public class QPanguApp : QI<IPanguApp> { }
}
