using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.svg{
	public  class FontSizes : global::haxe.lang.HxObject {
		static FontSizes() {
			global::alphatab.platform.svg.FontSizes.TimesNewRoman = new global::haxe.root.Array<int>(new int[]{3, 4, 5, 6, 6, 9, 9, 2, 4, 4, 6, 6, 3, 4, 3, 3, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 3, 3, 6, 6, 6, 5, 10, 8, 7, 7, 8, 7, 6, 7, 8, 4, 4, 8, 7, 10, 8, 8, 7, 8, 7, 5, 8, 8, 7, 11, 8, 8, 7, 4, 3, 4, 5, 6, 4, 5, 5, 5, 5, 5, 4, 5, 6, 3, 3, 6, 3, 9, 6, 6, 6, 5, 4, 4, 4, 5, 6, 7, 6, 6, 5, 5, 2, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 4, 6, 6, 6, 6, 2, 5, 4, 8, 4, 6, 6, 0, 8, 6, 4, 6, 3, 3, 4, 5, 5, 4, 4, 3, 3, 6, 8, 8, 8, 5, 8, 8, 8, 8, 8, 8, 11, 7, 7, 7, 7, 7, 4, 4, 4, 4, 8, 8, 8, 8, 8, 8, 8, 6, 8, 8, 8, 8, 8, 8, 6, 5, 5, 5, 5, 5, 5, 5, 8, 5, 5, 5, 5, 5, 3, 3, 3, 3, 6, 6, 6, 6, 6, 6, 6, 6, 6, 5, 5, 5, 5, 6, 6});
			global::alphatab.platform.svg.FontSizes.Arial11Pt = new global::haxe.root.Array<int>(new int[]{3, 2, 4, 6, 6, 10, 7, 2, 4, 4, 4, 6, 3, 4, 3, 3, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 3, 3, 6, 6, 6, 6, 11, 8, 7, 7, 7, 6, 6, 8, 7, 2, 5, 7, 6, 8, 7, 8, 6, 8, 7, 7, 6, 7, 8, 10, 7, 8, 7, 3, 3, 3, 5, 6, 4, 6, 6, 6, 6, 6, 4, 6, 6, 2, 2, 5, 2, 8, 6, 6, 6, 6, 4, 6, 3, 6, 6, 10, 6, 6, 6, 4, 2, 4, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 2, 6, 6, 7, 6, 2, 6, 4, 8, 4, 6, 6, 0, 8, 6, 4, 6, 4, 4, 4, 6, 6, 4, 4, 4, 5, 6, 9, 10, 10, 6, 8, 8, 8, 8, 8, 8, 11, 7, 6, 6, 6, 6, 2, 2, 2, 2, 8, 7, 8, 8, 8, 8, 8, 6, 8, 7, 7, 7, 7, 8, 7, 7, 6, 6, 6, 6, 6, 6, 10, 6, 6, 6, 6, 6, 2, 2, 2, 2, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6});
			global::alphatab.platform.svg.FontSizes.ControlChars = 32;
		}
		public    FontSizes(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    FontSizes(){
			unchecked {
				global::alphatab.platform.svg.FontSizes.__hx_ctor_alphatab_platform_svg_FontSizes(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_svg_FontSizes(global::alphatab.platform.svg.FontSizes __temp_me103){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  global::haxe.root.Array<int> TimesNewRoman;
		
		public static  global::haxe.root.Array<int> Arial11Pt;
		
		public static  int ControlChars;
		
		public static   int measureString(string s, global::alphatab.platform.svg.SupportedFonts f, double size){
			unchecked {
				global::haxe.root.Array<int> data = default(global::haxe.root.Array<int>);
				int dataSize = default(int);
				if (( f == global::alphatab.platform.svg.SupportedFonts.TimesNewRoman )) {
					data = global::alphatab.platform.svg.FontSizes.TimesNewRoman;
					dataSize = 11;
				}
				 else {
					if (( f == global::alphatab.platform.svg.SupportedFonts.Arial )) {
						data = global::alphatab.platform.svg.FontSizes.Arial11Pt;
						dataSize = 11;
					}
					 else {
						data = new global::haxe.root.Array<int>(new int[]{8});
						dataSize = 11;
					}
					
				}
				
				int stringSize = 0;
				{
					int _g1 = 0;
					int _g = s.Length;
					while (( _g1 < _g )){
						int i = _g1++;
						int code = default(int);
						int __temp_stmt552 = default(int);
						{
							double x = default(double);
							{
								double b = ((double) (global::haxe.lang.StringExt.charCodeAt(s, i).@value) );
								x = global::System.Math.Min(((double) (( data.length - 1 )) ), ((double) (b) ));
							}
							
							__temp_stmt552 = ((int) (x) );
						}
						
						code = ( __temp_stmt552 - global::alphatab.platform.svg.FontSizes.ControlChars );
						if (( code >= 0 )) {
							int charSize = data[code];
							stringSize += ((int) (( ( data[code] * size ) / dataSize )) );
						}
						
					}
					
				}
				
				return stringSize;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.platform.svg.FontSizes(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.platform.svg.FontSizes();
			}
		}
		
		
	}
}


