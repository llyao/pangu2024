using System;
using System.Collections.Generic;
using UnityEngine;

namespace YooAsset
{
	public static partial class YooAssets
	{
		private static bool _isInitialize = false;
		private static GameObject _driver = null;
		private static readonly List<ResourcePackage> _packages = new List<ResourcePackage>();

		#region Initialize
		/// <summary>
		/// 是否已经初始化
		/// </summary>
		public static bool Initialized
		{
			get { return _isInitialize; }
		}

		/// <summary>
		/// 初始化资源系统
		/// </summary>
		/// <param name="logger">自定义日志处理</param>
		public static void Initialize(ILogger logger = null)
		{
			if (_isInitialize)
			{
				UnityEngine.Debug.LogWarning($"{nameof(YooAssets)} is initialized !");
				return;
			}

			if (_isInitialize == false)
			{
				YooLogger.Logger = logger;

				// 创建驱动器
				_isInitialize = true;
				_driver = new UnityEngine.GameObject($"[{nameof(YooAssets)}]");
				_driver.AddComponent<YooAssetsDriver>();
				UnityEngine.Object.DontDestroyOnLoad(_driver);
				YooLogger.Log($"{nameof(YooAssets)} initialize !");

#if DEBUG
				// 添加远程调试脚本
				_driver.AddComponent<RemoteDebuggerInRuntime>();
#endif

				OperationSystem.Initialize();
			}
		}
        #endregion

        /// <summary>
        /// 销毁资源系统
        /// </summary>
        public static void Destroy()
		{
			if (_isInitialize)
			{
				OperationSystem.DestroyAll();

				foreach (var package in _packages)
				{
					package.DestroyPackage();
				}
				_packages.Clear();

				_isInitialize = false;
				if (_driver != null)
					GameObject.Destroy(_driver);
				YooLogger.Log($"{nameof(YooAssets)} destroy all !");
			}
		}

		/// <summary>
		/// 更新资源系统
		/// </summary>
		internal static void Update()
		{
			if (_isInitialize)
			{
				OperationSystem.Update();

				for (int i = 0; i < _packages.Count; i++)
				{
					_packages[i].UpdatePackage();
				}
			}
		}
	}
}