#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sms
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct SmsEncodedLength 
	{
		// Forced skipping of method Windows.Devices.Sms.SmsEncodedLength.SmsEncodedLength()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint SegmentCount;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint CharacterCountLastSegment;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint CharactersPerSegment;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint ByteCountLastSegment;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint BytesPerSegment;
		#endif
	}
}
