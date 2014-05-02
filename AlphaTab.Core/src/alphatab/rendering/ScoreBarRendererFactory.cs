using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class ScoreBarRendererFactory : global::alphatab.rendering.BarRendererFactory {
		public    ScoreBarRendererFactory(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    ScoreBarRendererFactory() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.ScoreBarRendererFactory.__hx_ctor_alphatab_rendering_ScoreBarRendererFactory(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_ScoreBarRendererFactory(global::alphatab.rendering.ScoreBarRendererFactory __temp_me39){
			unchecked {
				global::alphatab.rendering.BarRendererFactory.__hx_ctor_alphatab_rendering_BarRendererFactory(__temp_me39);
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.ScoreBarRendererFactory(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.ScoreBarRendererFactory();
			}
		}
		
		
		public override   global::alphatab.rendering.BarRendererBase create(global::alphatab.model.Bar bar){
			unchecked {
				return new global::alphatab.rendering.ScoreBarRenderer(((global::alphatab.model.Bar) (bar) ));
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 2081384188:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("create") ), ((int) (2081384188) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


