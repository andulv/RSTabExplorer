using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.layout{
	public  class HeaderFooterElements : global::haxe.lang.HxObject {
		static HeaderFooterElements() {
			global::alphatab.rendering.layout.HeaderFooterElements.None = 0;
			global::alphatab.rendering.layout.HeaderFooterElements.Title = 1;
			global::alphatab.rendering.layout.HeaderFooterElements.SubTitle = 2;
			global::alphatab.rendering.layout.HeaderFooterElements.Artist = 4;
			global::alphatab.rendering.layout.HeaderFooterElements.Album = 8;
			global::alphatab.rendering.layout.HeaderFooterElements.Words = 16;
			global::alphatab.rendering.layout.HeaderFooterElements.Music = 32;
			global::alphatab.rendering.layout.HeaderFooterElements.WordsAndMusic = 64;
			global::alphatab.rendering.layout.HeaderFooterElements.Copyright = 128;
			global::alphatab.rendering.layout.HeaderFooterElements.PageNumber = 256;
			global::alphatab.rendering.layout.HeaderFooterElements.All = 511;
		}
		public    HeaderFooterElements(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    HeaderFooterElements(){
			unchecked {
				global::alphatab.rendering.layout.HeaderFooterElements.__hx_ctor_alphatab_rendering_layout_HeaderFooterElements(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_layout_HeaderFooterElements(global::alphatab.rendering.layout.HeaderFooterElements __temp_me278){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  int None;
		
		public static  int Title;
		
		public static  int SubTitle;
		
		public static  int Artist;
		
		public static  int Album;
		
		public static  int Words;
		
		public static  int Music;
		
		public static  int WordsAndMusic;
		
		public static  int Copyright;
		
		public static  int PageNumber;
		
		public static  int All;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.layout.HeaderFooterElements(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.layout.HeaderFooterElements();
			}
		}
		
		
	}
}


