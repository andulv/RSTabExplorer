using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class GroupedBarRenderer : global::alphatab.rendering.BarRendererBase 
	{
		static GroupedBarRenderer() 
		{
			global::alphatab.rendering.GroupedBarRenderer.KeySizePre = "Pre";
			global::alphatab.rendering.GroupedBarRenderer.KeySizePost = "Post";
		}
		public    GroupedBarRenderer(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
			}
		}
		
		
		public    GroupedBarRenderer(global::alphatab.model.Bar bar) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				global::alphatab.rendering.GroupedBarRenderer.__hx_ctor_alphatab_rendering_GroupedBarRenderer(this, bar);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_GroupedBarRenderer(global::alphatab.rendering.GroupedBarRenderer __temp_me92, global::alphatab.model.Bar bar)
		{
			unchecked 
			{
				global::alphatab.rendering.BarRendererBase.__hx_ctor_alphatab_rendering_BarRendererBase(__temp_me92, bar);
				__temp_me92._preBeatGlyphs = new global::haxe.root.Array<object>();
				__temp_me92._voiceContainers = new global::haxe.root.Array<object>();
				__temp_me92._postBeatGlyphs = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  string KeySizePre;
		
		public static  string KeySizePost;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.GroupedBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.GroupedBarRenderer(((global::alphatab.model.Bar) (arr[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _preBeatGlyphs;
		
		public  global::haxe.root.Array<object> _voiceContainers;
		
		public  global::haxe.root.Array<object> _postBeatGlyphs;
		
		public  global::alphatab.rendering.glyphs.VoiceContainerGlyph _biggestVoiceContainer;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.createPreBeatGlyphs();
				this.createBeatGlyphs();
				this.createPostBeatGlyphs();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._voiceContainers;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
						 ++ _g;
						c.doLayout();
					}
					
				}
				
				this.updateWidth();
			}
		}
		
		
		public virtual   void updateWidth()
		{
			unchecked 
			{
				this.width = this.getPostBeatGlyphsStart();
				if (( this._postBeatGlyphs.length > 0 )) 
				{
					this.width += ( ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).width );
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._voiceContainers;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
						 ++ _g;
						if (( ( this._biggestVoiceContainer == default(global::alphatab.rendering.glyphs.VoiceContainerGlyph) ) || ( c.width > this._biggestVoiceContainer.width ) )) 
						{
							this._biggestVoiceContainer = c;
						}
						
					}
					
				}
				
			}
		}
		
		
		public override   void registerMaxSizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				int preSize = this.getBeatGlyphsStart();
				if (( sizes.getSize("Pre").@value < preSize )) 
				{
					sizes.setSize("Pre", preSize);
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._voiceContainers;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
						 ++ _g;
						c.registerMaxSizes(sizes);
					}
					
				}
				
				int postSize = default(int);
				if (( this._postBeatGlyphs.length == 0 )) 
				{
					postSize = 0;
				}
				 else 
				{
					postSize = ( ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).width );
				}
				
				if (( sizes.getSize("Post").@value < postSize )) 
				{
					sizes.setSize("Post", postSize);
				}
				
				if (( sizes.fullWidth < this.width )) 
				{
					sizes.fullWidth = this.width;
				}
				
			}
		}
		
		
		public override   void applySizes(global::alphatab.rendering.staves.BarSizeInfo sizes)
		{
			unchecked 
			{
				global::haxe.lang.Null<int> preSize = sizes.getSize("Pre");
				int preSizeDiff = ( preSize.@value - this.getBeatGlyphsStart() );
				if (( preSizeDiff > 0 )) 
				{
					this.addPreBeatGlyph(new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (preSizeDiff) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._voiceContainers;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
						 ++ _g;
						c.applySizes(sizes);
					}
					
				}
				
				global::haxe.lang.Null<int> postSize = sizes.getSize("Post");
				int postSizeDiff = default(int);
				if (( this._postBeatGlyphs.length == 0 )) 
				{
					postSizeDiff = 0;
				}
				 else 
				{
					postSizeDiff = ( postSize.@value - (( ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).width )) );
				}
				
				if (( postSizeDiff > 0 )) 
				{
					this._postBeatGlyphs.insert(0, new global::alphatab.rendering.glyphs.SpacingGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (postSizeDiff) ), ((global::haxe.lang.Null<bool>) (default(global::haxe.lang.Null<bool>)) )));
					{
						int _g11 = 0;
						int _g2 = this._postBeatGlyphs.length;
						while (( _g11 < _g2 ))
						{
							int i = _g11++;
							global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[i]) );
							if (( i == 0 )) 
							{
								g.x = 0;
							}
							 else 
							{
								g.x = ( ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.Glyph) (this._postBeatGlyphs[( this._postBeatGlyphs.length - 1 )]) ).width );
							}
							
							g.index = i;
							g.renderer = this;
						}
						
					}
					
				}
				
				this.updateWidth();
			}
		}
		
		
		public virtual   void addGlyph(global::haxe.root.Array<object> c, global::alphatab.rendering.Glyph g)
		{
			unchecked 
			{
				this.isEmpty = false;
				if (( c.length == 0 )) 
				{
					g.x = 0;
				}
				 else 
				{
					g.x = ( ((global::alphatab.rendering.Glyph) (c[( c.length - 1 )]) ).x + ((global::alphatab.rendering.Glyph) (c[( c.length - 1 )]) ).width );
				}
				
				g.index = c.length;
				g.renderer = this;
				g.doLayout();
				c.push(g);
			}
		}
		
		
		public virtual   void addPreBeatGlyph(global::alphatab.rendering.Glyph g)
		{
			unchecked 
			{
				this.addGlyph(this._preBeatGlyphs, g);
			}
		}
		
		
		public virtual   void addBeatGlyph(global::alphatab.rendering.glyphs.BeatContainerGlyph g)
		{
			unchecked 
			{
				this.getOrCreateVoiceContainer(g.beat.voice.index).addGlyph(g);
			}
		}
		
		
		public virtual   global::alphatab.rendering.glyphs.VoiceContainerGlyph getOrCreateVoiceContainer(int voiceIndex)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.VoiceContainerGlyph c = default(global::alphatab.rendering.glyphs.VoiceContainerGlyph);
				if (( voiceIndex >= this._voiceContainers.length )) 
				{
					c = new global::alphatab.rendering.glyphs.VoiceContainerGlyph(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true), ((int) (voiceIndex) ));
					c.renderer = this;
					this._voiceContainers[voiceIndex] = c;
				}
				 else 
				{
					c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (this._voiceContainers[voiceIndex]) );
				}
				
				return c;
			}
		}
		
		
		public   global::alphatab.rendering.glyphs.BeatContainerGlyph getBeatContainer(int voice, int beat)
		{
			unchecked 
			{
				return ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(voice).beatGlyphs[beat]) );
			}
		}
		
		
		public   global::alphatab.rendering.glyphs.BeatGlyphBase getPreNotesPosition(int voice, int beat)
		{
			unchecked 
			{
				return ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(voice).beatGlyphs[beat]) ).preNotes;
			}
		}
		
		
		public   global::alphatab.rendering.glyphs.BeatGlyphBase getOnNotesPosition(int voice, int beat)
		{
			unchecked 
			{
				return ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(voice).beatGlyphs[beat]) ).onNotes;
			}
		}
		
		
		public   global::alphatab.rendering.glyphs.BeatGlyphBase getPostNotesPosition(int voice, int beat)
		{
			unchecked 
			{
				return ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(voice).beatGlyphs[beat]) ).postNotes;
			}
		}
		
		
		public virtual   void addPostBeatGlyph(global::alphatab.rendering.Glyph g)
		{
			unchecked 
			{
				this.addGlyph(this._postBeatGlyphs, g);
			}
		}
		
		
		public virtual   void createPreBeatGlyphs()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void createBeatGlyphs()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void createPostBeatGlyphs()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   int getPreBeatGlyphStart()
		{
			unchecked 
			{
				return 0;
			}
		}
		
		
		public virtual   int getBeatGlyphsStart()
		{
			unchecked 
			{
				int start = this.getPreBeatGlyphStart();
				if (( this._preBeatGlyphs.length > 0 )) 
				{
					start += ( ((global::alphatab.rendering.Glyph) (this._preBeatGlyphs[( this._preBeatGlyphs.length - 1 )]) ).x + ((global::alphatab.rendering.Glyph) (this._preBeatGlyphs[( this._preBeatGlyphs.length - 1 )]) ).width );
				}
				
				return start;
			}
		}
		
		
		public virtual   int getPostBeatGlyphsStart()
		{
			unchecked 
			{
				int start = this.getBeatGlyphsStart();
				int offset = 0;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._voiceContainers;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
						 ++ _g;
						if (( c.width > offset )) 
						{
							offset = c.width;
						}
						
					}
					
				}
				
				return ( start + offset );
			}
		}
		
		
		public override   void applyBarSpacing(int spacing)
		{
			unchecked 
			{
				this.width += spacing;
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._voiceContainers;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
						 ++ _g;
						int toApply = spacing;
						if (( this._biggestVoiceContainer != default(global::alphatab.rendering.glyphs.VoiceContainerGlyph) )) 
						{
							toApply += ( this._biggestVoiceContainer.width - c.width );
						}
						
						c.applyGlyphSpacing(toApply);
					}
					
				}
				
			}
		}
		
		
		public override   void finalizeRenderer(global::alphatab.rendering.layout.ScoreLayout layout)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._voiceContainers;
				while (( _g < _g1.length ))
				{
					global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g1[_g]) );
					 ++ _g;
					c.finalizeGlyph(layout);
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				this.paintBackground(cx, cy, canvas);
				int glyphStartX = this.getPreBeatGlyphStart();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._preBeatGlyphs;
					while (( _g < _g1.length ))
					{
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (_g1[_g]) );
						 ++ _g;
						g.paint(( ( cx + this.x ) + glyphStartX ), ( cy + this.y ), canvas);
					}
					
				}
				
				glyphStartX = this.getBeatGlyphsStart();
				{
					int _g2 = 0;
					global::haxe.root.Array<object> _g11 = this._voiceContainers;
					while (( _g2 < _g11.length ))
					{
						global::alphatab.rendering.glyphs.VoiceContainerGlyph c = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (_g11[_g2]) );
						 ++ _g2;
						c.paint(( ( cx + this.x ) + glyphStartX ), ( cy + this.y ), canvas);
					}
					
				}
				
				glyphStartX = this.getPostBeatGlyphsStart();
				{
					int _g3 = 0;
					global::haxe.root.Array<object> _g12 = this._postBeatGlyphs;
					while (( _g3 < _g12.length ))
					{
						global::alphatab.rendering.Glyph g1 = ((global::alphatab.rendering.Glyph) (_g12[_g3]) );
						 ++ _g3;
						g1.paint(( ( cx + this.x ) + glyphStartX ), ( cy + this.y ), canvas);
					}
					
				}
				
			}
		}
		
		
		public virtual   void paintBackground(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 572707279:
					{
						this._biggestVoiceContainer = ((global::alphatab.rendering.glyphs.VoiceContainerGlyph) (@value) );
						return @value;
					}
					
					
					case 1420285052:
					{
						this._postBeatGlyphs = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 486630117:
					{
						this._voiceContainers = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 347982241:
					{
						this._preBeatGlyphs = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBackground"), ((int) (1334722860) ))) );
					}
					
					
					case 1028568990:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paint"), ((int) (1028568990) ))) );
					}
					
					
					case 236164353:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeRenderer"), ((int) (236164353) ))) );
					}
					
					
					case 561297662:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("applyBarSpacing"), ((int) (561297662) ))) );
					}
					
					
					case 447718479:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getPostBeatGlyphsStart"), ((int) (447718479) ))) );
					}
					
					
					case 1349150671:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBeatGlyphsStart"), ((int) (1349150671) ))) );
					}
					
					
					case 702377529:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getPreBeatGlyphStart"), ((int) (702377529) ))) );
					}
					
					
					case 2000963577:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPostBeatGlyphs"), ((int) (2000963577) ))) );
					}
					
					
					case 1907509625:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createBeatGlyphs"), ((int) (1907509625) ))) );
					}
					
					
					case 918754500:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPreBeatGlyphs"), ((int) (918754500) ))) );
					}
					
					
					case 1248668917:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addPostBeatGlyph"), ((int) (1248668917) ))) );
					}
					
					
					case 1602529300:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getPostNotesPosition"), ((int) (1602529300) ))) );
					}
					
					
					case 1581836661:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getOnNotesPosition"), ((int) (1581836661) ))) );
					}
					
					
					case 1905696925:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getPreNotesPosition"), ((int) (1905696925) ))) );
					}
					
					
					case 1705131637:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBeatContainer"), ((int) (1705131637) ))) );
					}
					
					
					case 90098500:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getOrCreateVoiceContainer"), ((int) (90098500) ))) );
					}
					
					
					case 484418037:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addBeatGlyph"), ((int) (484418037) ))) );
					}
					
					
					case 1239076724:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addPreBeatGlyph"), ((int) (1239076724) ))) );
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
					
					
					case 804986685:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("updateWidth"), ((int) (804986685) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 572707279:
					{
						return this._biggestVoiceContainer;
					}
					
					
					case 1420285052:
					{
						return this._postBeatGlyphs;
					}
					
					
					case 486630117:
					{
						return this._voiceContainers;
					}
					
					
					case 347982241:
					{
						return this._preBeatGlyphs;
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
					case 1825584277:case 632903889:case 673875012:case 561297662:case 236164353:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 1334722860:
					{
						this.paintBackground(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::alphatab.platform.ICanvas) (dynargs[2]) ));
						break;
					}
					
					
					case 447718479:
					{
						return this.getPostBeatGlyphsStart();
					}
					
					
					case 1349150671:
					{
						return this.getBeatGlyphsStart();
					}
					
					
					case 702377529:
					{
						return this.getPreBeatGlyphStart();
					}
					
					
					case 2000963577:
					{
						this.createPostBeatGlyphs();
						break;
					}
					
					
					case 1907509625:
					{
						this.createBeatGlyphs();
						break;
					}
					
					
					case 918754500:
					{
						this.createPreBeatGlyphs();
						break;
					}
					
					
					case 1248668917:
					{
						this.addPostBeatGlyph(((global::alphatab.rendering.Glyph) (dynargs[0]) ));
						break;
					}
					
					
					case 1602529300:
					{
						return this.getPostNotesPosition(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1581836661:
					{
						return this.getOnNotesPosition(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1905696925:
					{
						return this.getPreNotesPosition(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 1705131637:
					{
						return this.getBeatContainer(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					}
					
					
					case 90098500:
					{
						return this.getOrCreateVoiceContainer(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 484418037:
					{
						this.addBeatGlyph(((global::alphatab.rendering.glyphs.BeatContainerGlyph) (dynargs[0]) ));
						break;
					}
					
					
					case 1239076724:
					{
						this.addPreBeatGlyph(((global::alphatab.rendering.Glyph) (dynargs[0]) ));
						break;
					}
					
					
					case 258089931:
					{
						this.addGlyph(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (dynargs[0]) ))) ), ((global::alphatab.rendering.Glyph) (dynargs[1]) ));
						break;
					}
					
					
					case 804986685:
					{
						this.updateWidth();
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
				baseArr.push("_biggestVoiceContainer");
				baseArr.push("_postBeatGlyphs");
				baseArr.push("_voiceContainers");
				baseArr.push("_preBeatGlyphs");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


