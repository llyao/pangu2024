
using System;

namespace YooAsset
{
    public static partial class YooAssets
    {
		private static ResourcePackage _defaultPackage;

		/// <summary>
		/// ����Ĭ�ϵ���Դ��
		/// </summary>
		public static void SetDefaultPackage(ResourcePackage package)
		{
			_defaultPackage = package;
		}
		/// <summary>
		/// ������Դ��
		/// </summary>
		/// <param name="packageName">��Դ������</param>
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
		/// ��ȡ��Դ��
		/// </summary>
		/// <param name="packageName">��Դ������</param>
		public static ResourcePackage GetPackage(string packageName)
		{
			CheckException(packageName);
			var package = GetPackageInternal(packageName);
			if (package == null)
				YooLogger.Error($"Not found resource package : {packageName}");
			return package;
		}

		/// <summary>
		/// ���Ի�ȡ��Դ��
		/// </summary>
		/// <param name="packageName">��Դ������</param>
		public static ResourcePackage TryGetPackage(string packageName)
		{
			CheckException(packageName);
			return GetPackageInternal(packageName);
		}

		/// <summary>
		/// ������Դ��
		/// </summary>
		/// <param name="packageName">��Դ������</param>
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
		/// �����Դ���Ƿ����
		/// </summary>
		/// <param name="packageName">��Դ������</param>
		public static bool ContainsPackage(string packageName)
		{
			CheckException(packageName);
			var package = GetPackageInternal(packageName);
			return package != null;
		}

		/// <summary>
		/// ����һ���첽����
		/// </summary>
		/// <param name="operation">�첽��������</param>
		public static void StartOperation(GameAsyncOperation operation)
		{
			// ע�⣺��Ϸҵ���߼��İ�����дΪ��
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
