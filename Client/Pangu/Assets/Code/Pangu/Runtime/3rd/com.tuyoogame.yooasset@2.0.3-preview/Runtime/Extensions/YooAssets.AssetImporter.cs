namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ��Դ����
        /// <summary>
        /// ������Դ������
        /// ע�⣺��Դ�ļ����Ʊ������Դ������������ļ�����һ�£�
        /// </summary>
        /// <param name="filePaths">��Դ·���б�</param>
        /// <param name="importerMaxNumber">ͬʱ���������ļ���</param>
        /// <param name="failedTryAgain">����ʧ�ܵ����Դ���</param>
        public static ResourceImporterOperation CreateResourceImporter(string[] filePaths, int importerMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceImporter(filePaths, importerMaxNumber, failedTryAgain);
        }
        #endregion
    }
}

