#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Perception
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PerceptionInfraredFrameSourceRemovedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Devices.Perception.PerceptionInfraredFrameSource FrameSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionInfraredFrameSource PerceptionInfraredFrameSourceRemovedEventArgs.FrameSource is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Perception.PerceptionInfraredFrameSourceRemovedEventArgs.FrameSource.get
	}
}
