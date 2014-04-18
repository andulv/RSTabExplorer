using haxe.root;
namespace alphatab.rendering.utils
{
	public enum BeamDirection
	{
		Up, Down
	}
}



namespace alphatab.rendering.utils
{
	public enum BeamBarType
	{
		Full, PartLeft, PartRight
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils
{
	public  class BeamingHelper : global::haxe.lang.HxObject 
	{
		static BeamingHelper() 
		{
			global::alphatab.rendering.utils.BeamingHelper.ScoreMiddleKeys = new global::haxe.root.Array<int>(new int[]{48, 45, 38, 59});
		}
		public    BeamingHelper(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    BeamingHelper(global::alphatab.model.Track track)
		{
			unchecked 
			{
				global::alphatab.rendering.utils.BeamingHelper.__hx_ctor_alphatab_rendering_utils_BeamingHelper(this, track);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_BeamingHelper(global::alphatab.rendering.utils.BeamingHelper __temp_me268, global::alphatab.model.Track track)
		{
			unchecked 
			{
				__temp_me268.beats = new global::haxe.root.Array<object>();
				__temp_me268._track = track;
				__temp_me268._beatLineXPositions = new global::haxe.ds.IntMap<object>();
				__temp_me268.maxDuration = global::alphatab.model.Duration.Whole;
			}
		}
		
		
		public static  global::haxe.root.Array<int> ScoreMiddleKeys;
		
		public static   bool canJoin(global::alphatab.model.Beat b1, global::alphatab.model.Beat b2)
		{
			unchecked 
			{
				if (( ( ( ( b1 == default(global::alphatab.model.Beat) ) || ( b2 == default(global::alphatab.model.Beat) ) ) || b1.isRest() ) || b2.isRest() )) 
				{
					return false;
				}
				
				global::alphatab.model.Bar m1 = b1.voice.bar;
				global::alphatab.model.Bar m2 = b1.voice.bar;
				if (( m1 != m2 )) 
				{
					return false;
				}
				
				int start1 = b1.start;
				int start2 = b2.start;
				if ((  ! (global::alphatab.rendering.utils.BeamingHelper.canJoinDuration(b1.duration))  ||  ! (global::alphatab.rendering.utils.BeamingHelper.canJoinDuration(b2.duration))  )) 
				{
					return ( start1 == start2 );
				}
				
				int divisionLength = 960;
				{
					int _g = ((global::alphatab.model.MasterBar) (m1.track.score.masterBars[m1.index]) ).timeSignatureDenominator;
					switch (_g)
					{
						case 8:
						{
							if (( ( ((global::alphatab.model.MasterBar) (m1.track.score.masterBars[m1.index]) ).timeSignatureNumerator % 3 ) == 0 )) 
							{
								{
									double x = global::System.Math.Floor(((double) (480.0) ));
									divisionLength += ((int) (x) );
								}
								
							}
							
							break;
						}
						
						
					}
					
				}
				
				int division1 = ( (( divisionLength + start1 )) / divisionLength );
				int division2 = ( (( divisionLength + start2 )) / divisionLength );
				return ( division1 == division2 );
			}
		}
		
		
		public static   void calculateDivision(global::alphatab.model.Beat b, int l)
		{
			unchecked 
			{
				int start = 0;
			}
		}
		
		
		public static   bool canJoinDuration(global::alphatab.model.Duration d)
		{
			unchecked 
			{
				switch (global::haxe.root.Type.enumIndex(d))
				{
					case 0:case 1:case 2:
					{
						return false;
					}
					
					
					default:
					{
						return true;
					}
					
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.rendering.utils.BeamingHelper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.rendering.utils.BeamingHelper(((global::alphatab.model.Track) (arr[0]) ));
			}
		}
		
		
		public  global::alphatab.model.Voice voice;
		
		public  global::haxe.root.Array<object> beats;
		
		public  global::alphatab.model.Beat _lastBeat;
		
		public  global::alphatab.model.Duration maxDuration;
		
		public  global::alphatab.model.Note firstMinNote;
		
		public  global::alphatab.model.Note firstMaxNote;
		
		public  global::alphatab.model.Note lastMinNote;
		
		public  global::alphatab.model.Note lastMaxNote;
		
		public  global::alphatab.model.Note minNote;
		
		public  global::alphatab.model.Note maxNote;
		
		public  global::alphatab.model.Track _track;
		
		public virtual   int getValue(global::alphatab.model.Note n)
		{
			unchecked 
			{
				if (this._track.isPercussion) 
				{
					return global::alphatab.rendering.utils.PercussionMapper.mapValue(n);
				}
				 else 
				{
					return ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] );
				}
				
			}
		}
		
		
		public  global::haxe.ds.IntMap<object> _beatLineXPositions;
		
		public virtual   int getBeatLineX(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				if (this._beatLineXPositions.exists(beat.index)) 
				{
					if (( this.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
					{
						return ((int) (global::haxe.lang.Runtime.getField_f((this._beatLineXPositions.@get(beat.index)).toDynamic(), "up", 26203, true)) );
					}
					 else 
					{
						return ((int) (global::haxe.lang.Runtime.getField_f((this._beatLineXPositions.@get(beat.index)).toDynamic(), "down", 1114503266, true)) );
					}
					
				}
				
				return 0;
			}
		}
		
		
		public virtual   void registerBeatLineX(global::alphatab.model.Beat beat, int up, int down)
		{
			unchecked 
			{
				this._beatLineXPositions.@set(beat.index, new global::haxe.lang.DynamicObject(new global::haxe.root.Array<int>(new int[]{}), new global::haxe.root.Array<object>(new object[]{}), new global::haxe.root.Array<int>(new int[]{26203, 1114503266}), new global::haxe.root.Array<double>(new double[]{((double) (up) ), ((double) (down) )})));
			}
		}
		
		
		public virtual   global::alphatab.rendering.utils.BeamDirection getDirection()
		{
			unchecked 
			{
				int avg = default(int);
				{
					double x = ( ((double) ((( this.getValue(this.maxNote) + this.getValue(this.minNote) ))) ) / 2 );
					avg = ((int) (x) );
				}
				
				if (( avg <= global::alphatab.rendering.utils.BeamingHelper.ScoreMiddleKeys[( global::haxe.root.Type.enumIndex(this._lastBeat.voice.bar.clef) - 1 )] )) 
				{
					return global::alphatab.rendering.utils.BeamDirection.Up;
				}
				 else 
				{
					return global::alphatab.rendering.utils.BeamDirection.Down;
				}
				
			}
		}
		
		
		public virtual   bool checkBeat(global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				if (( this.voice == default(global::alphatab.model.Voice) )) 
				{
					this.voice = beat.voice;
				}
				
				bool @add = false;
				if (( this.beats.length == 0 )) 
				{
					@add = true;
				}
				 else 
				{
					if (global::alphatab.rendering.utils.BeamingHelper.canJoin(this._lastBeat, beat)) 
					{
						@add = true;
					}
					
				}
				
				if (@add) 
				{
					this._lastBeat = beat;
					this.beats.push(beat);
					this.checkNote(beat.minNote());
					this.checkNote(beat.maxNote());
					if (( global::alphatab.model.ModelUtils.getDurationValue(this.maxDuration) < global::alphatab.model.ModelUtils.getDurationValue(beat.duration) )) 
					{
						this.maxDuration = beat.duration;
					}
					
				}
				
				return @add;
			}
		}
		
		
		public virtual   void checkNote(global::alphatab.model.Note note)
		{
			unchecked 
			{
				int @value = ( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] );
				if (( ( this.firstMinNote == default(global::alphatab.model.Note) ) || ( note.beat.index < this.firstMinNote.beat.index ) )) 
				{
					this.firstMinNote = note;
				}
				 else 
				{
					if (( note.beat.index == this.firstMinNote.beat.index )) 
					{
						int __temp_stmt609 = default(int);
						{
							global::alphatab.model.Note _this = this.firstMinNote;
							__temp_stmt609 = ( _this.fret + _this.beat.voice.bar.track.tuning[( ( _this.beat.voice.bar.track.tuning.length - (( _this.@string - 1 )) ) - 1 )] );
						}
						
						if (( ( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] ) < __temp_stmt609 )) 
						{
							this.firstMinNote = note;
						}
						
					}
					
				}
				
				if (( ( this.firstMaxNote == default(global::alphatab.model.Note) ) || ( note.beat.index < this.firstMaxNote.beat.index ) )) 
				{
					this.firstMaxNote = note;
				}
				 else 
				{
					if (( note.beat.index == this.firstMaxNote.beat.index )) 
					{
						int __temp_stmt610 = default(int);
						{
							global::alphatab.model.Note _this1 = this.firstMaxNote;
							__temp_stmt610 = ( _this1.fret + _this1.beat.voice.bar.track.tuning[( ( _this1.beat.voice.bar.track.tuning.length - (( _this1.@string - 1 )) ) - 1 )] );
						}
						
						if (( ( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] ) > __temp_stmt610 )) 
						{
							this.firstMaxNote = note;
						}
						
					}
					
				}
				
				if (( ( this.lastMinNote == default(global::alphatab.model.Note) ) || ( note.beat.index > this.lastMinNote.beat.index ) )) 
				{
					this.lastMinNote = note;
				}
				 else 
				{
					if (( note.beat.index == this.lastMinNote.beat.index )) 
					{
						int __temp_stmt611 = default(int);
						{
							global::alphatab.model.Note _this2 = this.lastMinNote;
							__temp_stmt611 = ( _this2.fret + _this2.beat.voice.bar.track.tuning[( ( _this2.beat.voice.bar.track.tuning.length - (( _this2.@string - 1 )) ) - 1 )] );
						}
						
						if (( ( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] ) < __temp_stmt611 )) 
						{
							this.lastMinNote = note;
						}
						
					}
					
				}
				
				if (( ( this.lastMaxNote == default(global::alphatab.model.Note) ) || ( note.beat.index > this.lastMaxNote.beat.index ) )) 
				{
					this.lastMaxNote = note;
				}
				 else 
				{
					if (( note.beat.index == this.lastMaxNote.beat.index )) 
					{
						int __temp_stmt612 = default(int);
						{
							global::alphatab.model.Note _this3 = this.lastMaxNote;
							__temp_stmt612 = ( _this3.fret + _this3.beat.voice.bar.track.tuning[( ( _this3.beat.voice.bar.track.tuning.length - (( _this3.@string - 1 )) ) - 1 )] );
						}
						
						if (( ( note.fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] ) > __temp_stmt612 )) 
						{
							this.lastMaxNote = note;
						}
						
					}
					
				}
				
				bool __temp_stmt614 = ( this.maxNote == default(global::alphatab.model.Note) );
				bool __temp_boolv615 = false;
				if ( ! (__temp_stmt614) ) 
				{
					int __temp_stmt616 = default(int);
					{
						global::alphatab.model.Note _this4 = this.maxNote;
						__temp_stmt616 = ( _this4.fret + _this4.beat.voice.bar.track.tuning[( ( _this4.beat.voice.bar.track.tuning.length - (( _this4.@string - 1 )) ) - 1 )] );
					}
					
					__temp_boolv615 = ( @value > __temp_stmt616 );
				}
				
				bool __temp_stmt613 = ( __temp_stmt614 || __temp_boolv615 );
				if (__temp_stmt613) 
				{
					this.maxNote = note;
				}
				
				bool __temp_stmt618 = ( this.minNote == default(global::alphatab.model.Note) );
				bool __temp_boolv619 = false;
				if ( ! (__temp_stmt618) ) 
				{
					int __temp_stmt620 = default(int);
					{
						global::alphatab.model.Note _this5 = this.minNote;
						__temp_stmt620 = ( _this5.fret + _this5.beat.voice.bar.track.tuning[( ( _this5.beat.voice.bar.track.tuning.length - (( _this5.@string - 1 )) ) - 1 )] );
					}
					
					__temp_boolv619 = ( @value < __temp_stmt620 );
				}
				
				bool __temp_stmt617 = ( __temp_stmt618 || __temp_boolv619 );
				if (__temp_stmt617) 
				{
					this.minNote = note;
				}
				
			}
		}
		
		
		public virtual   int calculateBeamY(int stemSize, int xCorrection, int xPosition, double scale, global::haxe.lang.Function yPosition)
		{
			unchecked 
			{
				global::alphatab.rendering.utils.BeamDirection direction = this.getDirection();
				if (( this.beats.length == 1 )) 
				{
					if (( this.getDirection() == global::alphatab.rendering.utils.BeamDirection.Up )) 
					{
						return ( ((int) (yPosition.__hx_invoke1_f(default(double), this.maxNote)) ) - stemSize );
					}
					 else 
					{
						return ( ((int) (yPosition.__hx_invoke1_f(default(double), this.minNote)) ) + stemSize );
					}
					
				}
				
				int maxDistance = ((int) (( 10 * scale )) );
				if (( ( ( direction == global::alphatab.rendering.utils.BeamDirection.Down ) && ( this.minNote != this.firstMinNote ) ) && ( this.minNote != this.lastMinNote ) )) 
				{
					return ( ((int) (yPosition.__hx_invoke1_f(default(double), this.minNote)) ) + stemSize );
				}
				 else 
				{
					if (( ( ( direction == global::alphatab.rendering.utils.BeamDirection.Up ) && ( this.maxNote != this.firstMaxNote ) ) && ( this.maxNote != this.lastMaxNote ) )) 
					{
						return ( ((int) (yPosition.__hx_invoke1_f(default(double), this.maxNote)) ) - stemSize );
					}
					
				}
				
				int startX = ( this.getBeatLineX(this.firstMinNote.beat) + xCorrection );
				int startY = default(int);
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) 
				{
					startY = ( ((int) (yPosition.__hx_invoke1_f(default(double), this.firstMaxNote)) ) - stemSize );
				}
				 else 
				{
					startY = ( ((int) (yPosition.__hx_invoke1_f(default(double), this.firstMinNote)) ) + stemSize );
				}
				
				int endX = ( this.getBeatLineX(this.lastMaxNote.beat) + xCorrection );
				int endY = default(int);
				if (( direction == global::alphatab.rendering.utils.BeamDirection.Up )) 
				{
					endY = ( ((int) (yPosition.__hx_invoke1_f(default(double), this.lastMaxNote)) ) - stemSize );
				}
				 else 
				{
					endY = ( ((int) (yPosition.__hx_invoke1_f(default(double), this.lastMinNote)) ) + stemSize );
				}
				
				if (( ( ( direction == global::alphatab.rendering.utils.BeamDirection.Down ) && ( startY > endY ) ) && ( ( startY - endY ) > maxDistance ) )) 
				{
					endY = ( startY - maxDistance );
				}
				
				if (( ( ( direction == global::alphatab.rendering.utils.BeamDirection.Down ) && ( endY > startY ) ) && ( ( endY - startY ) > maxDistance ) )) 
				{
					startY = ( endY - maxDistance );
				}
				
				if (( ( ( direction == global::alphatab.rendering.utils.BeamDirection.Up ) && ( startY < endY ) ) && ( ( endY - startY ) > maxDistance ) )) 
				{
					endY = ( startY + maxDistance );
				}
				
				if (( ( ( direction == global::alphatab.rendering.utils.BeamDirection.Up ) && ( endY < startY ) ) && ( ( startY - endY ) > maxDistance ) )) 
				{
					startY = ( endY + maxDistance );
				}
				
				return ((int) (( ( ( ((double) ((( endY - startY ))) ) / (( endX - startX )) ) * (( xPosition - startX )) ) + startY )) );
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 448361819:
					{
						this._beatLineXPositions = ((global::haxe.ds.IntMap<object>) (global::haxe.ds.IntMap<object>.__hx_cast<object>(((global::haxe.ds.IntMap) (@value) ))) );
						return @value;
					}
					
					
					case 302437836:
					{
						this._track = ((global::alphatab.model.Track) (@value) );
						return @value;
					}
					
					
					case 1228566710:
					{
						this.maxNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 974358180:
					{
						this.minNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 2112234752:
					{
						this.lastMaxNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 1858026222:
					{
						this.lastMinNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 1921156710:
					{
						this.firstMaxNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 1666948180:
					{
						this.firstMinNote = ((global::alphatab.model.Note) (@value) );
						return @value;
					}
					
					
					case 173283864:
					{
						this.maxDuration = ((global::alphatab.model.Duration) (@value) );
						return @value;
					}
					
					
					case 468906571:
					{
						this._lastBeat = ((global::alphatab.model.Beat) (@value) );
						return @value;
					}
					
					
					case 810640957:
					{
						this.beats = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 989275570:
					{
						this.voice = ((global::alphatab.model.Voice) (@value) );
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
					case 1392437444:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("calculateBeamY"), ((int) (1392437444) ))) );
					}
					
					
					case 485089498:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("checkNote"), ((int) (485089498) ))) );
					}
					
					
					case 351513182:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("checkBeat"), ((int) (351513182) ))) );
					}
					
					
					case 529989321:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getDirection"), ((int) (529989321) ))) );
					}
					
					
					case 1751332267:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("registerBeatLineX"), ((int) (1751332267) ))) );
					}
					
					
					case 199163160:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getBeatLineX"), ((int) (199163160) ))) );
					}
					
					
					case 448361819:
					{
						return this._beatLineXPositions;
					}
					
					
					case 294620923:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getValue"), ((int) (294620923) ))) );
					}
					
					
					case 302437836:
					{
						return this._track;
					}
					
					
					case 1228566710:
					{
						return this.maxNote;
					}
					
					
					case 974358180:
					{
						return this.minNote;
					}
					
					
					case 2112234752:
					{
						return this.lastMaxNote;
					}
					
					
					case 1858026222:
					{
						return this.lastMinNote;
					}
					
					
					case 1921156710:
					{
						return this.firstMaxNote;
					}
					
					
					case 1666948180:
					{
						return this.firstMinNote;
					}
					
					
					case 173283864:
					{
						return this.maxDuration;
					}
					
					
					case 468906571:
					{
						return this._lastBeat;
					}
					
					
					case 810640957:
					{
						return this.beats;
					}
					
					
					case 989275570:
					{
						return this.voice;
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
					case 1392437444:
					{
						return this.calculateBeamY(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ), ((double) (global::haxe.lang.Runtime.toDouble(dynargs[3])) ), ((global::haxe.lang.Function) (dynargs[4]) ));
					}
					
					
					case 485089498:
					{
						this.checkNote(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 351513182:
					{
						return this.checkBeat(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 529989321:
					{
						return this.getDirection();
					}
					
					
					case 1751332267:
					{
						this.registerBeatLineX(((global::alphatab.model.Beat) (dynargs[0]) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[2])) ));
						break;
					}
					
					
					case 199163160:
					{
						return this.getBeatLineX(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 294620923:
					{
						return this.getValue(((global::alphatab.model.Note) (dynargs[0]) ));
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
				baseArr.push("_beatLineXPositions");
				baseArr.push("_track");
				baseArr.push("maxNote");
				baseArr.push("minNote");
				baseArr.push("lastMaxNote");
				baseArr.push("lastMinNote");
				baseArr.push("firstMaxNote");
				baseArr.push("firstMinNote");
				baseArr.push("maxDuration");
				baseArr.push("_lastBeat");
				baseArr.push("beats");
				baseArr.push("voice");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


