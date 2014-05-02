using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class NoteHeadGlyph : global::alphatab.rendering.glyphs.SvgGlyph {
		static NoteHeadGlyph() {
			global::alphatab.rendering.glyphs.NoteHeadGlyph.graceScale = 0.7;
			global::alphatab.rendering.glyphs.NoteHeadGlyph.noteHeadHeight = 9;
		}
		public    NoteHeadGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    NoteHeadGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.NoteHeadGlyph.__hx_ctor_alphatab_rendering_glyphs_NoteHeadGlyph(this, x, y, duration, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_NoteHeadGlyph(global::alphatab.rendering.glyphs.NoteHeadGlyph __temp_me185, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Duration duration, bool isGrace){
			unchecked {
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me185, ( ( ! (x.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (x) ), ( ( ! (y.hasValue) ) ? (new global::haxe.lang.Null<int>(0, true)) : (y) ), __temp_me185.getNoteSvg(duration), ( (isGrace) ? (0.7) : (((double) (1) )) ), ( (isGrace) ? (0.7) : (((double) (1) )) ));
				int __temp_y184 = ( ( ! (y.hasValue) ) ? (((int) (0) )) : (y.@value) );
				int __temp_x183 = ( ( ! (x.hasValue) ) ? (((int) (0) )) : (x.@value) );
				__temp_me185._isGrace = isGrace;
				__temp_me185._duration = duration;
			}
		}
		
		
		public static  double graceScale;
		
		public static  int noteHeadHeight;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.NoteHeadGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.NoteHeadGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.Duration) (arr[2]) ), global::haxe.lang.Runtime.toBool(arr[3]));
			}
		}
		
		
		public  bool _isGrace;
		
		public  global::alphatab.model.Duration _duration;
		
		public override   void doLayout(){
			unchecked {
				global::alphatab.model.Duration _g = this._duration;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 0:
					{
						this.width = ((int) (( ( 14 * (( (this._isGrace) ? (0.7) : (((double) (1) )) )) ) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
						break;
					}
					
					
					default:
					{
						this.width = ((int) (( ( 9 * (( (this._isGrace) ? (0.7) : (((double) (1) )) )) ) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
						break;
					}
					
				}
				
			}
		}
		
		
		public override   bool canScale(){
			unchecked {
				return false;
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getNoteSvg(global::alphatab.model.Duration duration){
			unchecked {
				switch (global::haxe.root.Type.enumIndex(duration)){
					case 0:
					{
						return global::alphatab.rendering.glyphs.MusicFont.NoteWhole;
					}
					
					
					case 1:
					{
						return global::alphatab.rendering.glyphs.MusicFont.NoteHalf;
					}
					
					
					default:
					{
						return global::alphatab.rendering.glyphs.MusicFont.NoteQuarter;
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1545864883:
					{
						this._duration = ((global::alphatab.model.Duration) (@value) );
						return @value;
					}
					
					
					case 1881669935:
					{
						this._isGrace = global::haxe.lang.Runtime.toBool(@value);
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
					case 481612700:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getNoteSvg") ), ((int) (481612700) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canScale") ), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1545864883:
					{
						return this._duration;
					}
					
					
					case 1881669935:
					{
						return this._isGrace;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1825584277:case 1734479962:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 481612700:
					{
						return this.getNoteSvg(((global::alphatab.model.Duration) (dynargs[0]) ));
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_duration");
				baseArr.push("_isGrace");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


