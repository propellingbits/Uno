#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct TimedTextSize 
	{
		// Forced skipping of method Windows.Media.Core.TimedTextSize.TimedTextSize()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double Height;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  double Width;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Media.Core.TimedTextUnit Unit;
		#endif
	}
}
