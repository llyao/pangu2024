using System.Collections.Generic;


namespace YooAsset
{
    public static partial class YooAssets
    {
		#region 系统参数
		/// <summary>
		/// 设置下载系统参数，下载失败后清理文件的HTTP错误码
		/// </summary>
		public static void SetDownloadSystemClearFileResponseCode(List<long> codes)
		{
			DownloadHelper.ClearFileResponseCodes = codes;
		}

		/// <summary>
		/// 设置下载系统参数，自定义下载请求
		/// </summary>
		public static void SetDownloadSystemUnityWebRequest(DownloadRequestDelegate requestDelegate)
		{
			DownloadHelper.RequestDelegate = requestDelegate;
		}

		/// <summary>
		/// 设置异步系统参数，每帧执行消耗的最大时间切片（单位：毫秒）
		/// </summary>
		public static void SetOperationSystemMaxTimeSlice(long milliseconds)
		{
			if (milliseconds < 10)
			{
				milliseconds = 10;
				YooLogger.Warning($"MaxTimeSlice minimum value is 10 milliseconds.");
			}
			OperationSystem.MaxTimeSlice = milliseconds;
		}

		/// <summary>
		/// 设置缓存系统参数，禁用缓存在WebGL平台
		/// </summary>
		public static void SetCacheSystemDisableCacheOnWebGL()
		{
			CacheHelper.DisableUnityCacheOnWebGL = true;
		}
		#endregion
	}
}
