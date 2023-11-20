using System.Diagnostics;
using System;
using UnityEngine;

namespace YooAsset
{
    public static partial class YooAssets
    {
        #region ���Է���
        [Conditional("DEBUG")]
        private static void DebugCheckDefaultPackageValid()
        {
            if (_defaultPackage == null)
                throw new Exception($"Default package is null. Please use {nameof(YooAssets.SetDefaultPackage)} !");
        }
        #endregion

        #region ������Ϣ
        internal static DebugReport GetDebugReport()
        {
            DebugReport report = new DebugReport();
            report.FrameCount = Time.frameCount;

            foreach (var package in _packages)
            {
                var packageData = package.GetDebugPackageData();
                report.PackageDatas.Add(packageData);
            }
            return report;
        }
        #endregion
    }
}

