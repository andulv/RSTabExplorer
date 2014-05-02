using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering{
	public  class RhythmBarRendererFactory : global::alphatab.rendering.BarRendererFactory {
		public    RhythmBarRendererFactory(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )){
			unchecked {
			}
		}
		
		
		public    RhythmBarRendererFactory(global::alphatab.rendering.utils.BeamDirection direction) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.RhythmBarRendererFactory.__hx_ctor_alphatab_rendering_RhythmBarRendererFactory(this, direction);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_RhythmBarRendererFactory(global::alphatab.rendering.RhythmBarRendererFactory __temp_me48, global::alphatab.rendering.utils.BeamDirection direction){
			unchecked {
				global::alphatab.rendering.BarRendererFactory.__hx_ctor_alphatab_rendering_BarRendererFactory(__temp_me48);
				__temp_me48.isInAccolade = false;
				__temp_me48._direction = direction;
				__temp_me48.hideOnMultiTrack = false;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.RhythmBarRendererFactory(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.RhythmBarRendererFactory(((global::alphatab.rendering.utils.BeamDirection) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.rendering.utils.BeamDirection _direction;
		
		public override   global::alphatab.rendering.BarRendererBase create(global::alphatab.model.Bar bar){
			unchecked {
				return new global::alphatab.rendering.RhythmBarRenderer(((global::alphatab.model.Bar) (bar) ), ((global::alphatab.rendering.utils.BeamDirection) (this._direction) ));
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1810030080:
					{
						this._direction = ((global::alphatab.rendering.utils.BeamDirection) (@value) );
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
					
					
					case 1810030080:
					{
						return this._direction;
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
				baseArr.push("_direction");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


