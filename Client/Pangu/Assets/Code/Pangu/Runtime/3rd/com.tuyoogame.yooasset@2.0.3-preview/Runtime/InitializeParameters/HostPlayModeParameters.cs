namespace YooAsset
{
	/// <summary>
	/// ��������ģʽ�ĳ�ʼ������
	/// </summary>
	public class HostPlayModeParameters : InitializeParameters
	{
		/// <summary>
		/// Զ����Դ��ַ��ѯ������
		/// </summary>
		public IRemoteServices RemoteServices = null;

		/// <summary>
		/// ������Դ��ѯ����ӿ�
		/// </summary>
		public IBuildinQueryServices BuildinQueryServices = null;

		/// <summary>
		/// �ַ���Դ��ѯ����ӿ�
		/// </summary>
		public IDeliveryQueryServices DeliveryQueryServices = null;

		/// <summary>
		/// �ַ���Դ���ط���ӿ�
		/// </summary>
		public IDeliveryLoadServices DeliveryLoadServices = null;
	}
}
