using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs.effects
{
	public  class LineRangedGlyph : global::alphatab.rendering.Glyph, global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph 
	{
		static LineRangedGlyph() 
		{
			global::alphatab.rendering.glyphs.effects.LineRangedGlyph.LineSpacing = 3;
			global::alphatab.rendering.glyphs.effects.LineRangedGlyph.LineTopPadding = 8;
			global::alphatab.rendering.glyphs.effects.LineRangedGlyph.LineTopOffset = 6;
			global::alphatab.rendering.glyphs.effects.LineRangedGlyph.LineSize = 8;
		}
		public    LineRangedGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    LineRangedGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, string label) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.effects.LineRangedGlyph.__hx_ctor_alphatab_rendering_glyphs_effects_LineRangedGlyph(this, x, y, label);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_effects_LineRangedGlyph(global::alphatab.rendering.glyphs.effects.LineRangedGlyph __temp_me245, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, string label)
		{
			unchecked 
			{
				int __temp_y244 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x243 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me245, new global::haxe.lang.Null<int>(__temp_x243, true), new global::haxe.lang.Null<int>(__temp_y244, true));
				__temp_me245._label = label;
			}
		}
		
		
		public static  int LineSpacing;
		
		public static  int LineTopPadding;
		
		public static  int LineTopOffset;
		
		public static  int LineSize;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.LineRangedGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.effects.LineRangedGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), global::haxe.lang.Runtime.toString(arr[2]));
			}
		}
		
		
		public  bool _isExpanded;
		
		public  string _label;
		
		public virtual   void expandedTo(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				this._isExpanded = true;
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				double step = ( 11 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				int loops = default(int);
				{
					double v = global::System.Math.Max(((double) (1) ), ((double) (( this.width / step )) ));
					{
						double x = global::System.Math.Floor(((double) (v) ));
						loops = ((int) (x) );
					}
					
				}
				
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				canvas.setColor(res.mainGlyphColor);
				canvas.setFont(res.effectFont);
				canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Left);
				double textWidth = canvas.measureText(this._label);
				canvas.fillText(this._label, ((double) (( cx + this.x )) ), ((double) (( cy + this.y )) ));
				if (this._isExpanded) 
				{
					int lineSpacing = ((int) (( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
					double startX = ( ( ( cx + this.x ) + textWidth ) + lineSpacing );
					int endX = ( ( ( ( cx + this.x ) + this.width ) - lineSpacing ) - lineSpacing );
					int lineY = ( ( cy + this.y ) + ((int) (( 8 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) );
					int lineSize = ((int) (( 8 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
					if (( endX > startX )) 
					{
						double lineX = startX;
						while (( lineX < endX ))
						{
							canvas.beginPath();
							canvas.moveTo(lineX, ((double) (lineY) ));
							int __temp_stmt606 = default(int);
							{
								double x1 = global::System.Math.Min(((double) (( lineX + lineSize )) ), ((double) (endX) ));
								__temp_stmt606 = ((int) (x1) );
							}
							
							canvas.lineTo(((double) (__temp_stmt606) ), ((double) (lineY) ));
							lineX += ((double) (( lineSize + lineSpacing )) );
							canvas.stroke();
						}
						
						canvas.beginPath();
						canvas.moveTo(((double) (endX) ), ((double) (( lineY - ((int) (( 6 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) )) ));
						canvas.lineTo(((double) (endX) ), ((double) (( lineY + ((int) (( 6 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) )) ));
						canvas.stroke();
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
					case 1805014325:
					{
						this._label = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1191702626:
					{
						this._isExpanded = ((bool) (@value) );
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
					
					
					case 1486936852:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("expandedTo"), ((int) (1486936852) ))) );
					}
					
					
					case 1805014325:
					{
						return this._label;
					}
					
					
					case 1191702626:
					{
						return this._isExpanded;
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
					case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1486936852:
					{
						this.expandedTo(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return default(object);
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("_label");
				baseArr.push("_isExpanded");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


