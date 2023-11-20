
using System;

namespace YooAsset
{
    public static partial class YooAssets
    {
		private static ResourcePackage _defaultPackage;

		/// <summary>
		/// 设置默认的资源包
		/// </summary>
		public static void SetDefaultPackage(ResourcePackage package)
		{
			_defaultPackage = package;
		}
		/// <summary>
		/// 创建资源包
		/// </summary>
		/// <param name="packageName">资源包名称</param>
		public static ResourcePackage CreatePackage(string packageName)
		{
			CheckException(packageName);
			if (ContainsPackage(packageName))
				throw new Exception($"Package {packageName} already existed !");

			YooLogger.Log($"Create resource package : {packageName}");
			ResourcePackage package = new ResourcePackage(packageName);
			_packages.Add(package);
			return package;
		}

		/// <summary>
		/// 获取资源包
		/// </summary>
		/// <param name="packageName">资源包名称</param>
		public static ResourcePackage GetPackage(string packageName)
		{
			CheckException(packageName);
			var package = GetPackageInternal(packageName);
			if (package == null)
				YooLogger.Error($"Not found resource package : {packageName}");
			return package;
		}

		/// <summary>
		/// 尝试获取资源包
		/// </summary>
		/// <param name="packageName">资源包名称</param>
		public static ResourcePackage TryGetPackage(string packageName)
		{
			CheckException(packageName);
			return GetPackageInternal(packageName);
		}

		/// <summary>
		/// 销毁资源包
		/// </summary>
		/// <param name="packageName">资源包名称</param>
		public static void DestroyPackage(string packageName)
		{
			CheckException(packageName);
			ResourcePackage package = GetPackageInternal(packageName);
			if (package == null)
				return;

			YooLogger.Log($"Destroy resource package : {packageName}");
			_packages.Remove(package);
			package.DestroyPackage();
		}

		/// <summary>
		/// 检测资源包是否存在
		/// </summary>
		/// <param name="packageName">资源包名称</param>
		public static bool ContainsPackage(string packageName)
		{
			CheckException(packageName);
			var package = GetPackageInternal(packageName);
			return package != null;
		}

		/// <summary>
		/// 开启一个异步操作
		/// </summary>
		/// <param name="operation">异步操作对象</param>
		public static void StartOperation(GameAsyncOperation operation)
		{
			// 注意：游戏业务逻辑的包裹填写为空
			OperationSystem.StartOperation(string.Empty, operation);
		}

		private static ResourcePackage GetPackageInternal(string packageName)
		{
			foreach (var package in _packages)
			{
				if (package.PackageName == packageName)
					return package;
			}
			return null;
		}
		private static void CheckException(string packageName)
		{
			if (_isInitialize == false)
				throw new Exception($"{nameof(YooAssets)} not initialize !");

			if (string.IsNullOrEmpty(packageName))
				throw new Exception("Package name is null or empty !");
		}
	}
}
