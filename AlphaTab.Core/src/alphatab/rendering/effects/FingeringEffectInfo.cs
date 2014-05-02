using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects{
	public  class FingeringEffectInfo : global::alphatab.rendering.effects.NoteEffectInfoBase {
		public    FingeringEffectInfo(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    FingeringEffectInfo() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.rendering.effects.FingeringEffectInfo.__hx_ctor_alphatab_rendering_effects_FingeringEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_FingeringEffectInfo(global::alphatab.rendering.effects.FingeringEffectInfo __temp_me120){
			unchecked {
				global::alphatab.rendering.effects.NoteEffectInfoBase.__hx_ctor_alphatab_rendering_effects_NoteEffectInfoBase(__temp_me120);
				__temp_me120._maxGlyphCount = 0;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.effects.FingeringEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.effects.FingeringEffectInfo();
			}
		}
		
		
		public  int _maxGlyphCount;
		
		public override   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat){
			unchecked {
				bool result = base.shouldCreateGlyph(renderer, beat);
				if (( this._lastCreateInfo.length > this._maxGlyphCount )) {
					this._maxGlyphCount = this._lastCreateInfo.length;
				}
				
				return result;
			}
		}
		
		
		public override   bool shouldCreateGlyphForNote(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Note note){
			unchecked {
				return ( ( ( note.leftHandFinger != -1 ) && ( note.leftHandFinger != -2 ) ) || ( ( note.rightHandFinger != -1 ) && ( note.rightHandFinger != -2 ) ) );
			}
		}
		
		
		public override   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer){
			unchecked {
				return ( this._maxGlyphCount * (((int) (( 20 * renderer.stave.staveGroup.layout.renderer.settings.scale )) )) );
			}
		}
		
		
		public override   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode(){
			unchecked {
				return global::alphatab.rendering.EffectBarGlyphSizing.SingleOnBeatOnly;
			}
		}
		
		
		public override   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat){
			unchecked {
				return new global::alphatab.rendering.glyphs.effects.DummyEffectGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((string) (global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(this._lastCreateInfo.length), "fingering")) ));
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1115413384:
					{
						this._maxGlyphCount = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1115413384:
					{
						this._maxGlyphCount = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 193577032:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createNewGlyph") ), ((int) (193577032) ))) );
					}
					
					
					case 268685047:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getSizingMode") ), ((int) (268685047) ))) );
					}
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("getHeight") ), ((int) (2124583197) ))) );
					}
					
					
					case 1906986366:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("shouldCreateGlyphForNote") ), ((int) (1906986366) ))) );
					}
					
					
					case 286784413:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("shouldCreateGlyph") ), ((int) (286784413) ))) );
					}
					
					
					case 1115413384:
					{
						return this._maxGlyphCount;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				switch (hash){
					case 1115413384:
					{
						return ((double) (this._maxGlyphCount) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_maxGlyphCount");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


