namespace YooAsset
{
	/// <summary>
	/// WebGL����ģʽ�ĳ�ʼ������
	/// </summary>
	public class WebPlayModeParameters : InitializeParameters
	{
		/// <summary>
		/// Զ����Դ��ַ��ѯ������
		/// </summary>
		public IRemoteServices RemoteServices = null;

		/// <summary>
		/// ������Դ��ѯ����ӿ�
		/// </summary>
		public IBuildinQueryServices BuildinQueryServices = null;
	}
}
