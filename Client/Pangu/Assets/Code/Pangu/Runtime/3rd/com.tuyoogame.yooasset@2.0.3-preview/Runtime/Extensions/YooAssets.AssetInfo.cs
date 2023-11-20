namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ��Դ��Ϣ
        /// <summary>
        /// �Ƿ���Ҫ��Զ�˸�������
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static bool IsNeedDownloadFromRemote(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.IsNeedDownloadFromRemote(location);
        }

        /// <summary>
        /// �Ƿ���Ҫ��Զ�˸�������
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static bool IsNeedDownloadFromRemote(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.IsNeedDownloadFromRemote(assetInfo);
        }

        /// <summary>
        /// ��ȡ��Դ��Ϣ�б�
        /// </summary>
        /// <param name="tag">��Դ��ǩ</param>
        public static AssetInfo[] GetAssetInfos(string tag)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfos(tag);
        }

        /// <summary>
        /// ��ȡ��Դ��Ϣ�б�
        /// </summary>
        /// <param name="tags">��Դ��ǩ�б�</param>
        public static AssetInfo[] GetAssetInfos(string[] tags)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfos(tags);
        }

        /// <summary>
        /// ��ȡ��Դ��Ϣ
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AssetInfo GetAssetInfo(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfo(location);
        }

        /// <summary>
        /// ��ȡ��Դ��Ϣ
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">��Դ����</param>
        public static AssetInfo GetAssetInfo(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfo(location, type);
        }

        /// <summary>
        /// ��ȡ��Դ��Ϣ
        /// </summary>
        /// <param name="assetGUID">��ԴGUID</param>
        public static AssetInfo GetAssetInfoByGUID(string assetGUID)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfoByGUID(assetGUID);
        }

        /// <summary>
        /// ��ȡ��Դ��Ϣ
        /// </summary>
        /// <param name="assetGUID">��ԴGUID</param>
        /// <param name="type">��Դ����</param>
        public static AssetInfo GetAssetInfoByGUID(string assetGUID, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.GetAssetInfoByGUID(assetGUID, type);
        }

        /// <summary>
        /// �����Դ��λ��ַ�Ƿ���Ч
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static bool CheckLocationValid(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CheckLocationValid(location);
        }
        #endregion
    }
}

