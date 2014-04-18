using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreBrushGlyph : global::alphatab.rendering.Glyph 
	{
		public    ScoreBrushGlyph(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    ScoreBrushGlyph(global::alphatab.model.Beat beat) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.ScoreBrushGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreBrushGlyph(this, beat);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreBrushGlyph(global::alphatab.rendering.glyphs.ScoreBrushGlyph __temp_me194, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me194, new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true));
				__temp_me194._beat = beat;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreBrushGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreBrushGlyph(((global::alphatab.model.Beat) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.model.Beat _beat;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = ((int) (( 10 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreBarRenderer scoreBarRenderer = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				double lineSize = ( 9 * scoreBarRenderer.stave.staveGroup.layout.renderer.settings.scale );
				global::alphatab.rendering.RenderingResources res = this.renderer.stave.staveGroup.layout.renderer.renderingResources;
				int startY = default(int);
				int __temp_stmt597 = default(int);
				{
					double x = ( scoreBarRenderer.getNoteY(this._beat.maxNote()) - ( lineSize / 2 ) );
					__temp_stmt597 = ((int) (x) );
				}
				
				startY = ( ( cy + this.y ) + __temp_stmt597 );
				double endY = ( ( ( cy + this.y ) + scoreBarRenderer.getNoteY(this._beat.minNote()) ) + lineSize );
				int arrowX = ((int) (( ( cx + this.x ) + ( ((double) (this.width) ) / 2 ) )) );
				double arrowSize = ( 8 * this.renderer.stave.staveGroup.layout.renderer.settings.scale );
				canvas.setColor(res.mainGlyphColor);
				if (( this._beat.brushType != global::alphatab.model.BrushType.None )) 
				{
					if (( ( this._beat.brushType == global::alphatab.model.BrushType.ArpeggioUp ) || ( this._beat.brushType == global::alphatab.model.BrushType.ArpeggioDown ) )) 
					{
						int size = ((int) (( 15 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
						int steps = default(int);
						{
							double v = ( global::System.Math.Abs(((double) (( endY - startY )) )) / size );
							{
								double x1 = global::System.Math.Floor(((double) (v) ));
								steps = ((int) (x1) );
							}
							
						}
						
						{
							int _g = 0;
							while (( _g < ((int) (steps) ) ))
							{
								int i = _g++;
								global::alphatab.rendering.glyphs.SvgGlyph arrow = new global::alphatab.rendering.glyphs.SvgGlyph(new global::haxe.lang.Null<int>(((int) (( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ), true), new global::haxe.lang.Null<int>(0, true), ((global::alphatab.rendering.glyphs.LazySvg) (global::alphatab.rendering.glyphs.MusicFont.WaveVertical) ), ((double) (1) ), ((double) (1) ));
								arrow.renderer = this.renderer;
								arrow.doLayout();
								arrow.paint(( cx + this.x ), ( startY + ( i * size ) ), canvas);
							}
							
						}
						
					}
					
					if (( this._beat.brushType == global::alphatab.model.BrushType.ArpeggioUp )) 
					{
						canvas.beginPath();
						canvas.moveTo(((double) (arrowX) ), endY);
						canvas.lineTo(((double) (((int) (( arrowX + ( arrowSize / 2 ) )) )) ), ((double) (((int) (( endY - arrowSize )) )) ));
						canvas.lineTo(((double) (((int) (( arrowX - ( arrowSize / 2 ) )) )) ), ((double) (((int) (( endY - arrowSize )) )) ));
						canvas.closePath();
						canvas.fill();
					}
					 else 
					{
						if (( this._beat.brushType == global::alphatab.model.BrushType.ArpeggioDown )) 
						{
							canvas.beginPath();
							canvas.moveTo(((double) (arrowX) ), ((double) (startY) ));
							canvas.lineTo(((double) (((int) (( arrowX + ( arrowSize / 2 ) )) )) ), ((double) (((int) (( startY + arrowSize )) )) ));
							canvas.lineTo(((double) (((int) (( arrowX - ( arrowSize / 2 ) )) )) ), ((double) (((int) (( startY + arrowSize )) )) ));
							canvas.closePath();
							canvas.fill();
						}
						
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
					case 1948581205:
					{
						this._beat = ((global::alphatab.model.Beat) (@value) );
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
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1948581205:
					{
						return this._beat;
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
				baseArr.push("_beat");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


