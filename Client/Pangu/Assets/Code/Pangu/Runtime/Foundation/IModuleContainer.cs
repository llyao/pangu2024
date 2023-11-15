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
    public interface IModuleContainer
    {
        /// <summary>
        /// ×¢²á
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="resolveInstantly"></param>
        /// <returns></returns>
        IModuleContainer Register<I, T>(bool resolveInstantly) where I : IModule where T : I;

        /// <summary>
        /// »ñÈ¡
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <returns></returns>
        I Resolve<I>() where I : IModule;
    }
}



