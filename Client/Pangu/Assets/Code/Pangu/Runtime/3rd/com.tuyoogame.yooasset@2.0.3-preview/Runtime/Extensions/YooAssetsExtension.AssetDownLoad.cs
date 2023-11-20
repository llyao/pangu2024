namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ��Դ����
        /// <summary>
        /// ������Դ���������������ص�ǰ��Դ�汾���е���Դ���ļ�
        /// </summary>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateResourceDownloader(int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceDownloader(downloadingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ������Դ����������������ָ������Դ��ǩ��������Դ���ļ�
        /// </summary>
        /// <param name="tag">��Դ��ǩ</param>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateResourceDownloader(string tag, int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceDownloader(new string[] { tag }, downloadingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ������Դ����������������ָ������Դ��ǩ�б��������Դ���ļ�
        /// </summary>
        /// <param name="tags">��Դ��ǩ�б�</param>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateResourceDownloader(string[] tags, int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceDownloader(tags, downloadingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ������Դ����������������ָ������Դ��������Դ���ļ�
        /// </summary>
        /// <param name="location">��Դ��λ��ַ</param>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateBundleDownloader(string location, int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateBundleDownloader(location, downloadingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ������Դ����������������ָ������Դ�б���������Դ���ļ�
        /// </summary>
        /// <param name="locations">��Դ��λ��ַ�б�</param>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateBundleDownloader(string[] locations, int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateBundleDownloader(locations, downloadingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ������Դ����������������ָ������Դ��������Դ���ļ�
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateBundleDownloader(AssetInfo assetInfo, int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateBundleDownloader(assetInfo, downloadingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ������Դ����������������ָ������Դ�б���������Դ���ļ�
        /// </summary>
        /// <param name="assetInfos">��Դ��Ϣ�б�</param>
        /// <param name="downloadingMaxNumber">ͬʱ���ص�����ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceDownloaderOperation CreateBundleDownloader(AssetInfo[] assetInfos, int downloadingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateBundleDownloader(assetInfos, downloadingMaxNumber, failedTryAgain);
        }
        #endregion
    }
}

