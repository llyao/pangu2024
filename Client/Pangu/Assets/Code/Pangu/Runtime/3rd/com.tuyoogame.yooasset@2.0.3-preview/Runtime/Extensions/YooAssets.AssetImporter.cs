namespace YooAsset
{
    public static partial class YooAssets
    {
        #region 资源导入
        /// <summary>
        /// 创建资源导入器
        /// 注意：资源文件名称必须和资源服务器部署的文件名称一致！
        /// </summary>
        /// <param name="filePaths">资源路径列表</param>
        /// <param name="importerMaxNumber">同时导入的最大文件数</param>
        /// <param name="failedTryAgain">导入失败的重试次数</param>
        public static ResourceImporterOperation CreateResourceImporter(string[] filePaths, int importerMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceImporter(filePaths, importerMaxNumber, failedTryAgain);
        }
        #endregion
    }
}

