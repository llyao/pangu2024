using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ��������
        /// <summary>
        /// �첽���س���
        /// </summary>
        /// <param name="location">�����Ķ�λ��ַ</param>
        /// <param name="sceneMode">��������ģʽ</param>
        /// <param name="suspendLoad">�������ص�90%�Զ�����</param>
        /// <param name="priority">���ȼ�</param>
        public static SceneHandle LoadSceneAsync(string location, LoadSceneMode sceneMode = LoadSceneMode.Single, bool suspendLoad = false, uint priority = 100)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSceneAsync(location, sceneMode, suspendLoad, priority);
        }

        /// <summary>
        /// �첽���س���
        /// </summary>
        /// <param name="assetInfo">��������Դ��Ϣ</param>
        /// <param name="sceneMode">��������ģʽ</param>
        /// <param name="suspendLoad">�������ص�90%�Զ�����</param>
        /// <param name="priority">���ȼ�</param>
        public static SceneHandle LoadSceneAsync(AssetInfo assetInfo, LoadSceneMode sceneMode = LoadSceneMode.Single, bool suspendLoad = false, uint priority = 100)
        {
            DebugCheckDefaultPackageValid();
            return _defaultPackage.LoadSceneAsync(assetInfo, sceneMode, suspendLoad, priority);
        }
        #endregion
    }
}

