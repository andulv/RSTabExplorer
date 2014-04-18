using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.effects
{
	public  class NoteEffectInfoBase : global::haxe.lang.HxObject, global::alphatab.rendering.IEffectBarRendererInfo 
	{
		public    NoteEffectInfoBase(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    NoteEffectInfoBase()
		{
			unchecked 
			{
				global::alphatab.rendering.effects.NoteEffectInfoBase.__hx_ctor_alphatab_rendering_effects_NoteEffectInfoBase(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_effects_NoteEffectInfoBase(global::alphatab.rendering.effects.NoteEffectInfoBase __temp_me33)
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
				return new global::alphatab.rendering.effects.NoteEffectInfoBase(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.effects.NoteEffectInfoBase();
			}
		}
		
		
		public  global::haxe.root.Array<object> _lastCreateInfo;
		
		public virtual   bool shouldCreateGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				this._lastCreateInfo = new global::haxe.root.Array<object>();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = beat.notes;
					while (( _g < _g1.length ))
					{
						global::alphatab.model.Note n = ((global::alphatab.model.Note) (_g1[_g]) );
						 ++ _g;
						if (this.shouldCreateGlyphForNote(renderer, n)) 
						{
							this._lastCreateInfo.push(n);
						}
						
					}
					
				}
				
				return ( this._lastCreateInfo.length > 0 );
			}
		}
		
		
		public virtual   bool canExpand(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat @from, global::alphatab.model.Beat to)
		{
			unchecked 
			{
				return true;
			}
		}
		
		
		public virtual   bool shouldCreateGlyphForNote(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Note note)
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public virtual   int getHeight(global::alphatab.rendering.EffectBarRenderer renderer)
		{
			unchecked 
			{
				return 0;
			}
		}
		
		
		public virtual   global::alphatab.rendering.EffectBarGlyphSizing getSizingMode()
		{
			unchecked 
			{
				return global::alphatab.rendering.EffectBarGlyphSizing.GroupedOnBeatToPostBeat;
			}
		}
		
		
		public virtual   global::alphatab.rendering.Glyph createNewGlyph(global::alphatab.rendering.EffectBarRenderer renderer, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				return default(global::alphatab.rendering.Glyph);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 355457055:
					{
						this._lastCreateInfo = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
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
					
					
					case 1906986366:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("shouldCreateGlyphForNote"), ((int) (1906986366) ))) );
					}
					
					
					case 381239946:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canExpand"), ((int) (381239946) ))) );
					}
					
					
					case 286784413:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("shouldCreateGlyph"), ((int) (286784413) ))) );
					}
					
					
					case 355457055:
					{
						return this._lastCreateInfo;
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
					
					
					case 1906986366:
					{
						return this.shouldCreateGlyphForNote(((global::alphatab.rendering.EffectBarRenderer) (dynargs[0]) ), ((global::alphatab.model.Note) (dynargs[1]) ));
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_lastCreateInfo");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


