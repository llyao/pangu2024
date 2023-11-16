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

namespace Pangu.App
{
    public class PanguApp : MonoBehaviour, IPanguApp
    {
        private Assembler _assembler;
        public void Dispose()
        {
            
        }

        private void Awake()
        {
            _assembler = Assembler.Instance;
            _assembler.Register<IPanguApp,PanguApp>(true);
        }

        private void Update()
        {
            if(_assembler != null)
            {
                _assembler.Tick(Time.deltaTime);
            }
        }

        private void LateUpdate()
        {
            if (_assembler != null)
            {
                _assembler.LateTick(Time.deltaTime);
            }
        }
    }
}

