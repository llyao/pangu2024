
namespace YooAsset
{
	/// <summary>
	/// 默认的构建管线
	/// </summary>
	public enum EDefaultBuildPipeline
	{
		/// <summary>
		/// 内置构建管线
		/// </summary>
		BuiltinBuildPipeline,

		/// <summary>
		/// 可编程构建管线
		/// </summary>
		ScriptableBuildPipeline,

		/// <summary>
		/// 原生文件构建管线
		/// </summary>
		RawFileBuildPipeline,
	}

	/// <summary>
	/// 运行模式
	/// </summary>
	public enum EPlayMode
	{
		/// <summary>
		/// 编辑器下的模拟模式
		/// </summary>
		EditorSimulateMode,

		/// <summary>
		/// 离线运行模式
		/// </summary>
		OfflinePlayMode,

		/// <summary>
		/// 联机运行模式
		/// </summary>
		HostPlayMode,

		/// <summary>
		/// WebGL运行模式
		/// </summary>
		WebPlayMode,
	}

	/// <summary>
	/// 初始化参数
	/// </summary>
	public abstract class InitializeParameters
	{
		/// <summary>
		/// 内置文件的根路径
		/// 注意：当参数为空的时候会使用默认的根目录。
		/// </summary>
		public string BuildinRootDirectory = string.Empty;

		/// <summary>
		/// 沙盒文件的根路径
		/// 注意：当参数为空的时候会使用默认的根目录。
		/// </summary>
		public string SandboxRootDirectory = string.Empty;

		/// <summary>
		/// 缓存文件追加原始后缀格式
		/// </summary>
		public bool CacheFileAppendExtension = false;

		/// <summary>
		/// 缓存系统启动时的验证级别
		/// </summary>
		public EVerifyLevel CacheBootVerifyLevel = EVerifyLevel.Middle;

		/// <summary>
		/// 自动销毁不再使用的资源提供者
		/// </summary>
		public bool AutoDestroyAssetProvider = false;

		/// <summary>
		/// 启用断点续传参数
		/// 说明：当文件的大小大于设置的字节数时启用断点续传下载器
		/// </summary>
		public uint BreakpointResumeFileSize = int.MaxValue;

		/// <summary>
		/// 文件解密服务接口
		/// </summary>
		public IDecryptionServices DecryptionServices = null;
	}
}