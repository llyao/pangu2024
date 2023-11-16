// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------
using System.Diagnostics;

namespace Pangu.LogSystem
{
    public static class Log
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        [Conditional("ENABLE_LOG")]
        public static void Info(object message)
        {
            UnityEngine.Debug.Log(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        [Conditional("ENABLE_LOG")]
        public static void Warning(object message)
        {
            UnityEngine.Debug.LogWarning(message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        [Conditional("ENABLE_LOG")]
        public static void Error(object message)
        {
            UnityEngine.Debug.LogError(message);
        }
    }
}

