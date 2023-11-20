namespace YooAsset
{
    public static partial class YooAssets
    {
        #region 资源加载
        /// <summary>
        /// 同步加载资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        public static AssetHandle LoadAssetSync(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync(assetInfo);
        }

        /// <summary>
        /// 同步加载资源对象
        /// </summary>
        /// <typeparam name="TObject">资源类型</typeparam>
        /// <param name="location">资源的定位地址</param>
        public static AssetHandle LoadAssetSync<TObject>(string location) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync<TObject>(location);
        }

        /// <summary>
        /// 同步加载资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">资源类型</param>
        public static AssetHandle LoadAssetSync(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync(location, type);
        }

        /// <summary>
        /// 同步加载资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static AssetHandle LoadAssetSync(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync(location);
        }


        /// <summary>
        /// 异步加载资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        public static AssetHandle LoadAssetAsync(AssetInfo assetInfo, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync(assetInfo, priority);
        }

        /// <summary>
        /// 异步加载资源对象
        /// </summary>
        /// <typeparam name="TObject">资源类型</typeparam>
        /// <param name="location">资源的定位地址</param>
        public static AssetHandle LoadAssetAsync<TObject>(string location, uint priority = 0) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync<TObject>(location, priority);
        }

        /// <summary>
        /// 异步加载资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">资源类型</param>
        public static AssetHandle LoadAssetAsync(string location, System.Type type, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync(location, type, priority);
        }

        /// <summary>
        /// 异步加载资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static AssetHandle LoadAssetAsync(string location, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync(location, priority);
        }
        #endregion

        #region 资源加载
        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        public static SubAssetsHandle LoadSubAssetsSync(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync(assetInfo);
        }

        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <typeparam name="TObject">资源类型</typeparam>
        /// <param name="location">资源的定位地址</param>
        public static SubAssetsHandle LoadSubAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync<TObject>(location);
        }

        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">子对象类型</param>
        public static SubAssetsHandle LoadSubAssetsSync(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync(location, type);
        }

        /// <summary>
        /// 同步加载子资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static SubAssetsHandle LoadSubAssetsSync(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync(location);
        }


        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        public static SubAssetsHandle LoadSubAssetsAsync(AssetInfo assetInfo, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync(assetInfo, priority);
        }

        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <typeparam name="TObject">资源类型</typeparam>
        /// <param name="location">资源的定位地址</param>
        public static SubAssetsHandle LoadSubAssetsAsync<TObject>(string location, uint priority = 0) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync<TObject>(location, priority);
        }

        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">子对象类型</param>
        public static SubAssetsHandle LoadSubAssetsAsync(string location, System.Type type, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync(location, type, priority);
        }

        /// <summary>
        /// 异步加载子资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static SubAssetsHandle LoadSubAssetsAsync(string location, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync(location, priority);
        }
        #endregion

        #region 资源加载
        /// <summary>
        /// 同步加载资源包内所有资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        public static AllAssetsHandle LoadAllAssetsSync(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync(assetInfo);
        }

        /// <summary>
        /// 同步加载资源包内所有资源对象
        /// </summary>
        /// <typeparam name="TObject">资源类型</typeparam>
        /// <param name="location">资源的定位地址</param>
        public static AllAssetsHandle LoadAllAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync<TObject>(location);
        }

        /// <summary>
        /// 同步加载资源包内所有资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">子对象类型</param>
        public static AllAssetsHandle LoadAllAssetsSync(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync(location, type);
        }

        /// <summary>
        /// 同步加载资源包内所有资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static AllAssetsHandle LoadAllAssetsSync(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync(location);
        }


        /// <summary>
        /// 异步加载资源包内所有资源对象
        /// </summary>
        /// <param name="assetInfo">资源信息</param>
        public static AllAssetsHandle LoadAllAssetsAsync(AssetInfo assetInfo, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync(assetInfo, priority);
        }

        /// <summary>
        /// 异步加载资源包内所有资源对象
        /// </summary>
        /// <typeparam name="TObject">资源类型</typeparam>
        /// <param name="location">资源的定位地址</param>
        public static AllAssetsHandle LoadAllAssetsAsync<TObject>(string location, uint priority = 0) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync<TObject>(location, priority);
        }

        /// <summary>
        /// 异步加载资源包内所有资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        /// <param name="type">子对象类型</param>
        public static AllAssetsHandle LoadAllAssetsAsync(string location, System.Type type, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync(location, type, priority);
        }

        /// <summary>
        /// 异步加载资源包内所有资源对象
        /// </summary>
        /// <param name="location">资源的定位地址</param>
        public static AllAssetsHandle LoadAllAssetsAsync(string location, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync(location, priority);
        }
        #endregion
    }
}

