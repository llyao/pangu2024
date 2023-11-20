namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ��Դ����
        /// <summary>
        /// ͬ��������Դ����
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        public static AssetHandle LoadAssetSync(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync(assetInfo);
        }

        /// <summary>
        /// ͬ��������Դ����
        /// </summary>
        /// <typeparam name="TObject">��Դ����</typeparam>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AssetHandle LoadAssetSync<TObject>(string location) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync<TObject>(location);
        }

        /// <summary>
        /// ͬ��������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">��Դ����</param>
        public static AssetHandle LoadAssetSync(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync(location, type);
        }

        /// <summary>
        /// ͬ��������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AssetHandle LoadAssetSync(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetSync(location);
        }


        /// <summary>
        /// �첽������Դ����
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        public static AssetHandle LoadAssetAsync(AssetInfo assetInfo, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync(assetInfo, priority);
        }

        /// <summary>
        /// �첽������Դ����
        /// </summary>
        /// <typeparam name="TObject">��Դ����</typeparam>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AssetHandle LoadAssetAsync<TObject>(string location, uint priority = 0) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync<TObject>(location, priority);
        }

        /// <summary>
        /// �첽������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">��Դ����</param>
        public static AssetHandle LoadAssetAsync(string location, System.Type type, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync(location, type, priority);
        }

        /// <summary>
        /// �첽������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AssetHandle LoadAssetAsync(string location, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAssetAsync(location, priority);
        }
        #endregion

        #region ��Դ����
        /// <summary>
        /// ͬ����������Դ����
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        public static SubAssetsHandle LoadSubAssetsSync(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync(assetInfo);
        }

        /// <summary>
        /// ͬ����������Դ����
        /// </summary>
        /// <typeparam name="TObject">��Դ����</typeparam>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static SubAssetsHandle LoadSubAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync<TObject>(location);
        }

        /// <summary>
        /// ͬ����������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">�Ӷ�������</param>
        public static SubAssetsHandle LoadSubAssetsSync(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync(location, type);
        }

        /// <summary>
        /// ͬ����������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static SubAssetsHandle LoadSubAssetsSync(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsSync(location);
        }


        /// <summary>
        /// �첽��������Դ����
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        public static SubAssetsHandle LoadSubAssetsAsync(AssetInfo assetInfo, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync(assetInfo, priority);
        }

        /// <summary>
        /// �첽��������Դ����
        /// </summary>
        /// <typeparam name="TObject">��Դ����</typeparam>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static SubAssetsHandle LoadSubAssetsAsync<TObject>(string location, uint priority = 0) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync<TObject>(location, priority);
        }

        /// <summary>
        /// �첽��������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">�Ӷ�������</param>
        public static SubAssetsHandle LoadSubAssetsAsync(string location, System.Type type, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync(location, type, priority);
        }

        /// <summary>
        /// �첽��������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static SubAssetsHandle LoadSubAssetsAsync(string location, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSubAssetsAsync(location, priority);
        }
        #endregion

        #region ��Դ����
        /// <summary>
        /// ͬ��������Դ����������Դ����
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        public static AllAssetsHandle LoadAllAssetsSync(AssetInfo assetInfo)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync(assetInfo);
        }

        /// <summary>
        /// ͬ��������Դ����������Դ����
        /// </summary>
        /// <typeparam name="TObject">��Դ����</typeparam>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AllAssetsHandle LoadAllAssetsSync<TObject>(string location) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync<TObject>(location);
        }

        /// <summary>
        /// ͬ��������Դ����������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">�Ӷ�������</param>
        public static AllAssetsHandle LoadAllAssetsSync(string location, System.Type type)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync(location, type);
        }

        /// <summary>
        /// ͬ��������Դ����������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AllAssetsHandle LoadAllAssetsSync(string location)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsSync(location);
        }


        /// <summary>
        /// �첽������Դ����������Դ����
        /// </summary>
        /// <param name="assetInfo">��Դ��Ϣ</param>
        public static AllAssetsHandle LoadAllAssetsAsync(AssetInfo assetInfo, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync(assetInfo, priority);
        }

        /// <summary>
        /// �첽������Դ����������Դ����
        /// </summary>
        /// <typeparam name="TObject">��Դ����</typeparam>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AllAssetsHandle LoadAllAssetsAsync<TObject>(string location, uint priority = 0) where TObject : UnityEngine.Object
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync<TObject>(location, priority);
        }

        /// <summary>
        /// �첽������Դ����������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        /// <param name="type">�Ӷ�������</param>
        public static AllAssetsHandle LoadAllAssetsAsync(string location, System.Type type, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync(location, type, priority);
        }

        /// <summary>
        /// �첽������Դ����������Դ����
        /// </summary>
        /// <param name="location">��Դ�Ķ�λ��ַ</param>
        public static AllAssetsHandle LoadAllAssetsAsync(string location, uint priority = 0)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadAllAssetsAsync(location, priority);
        }
        #endregion
    }
}

