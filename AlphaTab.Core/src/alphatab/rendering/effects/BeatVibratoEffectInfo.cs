using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects
{
	public  class BeatVibratoEffectInfo : global::haxe.lang.HxObject, global::alphatab.rendering.IEffectBarRendererInfo 
	{
		public    BeatVibratoEffectInfo(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    BeatVibratoEffectInfo()
		{
			unchecked 
			{
				global::alphatab.rendering.effects.BeatVibratoEffectInfo.__hx_ctor_alphatab_rendering_effects_BeatVibratoEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_BeatVibratoEffectInfo(global::alphatab.rendering.effects.BeatVibratoEffectInfo __temp_me35)
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
				return new global::alphatab.rendering.effects.BeatVibratoEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.BeatVibratoEffectInfo();
			}
		}
		
		
		public virtual   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				return ( beat.vibrato != global::alphatab.model.VibratoType.None );
			}
		}
		
		
		public virtual   bool canExpand(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat @from, global::alphatab.model.Beat to)
		{
			unchecked 
			{
				return true;
			}
		}
		
		
		public virtual   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode()
		{
			unchecked 
			{
				return global::alphatab.rendering.EffectBarGlyphSizing.GroupedOnBeatToPostBeat;
			}
		}
		
		
		public virtual   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer)
		{
			unchecked 
			{
				return ((int) (( 17 * renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.VibratoGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(((int) (( 5 * renderer.stave.staveGroup.layout.renderer.settings.scale )) ), true), new global::haxe.lang.Null<double>(1.15, true));
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
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getHeight"), ((int) (2124583197) ))) );
					}
					
					
					case 268685047:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSizingMode"), ((int) (268685047) ))) );
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
					
					
					case 2124583197:
					{
						return this.getHeight(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ));
					}
					
					
					case 268685047:
					{
						return this.getSizingMode();
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


