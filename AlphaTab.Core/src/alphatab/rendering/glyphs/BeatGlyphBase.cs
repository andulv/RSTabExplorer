using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs{
	public  class BeatGlyphBase : global::alphatab.rendering.glyphs.GlyphGroup {
		public    BeatGlyphBase(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    BeatGlyphBase() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.glyphs.BeatGlyphBase.__hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BeatGlyphBase(global::alphatab.rendering.glyphs.BeatGlyphBase __temp_me146){
			unchecked {
				global::alphatab.rendering.glyphs.GlyphGroup.__hx_ctor_alphatab_rendering_glyphs_GlyphGroup(__temp_me146, default(global::haxe.lang.Null<int>), default(global::haxe.lang.Null<int>), default(global::haxe.root.Array<object>));
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.glyphs.BeatGlyphBase(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.glyphs.BeatGlyphBase();
			}
		}
		
		
		public  global::alphatab.rendering.glyphs.BeatContainerGlyph container;
		
		public override   void doLayout(){
			unchecked {
				int w = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._glyphs;
					while (( _g < _g1.length )){
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.x = w;
						g.renderer = this.renderer;
						g.doLayout();
						w += g.width;
					}
					
				}
				
				this.width = w;
			}
		}
		
		
		public virtual   void noteLoop(global::haxe.lang.Function action){
			unchecked {
				int i = ( this.container.beat.notes.length - 1 );
				while (( i >= 0 )){
					action.__hx_invoke1_o(default(double), ((global::alphatab.model.Note) (this.container.beat.notes[i--]) ));
				}
				
			}
		}
		
		
		public virtual   int getBeatDurationWidth(){
			unchecked {
				global::alphatab.model.Duration _g = this.container.beat.duration;
				switch (global::haxe.root.Type.enumIndex(_g)){
					case 0:
					{
						return 103;
					}
					
					
					case 1:
					{
						return 45;
					}
					
					
					case 2:
					{
						return 29;
					}
					
					
					case 3:
					{
						return 19;
					}
					
					
					case 4:
					{
						return 11;
					}
					
					
					case 5:
					{
						return 11;
					}
					
					
					case 6:
					{
						return 11;
					}
					
					
				}
				
				return default(int);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1064531265:
					{
						this.container = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (@value) );
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
					case 1195604294:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getBeatDurationWidth") ), ((int) (1195604294) ))) );
					}
					
					
					case 1458228086:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("noteLoop") ), ((int) (1458228086) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("doLayout") ), ((int) (1825584277) ))) );
					}
					
					
					case 1064531265:
					{
						return this.container;
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
					case 1825584277:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1195604294:
					{
						return this.getBeatDurationWidth();
					}
					
					
					case 1458228086:
					{
						this.noteLoop(((global::haxe.lang.Function) (dynargs[0]) ));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("container");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


