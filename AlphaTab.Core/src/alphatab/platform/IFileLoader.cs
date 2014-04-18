using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform
{
	public  interface IFileLoader : global::haxe.lang.IHxObject 
	{
		   global::haxe.io.Bytes loadBinary(string path);
		
		   void loadBinaryAsync(string path, global::haxe.lang.Function success, global::haxe.lang.Function error);
		
	}
}


