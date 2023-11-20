namespace YooAsset
{
    public static partial class YooAssets
    {
        #region 资源解压
        /// <summary>
        /// 创建内置资源解压器，用于解压当前资源版本所有的资源包文件
        /// </summary>
        /// <param name="unpackingMaxNumber">同时解压的最大文件数</param>
        /// <param name="failedTryAgain">解压失败的重试次数</param>
        public static ResourceUnpackerOperation CreateResourceUnpacker(int unpackingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceUnpacker(unpackingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// 创建内置资源解压器，用于解压指定的资源标签关联的资源包文件
        /// </summary>
        /// <param name="tag">资源标签</param>
        /// <param name="unpackingMaxNumber">同时解压的最大文件数</param>
        /// <param name="failedTryAgain">解压失败的重试次数</param>
        public static ResourceUnpackerOperation CreateResourceUnpacker(string tag, int unpackingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceUnpacker(tag, unpackingMaxNumber, failedTryAgain);
        }

        /// <summary>
        /// 创建内置资源解压器，用于解压指定的资源标签列表关联的资源包文件
        /// </summary>
        /// <param name="tags">资源标签列表</param>
        /// <param name="unpackingMaxNumber">同时解压的最大文件数</param>
        /// <param name="failedTryAgain">解压失败的重试次数</param>
        public static ResourceUnpackerOperation CreateResourceUnpacker(string[] tags, int unpackingMaxNumber, int failedTryAgain)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.CreateResourceUnpacker(tags, unpackingMaxNumber, failedTryAgain);
        }
        #endregion
    }
}

