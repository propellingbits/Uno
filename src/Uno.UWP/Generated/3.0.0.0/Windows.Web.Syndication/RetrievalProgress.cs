#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Web.Syndication
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct RetrievalProgress 
	{
		// Forced skipping of method Windows.Web.Syndication.RetrievalProgress.RetrievalProgress()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint BytesRetrieved;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint TotalBytesToRetrieve;
		#endif
	}
}
