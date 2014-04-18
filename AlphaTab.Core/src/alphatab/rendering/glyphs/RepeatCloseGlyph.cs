using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class RepeatCloseGlyph : global::alphatab.rendering.Glyph 
	{
		public    RepeatCloseGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    RepeatCloseGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.RepeatCloseGlyph.__hx_ctor_alphatab_rendering_glyphs_RepeatCloseGlyph(this, x, y);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_RepeatCloseGlyph(global::alphatab.rendering.glyphs.RepeatCloseGlyph __temp_me177, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y)
		{
			unchecked 
			{
				int __temp_y176 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x175 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me177, new global::haxe.lang.Null<int>(__temp_x175, true), new global::haxe.lang.Null<int>(__temp_y176, true));
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.RepeatCloseGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.RepeatCloseGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				int @base = default(int);
				bool __temp_stmt595 = default(bool);
				{
					global::alphatab.rendering.BarRendererBase _this = this.renderer;
					__temp_stmt595 = ( _this._bar.index == ( _this._bar.track.bars.length - 1 ) );
				}
				
				if (__temp_stmt595) 
				{
					@base = 11;
				}
				 else 
				{
					@base = 13;
				}
				
				this.width = ((int) (( @base * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
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
				canvas.setColor(res.mainGlyphColor);
				double blockWidth = ( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				int top = ( ( cy + this.y ) + this.renderer.getTopPadding() );
				int bottom = ( ( ( cy + this.y ) + this.renderer.height ) - this.renderer.getBottomPadding() );
				double left = ((double) (( cx + this.x )) );
				int h = ( bottom - top );
				double circleSize = ( 1.5 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				double middle = ( ((double) ((( top + bottom ))) ) / 2 );
				int dotOffset = 3;
				canvas.beginPath();
				canvas.circle(left, ( middle - ( circleSize * dotOffset ) ), circleSize);
				canvas.circle(left, ( middle + ( circleSize * dotOffset ) ), circleSize);
				canvas.fill();
				left += ( 4 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				canvas.beginPath();
				canvas.moveTo(left, ((double) (top) ));
				canvas.lineTo(left, ((double) (bottom) ));
				canvas.stroke();
				left += ( ( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) + 0.5 );
				canvas.fillRect(left, ((double) (top) ), blockWidth, ((double) (h) ));
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
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
	}
}


