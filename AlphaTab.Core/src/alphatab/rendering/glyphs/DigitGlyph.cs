using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class DigitGlyph : global::alphatab.rendering.glyphs.SvgGlyph 
	{
		public    DigitGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    DigitGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int digit) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.DigitGlyph.__hx_ctor_alphatab_rendering_glyphs_DigitGlyph(this, x, y, digit);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_DigitGlyph(global::alphatab.rendering.glyphs.DigitGlyph __temp_me150, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int digit)
		{
			unchecked 
			{
				int __temp_y149 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x148 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.glyphs.SvgGlyph.__hx_ctor_alphatab_rendering_glyphs_SvgGlyph(__temp_me150, new global::haxe.lang.Null<int>(__temp_x148, true), new global::haxe.lang.Null<int>(__temp_y149, true), __temp_me150.getDigit(digit), ((double) (1) ), ((double) (1) ));
				__temp_me150._digit = digit;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.DigitGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.DigitGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ));
			}
		}
		
		
		public  int _digit;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.y += ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				{
					double x = ( this.getDigitWidth(this._digit) * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
					this.width = ((int) (x) );
				}
				
			}
		}
		
		
		public override   bool canScale()
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public virtual   int getDigitWidth(int digit)
		{
			unchecked 
			{
				switch (digit)
				{
					case 0:case 2:case 3:case 4:case 5:case 6:case 7:case 8:case 9:
					{
						return 14;
					}
					
					
					case 1:
					{
						return 10;
					}
					
					
					default:
					{
						return 0;
					}
					
				}
				
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.LazySvg getDigit(int digit)
		{
			unchecked 
			{
				switch (digit)
				{
					case 0:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num0;
					}
					
					
					case 1:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num1;
					}
					
					
					case 2:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num2;
					}
					
					
					case 3:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num3;
					}
					
					
					case 4:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num4;
					}
					
					
					case 5:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num5;
					}
					
					
					case 6:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num6;
					}
					
					
					case 7:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num7;
					}
					
					
					case 8:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num8;
					}
					
					
					case 9:
					{
						return global::alphatab.rendering.glyphs.MusicFont.Num9;
					}
					
					
					default:
					{
						return default(global::alphatab.rendering.glyphs.LazySvg);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1437545710:
					{
						this._digit = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1437545710:
					{
						this._digit = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 966720823:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getDigit"), ((int) (966720823) ))) );
					}
					
					
					case 1327292751:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getDigitWidth"), ((int) (1327292751) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1437545710:
					{
						return this._digit;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1437545710:
					{
						return ((double) (this._digit) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
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
					case 1825584277:case 1734479962:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 966720823:
					{
						return this.getDigit(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1327292751:
					{
						return this.getDigitWidth(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
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
				baseArr.push("_digit");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


