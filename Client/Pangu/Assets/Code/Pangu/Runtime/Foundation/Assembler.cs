// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------

using Pangu.System;
using System;
using System.Collections.Generic;

namespace Pangu.Foundation
{
    public class Assembler : IModuleContainer
    {
        #region const 

        private const string OnResolveMethod = "OnResolve";

        #endregion

        #region private values

        private Dictionary<Type, Type> _moduleTypes = new Dictionary<Type, Type>(); 

        private Dictionary<Type, IModule> _roslveModules = new Dictionary<Type, IModule>();

        private Dictionary<Type, IModuleTick> _moduleTick = new Dictionary<Type, IModuleTick>();

        private Dictionary<Type, IModuleLateTick> _moduleLateTick = new Dictionary<Type, IModuleLateTick>();

        #endregion

        #region instance
        private static Assembler _instance = null;
        public static Assembler Instance
        {
            get { 
                if( _instance == null)
                {
                    _instance = new Assembler();
                }
                return _instance;
            }
        }
        #endregion

        #region interface

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <param name="loadImmediate"></param>
        /// <returns></returns>
        public IModuleContainer Register<I, T>(bool loadImmediate)
            where I : IModule where T : I
        {
            Type ti = typeof(I);
            if (_moduleTypes.ContainsKey(ti))
            {
                UnityEngine.Debug.LogError($"ÖØ¸´×¢²á {ti.ToString()}");
                return this;
            }
            Type tt = typeof(T);
            _moduleTypes.Add(ti, tt);
            if (loadImmediate)
            {
                Resolve<I>();
            }
            return (this);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="I"></typeparam>
        /// <returns></returns>
        public I Resolve<I>() where I : IModule
        {
            Type ti = typeof(I);
            if(_roslveModules.TryGetValue(ti, out var t))
            {
                if(t is I)
                {
                    return (I)t;
                }
                else
                {
                    UnityEngine.Debug.LogError($"Resolve failed,  {t.GetType().ToString()} is not {ti.ToString()}");
                    return default(I);
                }
            }
            return (I)Resolve(ti);
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deltaTime"></param>
        public void Tick(float deltaTime)
        {
            foreach(var update in _moduleTick)
            {
                update.Value.Tick(deltaTime);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="deltaTime"></param>
        public void LateTick(float deltaTime)
        {
            foreach(var lateUpdate in _moduleLateTick)
            {
                lateUpdate.Value.LateTick(deltaTime);
            }
        }
        #endregion

        #region internal function
        /// <summary>
        /// 
        /// </summary>
        /// <param name="interType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private IModule Resolve(Type interType)
        {
            if (_roslveModules.TryGetValue(interType, out IModule module))
            {
                return module;
            }
            else if (_moduleTypes.TryGetValue(interType, out Type tt))
            {
                var moduleObject = tt.Assembly.CreateInstance(tt.ToString());
                if (moduleObject is IModule)
                {
                    var resolveMethod = SystemResolver.GetMethod(tt, OnResolveMethod, 0);
                    _roslveModules.Add(interType, moduleObject as IModule);
                    if (moduleObject is IModuleTick)
                    {
                        _moduleTick.Add(interType, moduleObject as IModuleTick);
                    }
                    if (moduleObject is IModuleLateTick)
                    {
                        _moduleLateTick.Add(interType, moduleObject as IModuleLateTick);
                    }
                    if (resolveMethod != null)
                    {
                        var parameters = resolveMethod.GetParameters();
                        var args = new object[parameters.Length];
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            var parameterType = parameters[i].ParameterType;
                            if (!parameterType.IsInterface && !parameterType.IsClass)
                            {
                                throw new ArgumentException(OnResolveMethod);
                            }
                            args[i] = Resolve(parameterType);
                        }
                        try
                        {
                            resolveMethod.Invoke(moduleObject, args);
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                }
            }
            return default;
        }

        #endregion
    }
}

