using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class DiamondNoteHeadGlyph : global::alphatab.rendering.glyphs.SvgGlyph 
	{
		static DiamondNoteHeadGlyph() 
		{
			global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph.noteHeadHeight = 9;
		}
		public    DiamondNoteHeadGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    DiamondNoteHeadGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph.__hx_ctor_alphatab_rendering_glyphs_DiamondNoteHeadGlyph(this, x, y, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_DiamondNoteHeadGlyph(global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph __temp_me147, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, bool isGrace)
		{
			unchecked 
			{
				int __temp_y146 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x145 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me147, new global::haxe.lang.Null<int>(__temp_x145, true), new global::haxe.lang.Null<int>(__temp_y146, true), global::alphatab.rendering.glyphs.MusicFont.NoteHarmonic, ( (isGrace) ? (0.7) : (((double) (1) )) ), ( (isGrace) ? (0.7) : (((double) (1) )) ));
				__temp_me147._isGrace = isGrace;
			}
		}
		
		
		public static  int noteHeadHeight;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.DiamondNoteHeadGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((bool) (arr[2]) ));
			}
		}
		
		
		public  bool _isGrace;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = ((int) (( ( 9 * (( (this._isGrace) ? (0.7) : (((double) (1) )) )) ) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale()
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1881669935:
					{
						this._isGrace = ((bool) (@value) );
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
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_isGrace");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


