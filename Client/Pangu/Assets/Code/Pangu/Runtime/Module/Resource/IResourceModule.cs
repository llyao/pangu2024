// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------
using Pangu.Foundation;
using UnityEngine;

namespace Pangu.Resource
{
    public interface IResourceModule : IModule
    {
        GameObject InitiateAsync(string path);
    }


    public class QResourceModule : QI<IResourceModule> { }
}

