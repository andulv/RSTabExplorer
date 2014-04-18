using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering
{
	public  class ScoreRenderer : global::haxe.lang.HxObject 
	{
		public    ScoreRenderer(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    ScoreRenderer(global::alphatab.Settings settings, object param)
		{
			unchecked 
			{
				global::alphatab.rendering.ScoreRenderer.__hx_ctor_alphatab_rendering_ScoreRenderer(this, settings, param);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_ScoreRenderer(global::alphatab.rendering.ScoreRenderer __temp_me101, global::alphatab.Settings settings, object param)
		{
			unchecked 
			{
				__temp_me101.settings = settings;
				__temp_me101._renderFinishedListeners = new global::haxe.root.Array<object>();
				__temp_me101.renderingResources = new global::alphatab.rendering.RenderingResources(((double) (1) ));
				if (( string.Equals(settings.engine, default(string)) ||  ! (global::alphatab.Environment.renderEngines.exists(settings.engine))  )) 
				{
					__temp_me101.canvas = ((global::alphatab.platform.ICanvas) (((global::haxe.lang.Function) (global::alphatab.Environment.renderEngines.@get("default").@value) ).__hx_invoke1_o(default(double), param)) );
				}
				 else 
				{
					__temp_me101.canvas = ((global::alphatab.platform.ICanvas) (((global::haxe.lang.Function) (global::alphatab.Environment.renderEngines.@get(settings.engine).@value) ).__hx_invoke1_o(default(double), param)) );
				}
				
				__temp_me101.recreateLayout();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.ScoreRenderer(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.ScoreRenderer(((global::alphatab.Settings) (arr[0]) ), ((object) (arr[1]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _renderFinishedListeners;
		
		public  global::alphatab.platform.ICanvas canvas;
		
		public  global::alphatab.model.Score score;
		
		public  global::alphatab.model.Track track;
		
		public  string _currentLayoutMode;
		
		public  global::alphatab.rendering.layout.ScoreLayout layout;
		
		public  global::alphatab.rendering.RenderingResources renderingResources;
		
		public  global::alphatab.Settings settings;
		
		public virtual   void recreateLayout()
		{
			unchecked 
			{
				if ( ! (string.Equals(this._currentLayoutMode, this.settings.layout.mode)) ) 
				{
					if (( ( this.settings.layout == default(global::alphatab.LayoutSettings) ) ||  ! (global::alphatab.Environment.layoutEngines.exists(this.settings.layout.mode))  )) 
					{
						this.layout = ((global::alphatab.rendering.layout.ScoreLayout) (((global::haxe.lang.Function) (global::alphatab.Environment.layoutEngines.@get("default").@value) ).__hx_invoke1_o(default(double), this)) );
					}
					 else 
					{
						this.layout = ((global::alphatab.rendering.layout.ScoreLayout) (((global::haxe.lang.Function) (global::alphatab.Environment.layoutEngines.@get(this.settings.layout.mode).@value) ).__hx_invoke1_o(default(double), this)) );
					}
					
					this._currentLayoutMode = this.settings.layout.mode;
				}
				
			}
		}
		
		
		public virtual   void render(global::alphatab.model.Track track)
		{
			unchecked 
			{
				this.track = track;
				this.invalidate();
			}
		}
		
		
		public virtual   void invalidate()
		{
			unchecked 
			{
				if (( this.renderingResources.scale != this.settings.scale )) 
				{
					this.renderingResources.init(this.settings.scale);
					this.canvas.setLineWidth(this.settings.scale);
				}
				
				this.recreateLayout();
				this.canvas.clear();
				this.doLayout();
				this.paintScore();
				this.raiseRenderFinished();
			}
		}
		
		
		public virtual   global::alphatab.model.Score _get_score()
		{
			unchecked 
			{
				if (( this.track == default(global::alphatab.model.Track) )) 
				{
					return default(global::alphatab.model.Score);
				}
				
				return this.track.score;
			}
		}
		
		
		public virtual   void doLayout()
		{
			unchecked 
			{
				this.layout.doLayout();
				int __temp_stmt566 = default(int);
				{
					double x = ( this.layout.height + ( this.renderingResources.copyrightFont.getSize() * 2 ) );
					__temp_stmt566 = ((int) (x) );
				}
				
				this.canvas.setHeight(__temp_stmt566);
				this.canvas.setWidth(this.layout.width);
			}
		}
		
		
		public virtual   void paintScore()
		{
			unchecked 
			{
				this.paintBackground();
				this.layout.paintScore();
			}
		}
		
		
		public virtual   void paintBackground()
		{
			unchecked 
			{
				string msg = "Rendered using alphaTab (http://www.alphaTab.net)";
				this.canvas.setColor(new global::alphatab.platform.model.Color(((int) (62) ), ((int) (62) ), ((int) (62) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) )));
				this.canvas.setFont(this.renderingResources.copyrightFont);
				this.canvas.setTextAlign(global::alphatab.platform.model.TextAlign.Center);
				double x = ( ((double) (this.canvas.getWidth()) ) / 2 );
				this.canvas.fillText(msg, x, ( this.canvas.getHeight() - ( this.renderingResources.copyrightFont.getSize() * 2 ) ));
			}
		}
		
		
		public virtual   void addRenderFinishedListener(global::haxe.lang.Function listener)
		{
			unchecked 
			{
				this._renderFinishedListeners.push(listener);
			}
		}
		
		
		public virtual   void removeRenderFinishedListener(global::haxe.lang.Function listener)
		{
			unchecked 
			{
				this._renderFinishedListeners.@remove(listener);
			}
		}
		
		
		public virtual   void raiseRenderFinished()
		{
			unchecked 
			{
				int _g = 0;
				global::haxe.root.Array<object> _g1 = this._renderFinishedListeners;
				while (( _g < _g1.length ))
				{
					global::haxe.lang.Function l = ((global::haxe.lang.Function) (_g1[_g]) );
					 ++ _g;
					if (( l != default(global::haxe.lang.Function) )) 
					{
						l.__hx_invoke0_o();
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
					case 188579043:
					{
						this.settings = ((global::alphatab.Settings) (@value) );
						return @value;
					}
					
					
					case 307761913:
					{
						this.renderingResources = ((global::alphatab.rendering.RenderingResources) (@value) );
						return @value;
					}
					
					
					case 1488498346:
					{
						this.layout = ((global::alphatab.rendering.layout.ScoreLayout) (@value) );
						return @value;
					}
					
					
					case 223048071:
					{
						this._currentLayoutMode = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 371166859:
					{
						this.track = ((global::alphatab.model.Track) (@value) );
						return @value;
					}
					
					
					case 2027516754:
					{
						this.score = ((global::alphatab.model.Score) (@value) );
						return @value;
					}
					
					
					case 943871192:
					{
						this.canvas = ((global::alphatab.platform.ICanvas) (@value) );
						return @value;
					}
					
					
					case 1842287352:
					{
						this._renderFinishedListeners = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
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
					case 1658175220:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("raiseRenderFinished"), ((int) (1658175220) ))) );
					}
					
					
					case 1008896224:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("removeRenderFinishedListener"), ((int) (1008896224) ))) );
					}
					
					
					case 1495460989:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addRenderFinishedListener"), ((int) (1495460989) ))) );
					}
					
					
					case 1334722860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintBackground"), ((int) (1334722860) ))) );
					}
					
					
					case 1331941076:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("paintScore"), ((int) (1331941076) ))) );
					}
					
					
					case 1825584277:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("doLayout"), ((int) (1825584277) ))) );
					}
					
					
					case 1015205801:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("get_score"), ((int) (1015205801) ))) );
					}
					
					
					case 120199547:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("invalidate"), ((int) (120199547) ))) );
					}
					
					
					case 86600534:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("render"), ((int) (86600534) ))) );
					}
					
					
					case 825135865:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("recreateLayout"), ((int) (825135865) ))) );
					}
					
					
					case 188579043:
					{
						return this.settings;
					}
					
					
					case 307761913:
					{
						return this.renderingResources;
					}
					
					
					case 1488498346:
					{
						return this.layout;
					}
					
					
					case 223048071:
					{
						return this._currentLayoutMode;
					}
					
					
					case 371166859:
					{
						return this.track;
					}
					
					
					case 2027516754:
					{
						if (handleProperties) 
						{
							return this._get_score();
						}
						 else 
						{
							return this.score;
						}
						
					}
					
					
					case 943871192:
					{
						return this.canvas;
					}
					
					
					case 1842287352:
					{
						return this._renderFinishedListeners;
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
					case 1658175220:
					{
						this.raiseRenderFinished();
						break;
					}
					
					
					case 1008896224:
					{
						this.removeRenderFinishedListener(((global::haxe.lang.Function) (dynargs[0]) ));
						break;
					}
					
					
					case 1495460989:
					{
						this.addRenderFinishedListener(((global::haxe.lang.Function) (dynargs[0]) ));
						break;
					}
					
					
					case 1334722860:
					{
						this.paintBackground();
						break;
					}
					
					
					case 1331941076:
					{
						this.paintScore();
						break;
					}
					
					
					case 1825584277:
					{
						this.doLayout();
						break;
					}
					
					
					case 1015205801:
					{
						return this._get_score();
					}
					
					
					case 120199547:
					{
						this.invalidate();
						break;
					}
					
					
					case 86600534:
					{
						this.render(((global::alphatab.model.Track) (dynargs[0]) ));
						break;
					}
					
					
					case 825135865:
					{
						this.recreateLayout();
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
				baseArr.push("settings");
				baseArr.push("renderingResources");
				baseArr.push("layout");
				baseArr.push("_currentLayoutMode");
				baseArr.push("track");
				baseArr.push("score");
				baseArr.push("canvas");
				baseArr.push("_renderFinishedListeners");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


