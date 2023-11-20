namespace YooAsset
{
    public static partial class YooAssets
    {
        #region 资源信息
        /// <summary>
        /// 是否需要从远端更新下载
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static bool IsNeedDownloadFromRemote(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.IsNeedDownloadFromRemote(location);
        }

        /// <summary>
        /// 是否需要从远端更新下载
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static bool IsNeedDownloadFromRemote(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.IsNeedDownloadFromRemote(assetInfo);
        }

        /// <summary>
        /// 获取资源信息列表
        /// </summary>
        /// <param name="tag">资源标签</param>
        public static AssetInfo[] GetAssetInfos(string tag)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfos(tag);
        }

        /// <summary>
        /// 获取资源信息列表
        /// </summary>
        /// <param name="tags">资源标签列表</param>
        public static AssetInfo[] GetAssetInfos(string[] tags)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfos(tags);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static AssetInfo GetAssetInfo(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfo(location);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">资源类型</param>
        public static AssetInfo GetAssetInfo(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfo(location, type);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        /// <param name="assetGUID">资源GUID</param>
        public static AssetInfo GetAssetInfoByGUID(string assetGUID)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfoByGUID(assetGUID);
        }

        /// <summary>
        /// 获取资源信息
        /// </summary>
        /// <param name="assetGUID">资源GUID</param>
        /// <param name="type">资源类型</param>
        public static AssetInfo GetAssetInfoByGUID(string assetGUID, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfoByGUID(assetGUID, type);
        }

        /// <summary>
        /// 检查资源定位地址是否有效
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static bool CheckLocationValid(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CheckLocationValid(location);
        }
        #endregion
    }
}

