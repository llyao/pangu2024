// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------
using Pangu.Foundation;

namespace Pangu.App
{
    public interface IPanguApp : IModule
    {
    }

    public class QPanguApp : QI<IPanguApp> { }
}
