using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class ScoreSlideLineGlyph : global::alphatab.rendering.Glyph 
	{
		public    ScoreSlideLineGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    ScoreSlideLineGlyph(global::alphatab.model.SlideType type, global::alphatab.model.Note startNote, global::alphatab.rendering.glyphs.BeatContainerGlyph parent) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.ScoreSlideLineGlyph.__hx_ctor_alphatab_rendering_glyphs_ScoreSlideLineGlyph(this, type, startNote, parent);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_ScoreSlideLineGlyph(global::alphatab.rendering.glyphs.ScoreSlideLineGlyph __temp_me199, global::alphatab.model.SlideType type, global::alphatab.model.Note startNote, global::alphatab.rendering.glyphs.BeatContainerGlyph parent)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me199, new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true));
				__temp_me199._type = type;
				__temp_me199._startNote = startNote;
				__temp_me199._parent = parent;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreSlideLineGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.ScoreSlideLineGlyph(((global::alphatab.model.SlideType) (arr[0]) ), ((global::alphatab.model.Note) (arr[1]) ), ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (arr[2]) ));
			}
		}
		
		
		public  global::alphatab.model.Note _startNote;
		
		public  global::alphatab.model.SlideType _type;
		
		public  global::alphatab.rendering.glyphs.BeatContainerGlyph _parent;
		
		public override   void doLayout()
		{
			unchecked 
			{
				this.width = 0;
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
				global::alphatab.rendering.ScoreBarRenderer r = ((global::alphatab.rendering.ScoreBarRenderer) (this.renderer) );
				int sizeX = ((int) (( 12 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
				int offsetX = ((int) (this.renderer.stave.staveGroup.layout.renderer.settings.scale) );
				int startX = default(int);
				int startY = default(int);
				int endX = default(int);
				int endY = default(int);
				{
					global::alphatab.model.SlideType _g = this._type;
					switch (global::haxe.root.Type.enumIndex(_g))
					{
						case 1:case 2:
						{
							startX = ( ( cx + r.getNoteX(this._startNote, new global::haxe.lang.Null<bool>(true, true)) ) + offsetX );
							startY = ( ( cy + r.getNoteY(this._startNote) ) + 4 );
							if (( this._startNote.slideTarget != default(global::alphatab.model.Note) )) 
							{
								endX = ( ( cx + r.getNoteX(this._startNote.slideTarget, new global::haxe.lang.Null<bool>(false, true)) ) - offsetX );
								endY = ( ( cy + r.getNoteY(this._startNote.slideTarget) ) + 4 );
							}
							 else 
							{
								endX = ( ( ( cx + this._parent.x ) + this._parent.postNotes.x ) + this._parent.postNotes.width );
								endY = startY;
							}
							
							break;
						}
						
						
						case 3:
						{
							endX = ( ( cx + r.getNoteX(this._startNote, new global::haxe.lang.Null<bool>(false, true)) ) - offsetX );
							endY = ( ( cy + r.getNoteY(this._startNote) ) + 4 );
							startX = ( endX - sizeX );
							startY = ( ( cy + r.getNoteY(this._startNote) ) + 9 );
							break;
						}
						
						
						case 4:
						{
							endX = ( ( cx + r.getNoteX(this._startNote, new global::haxe.lang.Null<bool>(false, true)) ) - offsetX );
							endY = ( ( cy + r.getNoteY(this._startNote) ) + 4 );
							startX = ( endX - sizeX );
							startY = ( cy + r.getNoteY(this._startNote) );
							break;
						}
						
						
						case 5:
						{
							startX = ( ( cx + r.getNoteX(this._startNote, new global::haxe.lang.Null<bool>(true, true)) ) + offsetX );
							startY = ( ( cy + r.getNoteY(this._startNote) ) + 4 );
							endX = ( startX + sizeX );
							endY = ( cy + r.getNoteY(this._startNote) );
							break;
						}
						
						
						case 6:
						{
							startX = ( ( cx + r.getNoteX(this._startNote, new global::haxe.lang.Null<bool>(true, true)) ) + offsetX );
							startY = ( ( cy + r.getNoteY(this._startNote) ) + 4 );
							endX = ( startX + sizeX );
							endY = ( ( cy + r.getNoteY(this._startNote) ) + 9 );
							break;
						}
						
						
						default:
						{
							return ;
						}
						
					}
					
				}
				
				canvas.setColor(this.renderer.stave.staveGroup.layout.renderer.renderingResources.mainGlyphColor);
				canvas.beginPath();
				canvas.moveTo(((double) (startX) ), ((double) (startY) ));
				canvas.lineTo(((double) (endX) ), ((double) (endY) ));
				canvas.stroke();
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1542788809:
					{
						this._parent = ((global::alphatab.rendering.glyphs.BeatContainerGlyph) (@value) );
						return @value;
					}
					
					
					case 1707673:
					{
						this._type = ((global::alphatab.model.SlideType) (@value) );
						return @value;
					}
					
					
					case 1570770229:
					{
						this._startNote = ((global::alphatab.model.Note) (@value) );
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
					
					
					case 1542788809:
					{
						return this._parent;
					}
					
					
					case 1707673:
					{
						return this._type;
					}
					
					
					case 1570770229:
					{
						return this._startNote;
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
				baseArr.push("_parent");
				baseArr.push("_type");
				baseArr.push("_startNote");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


