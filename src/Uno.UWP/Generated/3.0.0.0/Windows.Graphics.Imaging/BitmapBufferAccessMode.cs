#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Imaging
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum BitmapBufferAccessMode 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Read,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		ReadWrite,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Write,
		#endif
	}
	#endif
}
