#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.WiFiDirect.Services
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum WiFiDirectServiceIPProtocol 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Tcp,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Udp,
		#endif
	}
	#endif
}
