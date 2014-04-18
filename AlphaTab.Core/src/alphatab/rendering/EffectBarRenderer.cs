using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class EffectBarRenderer : global::alphatab.rendering.GroupedBarRenderer 
	{
		public    EffectBarRenderer(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    EffectBarRenderer(global::alphatab.model.Bar bar, global::alphatab.rendering.IEffectBarRendererInfo info) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ))
		{
			unchecked 
			{
				global::alphatab.rendering.EffectBarRenderer.__hx_ctor_alphatab_rendering_EffectBarRenderer(this, bar, info);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_EffectBarRenderer(global::alphatab.rendering.EffectBarRenderer __temp_me93, global::alphatab.model.Bar bar, global::alphatab.rendering.IEffectBarRendererInfo info)
		{
			unchecked 
			{
				global::alphatab.rendering.GroupedBarRenderer.__hx_ctor_alphatab_rendering_GroupedBarRenderer(__temp_me93, bar);
				__temp_me93._info = info;
				__temp_me93._uniqueEffectGlyphs = new global::haxe.root.Array<object>();
				__temp_me93._effectGlyphs = new global::haxe.root.Array<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.EffectBarRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.EffectBarRenderer(((global::alphatab.model.Bar) (arr[0]) ), ((global::alphatab.rendering.IEffectBarRendererInfo) (arr[1]) ));
			}
		}
		
		
		public  global::alphatab.rendering.IEffectBarRendererInfo _info;
		
		public  global::haxe.root.Array<object> _uniqueEffectGlyphs;
		
		public  global::haxe.root.Array<object> _effectGlyphs;
		
		public  global::alphatab.model.Beat _lastBeat;
		
		public override   void doLayout()
		{
			unchecked 
			{
				base.doLayout();
				if (( this.index == 0 )) 
				{
					this.stave.topSpacing = 5;
					this.stave.bottomSpacing = 5;
				}
				
				this.height = this._info.getHeight(this);
			}
		}
		
		
		public override   void finalizeRenderer(global::alphatab.rendering.layout.ScoreLayout layout)
		{
			unchecked 
			{
				base.finalizeRenderer(layout);
				this.isEmpty = true;
				global::alphatab.rendering.Glyph prevGlyph = default(global::alphatab.rendering.Glyph);
				if (( this.index > 0 )) 
				{
					global::alphatab.rendering.EffectBarRenderer prevRenderer = ((global::alphatab.rendering.EffectBarRenderer) (((global::alphatab.rendering.BarRendererBase) (this.stave.barRenderers[( this.index - 1 )]) )) );
					if (( prevRenderer._lastBeat != default(global::alphatab.model.Beat) )) 
					{
						prevGlyph = ((global::alphatab.rendering.Glyph) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (prevRenderer._effectGlyphs[0]) ))) ).@get(prevRenderer._lastBeat.index).@value) );
					}
					
				}
				
				{
					object __temp_iterator446 = ((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._effectGlyphs[0]) ))) ).keys();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator446, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						int beatIndex = ((int) (global::haxe.lang.Runtime.toInt(global::haxe.lang.Runtime.callField(__temp_iterator446, "next", 1224901875, default(global::haxe.root.Array)))) );
						global::alphatab.rendering.Glyph effect = ((global::alphatab.rendering.Glyph) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._effectGlyphs[0]) ))) ).@get(beatIndex).@value) );
						this.alignGlyph(this._info.getSizingMode(), beatIndex, 0, prevGlyph);
						prevGlyph = effect;
						this.isEmpty = false;
					}
					
				}
				
			}
		}
		
		
		public virtual   void alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing sizing, int beatIndex, int voiceIndex, global::alphatab.rendering.Glyph prevGlyph)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._effectGlyphs[voiceIndex]) ))) ).@get(beatIndex).@value) );
				global::alphatab.rendering.Glyph pos = default(global::alphatab.rendering.Glyph);
				global::alphatab.rendering.glyphs.BeatContainerGlyph container = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (this.getOrCreateVoiceContainer(voiceIndex).beatGlyphs[beatIndex]) );
				switch (global::haxe.root.Type.enumIndex(sizing))
				{
					case 0:
					{
						pos = container.preNotes;
						g.x = ( pos.x + container.x );
						g.width = pos.width;
						break;
					}
					
					
					case 1:
					{
						pos = container.preNotes;
						g.x = ( pos.x + container.x );
						pos = container.onNotes;
						g.width = ( ( ( pos.x + container.x ) + pos.width ) - g.x );
						break;
					}
					
					
					case 2:
					{
						pos = container.preNotes;
						g.x = ( pos.x + container.x );
						pos = container.postNotes;
						g.width = ( ( ( pos.x + container.x ) + pos.width ) - g.x );
						break;
					}
					
					
					case 3:
					{
						pos = container.onNotes;
						g.x = ( pos.x + container.x );
						g.width = pos.width;
						break;
					}
					
					
					case 4:
					{
						pos = container.onNotes;
						g.x = ( pos.x + container.x );
						pos = container.postNotes;
						g.width = ( ( ( pos.x + container.x ) + pos.width ) - g.x );
						break;
					}
					
					
					case 5:
					{
						pos = container.postNotes;
						g.x = ( pos.x + container.x );
						g.width = pos.width;
						break;
					}
					
					
					case 6:
					{
						if (( g != prevGlyph )) 
						{
							this.alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly, beatIndex, voiceIndex, prevGlyph);
						}
						 else 
						{
							pos = container.preNotes;
							global::alphatab.rendering.EffectBarRenderer posR = default(global::alphatab.rendering.EffectBarRenderer);
							posR = ((global::alphatab.rendering.EffectBarRenderer) (pos.renderer) );
							global::alphatab.rendering.EffectBarRenderer gR = default(global::alphatab.rendering.EffectBarRenderer);
							gR = ((global::alphatab.rendering.EffectBarRenderer) (g.renderer) );
							g.width = ( ( ( ( ( posR.x + posR.getBeatGlyphsStart() ) + container.x ) + pos.x ) + pos.width ) - (( ( gR.x + gR.getBeatGlyphsStart() ) + g.x )) );
							if (( g is global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph )) 
							{
								(((global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph) (((object) (g) )) )).expandedTo(container.beat);
							}
							
						}
						
						break;
					}
					
					
					case 7:
					{
						if (( g != prevGlyph )) 
						{
							this.alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatToOnBeat, beatIndex, voiceIndex, prevGlyph);
						}
						 else 
						{
							pos = container.onNotes;
							global::alphatab.rendering.EffectBarRenderer posR1 = default(global::alphatab.rendering.EffectBarRenderer);
							posR1 = ((global::alphatab.rendering.EffectBarRenderer) (pos.renderer) );
							global::alphatab.rendering.EffectBarRenderer gR1 = default(global::alphatab.rendering.EffectBarRenderer);
							gR1 = ((global::alphatab.rendering.EffectBarRenderer) (g.renderer) );
							g.width = ( ( ( ( ( posR1.x + posR1.getBeatGlyphsStart() ) + container.x ) + pos.x ) + pos.width ) - (( ( gR1.x + gR1.getBeatGlyphsStart() ) + g.x )) );
							if (( g is global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph )) 
							{
								(((global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph) (((object) (g) )) )).expandedTo(container.beat);
							}
							
						}
						
						break;
					}
					
					
					case 8:
					{
						if (( g != prevGlyph )) 
						{
							this.alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatToPostBeat, beatIndex, voiceIndex, prevGlyph);
						}
						 else 
						{
							pos = container.postNotes;
							global::alphatab.rendering.EffectBarRenderer posR2 = default(global::alphatab.rendering.EffectBarRenderer);
							posR2 = ((global::alphatab.rendering.EffectBarRenderer) (pos.renderer) );
							global::alphatab.rendering.EffectBarRenderer gR2 = default(global::alphatab.rendering.EffectBarRenderer);
							gR2 = ((global::alphatab.rendering.EffectBarRenderer) (g.renderer) );
							g.width = ( ( ( ( ( posR2.x + posR2.getBeatGlyphsStart() ) + container.x ) + pos.x ) + pos.width ) - (( ( gR2.x + gR2.getBeatGlyphsStart() ) + g.x )) );
							if (( g is global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph )) 
							{
								(((global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph) (((object) (g) )) )).expandedTo(container.beat);
							}
							
						}
						
						break;
					}
					
					
					case 9:
					{
						if (( g != prevGlyph )) 
						{
							this.alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SingleOnBeatOnly, beatIndex, voiceIndex, prevGlyph);
						}
						 else 
						{
							pos = container.onNotes;
							global::alphatab.rendering.EffectBarRenderer posR3 = default(global::alphatab.rendering.EffectBarRenderer);
							posR3 = ((global::alphatab.rendering.EffectBarRenderer) (pos.renderer) );
							global::alphatab.rendering.EffectBarRenderer gR3 = default(global::alphatab.rendering.EffectBarRenderer);
							gR3 = ((global::alphatab.rendering.EffectBarRenderer) (g.renderer) );
							g.width = ( ( ( ( ( posR3.x + posR3.getBeatGlyphsStart() ) + container.x ) + pos.x ) + pos.width ) - (( ( gR3.x + gR3.getBeatGlyphsStart() ) + g.x )) );
							if (( g is global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph )) 
							{
								(((global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph) (((object) (g) )) )).expandedTo(container.beat);
							}
							
						}
						
						break;
					}
					
					
					case 10:
					{
						if (( g != prevGlyph )) 
						{
							this.alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SingleOnBeatToPostBeat, beatIndex, voiceIndex, prevGlyph);
						}
						 else 
						{
							pos = container.postNotes;
							global::alphatab.rendering.EffectBarRenderer posR4 = default(global::alphatab.rendering.EffectBarRenderer);
							posR4 = ((global::alphatab.rendering.EffectBarRenderer) (pos.renderer) );
							global::alphatab.rendering.EffectBarRenderer gR4 = default(global::alphatab.rendering.EffectBarRenderer);
							gR4 = ((global::alphatab.rendering.EffectBarRenderer) (g.renderer) );
							g.width = ( ( ( ( ( posR4.x + posR4.getBeatGlyphsStart() ) + container.x ) + pos.x ) + pos.width ) - (( ( gR4.x + gR4.getBeatGlyphsStart() ) + g.x )) );
							if (( g is global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph )) 
							{
								(((global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph) (((object) (g) )) )).expandedTo(container.beat);
							}
							
						}
						
						break;
					}
					
					
					case 11:
					{
						if (( g != prevGlyph )) 
						{
							this.alignGlyph(global::alphatab.rendering.EffectBarGlyphSizing.GroupedPostBeatOnly, beatIndex, voiceIndex, prevGlyph);
						}
						 else 
						{
							pos = container.postNotes;
							global::alphatab.rendering.EffectBarRenderer posR5 = default(global::alphatab.rendering.EffectBarRenderer);
							posR5 = ((global::alphatab.rendering.EffectBarRenderer) (pos.renderer) );
							global::alphatab.rendering.EffectBarRenderer gR5 = default(global::alphatab.rendering.EffectBarRenderer);
							gR5 = ((global::alphatab.rendering.EffectBarRenderer) (g.renderer) );
							g.width = ( ( ( ( ( posR5.x + posR5.getBeatGlyphsStart() ) + container.x ) + pos.x ) + pos.width ) - (( ( gR5.x + gR5.getBeatGlyphsStart() ) + g.x )) );
							if (( g is global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph )) 
							{
								(((global::alphatab.rendering.glyphs.IMultiBeatEffectGlyph) (((object) (g) )) )).expandedTo(container.beat);
							}
							
						}
						
						break;
					}
					
					
				}
				
			}
		}
		
		
		public override   void createPreBeatGlyphs()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public override   void createBeatGlyphs()
		{
			unchecked 
			{
				this._effectGlyphs.push(new global::haxe.ds.IntMap<object>());
				this._uniqueEffectGlyphs.push(new global::haxe.root.Array<object>());
				this.createVoiceGlyphs(((global::alphatab.model.Voice) (this._bar.voices[0]) ));
			}
		}
		
		
		public virtual   void createVoiceGlyphs(global::alphatab.model.Voice v)
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = v.beats;
				while (( _g < _g1.length ))
				{
					global::alphatab.model.Beat b = ((global::alphatab.model.Beat) (_g1[_g]) );
					 ++ _g;
					global::alphatab.rendering.glyphs.BeatContainerGlyph container = new global::alphatab.rendering.glyphs.BeatContainerGlyph(((global::alphatab.model.Beat) (b) ));
					container.preNotes = new global::alphatab.rendering.glyphs.BeatGlyphBase();
					container.onNotes = new global::alphatab.rendering.glyphs.BeatGlyphBase();
					container.postNotes = new global::alphatab.rendering.glyphs.BeatGlyphBase();
					this.addBeatGlyph(container);
					if (this._info.shouldCreateGlyph(this, b)) 
					{
						this.createOrResizeGlyph(this._info.getSizingMode(), b);
					}
					
					this._lastBeat = b;
				}
				
			}
		}
		
		
		public virtual   void createOrResizeGlyph(global::alphatab.rendering.EffectBarGlyphSizing sizing, global::alphatab.model.Beat b)
		{
			unchecked 
			{
				switch (global::haxe.root.Type.enumIndex(sizing))
				{
					case 0:case 1:case 2:case 3:case 4:case 5:
					{
						global::alphatab.rendering.Glyph g = this._info.createNewGlyph(this, b);
						g.renderer = this;
						g.doLayout();
						((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._effectGlyphs[b.voice.index]) ))) ).@set(b.index, g);
						((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._uniqueEffectGlyphs[b.voice.index]) ))) ).push(g);
						break;
					}
					
					
					case 6:case 7:case 8:case 9:case 10:case 11:
					{
						if (( ( b.index > 0 ) || ( this.index > 0 ) )) 
						{
							global::alphatab.model.Beat prevBeat = b.previousBeat;
							if (this._info.shouldCreateGlyph(this, prevBeat)) 
							{
								global::alphatab.rendering.Glyph prevEffect = default(global::alphatab.rendering.Glyph);
								if (( b.index > 0 )) 
								{
									prevEffect = ((global::alphatab.rendering.Glyph) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._effectGlyphs[b.voice.index]) ))) ).@get(prevBeat.index).@value) );
								}
								 else 
								{
									prevEffect = ((global::alphatab.rendering.Glyph) (((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) ((((global::alphatab.rendering.EffectBarRenderer) (((global::alphatab.rendering.BarRendererBase) (this.stave.barRenderers[( this.index - 1 )]) )) ))._effectGlyphs[b.voice.index]) ))) ).@get(prevBeat.index).@value) );
								}
								
								if (( ( prevEffect == default(global::alphatab.rendering.Glyph) ) ||  ! (this._info.canExpand(this, prevBeat, b))  )) 
								{
									this.createOrResizeGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly, b);
								}
								 else 
								{
									((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (this._effectGlyphs[b.voice.index]) ))) ).@set(b.index, prevEffect);
								}
								
							}
							 else 
							{
								this.createOrResizeGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly, b);
							}
							
						}
						 else 
						{
							this.createOrResizeGlyph(global::alphatab.rendering.EffectBarGlyphSizing.SinglePreBeatOnly, b);
						}
						
						break;
					}
					
					
				}
				
			}
		}
		
		
		public override   void createPostBeatGlyphs()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public override   int getTopPadding()
		{
			unchecked 
			{
				return 0;
			}
		}
		
		
		public override   int getBottomPadding()
		{
			unchecked 
			{
				return 0;
			}
		}
		
		
		public override   void paintBackground(int cx, int cy, global::alphatab.platform.ICanvas canvas)
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
				base.paint(cx, cy, canvas);
				int glyphStart = this.getBeatGlyphsStart();
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._uniqueEffectGlyphs;
					while (( _g < _g1.length ))
					{
						global::haxe.root.Array<object> v = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g1[_g]) ))) );
						 ++ _g;
						{
							int _g2 = 0;
							while (( _g2 < v.length ))
							{
								global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (v[_g2]) );
								 ++ _g2;
								if (( g.renderer == this )) 
								{
									g.paint(( ( cx + this.x ) + glyphStart ), ( cy + this.y ), canvas);
								}
								
							}
							
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
					case 468906571:
					{
						this._lastBeat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 1537678743:
					{
						this._effectGlyphs = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1100006280:
					{
						this._uniqueEffectGlyphs = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 2026656845:
					{
						this._info = ((global::alphatab.rendering.IEffectBarRendererInfo) (@value) );
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
					
					
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBackground"), ((int) (1334722860) ))) );
					}
					
					
					case 357418928:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBottomPadding"), ((int) (357418928) ))) );
					}
					
					
					case 415081458:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTopPadding"), ((int) (415081458) ))) );
					}
					
					
					case 2000963577:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPostBeatGlyphs"), ((int) (2000963577) ))) );
					}
					
					
					case 524783129:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createOrResizeGlyph"), ((int) (524783129) ))) );
					}
					
					
					case 131841789:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createVoiceGlyphs"), ((int) (131841789) ))) );
					}
					
					
					case 1907509625:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createBeatGlyphs"), ((int) (1907509625) ))) );
					}
					
					
					case 918754500:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("createPreBeatGlyphs"), ((int) (918754500) ))) );
					}
					
					
					case 794258599:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("alignGlyph"), ((int) (794258599) ))) );
					}
					
					
					case 236164353:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finalizeRenderer"), ((int) (236164353) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 468906571:
					{
						return this._lastBeat;
					}
					
					
					case 1537678743:
					{
						return this._effectGlyphs;
					}
					
					
					case 1100006280:
					{
						return this._uniqueEffectGlyphs;
					}
					
					
					case 2026656845:
					{
						return this._info;
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
					case 1825584277:case 236164353:case 918754500:case 1907509625:case 2000963577:case 415081458:case 357418928:case 1334722860:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 524783129:
					{
						this.createOrResizeGlyph(((global::alphatab.rendering.EffectBarGlyphSizing) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ));
						break;
					}
					
					
					case 131841789:
					{
						this.createVoiceGlyphs(((global::alphatab.model.Voice) (dynargs[0]) ));
						break;
					}
					
					
					case 794258599:
					{
						this.alignGlyph(((global::alphatab.rendering.EffectBarGlyphSizing) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((global::alphatab.rendering.Glyph) (dynargs[3]) ));
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
				baseArr.push("_lastBeat");
				baseArr.push("_effectGlyphs");
				baseArr.push("_uniqueEffectGlyphs");
				baseArr.push("_info");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


