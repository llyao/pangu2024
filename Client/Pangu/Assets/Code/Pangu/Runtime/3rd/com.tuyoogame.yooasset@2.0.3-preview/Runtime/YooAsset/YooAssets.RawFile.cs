
namespace YooAsset
{
    public static partial class YooAssets
    {
		#region 原生文件
		/// <summary>
		/// 同步加载原生文件
		/// </summary>
		/// <param name="assetInfo">资源信息</param>
		public static RawFileHandle LoadRawFileSync(AssetInfo assetInfo)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileSync(assetInfo);
		}

		/// <summary>
		/// 同步加载原生文件
		/// </summary>
		/// <param name="location">资源的定位地址</param>
		public static RawFileHandle LoadRawFileSync(string location)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileSync(location);
		}


		/// <summary>
		/// 异步加载原生文件
		/// </summary>
		/// <param name="assetInfo">资源信息</param>
		public static RawFileHandle LoadRawFileAsync(AssetInfo assetInfo, uint priority = 0)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileAsync(assetInfo, priority);
		}

		/// <summary>
		/// 异步加载原生文件
		/// </summary>
		/// <param name="location">资源的定位地址</param>
		public static RawFileHandle LoadRawFileAsync(string location, uint priority = 0)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileAsync(location, priority);
		}
		#endregion
	}
}
