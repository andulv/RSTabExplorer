using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreNoteChordGlyph : global::alphatab.rendering.Glyph 
	{
		public    ScoreNoteChordGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    ScoreNoteChordGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.ScoreNoteChordGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreNoteChordGlyph(this, x, y);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreNoteChordGlyph(global::alphatab.rendering.glyphs.ScoreNoteChordGlyph __temp_me198, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y)
		{
			unchecked 
			{
				int __temp_y197 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x196 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me198, new global::haxe.lang.Null<int>(__temp_x196, true), new global::haxe.lang.Null<int>(__temp_y197, true));
				__temp_me198._infos = new global::haxe.root.Array<object>();
				__temp_me198.beatEffects = new global::haxe.ds.StringMap<object>();
				__temp_me198._noteLookup = new global::haxe.ds.IntMap<object>();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreNoteChordGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreNoteChordGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]));
			}
		}
		
		
		public  global::haxe.root.Array<object> _infos;
		
		public  global::haxe.ds.IntMap<object> _noteLookup;
		
		public  global::alphatab.rendering.Glyph _tremoloPicking;
		
		public  object minNote;
		
		public  object maxNote;
		
		public  global::haxe.lang.Function spacingChanged;
		
		public  int upLineX;
		
		public  int downLineX;
		
		public  global::haxe.ds.StringMap<object> beatEffects;
		
		public  global::alphatab.model.Beat beat;
		
		public  global::alphatab.rendering.utils.BeamingHelper beamingHelper;
		
		public   global::alphatab.rendering.utils.BeamDirection getDirection()
		{
			unchecked 
			{
				return this.beamingHelper.getDirection();
			}
		}
		
		
		public virtual   int getNoteX(global::alphatab.model.Note note, global::haxe.lang.Null<bool> onEnd)
		{
			unchecked 
			{
				bool __temp_onEnd195 = ( (global::haxe.lang.Runtime.eq((onEnd).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (true) )) : (onEnd.@value) );
				if (this._noteLookup.exists(note.@string)) 
				{
					global::alphatab.rendering.Glyph n = ((global::alphatab.rendering.Glyph) (this._noteLookup.@get(note.@string).@value) );
					int pos = ( this.x + n.x );
					if (__temp_onEnd195) 
					{
						pos += n.width;
					}
					
					return pos;
				}
				
				return 0;
			}
		}
		
		
		public virtual   int getNoteY(global::alphatab.model.Note note)
		{
			unchecked 
			{
				if (this._noteLookup.exists(note.@string)) 
				{
					return ( this.y + ((global::alphatab.rendering.Glyph) (this._noteLookup.@get(note.@string).@value) ).y );
				}
				
				return 0;
			}
		}
		
		
		public virtual   void addNoteGlyph(global::alphatab.rendering.Glyph noteGlyph, global::alphatab.model.Note note, int noteLine)
		{
			unchecked 
			{
				object info = new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{369425836}), new global::haxe.root.Array<object>(new object[]{noteGlyph}), new global::haxe.root.Array<int>(new int[]{1202919412}), new global::haxe.root.Array<double>(new double[]{((double) (noteLine) )}));
				this._infos.push(info);
				this._noteLookup.@set(note.@string, noteGlyph);
				if (( global::haxe.lang.Runtime.refEq(this.minNote, default(object)) || ( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(this.minNote, "line", 1202919412, true)) ), ((int) (global::haxe.lang.Runtime.getField_f(info, "line", 1202919412, true)) )) > 0 ) )) 
				{
					this.minNote = info;
				}
				
				if (( global::haxe.lang.Runtime.refEq(this.maxNote, default(object)) || ( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(this.maxNote, "line", 1202919412, true)) ), ((int) (global::haxe.lang.Runtime.getField_f(info, "line", 1202919412, true)) )) < 0 ) )) 
				{
					this.maxNote = info;
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
		
		
		public virtual   void updateBeamingHelper(int cx)
		{
			unchecked 
			{
				this.beamingHelper.registerBeatLineX(this.beat, ( ( cx + this.x ) + this.upLineX ), ( ( cx + this.x ) + this.downLineX ));
			}
		}
		
		
		public virtual   bool hasTopOverflow()
		{
			unchecked 
			{
				return ( ( ! (global::haxe.lang.Runtime.refEq(this.minNote, default(object))) ) && ( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(this.minNote, "line", 1202919412, true)) ), 0) < 0 ) );
			}
		}
		
		
		public virtual   bool hasBottomOverflow()
		{
			unchecked 
			{
				return ( ( ! (global::haxe.lang.Runtime.refEq(this.maxNote, default(object))) ) && ( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(this.maxNote, "line", 1202919412, true)) ), 8) > 0 ) );
			}
		}
		
		
		public override   void doLayout()
		{
			unchecked 
			{
				this._infos.sort(( (( global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun.__hx_current != default(global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun) )) ? (global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun.__hx_current) : (global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun.__hx_current = ((global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun) (new global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun()) )) ));
				int padding = 0;
				int displacedX = 0;
				bool lastDisplaced = false;
				int lastLine = 0;
				bool anyDisplaced = false;
				int w = 0;
				{
					int _g1 = 0;
					int _g = this._infos.length;
					while (( _g1 < _g ))
					{
						int i = _g1++;
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.getField(this._infos[i], "glyph", 369425836, true)) );
						g.renderer = this.renderer;
						g.doLayout();
						g.x = padding;
						if (( i == 0 )) 
						{
							displacedX = ( g.width + padding );
						}
						 else 
						{
							if (( global::System.Math.Abs(((double) (( ((int) (lastLine) ) - ((int) (global::haxe.lang.Runtime.getField_f(this._infos[i], "line", 1202919412, true)) ) )) )) <= 1 )) 
							{
								if ( ! (lastDisplaced) ) 
								{
									g.x = ((int) (( displacedX - this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
									anyDisplaced = true;
									lastDisplaced = true;
								}
								 else 
								{
									lastDisplaced = false;
								}
								
							}
							 else 
							{
								lastDisplaced = false;
							}
							
						}
						
						lastLine = ((int) (global::haxe.lang.Runtime.getField_f(this._infos[i], "line", 1202919412, true)) );
						{
							double x = global::System.Math.Max(((double) (w) ), ((double) (( g.x + g.width )) ));
							w = ((int) (x) );
						}
						
					}
					
				}
				
				if (anyDisplaced) 
				{
					this.upLineX = displacedX;
					this.downLineX = displacedX;
				}
				 else 
				{
					this.upLineX = w;
					this.downLineX = padding;
				}
				
				{
					object __temp_iterator447 = this.beatEffects.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator447, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::alphatab.rendering.Glyph e = ((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.callField(__temp_iterator447, "next", 1224901875, default(global::haxe.root.Array))) );
						e.renderer = this.renderer;
						e.doLayout();
					}
					
				}
				
				if (( ! (global::haxe.lang.Runtime.eq((this.beat.tremoloSpeed).toDynamic(), (default(global::haxe.lang.Null<global::alphatab.model.Duration>)).toDynamic())) )) 
				{
					int offset = default(int);
					object baseNote = default(object);
					if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
					{
						baseNote = this.minNote;
					}
					 else 
					{
						baseNote = this.maxNote;
					}
					
					int tremoloX = default(int);
					if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
					{
						tremoloX = displacedX;
					}
					 else 
					{
						tremoloX = 0;
					}
					
					{
						global::haxe.lang.Null<global::alphatab.model.Duration> _g2 = this.beat.tremoloSpeed;
						switch (global::haxe.root.Type.enumIndex((_g2).toDynamic()))
						{
							case 5:
							{
								if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
								{
									offset = -15;
								}
								 else 
								{
									offset = 10;
								}
								
								break;
							}
							
							
							case 4:
							{
								if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
								{
									offset = -12;
								}
								 else 
								{
									offset = 10;
								}
								
								break;
							}
							
							
							case 3:
							{
								if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
								{
									offset = -10;
								}
								 else 
								{
									offset = 10;
								}
								
								break;
							}
							
							
							default:
							{
								if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
								{
									offset = -15;
								}
								 else 
								{
									offset = 15;
								}
								
								break;
							}
							
						}
						
					}
					
					this._tremoloPicking = new global::alphatab.rendering.glyphs.TremoloPickingGlyph(new global::haxe.lang.Null<int>(tremoloX, true), new global::haxe.lang.Null<int>(( ((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.getField(baseNote, "glyph", 369425836, true)) ).y + ((int) (( offset * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) ) ), true), this.beat.tremoloSpeed.@value);
					this._tremoloPicking.renderer = this.renderer;
					this._tremoloPicking.doLayout();
				}
				
				this.width = ( w + padding );
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreBarRenderer scoreRenderer = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				int effectY = default(int);
				if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
				{
					effectY = scoreRenderer.getScoreY(((int) (global::haxe.lang.Runtime.getField_f(this.maxNote, "line", 1202919412, true)) ), new global::haxe.lang.Null<int>(13, true));
				}
				 else 
				{
					effectY = scoreRenderer.getScoreY(((int) (global::haxe.lang.Runtime.getField_f(this.minNote, "line", 1202919412, true)) ), new global::haxe.lang.Null<int>(-9, true));
				}
				
				int effectSpacing = default(int);
				if (( this.beamingHelper.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
				{
					effectSpacing = ((int) (( 7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				}
				 else 
				{
					effectSpacing = ((int) (( -7 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				}
				
				{
					object __temp_iterator448 = this.beatEffects.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator448, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::alphatab.rendering.Glyph g = ((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.callField(__temp_iterator448, "next", 1224901875, default(global::haxe.root.Array))) );
						g.y = effectY;
						g.x = ( this.width / 2 );
						g.paint(( cx + this.x ), ( cy + this.y ), canvas);
						effectY += effectSpacing;
					}
					
				}
				
				canvas.setColor(this.renderer.stave.staveGroup.layout.renderer.renderingResources.staveLineColor);
				int linePadding = ((int) (( 3 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				if (this.hasTopOverflow()) 
				{
					int l = -1;
					while (( global::haxe.lang.Runtime.compare(l, ((int) (global::haxe.lang.Runtime.getField_f(this.minNote, "line", 1202919412, true)) )) >= 0 ))
					{
						int lY = ( ( cy + this.y ) + scoreRenderer.getScoreY(( l + 1 ), new global::haxe.lang.Null<int>(-1, true)) );
						canvas.beginPath();
						canvas.moveTo(((double) (( ( cx + this.x ) - linePadding )) ), ((double) (lY) ));
						canvas.lineTo(((double) (( ( ( cx + this.x ) + this.width ) + linePadding )) ), ((double) (lY) ));
						canvas.stroke();
						l -= 2;
					}
					
				}
				
				if (this.hasBottomOverflow()) 
				{
					int l1 = 11;
					while (( global::haxe.lang.Runtime.compare(l1, ((int) (global::haxe.lang.Runtime.getField_f(this.maxNote, "line", 1202919412, true)) )) <= 0 ))
					{
						int lY1 = ( ( cy + this.y ) + scoreRenderer.getScoreY(( l1 + 1 ), new global::haxe.lang.Null<int>(-1, true)) );
						canvas.beginPath();
						canvas.moveTo(((double) (( ( cx + this.x ) - linePadding )) ), ((double) (lY1) ));
						canvas.lineTo(((double) (( ( ( cx + this.x ) + this.width ) + linePadding )) ), ((double) (lY1) ));
						canvas.stroke();
						l1 += 2;
					}
					
				}
				
				if (( this._tremoloPicking != default(global::alphatab.rendering.Glyph) )) 
				{
					this._tremoloPicking.paint(( cx + this.x ), ( cy + this.y ), canvas);
				}
				
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = this._infos;
					while (( _g < _g1.length ))
					{
						object g1 = _g1[_g];
						 ++ _g;
						((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.getField(g1, "glyph", 369425836, true)) ).renderer = this.renderer;
						((global::alphatab.rendering.Glyph) (global::haxe.lang.Runtime.getField(g1, "glyph", 369425836, true)) ).paint(( cx + this.x ), ( cy + this.y ), canvas);
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
					case 186102306:
					{
						this.downLineX = ((int) (@value) );
						return @value;
					}
					
					
					case 1366752649:
					{
						this.upLineX = ((int) (@value) );
						return @value;
					}
					
					
					case 1228566710:
					{
						this.maxNote = ((object) (@value) );
						return @value;
					}
					
					
					case 974358180:
					{
						this.minNote = ((object) (@value) );
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
					case 1692978337:
					{
						this.beamingHelper = ((global::alphatab.rendering.utils.BeamingHelper) (@value) );
						return @value;
					}
					
					
					case 1091821942:
					{
						this.beat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 108520940:
					{
						this.beatEffects = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 186102306:
					{
						this.downLineX = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1366752649:
					{
						this.upLineX = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1464822705:
					{
						this.spacingChanged = ((global::haxe.lang.Function) (@value) );
						return @value;
					}
					
					
					case 1228566710:
					{
						this.maxNote = ((object) (@value) );
						return @value;
					}
					
					
					case 974358180:
					{
						this.minNote = ((object) (@value) );
						return @value;
					}
					
					
					case 1270934932:
					{
						this._tremoloPicking = ((global::alphatab.rendering.Glyph) (@value) );
						return @value;
					}
					
					
					case 1381203243:
					{
						this._noteLookup = ((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (@value) ))) );
						return @value;
					}
					
					
					case 972910470:
					{
						this._infos = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					
					
					case 67315271:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("hasBottomOverflow"), ((int) (67315271) ))) );
					}
					
					
					case 455632317:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("hasTopOverflow"), ((int) (455632317) ))) );
					}
					
					
					case 2020590808:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("updateBeamingHelper"), ((int) (2020590808) ))) );
					}
					
					
					case 1734479962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("canScale"), ((int) (1734479962) ))) );
					}
					
					
					case 1390832121:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addNoteGlyph"), ((int) (1390832121) ))) );
					}
					
					
					case 2141318065:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteY"), ((int) (2141318065) ))) );
					}
					
					
					case 2141318064:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getNoteX"), ((int) (2141318064) ))) );
					}
					
					
					case 529989321:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getDirection"), ((int) (529989321) ))) );
					}
					
					
					case 1692978337:
					{
						return this.beamingHelper;
					}
					
					
					case 1091821942:
					{
						return this.beat;
					}
					
					
					case 108520940:
					{
						return this.beatEffects;
					}
					
					
					case 186102306:
					{
						return this.downLineX;
					}
					
					
					case 1366752649:
					{
						return this.upLineX;
					}
					
					
					case 1464822705:
					{
						return this.spacingChanged;
					}
					
					
					case 1228566710:
					{
						return this.maxNote;
					}
					
					
					case 974358180:
					{
						return this.minNote;
					}
					
					
					case 1270934932:
					{
						return this._tremoloPicking;
					}
					
					
					case 1381203243:
					{
						return this._noteLookup;
					}
					
					
					case 972910470:
					{
						return this._infos;
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
					case 186102306:
					{
						return ((double) (this.downLineX) );
					}
					
					
					case 1366752649:
					{
						return ((double) (this.upLineX) );
					}
					
					
					case 1228566710:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.maxNote)) );
					}
					
					
					case 974358180:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.minNote)) );
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
					case 1734479962:case 1825584277:case 1028568990:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 67315271:
					{
						return this.hasBottomOverflow();
					}
					
					
					case 455632317:
					{
						return this.hasTopOverflow();
					}
					
					
					case 2020590808:
					{
						this.updateBeamingHelper(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1390832121:
					{
						this.addNoteGlyph(((global::alphatab.rendering.Glyph) (dynargs[0]) ), ((global::alphatab.model.Note) (dynargs[1]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 2141318065:
					{
						return this.getNoteY(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 2141318064:
					{
						return this.getNoteX(((global::alphatab.model.Note) (dynargs[0]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[1]));
					}
					
					
					case 529989321:
					{
						return this.getDirection();
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
				baseArr.push("beamingHelper");
				baseArr.push("beat");
				baseArr.push("beatEffects");
				baseArr.push("downLineX");
				baseArr.push("upLineX");
				baseArr.push("spacingChanged");
				baseArr.push("maxNote");
				baseArr.push("minNote");
				baseArr.push("_tremoloPicking");
				baseArr.push("_noteLookup");
				baseArr.push("_infos");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreNoteChordGlyph_doLayout_130__Fun : global::haxe.lang.Function 
	{
		public    ScoreNoteChordGlyph_doLayout_130__Fun() : base(2, 1)
		{
			unchecked 
			{
			}
		}
		
		
		public static  global::alphatab.rendering.glyphs.ScoreNoteChordGlyph_doLayout_130__Fun __hx_current;
		
		public override   double __hx_invoke2_f(double __fn_float1, double __fn_float2, object __fn_dyn1, object __fn_dyn2)
		{
			unchecked 
			{
				object b = ( (global::haxe.lang.Runtime.eq(__fn_dyn2, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float2) )) : (((object) (__fn_dyn2) )) );
				object a = ( (global::haxe.lang.Runtime.eq(__fn_dyn1, global::haxe.lang.Runtime.undefined)) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
				if (( ((int) (global::haxe.lang.Runtime.getField_f(a, "line", 1202919412, true)) ) == ((int) (global::haxe.lang.Runtime.getField_f(b, "line", 1202919412, true)) ) )) 
				{
					return ((double) (0) );
				}
				 else 
				{
					if (( global::haxe.lang.Runtime.compare(((int) (global::haxe.lang.Runtime.getField_f(a, "line", 1202919412, true)) ), ((int) (global::haxe.lang.Runtime.getField_f(b, "line", 1202919412, true)) )) < 0 )) 
					{
						return ((double) (1) );
					}
					 else 
					{
						return ((double) (-1) );
					}
					
				}
				
			}
		}
		
		
	}
}


