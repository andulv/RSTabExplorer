using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class BarSeperatorGlyph : global::alphatab.rendering.Glyph 
	{
		public    BarSeperatorGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    BarSeperatorGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<bool> isLast) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.BarSeperatorGlyph.__hx_ctor_alphatab_rendering_glyphs_BarSeperatorGlyph(this, x, y, isLast);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BarSeperatorGlyph(global::alphatab.rendering.glyphs.BarSeperatorGlyph __temp_me126, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::haxe.lang.Null<bool> isLast)
		{
			unchecked 
			{
				bool __temp_isLast125 = ( (global::haxe.lang.Runtime.eq((isLast).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (isLast.@value) );
				int __temp_y124 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x123 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me126, new global::haxe.lang.Null<int>(__temp_x123, true), new global::haxe.lang.Null<int>(__temp_y124, true));
				__temp_me126._isLast = __temp_isLast125;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.BarSeperatorGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.BarSeperatorGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Null<object>.ofDynamic<bool>(arr[2]));
			}
		}
		
		
		public  bool _isLast;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = ((int) (( (( (this._isLast) ? (8) : (1) )) * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   bool canScale()
		{
			unchecked 
			{
				return false;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.barSeperatorColor);
				double blockWidth = ( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				int top = ( ( cy + this.y ) + this.renderer.getTopPadding() );
				int bottom = ( ( ( cy + this.y ) + this.renderer.height ) - this.renderer.getBottomPadding() );
				double left = ((double) (( cx + this.x )) );
				int h = ( bottom - top );
				canvas.beginPath();
				canvas.moveTo(left, ((double) (top) ));
				canvas.lineTo(left, ((double) (bottom) ));
				canvas.stroke();
				if (this._isLast) 
				{
					left += ( ( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) + 0.5 );
					canvas.fillRect(left, ((double) (top) ), blockWidth, ((double) (h) ));
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1401610495:
					{
						this._isLast = ((bool) (@value) );
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
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1401610495:
					{
						return this._isLast;
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
				baseArr.push("_isLast");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


