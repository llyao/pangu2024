
namespace YooAsset
{
    public static partial class YooAssets
    {
		#region ԭ���ļ�
		/// <summary>
		/// ͬ������ԭ���ļ�
		/// </summary>
		/// <param name="assetInfo">��Դ��Ϣ</param>
		public static RawFileHandle LoadRawFileSync(AssetInfo assetInfo)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileSync(assetInfo);
		}

		/// <summary>
		/// ͬ������ԭ���ļ�
		/// </summary>
		/// <param name="location">��Դ�Ķ�λ��ַ</param>
		public static RawFileHandle LoadRawFileSync(string location)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileSync(location);
		}


		/// <summary>
		/// �첽����ԭ���ļ�
		/// </summary>
		/// <param name="assetInfo">��Դ��Ϣ</param>
		public static RawFileHandle LoadRawFileAsync(AssetInfo assetInfo, uint priority = 0)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileAsync(assetInfo, priority);
		}

		/// <summary>
		/// �첽����ԭ���ļ�
		/// </summary>
		/// <param name="location">��Դ�Ķ�λ��ַ</param>
		public static RawFileHandle LoadRawFileAsync(string location, uint priority = 0)
		{
			DebugCheckDefaultPackageValid();
			return _defaultPackage.LoadRawFileAsync(location, priority);
		}
		#endregion
	}
}
