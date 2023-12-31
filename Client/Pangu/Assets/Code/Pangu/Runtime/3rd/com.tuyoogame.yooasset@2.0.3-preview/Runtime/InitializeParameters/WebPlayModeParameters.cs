namespace YooAsset
{
	/// <summary>
	/// WebGL运行模式的初始化参数
	/// </summary>
	public class WebPlayModeParameters : InitializeParameters
	{
		/// <summary>
		/// 远端资源地址查询服务类
		/// </summary>
		public IRemoteServices RemoteServices = null;

		/// <summary>
		/// 内置资源查询服务接口
		/// </summary>
		public IBuildinQueryServices BuildinQueryServices = null;
	}
}
