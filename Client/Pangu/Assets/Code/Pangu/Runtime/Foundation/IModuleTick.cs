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
    public interface IModuleTick 
    {
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="deltaTime">���ʱ��</param>
        void Tick(float deltaTime);
    }
}
