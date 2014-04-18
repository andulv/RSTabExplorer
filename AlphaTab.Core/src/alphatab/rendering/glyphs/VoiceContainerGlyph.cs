using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class VoiceContainerGlyph : global::alphatab.rendering.glyphs.GlyphGroup, global::alphatab.rendering.glyphs.ISupportsFinalize 
	{
		static VoiceContainerGlyph() 
		{
			global::alphatab.rendering.glyphs.VoiceContainerGlyph.KeySizeBeat = "Beat";
		}
		public    VoiceContainerGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    VoiceContainerGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int voiceIndex) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.VoiceContainerGlyph.__hx_ctor_alphatab_rendering_glyphs_VoiceContainerGlyph(this, x, y, voiceIndex);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_VoiceContainerGlyph(global::alphatab.rendering.glyphs.VoiceContainerGlyph __temp_me229, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, int voiceIndex)
		{
			unchecked 
			{
				int __temp_y228 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x227 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.glyphs.GlyphGroup.__hx_ctor_alphatab_rendering_glyphs_GlyphGroup(__temp_me229, new global::haxe.lang.Null<int>(__temp_x227, true), new global::haxe.lang.Null<int>(__temp_y228, true), default(global::haxe.root.Array<object>));
				__temp_me229.beatGlyphs = new global::haxe.root.Array<object>();
				__temp_me229.voiceIndex = voiceIndex;
			}
		}
		
		
		public static  string KeySizeBeat;
		
		public static   string getKey(int index)
		{
			unchecked 
			{
				return "Beat";
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.VoiceContainerGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.VoiceContainerGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((int) (global::haxe.lang.Runtime.toInt(arr[2])) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> beatGlyphs;
		
		public  int voiceIndex;
		
		public override   void applyGlyphSpacing(int spacing)
		{
			unchecked 
			{
				double glyphSpacing = ( ((double) (spacing) ) / this.beatGlyphs.length );
				double gx = 0.0;
				{
					int _g1 = 0;
					int _g = this.beatGlyphs.length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						global::alphatab.rendering.glyphs.BeatContainerGlyph g = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[i]) );
						g.x = ((int) (gx) );
						gx += ( g.width + glyphSpacing );
						g.applyGlyphSpacing(((int) (glyphSpacing) ));
					}
					
				}
				
				this.width = ((int) (gx) );
			}
		}
		
		
		public virtual   void registerMaxSizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this.beatGlyphs;
				while (( _g < _g1.length ))
				{
					global::alphatab.rendering.glyphs.BeatContainerGlyph b = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (_g1[_g]) );
					 ++ _g;
					b.registerMaxSizes(sizes);
				}
				
			}
		}
		
		
		public virtual   void applySizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				this.width = 0;
				{
					int _g1 = 0;
					int _g = this.beatGlyphs.length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						if (( i == 0 )) 
						{
							((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[i]) ).x = 0;
						}
						 else 
						{
							((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[i]) ).x = ( ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[( i - 1 )]) ).x + ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[( i - 1 )]) ).width );
						}
						
						((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[i]) ).applySizes(sizes);
					}
					
				}
				
				if (( this.beatGlyphs.length > 0 )) 
				{
					this.width = ( ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[( this.beatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[( this.beatGlyphs.length - 1 )]) ).width );
				}
				
			}
		}
		
		
		public override   void addGlyph(global::alphatab.rendering.Glyph g)
		{
			unchecked 
			{
				if (( this.beatGlyphs.length == 0 )) 
				{
					g.x = 0;
				}
				 else 
				{
					g.x = ( ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[( this.beatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[( this.beatGlyphs.length - 1 )]) ).width );
				}
				
				g.index = this.beatGlyphs.length;
				g.renderer = this.renderer;
				g.doLayout();
				this.beatGlyphs.push(((global::alphatab.rendering.glyphs.BeatContainerGlyph) (g) ));
				this.width = ( g.x + g.width );
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void finalizeGlyph(global::alphatab.rendering.layout.ScoreLayout layout)
		{
			unchecked 
			{
				int _g1 = 0;
				int _g = this.beatGlyphs.length;
				while (( _g1 < _g ))
				{
					int i = _g1++;
					((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.beatGlyphs[i]) ).finalizeGlyph(layout);
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this.beatGlyphs;
				while (( _g < _g1.length ))
				{
					global::alphatab.rendering.glyphs.BeatContainerGlyph g = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (_g1[_g]) );
					 ++ _g;
					g.paint(( cx + this.x ), ( cy + this.y ), canvas);
				}
				
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1456144384:
					{
						this.voiceIndex = ((int) (@value) );
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
					case 1456144384:
					{
						this.voiceIndex = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1015335773:
					{
						this.beatGlyphs = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					
					
					case 1308691246:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeGlyph"), ((int) (1308691246) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 258089931:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addGlyph"), ((int) (258089931) ))) );
					}
					
					
					case 673875012:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applySizes"), ((int) (673875012) ))) );
					}
					
					
					case 632903889:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("registerMaxSizes"), ((int) (632903889) ))) );
					}
					
					
					case 1827465669:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applyGlyphSpacing"), ((int) (1827465669) ))) );
					}
					
					
					case 1456144384:
					{
						return this.voiceIndex;
					}
					
					
					case 1015335773:
					{
						return this.beatGlyphs;
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
					case 1456144384:
					{
						return ((double) (this.voiceIndex) );
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
					case 1827465669:case 258089931:case 1825584277:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1308691246:
					{
						this.finalizeGlyph(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
						break;
					}
					
					
					case 673875012:
					{
						this.applySizes(((global::alphatab.rendering.staves.BarSizeInfo) (dynargs[0]) ));
						break;
					}
					
					
					case 632903889:
					{
						this.registerMaxSizes(((global::alphatab.rendering.staves.BarSizeInfo) (dynargs[0]) ));
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
				baseArr.push("voiceIndex");
				baseArr.push("beatGlyphs");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


