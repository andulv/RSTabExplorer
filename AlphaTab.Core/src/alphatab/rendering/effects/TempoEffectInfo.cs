using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects
{
	public  class TempoEffectInfo : global::haxe.lang.HxObject, global::alphatab.rendering.IEffectBarRendererInfo 
	{
		public    TempoEffectInfo(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    TempoEffectInfo()
		{
			unchecked 
			{
				global::alphatab.rendering.effects.TempoEffectInfo.__hx_ctor_alphatab_rendering_effects_TempoEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_TempoEffectInfo(global::alphatab.rendering.effects.TempoEffectInfo __temp_me30)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.TempoEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.TempoEffectInfo();
			}
		}
		
		
		public virtual   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				bool __temp_boolv487 = ( beat.index == 0 );
				bool __temp_boolv486 = false;
				if (__temp_boolv487) 
				{
					global::alphatab.model.MasterBar __temp_stmt490 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this = beat.voice.bar;
						__temp_stmt490 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
					}
					
					bool __temp_stmt489 = ( __temp_stmt490.tempoAutomation != default(global::alphatab.model.Automation) );
					bool __temp_boolv491 = false;
					if ( ! (__temp_stmt489) ) 
					{
						__temp_boolv491 = ( beat.voice.bar.index == 0 );
					}
					
					bool __temp_stmt488 = ( __temp_stmt489 || __temp_boolv491 );
					__temp_boolv486 = (__temp_stmt488);
				}
				
				bool __temp_stmt485 = ( __temp_boolv487 && __temp_boolv486 );
				return __temp_stmt485;
			}
		}
		
		
		public virtual   bool canExpand(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat @from, global::alphatab.model.Beat to)
		{
			unchecked 
			{
				return true;
			}
		}
		
		
		public virtual   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer)
		{
			unchecked 
			{
				return ((int) (( 25 * renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public virtual   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode()
		{
			unchecked 
			{
				return global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly;
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				int tempo = default(int);
				global::alphatab.model.MasterBar __temp_stmt492 = default(global::alphatab.model.MasterBar);
				{
					global::alphatab.model.Bar _this = beat.voice.bar;
					__temp_stmt492 = ((global::alphatab.model.MasterBar) (_this.track.score.masterBars[_this.index]) );
				}
				
				if (( __temp_stmt492.tempoAutomation != default(global::alphatab.model.Automation) )) 
				{
					global::alphatab.model.MasterBar __temp_stmt493 = default(global::alphatab.model.MasterBar);
					{
						global::alphatab.model.Bar _this1 = beat.voice.bar;
						__temp_stmt493 = ((global::alphatab.model.MasterBar) (_this1.track.score.masterBars[_this1.index]) );
					}
					
					tempo = ((int) (__temp_stmt493.tempoAutomation.@value) );
				}
				 else 
				{
					tempo = beat.voice.bar.track.score.tempo;
				}
				
				return new global::alphatab.rendering.glyphs.effects.TempoGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (tempo) ));
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 193577032:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createNewGlyph"), ((int) (193577032) ))) );
					}
					
					
					case 268685047:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSizingMode"), ((int) (268685047) ))) );
					}
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getHeight"), ((int) (2124583197) ))) );
					}
					
					
					case 381239946:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canExpand"), ((int) (381239946) ))) );
					}
					
					
					case 286784413:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("shouldCreateGlyph"), ((int) (286784413) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs)
		{
			unchecked 
			{
				switch (hash)
				{
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
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
		}
		
		
	}
}


