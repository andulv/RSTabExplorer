using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class BeatContainerGlyph : global::alphatab.rendering.Glyph, global::alphatab.rendering.glyphs.ISupportsFinalize 
	{
		static BeatContainerGlyph() 
		{
			global::alphatab.rendering.glyphs.BeatContainerGlyph.PixelPerTick = 0.041666666666666664;
		}
		public    BeatContainerGlyph(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    BeatContainerGlyph(global::alphatab.model.Beat beat) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.BeatContainerGlyph.__hx_ctor_alphatab_rendering_glyphs_BeatContainerGlyph(this, beat);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_BeatContainerGlyph(global::alphatab.rendering.glyphs.BeatContainerGlyph __temp_me130, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me130, new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true));
				__temp_me130.beat = beat;
				__temp_me130.ties = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  double PixelPerTick;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.BeatContainerGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.BeatContainerGlyph(((global::alphatab.model.Beat) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.model.Beat beat;
		
		public  global::alphatab.rendering.glyphs.BeatGlyphBase preNotes;
		
		public  global::alphatab.rendering.glyphs.BeatGlyphBase onNotes;
		
		public  global::alphatab.rendering.glyphs.BeatGlyphBase postNotes;
		
		public  global::haxe.root.Array<object> ties;
		
		public virtual   void finalizeGlyph(global::alphatab.rendering.layout.ScoreLayout layout)
		{
			unchecked 
			{
				if (( this.preNotes is global::alphatab.rendering.glyphs.ISupportsFinalize )) 
				{
					(((global::alphatab.rendering.glyphs.ISupportsFinalize) (((object) (this.preNotes) )) )).finalizeGlyph(layout);
				}
				
				if (( this.onNotes is global::alphatab.rendering.glyphs.ISupportsFinalize )) 
				{
					(((global::alphatab.rendering.glyphs.ISupportsFinalize) (((object) (this.onNotes) )) )).finalizeGlyph(layout);
				}
				
				if (( this.postNotes is global::alphatab.rendering.glyphs.ISupportsFinalize )) 
				{
					(((global::alphatab.rendering.glyphs.ISupportsFinalize) (((object) (this.postNotes) )) )).finalizeGlyph(layout);
				}
				
			}
		}
		
		
		public virtual   void registerMaxSizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				if (( sizes.getPreNoteSize(this.beat.start) < this.preNotes.width )) 
				{
					sizes.preNoteSizes.@set(this.beat.start, this.preNotes.width);
				}
				
				if (( sizes.getOnNoteSize(this.beat.start) < this.onNotes.width )) 
				{
					sizes.onNoteSizes.@set(this.beat.start, this.onNotes.width);
				}
				
				if (( sizes.getPostNoteSize(this.beat.start) < this.postNotes.width )) 
				{
					sizes.postNoteSizes.@set(this.beat.start, this.postNotes.width);
				}
				
			}
		}
		
		
		public virtual   void applySizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				int size = default(int);
				int diff = default(int);
				size = sizes.getPreNoteSize(this.beat.start);
				diff = ( size - this.preNotes.width );
				this.preNotes.x = 0;
				if (( diff > 0 )) 
				{
					this.preNotes.applyGlyphSpacing(diff);
				}
				
				size = sizes.getOnNoteSize(this.beat.start);
				diff = ( size - this.onNotes.width );
				this.onNotes.x = ( this.preNotes.x + this.preNotes.width );
				if (( diff > 0 )) 
				{
					this.onNotes.applyGlyphSpacing(diff);
				}
				
				size = sizes.getPostNoteSize(this.beat.start);
				diff = ( size - this.postNotes.width );
				this.postNotes.x = ( this.onNotes.x + this.onNotes.width );
				if (( diff > 0 )) 
				{
					this.postNotes.applyGlyphSpacing(diff);
				}
				
				this.width = this.calculateWidth();
			}
		}
		
		
		public virtual   int calculateWidth()
		{
			unchecked 
			{
				return ( this.postNotes.x + this.postNotes.width );
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.preNotes.x = 0;
				this.preNotes.index = 0;
				this.preNotes.renderer = this.renderer;
				this.preNotes.container = this;
				this.preNotes.doLayout();
				this.onNotes.x = ( this.preNotes.x + this.preNotes.width );
				this.onNotes.index = 1;
				this.onNotes.renderer = this.renderer;
				this.onNotes.container = this;
				this.onNotes.doLayout();
				this.postNotes.x = ( this.onNotes.x + this.onNotes.width );
				this.postNotes.index = 2;
				this.postNotes.renderer = this.renderer;
				this.postNotes.container = this;
				this.postNotes.doLayout();
				int i = ( this.beat.notes.length - 1 );
				while (( i >= 0 ))
				{
					this.createTies(((global::alphatab.model.Note) (this.beat.notes[i--]) ));
				}
				
				this.width = this.calculateWidth();
			}
		}
		
		
		public virtual   void createTies(global::alphatab.model.Note n)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				this.preNotes.paint(( cx + this.x ), ( cy + this.y ), canvas);
				this.onNotes.paint(( cx + this.x ), ( cy + this.y ), canvas);
				this.postNotes.paint(( cx + this.x ), ( cy + this.y ), canvas);
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this.ties;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.Glyph t = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						t.renderer = this.renderer;
						t.paint(cx, ( cy + this.y ), canvas);
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
					case 1291633955:
					{
						this.ties = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1493167041:
					{
						this.postNotes = ((global::alphatab.rendering.glyphs.BeatGlyphBase) (@value) );
						return @value;
					}
					
					
					case 906525346:
					{
						this.onNotes = ((global::alphatab.rendering.glyphs.BeatGlyphBase) (@value) );
						return @value;
					}
					
					
					case 530877726:
					{
						this.preNotes = ((global::alphatab.rendering.glyphs.BeatGlyphBase) (@value) );
						return @value;
					}
					
					
					case 1091821942:
					{
						this.beat = ((global::alphatab.model.Beat) (@value) );
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
					
					
					case 1602913855:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createTies"), ((int) (1602913855) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1829781184:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("calculateWidth"), ((int) (1829781184) ))) );
					}
					
					
					case 673875012:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applySizes"), ((int) (673875012) ))) );
					}
					
					
					case 632903889:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("registerMaxSizes"), ((int) (632903889) ))) );
					}
					
					
					case 1308691246:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeGlyph"), ((int) (1308691246) ))) );
					}
					
					
					case 1291633955:
					{
						return this.ties;
					}
					
					
					case 1493167041:
					{
						return this.postNotes;
					}
					
					
					case 906525346:
					{
						return this.onNotes;
					}
					
					
					case 530877726:
					{
						return this.preNotes;
					}
					
					
					case 1091821942:
					{
						return this.beat;
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
					case 1825584277:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1602913855:
					{
						this.createTies(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 1829781184:
					{
						return this.calculateWidth();
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
					
					
					case 1308691246:
					{
						this.finalizeGlyph(((global::alphatab.rendering.layout.ScoreLayout) (dynargs[0]) ));
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
				baseArr.push("ties");
				baseArr.push("postNotes");
				baseArr.push("onNotes");
				baseArr.push("preNotes");
				baseArr.push("beat");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


