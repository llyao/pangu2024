using System.Collections.Generic;


namespace YooAsset
{
    public static partial class YooAssets
    {
		#region ϵͳ����
		/// <summary>
		/// ��������ϵͳ����������ʧ�ܺ������ļ���HTTP������
		/// </summary>
		public static void SetDownloadSystemClearFileResponseCode(List<long> codes)
		{
			DownloadHelper.ClearFileResponseCodes = codes;
		}

		/// <summary>
		/// ��������ϵͳ�������Զ�����������
		/// </summary>
		public static void SetDownloadSystemUnityWebRequest(DownloadRequestDelegate requestDelegate)
		{
			DownloadHelper.RequestDelegate = requestDelegate;
		}

		/// <summary>
		/// �����첽ϵͳ������ÿִ֡�����ĵ����ʱ����Ƭ����λ�����룩
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
		/// ���û���ϵͳ���������û�����WebGLƽ̨
		/// </summary>
		public static void SetCacheSystemDisableCacheOnWebGL()
		{
			CacheHelper.DisableUnityCacheOnWebGL = true;
		}
		#endregion
	}
}
