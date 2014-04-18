using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class ScoreImporter : global::haxe.lang.HxObject 
	{
		static ScoreImporter() 
		{
			global::alphatab.importer.ScoreImporter.UnsupportedFormat = "unsupported file";
		}
		public    ScoreImporter(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    ScoreImporter()
		{
			unchecked 
			{
				global::alphatab.importer.ScoreImporter.__hx_ctor_alphatab_importer_ScoreImporter(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_ScoreImporter(global::alphatab.importer.ScoreImporter __temp_me54)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  string UnsupportedFormat;
		
		public static   global::haxe.root.Array<object> availableImporters()
		{
			unchecked 
			{
				global::haxe.root.Array<object> scoreImporter = new global::haxe.root.Array<object>();
				scoreImporter.push(new global::alphatab.importer.Gp3To5Importer());
				scoreImporter.push(new global::alphatab.importer.AlphaTexImporter());
				scoreImporter.push(new global::alphatab.importer.GpxImporter());
				return scoreImporter;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.importer.ScoreImporter(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.importer.ScoreImporter();
			}
		}
		
		
		public  global::haxe.io.BytesInput _data;
		
		public virtual   void init(global::haxe.io.BytesInput data)
		{
			unchecked 
			{
				this._data = data;
			}
		}
		
		
		public virtual   global::alphatab.model.Score readScore()
		{
			unchecked 
			{
				return default(global::alphatab.model.Score);
			}
		}
		
		
		public virtual   void finish(global::alphatab.model.Score score)
		{
			unchecked 
			{
				global::haxe.root.Array<object> _g10 = new global::haxe.root.Array<object>(new object[]{this});
				{
					int _g = 0;
					global::haxe.root.Array<object> _g1 = score.tracks;
					while (( _g < _g1.length ))
					{
						global::alphatab.model.Track t = ((global::alphatab.model.Track) (_g1[_g]) );
						 ++ _g;
						if ( ! (t.isPercussion) ) 
						{
							int _g2 = 0;
							global::haxe.root.Array<object> _g3 = t.bars;
							while (( _g2 < _g3.length ))
							{
								global::alphatab.model.Bar bar = ((global::alphatab.model.Bar) (_g3[_g2]) );
								 ++ _g2;
								{
									int _g4 = 0;
									global::haxe.root.Array<object> _g5 = bar.voices;
									while (( _g4 < _g5.length ))
									{
										global::alphatab.model.Voice v = ((global::alphatab.model.Voice) (_g5[_g4]) );
										 ++ _g4;
										{
											int _g6 = 0;
											global::haxe.root.Array<object> _g7 = v.beats;
											while (( _g6 < _g7.length ))
											{
												global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (_g7[_g6]) );
												 ++ _g6;
												if (( ( beat.voice.bar.index == 0 ) && ( beat.index == 0 ) )) 
												{
													beat.start = 0;
													beat.previousBeat = default(global::alphatab.model.Beat);
												}
												 else 
												{
													if (( beat.index == 0 )) 
													{
														beat.previousBeat = ((global::alphatab.model.Beat) (((global::alphatab.model.Voice) (bar.previousBar.voices[v.index]) ).beats[( ((global::alphatab.model.Voice) (bar.previousBar.voices[v.index]) ).beats.length - 1 )]) );
													}
													 else 
													{
														beat.previousBeat = ((global::alphatab.model.Beat) (v.beats[( beat.index - 1 )]) );
													}
													
													beat.previousBeat.nextBeat = beat;
													beat.start = ( beat.previousBeat.start + beat.previousBeat.calculateDuration() );
												}
												
												{
													int _g8 = 0;
													global::haxe.root.Array<object> _g9 = beat.notes;
													while (( _g8 < _g9.length ))
													{
														global::haxe.root.Array<object> n = new global::haxe.root.Array<object>(new object[]{((global::alphatab.model.Note) (_g9[_g8]) )});
														 ++ _g8;
														global::alphatab.util.LazyVar<object> nextNoteOnLine = new global::alphatab.util.LazyVar<object>(((global::haxe.lang.Function) (new global::alphatab.importer.ScoreImporter_finish_100__Fun(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g10) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (n) ))) ))) ));
														global::alphatab.util.LazyVar<object> prevNoteOnLine = new global::alphatab.util.LazyVar<object>(((global::haxe.lang.Function) (new global::alphatab.importer.ScoreImporter_finish_101__Fun(((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g10) ))) ), ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (n) ))) ))) ));
														if (((global::alphatab.model.Note) (n[0]) ).isTieDestination) 
														{
															if (( ((global::alphatab.model.Note) (prevNoteOnLine.getValue()) ) == default(global::alphatab.model.Note) )) 
															{
																((global::alphatab.model.Note) (n[0]) ).isTieDestination = false;
															}
															 else 
															{
																((global::alphatab.model.Note) (n[0]) ).tieOrigin = ((global::alphatab.model.Note) (prevNoteOnLine.getValue()) );
																((global::alphatab.model.Note) (n[0]) ).tieOrigin.isTieOrigin = true;
																((global::alphatab.model.Note) (n[0]) ).fret = ((global::alphatab.model.Note) (n[0]) ).tieOrigin.fret;
															}
															
														}
														
														if (((global::alphatab.model.Note) (n[0]) ).isHammerPullOrigin) 
														{
															if (( ((global::alphatab.model.Note) (nextNoteOnLine.getValue()) ) == default(global::alphatab.model.Note) )) 
															{
																((global::alphatab.model.Note) (n[0]) ).isHammerPullOrigin = false;
															}
															 else 
															{
																((global::alphatab.model.Note) (nextNoteOnLine.getValue()) ).isHammerPullDestination = true;
																((global::alphatab.model.Note) (nextNoteOnLine.getValue()) ).hammerPullOrigin = ((global::alphatab.model.Note) (n[0]) );
															}
															
														}
														
														if (( ((global::alphatab.model.Note) (n[0]) ).slideType != global::alphatab.model.SlideType.None )) 
														{
															((global::alphatab.model.Note) (n[0]) ).slideTarget = ((global::alphatab.model.Note) (nextNoteOnLine.getValue()) );
														}
														
													}
													
												}
												
											}
											
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   global::alphatab.model.Note nextNoteOnSameLine(global::alphatab.model.Note note)
		{
			unchecked 
			{
				global::alphatab.model.Beat nextBeat = note.beat.nextBeat;
				while (( ( nextBeat != default(global::alphatab.model.Beat) ) && ( nextBeat.voice.bar.index <= ( note.beat.voice.bar.index + 3 ) ) ))
				{
					global::alphatab.model.Note noteOnString = nextBeat.getNoteOnString(note.@string);
					if (( noteOnString != default(global::alphatab.model.Note) )) 
					{
						return noteOnString;
					}
					 else 
					{
						nextBeat = nextBeat.nextBeat;
					}
					
				}
				
				return default(global::alphatab.model.Note);
			}
		}
		
		
		public virtual   global::alphatab.model.Note previousNoteOnSameLine(global::alphatab.model.Note note)
		{
			unchecked 
			{
				global::alphatab.model.Beat previousBeat = note.beat.previousBeat;
				while (( ( previousBeat != default(global::alphatab.model.Beat) ) && ( previousBeat.voice.bar.index >= ( note.beat.voice.bar.index - 3 ) ) ))
				{
					global::alphatab.model.Note noteOnString = previousBeat.getNoteOnString(note.@string);
					if (( noteOnString != default(global::alphatab.model.Note) )) 
					{
						return noteOnString;
					}
					 else 
					{
						previousBeat = previousBeat.previousBeat;
					}
					
				}
				
				return default(global::alphatab.model.Note);
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 1970565641:
					{
						this._data = ((global::haxe.io.BytesInput) (@value) );
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
					case 1802708962:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("previousNoteOnSameLine"), ((int) (1802708962) ))) );
					}
					
					
					case 1511801246:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("nextNoteOnSameLine"), ((int) (1511801246) ))) );
					}
					
					
					case 109002835:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("finish"), ((int) (109002835) ))) );
					}
					
					
					case 1237368860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("readScore"), ((int) (1237368860) ))) );
					}
					
					
					case 1169898256:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("init"), ((int) (1169898256) ))) );
					}
					
					
					case 1970565641:
					{
						return this._data;
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
					case 1802708962:
					{
						return this.previousNoteOnSameLine(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 1511801246:
					{
						return this.nextNoteOnSameLine(((global::alphatab.model.Note) (dynargs[0]) ));
					}
					
					
					case 109002835:
					{
						this.finish(((global::alphatab.model.Score) (dynargs[0]) ));
						break;
					}
					
					
					case 1237368860:
					{
						return this.readScore();
					}
					
					
					case 1169898256:
					{
						this.init(((global::haxe.io.BytesInput) (dynargs[0]) ));
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
				baseArr.push("_data");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class ScoreImporter_finish_100__Fun : global::haxe.lang.Function 
	{
		public    ScoreImporter_finish_100__Fun(global::haxe.root.Array<object> _g10, global::haxe.root.Array<object> n) : base(0, 0)
		{
			unchecked 
			{
				this._g10 = _g10;
				this.n = n;
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				return ((global::alphatab.importer.ScoreImporter) (this._g10[0]) ).nextNoteOnSameLine(((global::alphatab.model.Note) (this.n[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _g10;
		
		public  global::haxe.root.Array<object> n;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class ScoreImporter_finish_101__Fun : global::haxe.lang.Function 
	{
		public    ScoreImporter_finish_101__Fun(global::haxe.root.Array<object> _g10, global::haxe.root.Array<object> n) : base(0, 0)
		{
			unchecked 
			{
				this._g10 = _g10;
				this.n = n;
			}
		}
		
		
		public override   object __hx_invoke0_o()
		{
			unchecked 
			{
				return ((global::alphatab.importer.ScoreImporter) (this._g10[0]) ).previousNoteOnSameLine(((global::alphatab.model.Note) (this.n[0]) ));
			}
		}
		
		
		public  global::haxe.root.Array<object> _g10;
		
		public  global::haxe.root.Array<object> n;
		
	}
}


