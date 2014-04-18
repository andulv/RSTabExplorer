using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.glyphs
{
	public  class TieGlyph : global::alphatab.rendering.Glyph 
	{
		public    TieGlyph(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
			}
		}
		
		
		public    TieGlyph(global::alphatab.model.Note startNote, global::alphatab.model.Note endNote, global::alphatab.rendering.Glyph parent) : base(global::haxe.lang.EmptyObject.EMPTY)
		{
			unchecked 
			{
				global::alphatab.rendering.glyphs.TieGlyph.__hx_ctor_alphatab_rendering_glyphs_TieGlyph(this, startNote, endNote, parent);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_glyphs_TieGlyph(global::alphatab.rendering.glyphs.TieGlyph __temp_me201, global::alphatab.model.Note startNote, global::alphatab.model.Note endNote, global::alphatab.rendering.Glyph parent)
		{
			unchecked 
			{
				global::alphatab.rendering.Glyph.__hx_ctor_alphatab_rendering_Glyph(__temp_me201, new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(0, true));
				__temp_me201._startNote = startNote;
				__temp_me201._endNote = endNote;
				__temp_me201._parent = parent;
			}
		}
		
		
		public static   void paintTie(global::alphatab.platform.ICanvas canvas, double scale, double x1, double y1, double x2, double y2, global::haxe.lang.Null<bool> down)
		{
			unchecked 
			{
				bool __temp_down200 = ( (global::haxe.lang.Runtime.eq((down).toDynamic(), (default(global::haxe.lang.Null<bool>)).toDynamic())) ? (((bool) (false) )) : (down.@value) );
				if (( x2 > x1 )) 
				{
					double t = x1;
					x1 = x2;
					x2 = t;
					t = y1;
					y1 = y2;
					y2 = t;
				}
				
				double offset = ( 15 * scale );
				double size = ( 4 * scale );
				double normalVector_x = ( y2 - y1 );
				double normalVector_y = ( x2 - x1 );
				double length = global::System.Math.Sqrt(((double) (( ( normalVector_x * normalVector_x ) + ( normalVector_y * normalVector_y ) )) ));
				if (__temp_down200) 
				{
					normalVector_x *= ((double) (-1) );
				}
				 else 
				{
					normalVector_y *= ((double) (-1) );
				}
				
				normalVector_x /= length;
				normalVector_y /= length;
				double center_x = ( (( x2 + x1 )) / 2 );
				double center_y = ( (( y2 + y1 )) / 2 );
				double cp1_x = ( center_x + ( offset * normalVector_x ) );
				double cp1_y = ( center_y + ( offset * normalVector_y ) );
				double cp2_x = ( center_x + ( (( offset - size )) * normalVector_x ) );
				double cp2_y = ( center_y + ( (( offset - size )) * normalVector_y ) );
				canvas.beginPath();
				canvas.moveTo(x1, y1);
				canvas.quadraticCurveTo(cp1_x, cp1_y, x2, y2);
				canvas.quadraticCurveTo(cp2_x, cp2_y, x1, y1);
				canvas.closePath();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TieGlyph(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.glyphs.TieGlyph(((global::alphatab.model.Note) (arr[0]) ), ((global::alphatab.model.Note) (arr[1]) ), ((global::alphatab.rendering.Glyph) (arr[2]) ));
			}
		}
		
		
		public  global::alphatab.model.Note _startNote;
		
		public  global::alphatab.model.Note _endNote;
		
		public  global::alphatab.rendering.Glyph _parent;
		
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
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1542788809:
					{
						this._parent = ((global::alphatab.rendering.Glyph) (@value) );
						return @value;
					}
					
					
					case 1692871406:
					{
						this._endNote = ((global::alphatab.model.Note) (@value) );
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
					
					
					case 1692871406:
					{
						return this._endNote;
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
				baseArr.push("_endNote");
				baseArr.push("_startNote");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


