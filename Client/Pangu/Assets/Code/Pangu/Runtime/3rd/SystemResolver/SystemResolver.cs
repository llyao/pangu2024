// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------
using System;
using System.Reflection;
namespace Pangu.System
{
    public static class SystemResolver
    {
        /// <summary>
        /// Type
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Type GetType(string name)
        {
            var t = Type.GetType(name);
            if (t == null)
            {
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var asm in assemblies)
                {
                    t = asm.GetType(name);
                    if (t != null)
                    {
                        break;
                    }
                }
            }
            return t;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="method"></param>
        /// <param name="argCount"></param>
        /// <returns></returns>
        public static MethodInfo GetMethod(Type type, string method, int argCount)
        {
            return FindNestedMethod(type, method);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="module"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public static object CreateInstance(string module, params object[] payload)
        {
            var t = GetType(module);
            return t != null ? Activator.CreateInstance(t, payload) : null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="target"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public static Delegate CreateDelegate(Type type, object target, MethodInfo method)
        {
            return Delegate.CreateDelegate(type, target, method);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private static MethodInfo FindNestedMethod(Type type, string name)
        {
            if (type == null || type == typeof(object))
            {
                return null;
            }

            var m = type.GetMethod(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (m != null)
            {
                return m;
            }

            return FindNestedMethod(type.BaseType, name);
        }
    }
}

