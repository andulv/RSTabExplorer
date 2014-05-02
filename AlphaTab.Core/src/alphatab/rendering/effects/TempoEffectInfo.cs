using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects{
	public  class TempoEffectInfo : global::haxe.lang.HxObject, global::alphatab.rendering.IEffectBarRendererInfo {
		public    TempoEffectInfo(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    TempoEffectInfo(){
			unchecked {
				global::alphatab.rendering.effects.TempoEffectInfo.__hx_ctor_alphatab_rendering_effects_TempoEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_TempoEffectInfo(global::alphatab.rendering.effects.TempoEffectInfo __temp_me31){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.effects.TempoEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.effects.TempoEffectInfo();
			}
		}
		
		
		public virtual   bool hideOnMultiTrack(){
			unchecked {
				return true;
			}
		}
		
		
		public virtual   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat){
			unchecked {
				bool __temp_boolv514 = ( beat.index == 0 );
				bool __temp_boolv513 = false;
				if (__temp_boolv514) {
					global::alphatab.model.MasterBar __temp_stmt517 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this = beat.voice.bar;
						__temp_stmt517 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
					}
					
					bool __temp_stmt516 = ( __temp_stmt517.tempoAutomation != default(global::alphatab.model.Automation) );
					bool __temp_boolv518 = false;
					if ( ! (__temp_stmt516) ) {
						__temp_boolv518 = ( beat.voice.bar.index == 0 );
					}
					
					bool __temp_stmt515 = ( __temp_stmt516 || __temp_boolv518 );
					__temp_boolv513 = (__temp_stmt515);
				}
				
				bool __temp_stmt512 = ( __temp_boolv514 && __temp_boolv513 );
				return __temp_stmt512;
			}
		}
		
		
		public virtual   bool canExpand(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat @from, global::alphatab.model.Beat to){
			unchecked {
				return true;
			}
		}
		
		
		public virtual   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer){
			unchecked {
				return ((int) (( 25 * renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public virtual   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode(){
			unchecked {
				return global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly;
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat){
			unchecked {
				int tempo = default(int);
				global::alphatab.model.MasterBar __temp_stmt519 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = beat.voice.bar;
					__temp_stmt519 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (( __temp_stmt519.tempoAutomation != default(global::alphatab.model.Automation) )) {
					global::alphatab.model.MasterBar __temp_stmt520 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = beat.voice.bar;
						__temp_stmt520 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					tempo = ((int) (__temp_stmt520.tempoAutomation.@value) );
				}
				 else {
					tempo = beat.voice.bar.track.score.tempo;
				}
				
				return new global::alphatab.rendering.glyphs.effects.TempoGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (tempo) ));
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
					
					
					case 381239946:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("canExpand") ), ((int) (381239946) ))) );
					}
					
					
					case 286784413:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("shouldCreateGlyph") ), ((int) (286784413) ))) );
					}
					
					
					case 496180019:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("hideOnMultiTrack") ), ((int) (496180019) ))) );
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
					case 193577032:
					{
						return this.createNewGlyph(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ));
					}
					
					
					case 268685047:
					{
						return this.getSizingMode();
					}
					
					
					case 2124583197:
					{
						return this.getHeight(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ));
					}
					
					
					case 381239946:
					{
						return this.canExpand(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ), ((global::alphatab.model.Beat) (dynargs[2]) ));
					}
					
					
					case 286784413:
					{
						return this.shouldCreateGlyph(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ));
					}
					
					
					case 496180019:
					{
						return this.hideOnMultiTrack();
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
	}
}


