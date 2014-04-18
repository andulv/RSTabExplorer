using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.platform.svg
{
	public  class SvgCanvas : global::haxe.lang.HxObject, global::alphatab.platform.ICanvas 
	{
		public    SvgCanvas(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    SvgCanvas()
		{
			unchecked 
			{
				global::alphatab.platform.svg.SvgCanvas.__hx_ctor_alphatab_platform_svg_SvgCanvas(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_platform_svg_SvgCanvas(global::alphatab.platform.svg.SvgCanvas __temp_me20)
		{
			unchecked 
			{
				__temp_me20._buffer = "";
				__temp_me20._currentPath = "";
				__temp_me20._currentPathIsEmpty = true;
				__temp_me20._color = new global::alphatab.platform.model.Color(((int) (255) ), ((int) (255) ), ((int) (255) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				__temp_me20._lineWidth = ((double) (1) );
				__temp_me20._width = 0;
				__temp_me20._height = 0;
				__temp_me20._font = new global::alphatab.platform.model.Font(global::haxe.lang.Runtime.toString("sans-serif"), ((double) (10) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
				__temp_me20._textAlign = global::alphatab.platform.model.TextAlign.Left;
				__temp_me20._textBaseline = global::alphatab.model.TextBaseline.Default;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.platform.svg.SvgCanvas(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.platform.svg.SvgCanvas();
			}
		}
		
		
		public  string _buffer;
		
		public  string _currentPath;
		
		public  bool _currentPathIsEmpty;
		
		public  int _width;
		
		public  int _height;
		
		public virtual   void writeTo(global::haxe.io.Output stream, bool includeWrapper, string className)
		{
			unchecked 
			{
				if (includeWrapper) 
				{
					stream.writeString("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" width=\"");
					global::alphatab.io.OutputExtensions.writeAsString(stream, this._width);
					stream.writeString("px\" height=\"");
					global::alphatab.io.OutputExtensions.writeAsString(stream, this._height);
					stream.writeString("px\"");
					if ( ! (string.Equals(className, default(string))) ) 
					{
						stream.writeString(" class=\"");
						stream.writeString(className);
						stream.writeString("\"");
					}
					
					stream.writeString(">\n");
				}
				
				stream.writeString(this._buffer);
				if (includeWrapper) 
				{
					stream.writeString("</svg>");
				}
				
			}
		}
		
		
		public virtual   string toSvg(bool includeWrapper, string className)
		{
			unchecked 
			{
				global::haxe.root.StringBuf buf = new global::haxe.root.StringBuf();
				if (includeWrapper) 
				{
					buf.b.Append(((object) ("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\" width=\"") ));
					buf.b.Append(((object) (global::Std.@string(this._width)) ));
					buf.b.Append(((object) ("px\" height=\"") ));
					buf.b.Append(((object) (global::Std.@string(this._height)) ));
					buf.b.Append(((object) ("px\"") ));
					if ( ! (string.Equals(className, default(string))) ) 
					{
						buf.b.Append(((object) (" class=\"") ));
						buf.b.Append(((object) (global::Std.@string(className)) ));
						buf.b.Append(((object) ("\"") ));
					}
					
					buf.b.Append(((object) (">\n") ));
				}
				
				buf.b.Append(((object) (global::Std.@string(this._buffer)) ));
				if (includeWrapper) 
				{
					buf.b.Append(((object) ("</svg>") ));
				}
				
				return buf.toString();
			}
		}
		
		
		public virtual   int getWidth()
		{
			unchecked 
			{
				return this._width;
			}
		}
		
		
		public virtual   int getHeight()
		{
			unchecked 
			{
				return this._height;
			}
		}
		
		
		public virtual   void setWidth(int width)
		{
			unchecked 
			{
				this._width = width;
			}
		}
		
		
		public virtual   void setHeight(int height)
		{
			unchecked 
			{
				this._height = height;
			}
		}
		
		
		public  global::alphatab.platform.model.Color _color;
		
		public virtual   void setColor(global::alphatab.platform.model.Color color)
		{
			unchecked 
			{
				this._color = color;
			}
		}
		
		
		public  double _lineWidth;
		
		public virtual   void setLineWidth(double @value)
		{
			unchecked 
			{
				this._lineWidth = @value;
			}
		}
		
		
		public virtual   void clear()
		{
			unchecked 
			{
				this._buffer = "";
				this._currentPath = "";
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public virtual   void fillRect(double x, double y, double w, double h)
		{
			unchecked 
			{
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop304 = this;
					__temp_dynop304._buffer = global::haxe.lang.Runtime.concat(__temp_dynop304._buffer, "<rect x=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop305 = this;
					__temp_dynop305._buffer = global::haxe.lang.Runtime.concat(__temp_dynop305._buffer, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop306 = this;
					__temp_dynop306._buffer = global::haxe.lang.Runtime.concat(__temp_dynop306._buffer, "\" y=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop307 = this;
					__temp_dynop307._buffer = global::haxe.lang.Runtime.concat(__temp_dynop307._buffer, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop308 = this;
					__temp_dynop308._buffer = global::haxe.lang.Runtime.concat(__temp_dynop308._buffer, "\" width=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop309 = this;
					__temp_dynop309._buffer = global::haxe.lang.Runtime.concat(__temp_dynop309._buffer, global::haxe.lang.Runtime.toString(w));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop310 = this;
					__temp_dynop310._buffer = global::haxe.lang.Runtime.concat(__temp_dynop310._buffer, "\" height=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop311 = this;
					__temp_dynop311._buffer = global::haxe.lang.Runtime.concat(__temp_dynop311._buffer, global::haxe.lang.Runtime.toString(h));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop312 = this;
					__temp_dynop312._buffer = global::haxe.lang.Runtime.concat(__temp_dynop312._buffer, "\" style=\"fill:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop313 = this;
					__temp_dynop313._buffer = global::haxe.lang.Runtime.concat(__temp_dynop313._buffer, this._color.toRgbaString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop314 = this;
					__temp_dynop314._buffer = global::haxe.lang.Runtime.concat(__temp_dynop314._buffer, ";\" />\n");
				}
				
			}
		}
		
		
		public virtual   void strokeRect(double x, double y, double w, double h)
		{
			unchecked 
			{
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop315 = this;
					__temp_dynop315._buffer = global::haxe.lang.Runtime.concat(__temp_dynop315._buffer, "<rect x=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop316 = this;
					__temp_dynop316._buffer = global::haxe.lang.Runtime.concat(__temp_dynop316._buffer, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop317 = this;
					__temp_dynop317._buffer = global::haxe.lang.Runtime.concat(__temp_dynop317._buffer, "\" y=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop318 = this;
					__temp_dynop318._buffer = global::haxe.lang.Runtime.concat(__temp_dynop318._buffer, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop319 = this;
					__temp_dynop319._buffer = global::haxe.lang.Runtime.concat(__temp_dynop319._buffer, "\" width=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop320 = this;
					__temp_dynop320._buffer = global::haxe.lang.Runtime.concat(__temp_dynop320._buffer, global::haxe.lang.Runtime.toString(w));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop321 = this;
					__temp_dynop321._buffer = global::haxe.lang.Runtime.concat(__temp_dynop321._buffer, "\" height=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop322 = this;
					__temp_dynop322._buffer = global::haxe.lang.Runtime.concat(__temp_dynop322._buffer, global::haxe.lang.Runtime.toString(h));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop323 = this;
					__temp_dynop323._buffer = global::haxe.lang.Runtime.concat(__temp_dynop323._buffer, "\" style=\"stroke:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop324 = this;
					__temp_dynop324._buffer = global::haxe.lang.Runtime.concat(__temp_dynop324._buffer, this._color.toRgbaString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop325 = this;
					__temp_dynop325._buffer = global::haxe.lang.Runtime.concat(__temp_dynop325._buffer, "; stroke-width:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop326 = this;
					__temp_dynop326._buffer = global::haxe.lang.Runtime.concat(__temp_dynop326._buffer, global::haxe.lang.Runtime.toString(this._lineWidth));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop327 = this;
					__temp_dynop327._buffer = global::haxe.lang.Runtime.concat(__temp_dynop327._buffer, ";\" />\n");
				}
				
			}
		}
		
		
		public virtual   void beginPath()
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public virtual   void closePath()
		{
			unchecked 
			{
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop328 = this;
					__temp_dynop328._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop328._currentPath, " z");
				}
				
			}
		}
		
		
		public virtual   void moveTo(double x, double y)
		{
			unchecked 
			{
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop329 = this;
					__temp_dynop329._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop329._currentPath, " M");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop330 = this;
					__temp_dynop330._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop330._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop331 = this;
					__temp_dynop331._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop331._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop332 = this;
					__temp_dynop332._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop332._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void lineTo(double x, double y)
		{
			unchecked 
			{
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop333 = this;
					__temp_dynop333._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop333._currentPath, " L");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop334 = this;
					__temp_dynop334._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop334._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop335 = this;
					__temp_dynop335._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop335._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop336 = this;
					__temp_dynop336._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop336._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void quadraticCurveTo(double cpx, double cpy, double x, double y)
		{
			unchecked 
			{
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop337 = this;
					__temp_dynop337._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop337._currentPath, " Q");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop338 = this;
					__temp_dynop338._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop338._currentPath, global::haxe.lang.Runtime.toString(cpx));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop339 = this;
					__temp_dynop339._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop339._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop340 = this;
					__temp_dynop340._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop340._currentPath, global::haxe.lang.Runtime.toString(cpy));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop341 = this;
					__temp_dynop341._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop341._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop342 = this;
					__temp_dynop342._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop342._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop343 = this;
					__temp_dynop343._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop343._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop344 = this;
					__temp_dynop344._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop344._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void bezierCurveTo(double cp1x, double cp1y, double cp2x, double cp2y, double x, double y)
		{
			unchecked 
			{
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop345 = this;
					__temp_dynop345._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop345._currentPath, " C");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop346 = this;
					__temp_dynop346._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop346._currentPath, global::haxe.lang.Runtime.toString(cp1x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop347 = this;
					__temp_dynop347._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop347._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop348 = this;
					__temp_dynop348._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop348._currentPath, global::haxe.lang.Runtime.toString(cp1y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop349 = this;
					__temp_dynop349._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop349._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop350 = this;
					__temp_dynop350._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop350._currentPath, global::haxe.lang.Runtime.toString(cp2x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop351 = this;
					__temp_dynop351._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop351._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop352 = this;
					__temp_dynop352._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop352._currentPath, global::haxe.lang.Runtime.toString(cp2y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop353 = this;
					__temp_dynop353._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop353._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop354 = this;
					__temp_dynop354._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop354._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop355 = this;
					__temp_dynop355._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop355._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop356 = this;
					__temp_dynop356._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop356._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
			}
		}
		
		
		public virtual   void circle(double x, double y, double radius)
		{
			unchecked 
			{
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop357 = this;
					__temp_dynop357._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop357._currentPath, " M");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop358 = this;
					__temp_dynop358._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop358._currentPath, global::haxe.lang.Runtime.toString(( x - radius )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop359 = this;
					__temp_dynop359._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop359._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop360 = this;
					__temp_dynop360._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop360._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop361 = this;
					__temp_dynop361._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop361._currentPath, " A1,1 0 0,0 ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop362 = this;
					__temp_dynop362._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop362._currentPath, global::haxe.lang.Runtime.toString(( x + radius )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop363 = this;
					__temp_dynop363._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop363._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop364 = this;
					__temp_dynop364._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop364._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop365 = this;
					__temp_dynop365._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop365._currentPath, " A1,1 0 0,0 ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop366 = this;
					__temp_dynop366._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop366._currentPath, global::haxe.lang.Runtime.toString(( x - radius )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop367 = this;
					__temp_dynop367._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop367._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop368 = this;
					__temp_dynop368._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop368._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop369 = this;
					__temp_dynop369._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop369._currentPath, " z");
				}
				
			}
		}
		
		
		public virtual   void rect(double x, double y, double w, double h)
		{
			unchecked 
			{
				this._currentPathIsEmpty = false;
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop370 = this;
					__temp_dynop370._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop370._currentPath, " M");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop371 = this;
					__temp_dynop371._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop371._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop372 = this;
					__temp_dynop372._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop372._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop373 = this;
					__temp_dynop373._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop373._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop374 = this;
					__temp_dynop374._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop374._currentPath, " L");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop375 = this;
					__temp_dynop375._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop375._currentPath, global::haxe.lang.Runtime.toString(( x + w )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop376 = this;
					__temp_dynop376._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop376._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop377 = this;
					__temp_dynop377._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop377._currentPath, global::haxe.lang.Runtime.toString(y));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop378 = this;
					__temp_dynop378._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop378._currentPath, " ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop379 = this;
					__temp_dynop379._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop379._currentPath, global::haxe.lang.Runtime.toString(( x + w )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop380 = this;
					__temp_dynop380._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop380._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop381 = this;
					__temp_dynop381._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop381._currentPath, global::haxe.lang.Runtime.toString(( y + h )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop382 = this;
					__temp_dynop382._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop382._currentPath, " ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop383 = this;
					__temp_dynop383._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop383._currentPath, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop384 = this;
					__temp_dynop384._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop384._currentPath, ",");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop385 = this;
					__temp_dynop385._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop385._currentPath, global::haxe.lang.Runtime.toString(( y + h )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop386 = this;
					__temp_dynop386._currentPath = global::haxe.lang.Runtime.concat(__temp_dynop386._currentPath, " z");
				}
				
			}
		}
		
		
		public virtual   void fill()
		{
			unchecked 
			{
				if ( ! (this._currentPathIsEmpty) ) 
				{
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop387 = this;
						__temp_dynop387._buffer = global::haxe.lang.Runtime.concat(__temp_dynop387._buffer, "<path d=\"");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop388 = this;
						__temp_dynop388._buffer = global::haxe.lang.Runtime.concat(__temp_dynop388._buffer, this._currentPath);
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop389 = this;
						__temp_dynop389._buffer = global::haxe.lang.Runtime.concat(__temp_dynop389._buffer, "\" style=\"fill:");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop390 = this;
						__temp_dynop390._buffer = global::haxe.lang.Runtime.concat(__temp_dynop390._buffer, this._color.toRgbaString());
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop391 = this;
						__temp_dynop391._buffer = global::haxe.lang.Runtime.concat(__temp_dynop391._buffer, "\" stroke=\"none\"/>\n");
					}
					
				}
				
				this._currentPath = "";
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public virtual   void stroke()
		{
			unchecked 
			{
				if ( ! (this._currentPathIsEmpty) ) 
				{
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop392 = this;
						__temp_dynop392._buffer = global::haxe.lang.Runtime.concat(__temp_dynop392._buffer, "<path d=\"");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop393 = this;
						__temp_dynop393._buffer = global::haxe.lang.Runtime.concat(__temp_dynop393._buffer, this._currentPath);
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop394 = this;
						__temp_dynop394._buffer = global::haxe.lang.Runtime.concat(__temp_dynop394._buffer, "\" style=\"stroke:");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop395 = this;
						__temp_dynop395._buffer = global::haxe.lang.Runtime.concat(__temp_dynop395._buffer, this._color.toRgbaString());
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop396 = this;
						__temp_dynop396._buffer = global::haxe.lang.Runtime.concat(__temp_dynop396._buffer, "; stroke-width:");
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop397 = this;
						__temp_dynop397._buffer = global::haxe.lang.Runtime.concat(__temp_dynop397._buffer, global::haxe.lang.Runtime.toString(this._lineWidth));
					}
					
					{
						global::alphatab.platform.svg.SvgCanvas __temp_dynop398 = this;
						__temp_dynop398._buffer = global::haxe.lang.Runtime.concat(__temp_dynop398._buffer, ";\" fill=\"none\" />\n");
					}
					
				}
				
				this._currentPath = "";
				this._currentPathIsEmpty = true;
			}
		}
		
		
		public  global::alphatab.platform.model.Font _font;
		
		public virtual   void setFont(global::alphatab.platform.model.Font font)
		{
			unchecked 
			{
				this._font = font;
			}
		}
		
		
		public  global::alphatab.platform.model.TextAlign _textAlign;
		
		public virtual   global::alphatab.platform.model.TextAlign getTextAlign()
		{
			unchecked 
			{
				return this._textAlign;
			}
		}
		
		
		public virtual   void setTextAlign(global::alphatab.platform.model.TextAlign textAlign)
		{
			unchecked 
			{
				this._textAlign = textAlign;
			}
		}
		
		
		public  global::alphatab.model.TextBaseline _textBaseline;
		
		public virtual   global::alphatab.model.TextBaseline getTextBaseline()
		{
			unchecked 
			{
				return this._textBaseline;
			}
		}
		
		
		public virtual   void setTextBaseline(global::alphatab.model.TextBaseline textBaseline)
		{
			unchecked 
			{
				this._textBaseline = textBaseline;
			}
		}
		
		
		public virtual   void fillText(string text, double x, double y)
		{
			unchecked 
			{
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop399 = this;
					__temp_dynop399._buffer = global::haxe.lang.Runtime.concat(__temp_dynop399._buffer, "<text x=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop400 = this;
					__temp_dynop400._buffer = global::haxe.lang.Runtime.concat(__temp_dynop400._buffer, global::haxe.lang.Runtime.toString(x));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop401 = this;
					__temp_dynop401._buffer = global::haxe.lang.Runtime.concat(__temp_dynop401._buffer, "\" y=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop402 = this;
					__temp_dynop402._buffer = global::haxe.lang.Runtime.concat(__temp_dynop402._buffer, global::haxe.lang.Runtime.toString(( y + this.getSvgBaseLineOffset() )));
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop403 = this;
					__temp_dynop403._buffer = global::haxe.lang.Runtime.concat(__temp_dynop403._buffer, "\" style=\"font:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop404 = this;
					__temp_dynop404._buffer = global::haxe.lang.Runtime.concat(__temp_dynop404._buffer, this._font.toCssString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop405 = this;
					__temp_dynop405._buffer = global::haxe.lang.Runtime.concat(__temp_dynop405._buffer, "; fill:");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop406 = this;
					__temp_dynop406._buffer = global::haxe.lang.Runtime.concat(__temp_dynop406._buffer, this._color.toRgbaString());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop407 = this;
					__temp_dynop407._buffer = global::haxe.lang.Runtime.concat(__temp_dynop407._buffer, ";\" ");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop408 = this;
					__temp_dynop408._buffer = global::haxe.lang.Runtime.concat(__temp_dynop408._buffer, " dominant-baseline=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop409 = this;
					string __temp_stmt475 = default(string);
					{
						global::alphatab.model.TextBaseline _g = this._textBaseline;
						switch (global::haxe.root.Type.enumIndex(_g))
						{
							case 1:
							{
								__temp_stmt475 = "top";
								break;
							}
							
							
							case 2:
							{
								__temp_stmt475 = "middle";
								break;
							}
							
							
							case 3:
							{
								__temp_stmt475 = "bottom";
								break;
							}
							
							
							default:
							{
								__temp_stmt475 = "top";
								break;
							}
							
						}
						
					}
					
					__temp_dynop409._buffer = global::haxe.lang.Runtime.concat(__temp_dynop409._buffer, __temp_stmt475);
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop410 = this;
					__temp_dynop410._buffer = global::haxe.lang.Runtime.concat(__temp_dynop410._buffer, "\" text-anchor=\"");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop411 = this;
					__temp_dynop411._buffer = global::haxe.lang.Runtime.concat(__temp_dynop411._buffer, this.getSvgTextAlignment());
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop412 = this;
					__temp_dynop412._buffer = global::haxe.lang.Runtime.concat(__temp_dynop412._buffer, "\">\n");
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop413 = this;
					__temp_dynop413._buffer = global::haxe.lang.Runtime.concat(__temp_dynop413._buffer, text);
				}
				
				{
					global::alphatab.platform.svg.SvgCanvas __temp_dynop414 = this;
					__temp_dynop414._buffer = global::haxe.lang.Runtime.concat(__temp_dynop414._buffer, "</text>\n");
				}
				
			}
		}
		
		
		public virtual   string getSvgTextAlignment()
		{
			unchecked 
			{
				global::alphatab.platform.model.TextAlign _g = this._textAlign;
				switch (global::haxe.root.Type.enumIndex(_g))
				{
					case 0:
					{
						return "start";
					}
					
					
					case 1:
					{
						return "middle";
					}
					
					
					case 2:
					{
						return "end";
					}
					
					
				}
				
				return default(string);
			}
		}
		
		
		public virtual   double getSvgBaseLineOffset()
		{
			unchecked 
			{
				global::alphatab.model.TextBaseline _g = this._textBaseline;
				switch (global::haxe.root.Type.enumIndex(_g))
				{
					case 1:
					{
						return ((double) (0) );
					}
					
					
					case 2:
					{
						return ((double) (0) );
					}
					
					
					case 3:
					{
						return ((double) (0) );
					}
					
					
					default:
					{
						return this._font.getSize();
					}
					
				}
				
			}
		}
		
		
		public   string getSvgBaseLine()
		{
			unchecked 
			{
				global::alphatab.model.TextBaseline _g = this._textBaseline;
				switch (global::haxe.root.Type.enumIndex(_g))
				{
					case 1:
					{
						return "top";
					}
					
					
					case 2:
					{
						return "middle";
					}
					
					
					case 3:
					{
						return "bottom";
					}
					
					
					default:
					{
						return "top";
					}
					
				}
				
			}
		}
		
		
		public virtual   double measureText(string text)
		{
			unchecked 
			{
				if (( string.Equals(text, default(string)) || ( text.Length == 0 ) )) 
				{
					return ((double) (0) );
				}
				
				global::alphatab.platform.svg.SupportedFonts font = global::alphatab.platform.svg.SupportedFonts.Arial;
				if (( global::haxe.lang.StringExt.indexOf(this._font.getFamily(), "Times", default(global::haxe.lang.Null<int>)) >= 0 )) 
				{
					font = global::alphatab.platform.svg.SupportedFonts.TimesNewRoman;
				}
				
				return ((double) (global::alphatab.platform.svg.FontSizes.measureString(text, font, this._font.getSize())) );
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1828730163:
					{
						this._lineWidth = ((double) (@value) );
						return @value;
					}
					
					
					case 1891834246:
					{
						this._height = ((int) (@value) );
						return @value;
					}
					
					
					case 1179254087:
					{
						this._width = ((int) (@value) );
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
					case 672263473:
					{
						this._textBaseline = ((global::alphatab.model.TextBaseline) (@value) );
						return @value;
					}
					
					
					case 371286681:
					{
						this._textAlign = ((global::alphatab.platform.model.TextAlign) (@value) );
						return @value;
					}
					
					
					case 1993439662:
					{
						this._font = ((global::alphatab.platform.model.Font) (@value) );
						return @value;
					}
					
					
					case 1828730163:
					{
						this._lineWidth = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
						return @value;
					}
					
					
					case 1178843300:
					{
						this._color = ((global::alphatab.platform.model.Color) (@value) );
						return @value;
					}
					
					
					case 1891834246:
					{
						this._height = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1179254087:
					{
						this._width = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1083160452:
					{
						this._currentPathIsEmpty = ((bool) (@value) );
						return @value;
					}
					
					
					case 1760390271:
					{
						this._currentPath = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1057738399:
					{
						this._buffer = global::haxe.lang.Runtime.toString(@value);
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
					case 1350630187:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("measureText"), ((int) (1350630187) ))) );
					}
					
					
					case 1118815795:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSvgBaseLine"), ((int) (1118815795) ))) );
					}
					
					
					case 1734539814:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSvgBaseLineOffset"), ((int) (1734539814) ))) );
					}
					
					
					case 507631656:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getSvgTextAlignment"), ((int) (507631656) ))) );
					}
					
					
					case 1846265040:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("fillText"), ((int) (1846265040) ))) );
					}
					
					
					case 1683565844:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setTextBaseline"), ((int) (1683565844) ))) );
					}
					
					
					case 1754116104:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTextBaseline"), ((int) (1754116104) ))) );
					}
					
					
					case 672263473:
					{
						return this._textBaseline;
					}
					
					
					case 1590601430:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setTextAlign"), ((int) (1590601430) ))) );
					}
					
					
					case 1238729570:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getTextAlign"), ((int) (1238729570) ))) );
					}
					
					
					case 371286681:
					{
						return this._textAlign;
					}
					
					
					case 155491985:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setFont"), ((int) (155491985) ))) );
					}
					
					
					case 1993439662:
					{
						return this._font;
					}
					
					
					case 288666552:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("stroke"), ((int) (288666552) ))) );
					}
					
					
					case 1136381571:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("fill"), ((int) (1136381571) ))) );
					}
					
					
					case 1269255460:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("rect"), ((int) (1269255460) ))) );
					}
					
					
					case 1443721744:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("circle"), ((int) (1443721744) ))) );
					}
					
					
					case 978278827:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("bezierCurveTo"), ((int) (978278827) ))) );
					}
					
					
					case 46352402:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("quadraticCurveTo"), ((int) (46352402) ))) );
					}
					
					
					case 1822443151:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("lineTo"), ((int) (1822443151) ))) );
					}
					
					
					case 1286394604:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("moveTo"), ((int) (1286394604) ))) );
					}
					
					
					case 337667453:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("closePath"), ((int) (337667453) ))) );
					}
					
					
					case 321635438:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("beginPath"), ((int) (321635438) ))) );
					}
					
					
					case 491088124:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("strokeRect"), ((int) (491088124) ))) );
					}
					
					
					case 1824081223:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("fillRect"), ((int) (1824081223) ))) );
					}
					
					
					case 1213952397:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("clear"), ((int) (1213952397) ))) );
					}
					
					
					case 900561264:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setLineWidth"), ((int) (900561264) ))) );
					}
					
					
					case 1828730163:
					{
						return this._lineWidth;
					}
					
					
					case 1485888097:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setColor"), ((int) (1485888097) ))) );
					}
					
					
					case 1178843300:
					{
						return this._color;
					}
					
					
					case 1643347241:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setHeight"), ((int) (1643347241) ))) );
					}
					
					
					case 1486298884:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("setWidth"), ((int) (1486298884) ))) );
					}
					
					
					case 2124583197:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getHeight"), ((int) (2124583197) ))) );
					}
					
					
					case 708429200:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getWidth"), ((int) (708429200) ))) );
					}
					
					
					case 337206185:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("toSvg"), ((int) (337206185) ))) );
					}
					
					
					case 724954170:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("writeTo"), ((int) (724954170) ))) );
					}
					
					
					case 1891834246:
					{
						return this._height;
					}
					
					
					case 1179254087:
					{
						return this._width;
					}
					
					
					case 1083160452:
					{
						return this._currentPathIsEmpty;
					}
					
					
					case 1760390271:
					{
						return this._currentPath;
					}
					
					
					case 1057738399:
					{
						return this._buffer;
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
					case 1828730163:
					{
						return this._lineWidth;
					}
					
					
					case 1891834246:
					{
						return ((double) (this._height) );
					}
					
					
					case 1179254087:
					{
						return ((double) (this._width) );
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
					case 1350630187:
					{
						return this.measureText(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1118815795:
					{
						return this.getSvgBaseLine();
					}
					
					
					case 1734539814:
					{
						return this.getSvgBaseLineOffset();
					}
					
					
					case 507631656:
					{
						return this.getSvgTextAlignment();
					}
					
					
					case 1846265040:
					{
						this.fillText(global::haxe.lang.Runtime.toString(dynargs[0]), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ));
						break;
					}
					
					
					case 1683565844:
					{
						this.setTextBaseline(((global::alphatab.model.TextBaseline) (dynargs[0]) ));
						break;
					}
					
					
					case 1754116104:
					{
						return this.getTextBaseline();
					}
					
					
					case 1590601430:
					{
						this.setTextAlign(((global::alphatab.platform.model.TextAlign) (dynargs[0]) ));
						break;
					}
					
					
					case 1238729570:
					{
						return this.getTextAlign();
					}
					
					
					case 155491985:
					{
						this.setFont(((global::alphatab.platform.model.Font) (dynargs[0]) ));
						break;
					}
					
					
					case 288666552:
					{
						this.stroke();
						break;
					}
					
					
					case 1136381571:
					{
						this.fill();
						break;
					}
					
					
					case 1269255460:
					{
						this.rect(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1443721744:
					{
						this.circle(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ));
						break;
					}
					
					
					case 978278827:
					{
						this.bezierCurveTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[4])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[5])) ));
						break;
					}
					
					
					case 46352402:
					{
						this.quadraticCurveTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1822443151:
					{
						this.lineTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ));
						break;
					}
					
					
					case 1286394604:
					{
						this.moveTo(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ));
						break;
					}
					
					
					case 337667453:
					{
						this.closePath();
						break;
					}
					
					
					case 321635438:
					{
						this.beginPath();
						break;
					}
					
					
					case 491088124:
					{
						this.strokeRect(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1824081223:
					{
						this.fillRect(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[1])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ));
						break;
					}
					
					
					case 1213952397:
					{
						this.clear();
						break;
					}
					
					
					case 900561264:
					{
						this.setLineWidth(((double) (global::haxe.lang.Runtime.toDouble(dynargs[0])) ));
						break;
					}
					
					
					case 1485888097:
					{
						this.setColor(((global::alphatab.platform.model.Color) (dynargs[0]) ));
						break;
					}
					
					
					case 1643347241:
					{
						this.setHeight(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1486298884:
					{
						this.setWidth(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 2124583197:
					{
						return this.getHeight();
					}
					
					
					case 708429200:
					{
						return this.getWidth();
					}
					
					
					case 337206185:
					{
						return this.toSvg(((bool) (dynargs[0]) ), global::haxe.lang.Runtime.toString(dynargs[1]));
					}
					
					
					case 724954170:
					{
						this.writeTo(((global::haxe.io.Output) (dynargs[0]) ), ((bool) (dynargs[1]) ), global::haxe.lang.Runtime.toString(dynargs[2]));
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
				baseArr.push("_textBaseline");
				baseArr.push("_textAlign");
				baseArr.push("_font");
				baseArr.push("_lineWidth");
				baseArr.push("_color");
				baseArr.push("_height");
				baseArr.push("_width");
				baseArr.push("_currentPathIsEmpty");
				baseArr.push("_currentPath");
				baseArr.push("_buffer");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


