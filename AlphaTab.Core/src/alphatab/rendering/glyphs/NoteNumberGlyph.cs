using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class NoteNumberGlyph : global::alphatab.rendering.Glyph 
	{
		static NoteNumberGlyph() 
		{
			global::alphatab.rendering.glyphs.NoteNumberGlyph.Padding = 0;
		}
		public    NoteNumberGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    NoteNumberGlyph(global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Note n, bool isGrace) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.NoteNumberGlyph.__hx_ctor_alphatab_rendering_glyphs_NoteNumberGlyph(this, x, y, n, isGrace);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_NoteNumberGlyph(global::alphatab.rendering.glyphs.NoteNumberGlyph __temp_me173, global::haxe.lang.Null<int> x, global::haxe.lang.Null<int> y, global::alphatab.model.Note n, bool isGrace)
		{
			unchecked 
			{
				int __temp_y172 = ( (global::haxe.lang.Runtime.eq((y).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (y.@value) );
				int __temp_x171 = ( (global::haxe.lang.Runtime.eq((x).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ? (((int) (0) )) : (x.@value) );
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me173, new global::haxe.lang.Null<int>(__temp_x171, true), new global::haxe.lang.Null<int>(__temp_y172, true));
				__temp_me173._isGrace = isGrace;
				if ( ! (n.isTieDestination) ) 
				{
					if (n.isDead) 
					{
						__temp_me173._noteString = "X";
					}
					 else 
					{
						__temp_me173._noteString = global::Std.@string(n.fret);
					}
					
					if (n.isGhost) 
					{
						__temp_me173._noteString = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("(", __temp_me173._noteString), ")");
					}
					
				}
				 else 
				{
					if (( n.beat.index == 0 )) 
					{
						__temp_me173._noteString = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("(", global::haxe.lang.Runtime.toString(n.tieOrigin.fret)), ")");
					}
					 else 
					{
						__temp_me173._noteString = "";
					}
					
				}
				
			}
		}
		
		
		public static  int Padding;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.NoteNumberGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.NoteNumberGlyph(global::haxe.lang.Null<object>.ofDynamic<int>(arr[0]), global::haxe.lang.Null<object>.ofDynamic<int>(arr[1]), ((global::alphatab.model.Note) (arr[2]) ), ((bool) (arr[3]) ));
			}
		}
		
		
		public  string _noteString;
		
		public  bool _isGrace;
		
		public override   void doLayout()
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreRenderer scoreRenderer = this.renderer.stave.staveGroup.layout.renderer;
				if (this._isGrace) 
				{
					scoreRenderer.canvas.setFont(scoreRenderer.renderingResources.graceFont);
				}
				 else 
				{
					scoreRenderer.canvas.setFont(scoreRenderer.renderingResources.tablatureFont);
				}
				
				this.width = ((int) (( 10 * this.renderer.stave.staveGroup.layout.renderer.settings.scale )) );
			}
		}
		
		
		public virtual   void calculateWidth()
		{
			unchecked 
			{
				{
					double x = this.renderer.stave.staveGroup.layout.renderer.canvas.measureText(this._noteString);
					this.width = ((int) (x) );
				}
				
			}
		}
		
		
		public override   void paint(int cx, int cy, global::alphatab.platform.ICanvas canvas)
		{
			unchecked 
			{
				if ( ! (string.Equals(this._noteString, default(string))) ) 
				{
					canvas.fillText(global::Std.@string(this._noteString), ( ( cx + this.x ) + ( 0 * this.renderer.stave.staveGroup.layout.renderer.settings.scale ) ), ((double) (( cy + this.y )) ));
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1881669935:
					{
						this._isGrace = ((bool) (@value) );
						return @value;
					}
					
					
					case 30278530:
					{
						this._noteString = global::haxe.lang.Runtime.toString(@value);
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
					
					
					case 1829781184:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("calculateWidth"), ((int) (1829781184) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1881669935:
					{
						return this._isGrace;
					}
					
					
					case 30278530:
					{
						return this._noteString;
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
					
					
					case 1829781184:
					{
						this.calculateWidth();
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
				baseArr.push("_isGrace");
				baseArr.push("_noteString");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


