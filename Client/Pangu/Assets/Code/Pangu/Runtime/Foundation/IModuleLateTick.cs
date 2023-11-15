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
    public interface IModuleLateTick
    {
        /// <summary>
        /// LateUpdate
        /// </summary>
        /// <param name="deltaTime">Ê±¼ä¼ä¸ô</param>
        void LateTick(float deltaTime);
    }

}
