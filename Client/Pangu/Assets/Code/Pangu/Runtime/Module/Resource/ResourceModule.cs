// -----------------------------------------------------------------------
// This file is part of Pangu framework.
// 
// (sange) yaolingling@ghost.com
// 
// For the full copyright and license information, please view the LICENSE
// file that was distributed with this source code.
// -----------------------------------------------------------------------

using Pangu.App;
using System.Collections;
using UnityEngine;
using YooAsset;
using YooAsset.Editor;

namespace Pangu.Resource
{
    public class ResourceModule : IResourceModule
    {
        ResourcePackage _package;
        public void OnResolve(IPanguApp panguApp)
        {
            //panguApp.StartCoroutineNew(InitializeYooAsset());
            Init();
        }

        private IEnumerator InitializeYooAsset()
        {
            // ��ʼ����Դϵͳ
            YooAssets.Initialize();

            // ����Ĭ�ϵ���Դ��
            var package = YooAssets.CreatePackage("DefaultPackage");

            // ���ø���Դ��ΪĬ�ϵ���Դ��������ʹ��YooAssets��ؼ��ؽӿڼ��ظ���Դ�����ݡ�
            YooAssets.SetDefaultPackage(package);

            var initParameters = new EditorSimulateModeParameters();

            initParameters.SimulateManifestFilePath = EditorSimulateModeHelper.SimulateBuild(EBuildPipeline.BuiltinBuildPipeline.ToString(), "DefaultPackage");

            _package = package;

            yield return package.InitializeAsync(initParameters);
        }

        private void Init()
        {
            YooAssets.Initialize();
            string packageName = "DefaultPackage";
            var defaultPackage = YooAssets.TryGetPackage(packageName);
            if (defaultPackage == null)
            {
                defaultPackage = YooAssets.CreatePackage(packageName);
                YooAssets.SetDefaultPackage(defaultPackage);
            }
            
            var createParameters = new EditorSimulateModeParameters();
            createParameters.SimulateManifestFilePath = EditorSimulateModeHelper.SimulateBuild(EBuildPipeline.BuiltinBuildPipeline.ToString(), "DefaultPackage");
            InitializationOperation initializationOperation = defaultPackage.InitializeAsync(createParameters);
            _package = defaultPackage;
        }

        public void Dispose()
        {
        }

        public GameObject InitiateAsync(string path)
        {
            if(_package == null)
            {
                //InitializeYooAsset();
                return null;
            }
            return _package.LoadAssetAsync<GameObject>("Assets/Loadable/TestA").InstantiateSync();
        }
        
    }
}


