namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ��Դ��ѹ
        /// <summary>
        /// ����������Դ��ѹ�������ڽ�ѹ��ǰ��Դ�汾���е���Դ���ļ�
        /// </summary>
        /// <param name="unpackingMaxNumber">ͬʱ��ѹ������ļ���</param>
        /// <param name="failedTryAgain">��ѹʧ�ܵ����Դ���</param>
        public static ResourceUnpackerOperation CreateResourceUnpacker(int unpackingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceUnpacker(unpackingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ����������Դ��ѹ�������ڽ�ѹָ������Դ��ǩ��������Դ���ļ�
        /// </summary>
        /// <param name="tag">��Դ��ǩ</param>
        /// <param name="unpackingMaxNumber">ͬʱ��ѹ������ļ���</param>
        /// <param name="failedTryAgain">��ѹʧ�ܵ����Դ���</param>
        public static ResourceUnpackerOperation CreateResourceUnpacker(string tag, int unpackingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceUnpacker(tag, unpackingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// ����������Դ��ѹ�������ڽ�ѹָ������Դ��ǩ�б��������Դ���ļ�
        /// </summary>
        /// <param name="tags">��Դ��ǩ�б�</param>
        /// <param name="unpackingMaxNumber">ͬʱ��ѹ������ļ���</param>
        /// <param name="failedTryAgain">��ѹʧ�ܵ����Դ���</param>
        public static ResourceUnpackerOperation CreateResourceUnpacker(string[] tags, int unpackingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceUnpacker(tags, unpackingMaxNumber, failedTryAgain);
        }
        #endregion
    }
}

