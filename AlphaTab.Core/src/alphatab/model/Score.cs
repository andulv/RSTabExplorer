using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class Score : global::haxe.lang.HxObject 
	{
		public    Score(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Score()
		{
			unchecked 
			{
				global::alphatab.model.Score.__hx_ctor_alphatab_model_Score(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Score(global::alphatab.model.Score __temp_me84)
		{
			unchecked 
			{
				__temp_me84.masterBars = new global::haxe.root.Array<object>();
				__temp_me84.tracks = new global::haxe.root.Array<object>();
				__temp_me84._currentRepeatGroup = new global::alphatab.model.RepeatGroup();
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.Score(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.Score();
			}
		}
		
		
		public  global::alphatab.model.RepeatGroup _currentRepeatGroup;
		
		public  string album;
		
		public  string artist;
		
		public  string copyright;
		
		public  string instructions;
		
		public  string music;
		
		public  string notices;
		
		public  string subTitle;
		
		public  string title;
		
		public  string words;
		
		public  string tab;
		
		public  int tempo;
		
		public  string tempoLabel;
		
		public  global::haxe.root.Array<object> masterBars;
		
		public  global::haxe.root.Array<object> tracks;
		
		public virtual   void addMasterBar(global::alphatab.model.MasterBar bar)
		{
			unchecked 
			{
				bar.score = this;
				bar.index = this.masterBars.length;
				if (( this.masterBars.length != 0 )) 
				{
					bar.previousMasterBar = ((global::alphatab.model.MasterBar) (this.masterBars[( this.masterBars.length - 1 )]) );
					bar.previousMasterBar.nextMasterBar = bar;
					bar.start = ( bar.previousMasterBar.start + bar.previousMasterBar.calculateDuration() );
				}
				
				if (( bar.isRepeatStart || ( this._currentRepeatGroup.isClosed && ( bar.alternateEndings <= 0 ) ) )) 
				{
					this._currentRepeatGroup = new global::alphatab.model.RepeatGroup();
				}
				
				this._currentRepeatGroup.addMasterBar(bar);
				this.masterBars.push(bar);
			}
		}
		
		
		public virtual   void addTrack(global::alphatab.model.Track track)
		{
			unchecked 
			{
				track.score = this;
				track.index = this.tracks.length;
				this.tracks.push(track);
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 227602139:
					{
						this.tempo = ((int) (@value) );
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
					case 1165831048:
					{
						this.tracks = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 137661698:
					{
						this.masterBars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1263850777:
					{
						this.tempoLabel = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 227602139:
					{
						this.tempo = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 5790293:
					{
						this.tab = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1315213161:
					{
						this.words = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 272307608:
					{
						this.title = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 89811960:
					{
						this.subTitle = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1342455131:
					{
						this.notices = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 274387109:
					{
						this.music = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1832883877:
					{
						this.instructions = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1546764295:
					{
						this.copyright = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 961082055:
					{
						this.artist = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 562828079:
					{
						this.album = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1116891722:
					{
						this._currentRepeatGroup = ((global::alphatab.model.RepeatGroup) (@value) );
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
					case 259830954:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addTrack"), ((int) (259830954) ))) );
					}
					
					
					case 2127207408:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("addMasterBar"), ((int) (2127207408) ))) );
					}
					
					
					case 1165831048:
					{
						return this.tracks;
					}
					
					
					case 137661698:
					{
						return this.masterBars;
					}
					
					
					case 1263850777:
					{
						return this.tempoLabel;
					}
					
					
					case 227602139:
					{
						return this.tempo;
					}
					
					
					case 5790293:
					{
						return this.tab;
					}
					
					
					case 1315213161:
					{
						return this.words;
					}
					
					
					case 272307608:
					{
						return this.title;
					}
					
					
					case 89811960:
					{
						return this.subTitle;
					}
					
					
					case 1342455131:
					{
						return this.notices;
					}
					
					
					case 274387109:
					{
						return this.music;
					}
					
					
					case 1832883877:
					{
						return this.instructions;
					}
					
					
					case 1546764295:
					{
						return this.copyright;
					}
					
					
					case 961082055:
					{
						return this.artist;
					}
					
					
					case 562828079:
					{
						return this.album;
					}
					
					
					case 1116891722:
					{
						return this._currentRepeatGroup;
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
					case 227602139:
					{
						return ((double) (this.tempo) );
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
					case 259830954:
					{
						this.addTrack(((global::alphatab.model.Track) (dynargs[0]) ));
						break;
					}
					
					
					case 2127207408:
					{
						this.addMasterBar(((global::alphatab.model.MasterBar) (dynargs[0]) ));
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
				baseArr.push("tracks");
				baseArr.push("masterBars");
				baseArr.push("tempoLabel");
				baseArr.push("tempo");
				baseArr.push("tab");
				baseArr.push("words");
				baseArr.push("title");
				baseArr.push("subTitle");
				baseArr.push("notices");
				baseArr.push("music");
				baseArr.push("instructions");
				baseArr.push("copyright");
				baseArr.push("artist");
				baseArr.push("album");
				baseArr.push("_currentRepeatGroup");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


