using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class EffectBarRendererFactory : global::alphatab.rendering.BarRendererFactory {
		public    EffectBarRendererFactory(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    EffectBarRendererFactory(global::alphatab.rendering.IEffectBarRendererInfo info) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.EffectBarRendererFactory.__hx_ctor_alphatab_rendering_EffectBarRendererFactory(this, info);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_EffectBarRendererFactory(global::alphatab.rendering.EffectBarRendererFactory __temp_me30, global::alphatab.rendering.IEffectBarRendererInfo info){
			unchecked {
				global::alphatab.rendering.BarRendererFactory.__hx_ctor_alphatab_rendering_BarRendererFactory(__temp_me30);
				__temp_me30.isInAccolade = false;
				__temp_me30._info = info;
				__temp_me30.hideOnMultiTrack = info.hideOnMultiTrack();
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.EffectBarRendererFactory(((global::alphatab.rendering.IEffectBarRendererInfo) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.IEffectBarRendererInfo _info;
		
		public override   global::alphatab.rendering.BarRendererBase create(global::alphatab.model.Bar bar){
			unchecked {
				return new global::alphatab.rendering.EffectBarRenderer(((global::alphatab.model.Bar) (bar) ), ((global::alphatab.rendering.IEffectBarRendererInfo) (this._info) ));
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 2026656845:
					{
						this._info = ((global::alphatab.rendering.IEffectBarRendererInfo) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 2081384188:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("create") ), ((int) (2081384188) ))) );
					}
					
					
					case 2026656845:
					{
						return this._info;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_info");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


