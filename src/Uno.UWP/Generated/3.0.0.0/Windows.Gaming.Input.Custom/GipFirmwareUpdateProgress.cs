#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input.Custom
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct GipFirmwareUpdateProgress 
	{
		// Forced skipping of method Windows.Gaming.Input.Custom.GipFirmwareUpdateProgress.GipFirmwareUpdateProgress()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double PercentCompleted;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint CurrentComponentId;
		#endif
	}
}
