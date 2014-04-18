using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects
{
	public  class TapEffectInfo : global::haxe.lang.HxObject, global::alphatab.rendering.IEffectBarRendererInfo 
	{
		public    TapEffectInfo(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    TapEffectInfo()
		{
			unchecked 
			{
				global::alphatab.rendering.effects.TapEffectInfo.__hx_ctor_alphatab_rendering_effects_TapEffectInfo(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_TapEffectInfo(global::alphatab.rendering.effects.TapEffectInfo __temp_me41)
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
				return new global::alphatab.rendering.effects.TapEffectInfo(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.TapEffectInfo();
			}
		}
		
		
		public virtual   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				return ( ( beat.slap || beat.pop ) || beat.tap );
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
				return ((int) (( 20 * renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public virtual   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode()
		{
			unchecked 
			{
				return global::alphatab.rendering.EffectBarGlyphSizing.SingleOnBeatOnly;
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = renderer.stave.staveGroup.layout.renderer.renderingResources;
				if (beat.slap) 
				{
					return new global::alphatab.rendering.glyphs.effects.TextGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), global::haxe.lang.Runtime.toString("S"), ((global::alphatab.platform.model.Font) (res.effectFont) ));
				}
				
				if (beat.pop) 
				{
					return new global::alphatab.rendering.glyphs.effects.TextGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), global::haxe.lang.Runtime.toString("P"), ((global::alphatab.platform.model.Font) (res.effectFont) ));
				}
				
				return new global::alphatab.rendering.glyphs.effects.TextGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), global::haxe.lang.Runtime.toString("T"), ((global::alphatab.platform.model.Font) (res.effectFont) ));
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


