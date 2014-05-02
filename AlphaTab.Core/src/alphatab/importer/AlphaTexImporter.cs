using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer{
	public  class AlphaTexImporter : global::alphatab.importer.ScoreImporter {
		static AlphaTexImporter() {
			global::alphatab.importer.AlphaTexImporter.Eof = new string(((char) (0) ), 1);
			global::alphatab.importer.AlphaTexImporter.TrackChannels = new global::haxe.root.Array<int>(new int[]{0, 1});
		}
		public    AlphaTexImporter(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
			}
		}
		
		
		public    AlphaTexImporter() : base(global::haxe.lang.EmptyObject.EMPTY){
			unchecked {
				global::alphatab.importer.AlphaTexImporter.__hx_ctor_alphatab_importer_AlphaTexImporter(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_AlphaTexImporter(global::alphatab.importer.AlphaTexImporter __temp_me70){
			unchecked {
				global::alphatab.importer.ScoreImporter.__hx_ctor_alphatab_importer_ScoreImporter(__temp_me70);
			}
		}
		
		
		public static  string Eof;
		
		public static  global::haxe.root.Array<int> TrackChannels;
		
		public static   bool isLetter(string ch){
			unchecked {
				int code = global::haxe.lang.StringExt.charCodeAt(ch, 0).@value;
				return (  ! (global::alphatab.importer.AlphaTexImporter.isTerminal(ch))  && (( ( ( ( code >= 33 ) && ( code <= 47 ) ) || ( ( code >= 58 ) && ( code <= 126 ) ) ) || ( code > 128 ) )) );
			}
		}
		
		
		public static   bool isTerminal(string ch){
			unchecked {
				return ( ( ( ( ( ( ( ( ( ( string.Equals(ch, ".") || string.Equals(ch, "{") ) || string.Equals(ch, "}") ) || string.Equals(ch, "[") ) || string.Equals(ch, "]") ) || string.Equals(ch, "(") ) || string.Equals(ch, ")") ) || string.Equals(ch, "|") ) || string.Equals(ch, "\'") ) || string.Equals(ch, "\"") ) || string.Equals(ch, "\\") );
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.importer.AlphaTexImporter(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.importer.AlphaTexImporter();
			}
		}
		
		
		public  global::alphatab.model.Score _score;
		
		public  global::alphatab.model.Track _track;
		
		public  string _ch;
		
		public  int _curChPos;
		
		public  global::alphatab.importer.AlphaTexSymbols _sy;
		
		public  object _syData;
		
		public  bool _allowNegatives;
		
		public  global::alphatab.model.Duration _currentDuration;
		
		public override   global::alphatab.model.Score readScore(){
			unchecked {
				try {
					this.createDefaultScore();
					this._curChPos = 0;
					this._currentDuration = global::alphatab.model.Duration.Quarter;
					this.nextChar();
					this.newSy();
					this.score();
					this._score.finish();
					return this._score;
				}
				catch (global::System.Exception __temp_catchallException523){
					global::haxe.lang.Exceptions.exception = __temp_catchallException523;
					object __temp_catchall524 = __temp_catchallException523;
					if (( __temp_catchall524 is global::haxe.lang.HaxeException )) {
						__temp_catchall524 = ((global::haxe.lang.HaxeException) (__temp_catchallException523) ).obj;
					}
					
					{
						object e = __temp_catchall524;
						throw global::haxe.lang.HaxeException.wrap(global::alphatab.importer.ScoreImporter.UnsupportedFormat);
					}
					
				}
				
				
			}
		}
		
		
		public virtual   void error(string nonterm, global::alphatab.importer.AlphaTexSymbols expected, global::haxe.lang.Null<bool> symbolError){
			unchecked {
				bool __temp_symbolError69 = ( ( ! (symbolError.hasValue) ) ? (global::haxe.lang.Runtime.toBool(true)) : (symbolError.@value) );
				if (__temp_symbolError69) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Custom(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(this._curChPos), ": Error on block "), nonterm), ", expected a "), global::haxe.root.Std.@string(expected)), " found a "), global::haxe.root.Std.@string(this._sy))));
				}
				 else {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.io.Error.Custom(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.root.Std.@string(this._curChPos), ": Error on block "), nonterm), ", invalid value:"), global::haxe.root.Std.@string(this._syData))));
				}
				
			}
		}
		
		
		public virtual   void score(){
			unchecked {
				this.metaData();
				this.bars();
			}
		}
		
		
		public virtual   void metaData(){
			unchecked {
				bool anyMeta = false;
				while (( this._sy == global::alphatab.importer.AlphaTexSymbols.MetaCommand )){
					if (global::haxe.lang.Runtime.eq(this._syData, "title")) {
						this.newSy();
						if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
							this._score.title = global::haxe.lang.Runtime.toString(this._syData);
						}
						 else {
							this.error("title", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
						}
						
						this.newSy();
						anyMeta = true;
					}
					 else {
						if (global::haxe.lang.Runtime.eq(this._syData, "subtitle")) {
							this.newSy();
							if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
								this._score.subTitle = global::haxe.lang.Runtime.toString(this._syData);
							}
							 else {
								this.error("subtitle", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
							}
							
							this.newSy();
							anyMeta = true;
						}
						 else {
							if (global::haxe.lang.Runtime.eq(this._syData, "artist")) {
								this.newSy();
								if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
									this._score.artist = global::haxe.lang.Runtime.toString(this._syData);
								}
								 else {
									this.error("artist", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
								}
								
								this.newSy();
								anyMeta = true;
							}
							 else {
								if (global::haxe.lang.Runtime.eq(this._syData, "album")) {
									this.newSy();
									if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
										this._score.album = global::haxe.lang.Runtime.toString(this._syData);
									}
									 else {
										this.error("album", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
									}
									
									this.newSy();
									anyMeta = true;
								}
								 else {
									if (global::haxe.lang.Runtime.eq(this._syData, "words")) {
										this.newSy();
										if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
											this._score.words = global::haxe.lang.Runtime.toString(this._syData);
										}
										 else {
											this.error("words", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
										}
										
										this.newSy();
										anyMeta = true;
									}
									 else {
										if (global::haxe.lang.Runtime.eq(this._syData, "music")) {
											this.newSy();
											if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
												this._score.music = global::haxe.lang.Runtime.toString(this._syData);
											}
											 else {
												this.error("music", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
											}
											
											this.newSy();
											anyMeta = true;
										}
										 else {
											if (global::haxe.lang.Runtime.eq(this._syData, "copyright")) {
												this.newSy();
												if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
													this._score.copyright = global::haxe.lang.Runtime.toString(this._syData);
												}
												 else {
													this.error("copyright", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
												}
												
												this.newSy();
												anyMeta = true;
											}
											 else {
												if (global::haxe.lang.Runtime.eq(this._syData, "tempo")) {
													this.newSy();
													if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Number )) {
														this._score.tempo = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
													}
													 else {
														this.error("tempo", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
													}
													
													this.newSy();
													anyMeta = true;
												}
												 else {
													if (global::haxe.lang.Runtime.eq(this._syData, "capo")) {
														this.newSy();
														if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Number )) {
															this._track.capo = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
														}
														 else {
															this.error("capo", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
														}
														
														this.newSy();
														anyMeta = true;
													}
													 else {
														if (global::haxe.lang.Runtime.eq(this._syData, "tuning")) {
															this.newSy();
															if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Tuning )) {
																this._track.tuning = new global::haxe.root.Array<int>();
																do {
																	this._track.tuning.push(this.parseTuning(global::haxe.lang.Runtime.toString(this._syData)));
																	this.newSy();
																}
																while (( this._sy == global::alphatab.importer.AlphaTexSymbols.Tuning ));
															}
															 else {
																this.error("tuning", global::alphatab.importer.AlphaTexSymbols.Tuning, default(global::haxe.lang.Null<bool>));
															}
															
															anyMeta = true;
														}
														 else {
															if (global::haxe.lang.Runtime.eq(this._syData, "instrument")) {
																this.newSy();
																if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Number )) {
																	int instrument = default(int);
																	instrument = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
																	if (( ( instrument >= 0 ) && ( instrument <= 128 ) )) {
																		this._track.playbackInfo.program = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
																	}
																	 else {
																		this.error("instrument", global::alphatab.importer.AlphaTexSymbols.Number, new global::haxe.lang.Null<bool>(false, true));
																	}
																	
																}
																 else {
																	if (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )) {
																		string instrumentName = default(string);
																		instrumentName = global::haxe.lang.Runtime.toString(this._syData);
																		this._track.playbackInfo.program = global::alphatab.audio.GeneralMidi.getValue(instrumentName);
																	}
																	 else {
																		this.error("instrument", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
																	}
																	
																}
																
																this.newSy();
																anyMeta = true;
															}
															 else {
																this.error("metaDataTags", global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
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
				
				if (anyMeta) {
					if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Dot )) {
						this.error("song", global::alphatab.importer.AlphaTexSymbols.Dot, default(global::haxe.lang.Null<bool>));
					}
					
					this.newSy();
				}
				
			}
		}
		
		
		public virtual   void bars(){
			unchecked {
				this.bar();
				while (( this._sy != global::alphatab.importer.AlphaTexSymbols.Eof )){
					if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Pipe )) {
						this.error("bar", global::alphatab.importer.AlphaTexSymbols.Pipe, default(global::haxe.lang.Null<bool>));
					}
					
					this.newSy();
					this.bar();
				}
				
			}
		}
		
		
		public virtual   void bar(){
			unchecked {
				global::alphatab.model.MasterBar master = new global::alphatab.model.MasterBar();
				this._score.addMasterBar(master);
				global::alphatab.model.Bar bar = new global::alphatab.model.Bar();
				this._track.addBar(bar);
				if (( master.index > 0 )) {
					master.keySignature = master.previousMasterBar.keySignature;
					master.timeSignatureDenominator = master.previousMasterBar.timeSignatureDenominator;
					master.timeSignatureNumerator = master.previousMasterBar.timeSignatureNumerator;
					bar.clef = bar.previousBar.clef;
				}
				
				this.barMeta(bar);
				global::alphatab.model.Voice voice = new global::alphatab.model.Voice();
				bar.addVoice(voice);
				while (( ( this._sy != global::alphatab.importer.AlphaTexSymbols.Pipe ) && ( this._sy != global::alphatab.importer.AlphaTexSymbols.Eof ) )){
					this.beat(voice);
				}
				
			}
		}
		
		
		public virtual   void beat(global::alphatab.model.Voice voice){
			unchecked {
				if (( this._sy == global::alphatab.importer.AlphaTexSymbols.DoubleDot )) {
					this.newSy();
					if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
						this.error("duration", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
					}
					
					if (( ( ( ( ( ( global::haxe.lang.Runtime.eq(this._syData, 1) || global::haxe.lang.Runtime.eq(this._syData, 2) ) || global::haxe.lang.Runtime.eq(this._syData, 4) ) || global::haxe.lang.Runtime.eq(this._syData, 8) ) || global::haxe.lang.Runtime.eq(this._syData, 16) ) || global::haxe.lang.Runtime.eq(this._syData, 32) ) || global::haxe.lang.Runtime.eq(this._syData, 64) )) {
						this._currentDuration = this.parseDuration(((int) (global::haxe.lang.Runtime.toInt(this._syData)) ));
					}
					 else {
						this.error("duration", global::alphatab.importer.AlphaTexSymbols.Number, new global::haxe.lang.Null<bool>(false, true));
					}
					
					this.newSy();
					return ;
				}
				
				global::alphatab.model.Beat beat = new global::alphatab.model.Beat();
				voice.addBeat(beat);
				if (( this._sy == global::alphatab.importer.AlphaTexSymbols.LParensis )) {
					this.newSy();
					this.note(beat);
					while (( ( this._sy != global::alphatab.importer.AlphaTexSymbols.RParensis ) && ( this._sy != global::alphatab.importer.AlphaTexSymbols.Eof ) )){
						this.note(beat);
					}
					
					if (( this._sy != global::alphatab.importer.AlphaTexSymbols.RParensis )) {
						this.error("note-list", global::alphatab.importer.AlphaTexSymbols.RParensis, default(global::haxe.lang.Null<bool>));
					}
					
					this.newSy();
				}
				 else {
					if (( ( this._sy == global::alphatab.importer.AlphaTexSymbols.String ) && string.Equals(global::haxe.root.Std.@string(this._syData).ToLower(), "r") )) {
						this.newSy();
					}
					 else {
						this.note(beat);
					}
					
				}
				
				if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Dot )) {
					this.newSy();
					if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
						this.error("duration", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
					}
					
					if (( ( ( ( ( ( global::haxe.lang.Runtime.eq(this._syData, 1) || global::haxe.lang.Runtime.eq(this._syData, 2) ) || global::haxe.lang.Runtime.eq(this._syData, 4) ) || global::haxe.lang.Runtime.eq(this._syData, 8) ) || global::haxe.lang.Runtime.eq(this._syData, 16) ) || global::haxe.lang.Runtime.eq(this._syData, 32) ) || global::haxe.lang.Runtime.eq(this._syData, 64) )) {
						beat.duration = this.parseDuration(((int) (global::haxe.lang.Runtime.toInt(this._syData)) ));
					}
					 else {
						this.error("duration", global::alphatab.importer.AlphaTexSymbols.Number, new global::haxe.lang.Null<bool>(false, true));
					}
					
					this.newSy();
				}
				 else {
					beat.duration = this._currentDuration;
				}
				
				int beatRepeat = 1;
				if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Multiply )) {
					this.newSy();
					if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
						this.error("multiplier", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
					}
					 else {
						beatRepeat = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
					}
					
					this.newSy();
				}
				
				this.beatEffects(beat);
				{
					int _g1 = 0;
					int _g = ( beatRepeat - 1 );
					while (( _g1 < _g )){
						int i = _g1++;
						voice.addBeat(beat.clone());
					}
					
				}
				
			}
		}
		
		
		public virtual   void beatEffects(global::alphatab.model.Beat beat){
			unchecked {
				if (( this._sy != global::alphatab.importer.AlphaTexSymbols.LBrace )) {
					return ;
				}
				
				this.newSy();
				while (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )){
					this._syData = global::haxe.root.Std.@string(this._syData).ToLower();
					if ( ! (this.applyBeatEffect(beat)) ) {
						this.error("beat-effects", global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
					}
					
				}
				
				if (( this._sy != global::alphatab.importer.AlphaTexSymbols.RBrace )) {
					this.error("beat-effects", global::alphatab.importer.AlphaTexSymbols.RBrace, default(global::haxe.lang.Null<bool>));
				}
				
				this.newSy();
			}
		}
		
		
		public virtual   bool applyBeatEffect(global::alphatab.model.Beat beat){
			unchecked {
				if (global::haxe.lang.Runtime.eq(this._syData, "f")) {
					beat.fadeIn = true;
					this.newSy();
					return true;
				}
				 else {
					if (global::haxe.lang.Runtime.eq(this._syData, "v")) {
						beat.vibrato = global::alphatab.model.VibratoType.Slight;
						this.newSy();
						return true;
					}
					 else {
						if (global::haxe.lang.Runtime.eq(this._syData, "s")) {
							beat.slap = true;
							this.newSy();
							return true;
						}
						 else {
							if (global::haxe.lang.Runtime.eq(this._syData, "p")) {
								beat.pop = true;
								this.newSy();
								return true;
							}
							 else {
								if (global::haxe.lang.Runtime.eq(this._syData, "dd")) {
									beat.dots = 2;
									this.newSy();
									return true;
								}
								 else {
									if (global::haxe.lang.Runtime.eq(this._syData, "d")) {
										beat.dots = 1;
										this.newSy();
										return true;
									}
									 else {
										if (global::haxe.lang.Runtime.eq(this._syData, "su")) {
											beat.pickStroke = global::alphatab.model.PickStrokeType.Up;
											this.newSy();
											return true;
										}
										 else {
											if (global::haxe.lang.Runtime.eq(this._syData, "sd")) {
												beat.pickStroke = global::alphatab.model.PickStrokeType.Down;
												this.newSy();
												return true;
											}
											 else {
												if (global::haxe.lang.Runtime.eq(this._syData, "tu")) {
													this.newSy();
													if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
														this.error("tuplet", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
														return false;
													}
													
													int tuplet = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
													switch (tuplet){
														case 3:
														{
															beat.tupletDenominator = 3;
															beat.tupletNumerator = 2;
															break;
														}
														
														
														case 5:
														{
															beat.tupletDenominator = 5;
															beat.tupletNumerator = 4;
															break;
														}
														
														
														case 6:
														{
															beat.tupletDenominator = 6;
															beat.tupletNumerator = 4;
															break;
														}
														
														
														case 7:
														{
															beat.tupletDenominator = 7;
															beat.tupletNumerator = 4;
															break;
														}
														
														
														case 9:
														{
															beat.tupletDenominator = 9;
															beat.tupletNumerator = 8;
															break;
														}
														
														
														case 10:
														{
															beat.tupletDenominator = 10;
															beat.tupletNumerator = 8;
															break;
														}
														
														
														case 11:
														{
															beat.tupletDenominator = 11;
															beat.tupletNumerator = 8;
															break;
														}
														
														
														case 12:
														{
															beat.tupletDenominator = 12;
															beat.tupletNumerator = 8;
															break;
														}
														
														
													}
													
													this.newSy();
													return true;
												}
												 else {
													if (global::haxe.lang.Runtime.eq(this._syData, "tb")) {
														this.newSy();
														if (( this._sy != global::alphatab.importer.AlphaTexSymbols.LParensis )) {
															this.error("tremolobar-effect", global::alphatab.importer.AlphaTexSymbols.LParensis, default(global::haxe.lang.Null<bool>));
															return false;
														}
														
														this._allowNegatives = true;
														this.newSy();
														while (( ( this._sy != global::alphatab.importer.AlphaTexSymbols.RParensis ) && ( this._sy != global::alphatab.importer.AlphaTexSymbols.Eof ) )){
															if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
																this.error("tremolobar-effect", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
																return false;
															}
															
															beat.whammyBarPoints.push(new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(0, true), global::haxe.lang.Null<object>.ofDynamic<int>(this._syData)));
															this.newSy();
														}
														
														if (( beat.whammyBarPoints.length > 60 )) {
															beat.whammyBarPoints = beat.whammyBarPoints.slice(0, new global::haxe.lang.Null<int>(60, true));
														}
														
														int count = beat.whammyBarPoints.length;
														int step = default(int);
														{
															double x = global::System.Math.Floor(((double) (( ((double) (60) ) / count )) ));
															step = ((int) (x) );
														}
														
														int i = 0;
														while (( i < count )){
															{
																double v = global::System.Math.Min(((double) (60) ), ((double) (( i * step )) ));
																{
																	double x1 = global::System.Math.Floor(((double) (v) ));
																	((global::alphatab.model.BendPoint) (beat.whammyBarPoints[i]) ).offset = ((int) (x1) );
																}
																
															}
															
															i++;
														}
														
														this._allowNegatives = false;
														if (( this._sy != global::alphatab.importer.AlphaTexSymbols.RParensis )) {
															this.error("tremolobar-effect", global::alphatab.importer.AlphaTexSymbols.RParensis, default(global::haxe.lang.Null<bool>));
															return false;
														}
														
														this.newSy();
														return true;
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
				
				return false;
			}
		}
		
		
		public virtual   global::alphatab.model.Note note(global::alphatab.model.Beat beat){
			unchecked {
				if (( ( this._sy != global::alphatab.importer.AlphaTexSymbols.Number ) &&  ! ((( ( this._sy == global::alphatab.importer.AlphaTexSymbols.String ) && (( string.Equals(global::haxe.root.Std.@string(this._syData).ToLower(), "x") || string.Equals(global::haxe.root.Std.@string(this._syData).ToLower(), "-") )) )))  )) {
					this.error("note-fret", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
				}
				
				bool isDead = string.Equals(global::haxe.root.Std.@string(this._syData).ToLower(), "x");
				bool isTie = string.Equals(global::haxe.root.Std.@string(this._syData).ToLower(), "-");
				int fret = default(int);
				if (( isDead || isTie )) {
					fret = 0;
				}
				 else {
					fret = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
				}
				
				this.newSy();
				if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Dot )) {
					this.error("note", global::alphatab.importer.AlphaTexSymbols.Dot, default(global::haxe.lang.Null<bool>));
				}
				
				this.newSy();
				if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
					this.error("note-string", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
				}
				
				int @string = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
				if (( ( @string < 1 ) || ( @string > this._track.tuning.length ) )) {
					this.error("note-string", global::alphatab.importer.AlphaTexSymbols.Number, new global::haxe.lang.Null<bool>(false, true));
				}
				
				this.newSy();
				global::alphatab.model.Note note = new global::alphatab.model.Note();
				this.noteEffects(note);
				note.@string = ( this._track.tuning.length - (( @string - 1 )) );
				note.isDead = isDead;
				note.isTieDestination = isTie;
				if ( ! (isTie) ) {
					note.fret = fret;
				}
				
				beat.addNote(note);
				return note;
			}
		}
		
		
		public virtual   void noteEffects(global::alphatab.model.Note note){
			unchecked {
				if (( this._sy != global::alphatab.importer.AlphaTexSymbols.LBrace )) {
					return ;
				}
				
				this.newSy();
				while (( this._sy == global::alphatab.importer.AlphaTexSymbols.String )){
					this._syData = global::haxe.root.Std.@string(this._syData).ToLower();
					if (global::haxe.lang.Runtime.eq(this._syData, "b")) {
						this.newSy();
						if (( this._sy != global::alphatab.importer.AlphaTexSymbols.LParensis )) {
							this.error("bend-effect", global::alphatab.importer.AlphaTexSymbols.LParensis, default(global::haxe.lang.Null<bool>));
						}
						
						this.newSy();
						while (( ( this._sy != global::alphatab.importer.AlphaTexSymbols.RParensis ) && ( this._sy != global::alphatab.importer.AlphaTexSymbols.Eof ) )){
							if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
								this.error("bend-effect-value", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
							}
							
							int bendValue = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
							int __temp_stmt527 = default(int);
							{
								double x = global::System.Math.Abs(((double) (bendValue) ));
								__temp_stmt527 = ((int) (x) );
							}
							
							note.bendPoints.push(new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(0, true), new global::haxe.lang.Null<int>(__temp_stmt527, true)));
							this.newSy();
						}
						
						if (( note.bendPoints.length > 60 )) {
							note.bendPoints = note.bendPoints.slice(0, new global::haxe.lang.Null<int>(60, true));
						}
						
						int count = note.bendPoints.length;
						int step = default(int);
						{
							double x1 = global::System.Math.Floor(((double) (( ((double) (60) ) / count )) ));
							step = ((int) (x1) );
						}
						
						int i = 0;
						while (( i < count )){
							{
								double v = global::System.Math.Min(((double) (60) ), ((double) (( i * step )) ));
								{
									double x2 = global::System.Math.Floor(((double) (v) ));
									((global::alphatab.model.BendPoint) (note.bendPoints[i]) ).offset = ((int) (x2) );
								}
								
							}
							
							i++;
						}
						
						if (( this._sy != global::alphatab.importer.AlphaTexSymbols.RParensis )) {
							this.error("bend-effect", global::alphatab.importer.AlphaTexSymbols.RParensis, default(global::haxe.lang.Null<bool>));
						}
						
						this.newSy();
					}
					 else {
						if (global::haxe.lang.Runtime.eq(this._syData, "nh")) {
							note.harmonicType = global::alphatab.model.HarmonicType.Natural;
							this.newSy();
						}
						 else {
							if (global::haxe.lang.Runtime.eq(this._syData, "ah")) {
								note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
								this.newSy();
							}
							 else {
								if (global::haxe.lang.Runtime.eq(this._syData, "th")) {
									note.harmonicType = global::alphatab.model.HarmonicType.Tap;
									this.newSy();
								}
								 else {
									if (global::haxe.lang.Runtime.eq(this._syData, "ph")) {
										note.harmonicType = global::alphatab.model.HarmonicType.Pinch;
										this.newSy();
									}
									 else {
										if (global::haxe.lang.Runtime.eq(this._syData, "sh")) {
											note.harmonicType = global::alphatab.model.HarmonicType.Semi;
											this.newSy();
										}
										 else {
											if (global::haxe.lang.Runtime.eq(this._syData, "gr")) {
												this.newSy();
												if (global::haxe.lang.Runtime.eq(this._syData, "ob")) {
													note.beat.graceType = global::alphatab.model.GraceType.OnBeat;
												}
												 else {
													note.beat.graceType = global::alphatab.model.GraceType.BeforeBeat;
												}
												
												this.newSy();
											}
											 else {
												if (global::haxe.lang.Runtime.eq(this._syData, "tr")) {
													this.newSy();
													if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
														this.error("trill-effect", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
													}
													
													int fret = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
													this.newSy();
													global::alphatab.model.Duration duration = global::alphatab.model.Duration.Sixteenth;
													if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Number )) {
														{
															object _g = this._syData;
															{
																object __temp_switch525 = (_g);
																if (global::haxe.lang.Runtime.eq(__temp_switch525, 16)) {
																	duration = global::alphatab.model.Duration.Sixteenth;
																}
																 else {
																	if (global::haxe.lang.Runtime.eq(__temp_switch525, 32)) {
																		duration = global::alphatab.model.Duration.ThirtySecond;
																	}
																	 else {
																		if (global::haxe.lang.Runtime.eq(__temp_switch525, 64)) {
																			duration = global::alphatab.model.Duration.ThirtySecond;
																		}
																		 else {
																			duration = global::alphatab.model.Duration.Sixteenth;
																		}
																		
																	}
																	
																}
																
															}
															
														}
														
														this.newSy();
													}
													
													note.trillValue = ( fret + note.beat.voice.bar.track.tuning[( ( note.beat.voice.bar.track.tuning.length - (( note.@string - 1 )) ) - 1 )] );
													note.trillSpeed = duration;
												}
												 else {
													if (global::haxe.lang.Runtime.eq(this._syData, "tp")) {
														this.newSy();
														global::alphatab.model.Duration duration1 = global::alphatab.model.Duration.Eighth;
														if (( this._sy == global::alphatab.importer.AlphaTexSymbols.Number )) {
															{
																object _g1 = this._syData;
																{
																	object __temp_switch526 = (_g1);
																	if (global::haxe.lang.Runtime.eq(__temp_switch526, 8)) {
																		duration1 = global::alphatab.model.Duration.Eighth;
																	}
																	 else {
																		if (global::haxe.lang.Runtime.eq(__temp_switch526, 16)) {
																			duration1 = global::alphatab.model.Duration.Sixteenth;
																		}
																		 else {
																			if (global::haxe.lang.Runtime.eq(__temp_switch526, 32)) {
																				duration1 = global::alphatab.model.Duration.ThirtySecond;
																			}
																			 else {
																				duration1 = global::alphatab.model.Duration.Eighth;
																			}
																			
																		}
																		
																	}
																	
																}
																
															}
															
															this.newSy();
														}
														
														note.beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(duration1, true);
													}
													 else {
														if (global::haxe.lang.Runtime.eq(this._syData, "v")) {
															this.newSy();
															note.vibrato = global::alphatab.model.VibratoType.Slight;
														}
														 else {
															if (global::haxe.lang.Runtime.eq(this._syData, "sl")) {
																this.newSy();
																note.slideType = global::alphatab.model.SlideType.Legato;
															}
															 else {
																if (global::haxe.lang.Runtime.eq(this._syData, "ss")) {
																	this.newSy();
																	note.slideType = global::alphatab.model.SlideType.Shift;
																}
																 else {
																	if (global::haxe.lang.Runtime.eq(this._syData, "h")) {
																		this.newSy();
																		note.isHammerPullOrigin = true;
																	}
																	 else {
																		if (global::haxe.lang.Runtime.eq(this._syData, "g")) {
																			this.newSy();
																			note.isGhost = true;
																		}
																		 else {
																			if (global::haxe.lang.Runtime.eq(this._syData, "ac")) {
																				this.newSy();
																				note.accentuated = global::alphatab.model.AccentuationType.Normal;
																			}
																			 else {
																				if (global::haxe.lang.Runtime.eq(this._syData, "hac")) {
																					this.newSy();
																					note.accentuated = global::alphatab.model.AccentuationType.Heavy;
																				}
																				 else {
																					if (global::haxe.lang.Runtime.eq(this._syData, "pm")) {
																						this.newSy();
																						note.isPalmMute = true;
																					}
																					 else {
																						if (global::haxe.lang.Runtime.eq(this._syData, "st")) {
																							this.newSy();
																							note.isStaccato = true;
																						}
																						 else {
																							if (global::haxe.lang.Runtime.eq(this._syData, "lr")) {
																								this.newSy();
																								note.isLetRing = true;
																							}
																							 else {
																								if (this.applyBeatEffect(note.beat)) {
																									{
																									}
																									
																								}
																								 else {
																									this.error(global::haxe.lang.Runtime.toString(this._syData), global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
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
												
											}
											
										}
										
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
				if (( this._sy != global::alphatab.importer.AlphaTexSymbols.RBrace )) {
					this.error("note-effect", global::alphatab.importer.AlphaTexSymbols.RBrace, new global::haxe.lang.Null<bool>(false, true));
				}
				
				this.newSy();
			}
		}
		
		
		public virtual   global::alphatab.model.Duration parseDuration(int duration){
			unchecked {
				switch (duration){
					case 1:
					{
						return global::alphatab.model.Duration.Whole;
					}
					
					
					case 2:
					{
						return global::alphatab.model.Duration.Half;
					}
					
					
					case 4:
					{
						return global::alphatab.model.Duration.Quarter;
					}
					
					
					case 8:
					{
						return global::alphatab.model.Duration.Eighth;
					}
					
					
					case 16:
					{
						return global::alphatab.model.Duration.Sixteenth;
					}
					
					
					case 32:
					{
						return global::alphatab.model.Duration.ThirtySecond;
					}
					
					
					case 64:
					{
						return global::alphatab.model.Duration.SixtyFourth;
					}
					
					
					default:
					{
						return global::alphatab.model.Duration.Quarter;
					}
					
				}
				
			}
		}
		
		
		public virtual   void barMeta(global::alphatab.model.Bar bar){
			unchecked {
				global::alphatab.model.MasterBar master = ((global::alphatab.model.MasterBar) (bar.track.score.masterBars[bar.index]) );
				while (( this._sy == global::alphatab.importer.AlphaTexSymbols.MetaCommand )){
					if (global::haxe.lang.Runtime.eq(this._syData, "ts")) {
						this.newSy();
						if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
							this.error("timesignature-numerator", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
						}
						
						master.timeSignatureNumerator = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
						this.newSy();
						if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
							this.error("timesignature-denominator", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
						}
						
						master.timeSignatureDenominator = ((int) (global::haxe.lang.Runtime.toInt(this._syData)) );
					}
					 else {
						if (global::haxe.lang.Runtime.eq(this._syData, "ro")) {
							master.isRepeatStart = true;
						}
						 else {
							if (global::haxe.lang.Runtime.eq(this._syData, "rc")) {
								this.newSy();
								if (( this._sy != global::alphatab.importer.AlphaTexSymbols.Number )) {
									this.error("repeatclose", global::alphatab.importer.AlphaTexSymbols.Number, default(global::haxe.lang.Null<bool>));
								}
								
								master.repeatCount = ( global::haxe.root.Std.parseInt(global::haxe.lang.Runtime.toString(this._syData)).@value - 1 );
							}
							 else {
								if (global::haxe.lang.Runtime.eq(this._syData, "ks")) {
									this.newSy();
									if (( this._sy != global::alphatab.importer.AlphaTexSymbols.String )) {
										this.error("keysignature", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
									}
									
									master.keySignature = this.parseKeySignature(global::haxe.lang.Runtime.toString(this._syData));
								}
								 else {
									if (global::haxe.lang.Runtime.eq(this._syData, "clef")) {
										this.newSy();
										if (( ( this._sy != global::alphatab.importer.AlphaTexSymbols.String ) && ( this._sy != global::alphatab.importer.AlphaTexSymbols.Tuning ) )) {
											this.error("clef", global::alphatab.importer.AlphaTexSymbols.String, default(global::haxe.lang.Null<bool>));
										}
										
										bar.clef = this.parseClef(global::haxe.lang.Runtime.toString(this._syData));
									}
									 else {
										this.error("measure-effects", global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
									}
									
								}
								
							}
							
						}
						
					}
					
					this.newSy();
				}
				
			}
		}
		
		
		public virtual   void createDefaultScore(){
			unchecked {
				this._score = new global::alphatab.model.Score();
				this._score.tempo = 120;
				this._score.tempoLabel = "";
				this._track = new global::alphatab.model.Track();
				this._track.playbackInfo.program = 25;
				this._track.playbackInfo.primaryChannel = global::alphatab.importer.AlphaTexImporter.TrackChannels[0];
				this._track.playbackInfo.secondaryChannel = global::alphatab.importer.AlphaTexImporter.TrackChannels[1];
				this._track.tuning = ((global::alphatab.model.Tuning) (global::alphatab.model.Tuning.getPresetsFor(6)[0]) ).tuning;
				this._score.addTrack(this._track);
			}
		}
		
		
		public virtual   global::alphatab.model.Clef parseClef(string str){
			unchecked {
				string _g = str.ToLower();
				switch (_g){
					case "g2":case "treble":
					{
						return global::alphatab.model.Clef.G2;
					}
					
					
					case "f4":case "bass":
					{
						return global::alphatab.model.Clef.F4;
					}
					
					
					case "c3":case "tenor":
					{
						return global::alphatab.model.Clef.C3;
					}
					
					
					case "c4":case "alto":
					{
						return global::alphatab.model.Clef.C4;
					}
					
					
					default:
					{
						return global::alphatab.model.Clef.G2;
					}
					
				}
				
			}
		}
		
		
		public virtual   int parseKeySignature(string str){
			unchecked {
				string _g = str.ToLower();
				switch (_g){
					case "cb":
					{
						return -7;
					}
					
					
					case "gb":
					{
						return -6;
					}
					
					
					case "db":
					{
						return -5;
					}
					
					
					case "ab":
					{
						return -4;
					}
					
					
					case "eb":
					{
						return -3;
					}
					
					
					case "bb":
					{
						return -2;
					}
					
					
					case "f":
					{
						return -1;
					}
					
					
					case "c":
					{
						return 0;
					}
					
					
					case "g":
					{
						return 1;
					}
					
					
					case "d":
					{
						return 2;
					}
					
					
					case "a":
					{
						return 3;
					}
					
					
					case "e":
					{
						return 4;
					}
					
					
					case "b":
					{
						return 5;
					}
					
					
					case "f#":
					{
						return 6;
					}
					
					
					case "c#":
					{
						return 7;
					}
					
					
					default:
					{
						return 0;
					}
					
				}
				
			}
		}
		
		
		public virtual   int parseTuning(string str){
			unchecked {
				int tuning = global::alphatab.model.Tuning.getTuningForText(str);
				if (( tuning < 0 )) {
					this.error("tuning-value", global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
				}
				
				return tuning;
			}
		}
		
		
		public virtual   void nextChar(){
			unchecked {
				try {
					this._ch = this._data.readString(1);
					this._curChPos++;
				}
				catch (global::System.Exception __temp_catchallException528){
					global::haxe.lang.Exceptions.exception = __temp_catchallException528;
					object __temp_catchall529 = __temp_catchallException528;
					if (( __temp_catchall529 is global::haxe.lang.HaxeException )) {
						__temp_catchall529 = ((global::haxe.lang.HaxeException) (__temp_catchallException528) ).obj;
					}
					
					if (( __temp_catchall529 is global::haxe.io.Eof )) {
						global::haxe.io.Eof e = ((global::haxe.io.Eof) (__temp_catchall529) );
						{
							this._ch = global::alphatab.importer.AlphaTexImporter.Eof;
						}
						
					}
					 else {
						throw;
					}
					
				}
				
				
			}
		}
		
		
		public virtual   void newSy(){
			unchecked {
				this._sy = global::alphatab.importer.AlphaTexSymbols.No;
				do {
					if (string.Equals(this._ch, global::alphatab.importer.AlphaTexImporter.Eof)) {
						this._sy = global::alphatab.importer.AlphaTexSymbols.Eof;
					}
					 else {
						if (( ( ( string.Equals(this._ch, " ") || string.Equals(this._ch, "\n") ) || string.Equals(this._ch, "\r") ) || string.Equals(this._ch, "\t") )) {
							this.nextChar();
						}
						 else {
							if (string.Equals(this._ch, "/")) {
								this.nextChar();
								if (string.Equals(this._ch, "/")) {
									while (( (  ! (string.Equals(this._ch, "\r"))  &&  ! (string.Equals(this._ch, "\n"))  ) &&  ! (string.Equals(this._ch, global::alphatab.importer.AlphaTexImporter.Eof))  )){
										this.nextChar();
									}
									
								}
								 else {
									if (string.Equals(this._ch, "*")) {
										while ( ! (string.Equals(this._ch, global::alphatab.importer.AlphaTexImporter.Eof)) ){
											if (string.Equals(this._ch, "*")) {
												this.nextChar();
												if (string.Equals(this._ch, "/")) {
													this.nextChar();
													break;
												}
												
											}
											 else {
												this.nextChar();
											}
											
										}
										
									}
									 else {
										this.error("symbol", global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
									}
									
								}
								
							}
							 else {
								if (( string.Equals(this._ch, "\"") || string.Equals(this._ch, "\'") )) {
									this.nextChar();
									this._syData = "";
									this._sy = global::alphatab.importer.AlphaTexSymbols.String;
									while (( (  ! (string.Equals(this._ch, "\""))  &&  ! (string.Equals(this._ch, "\'"))  ) &&  ! (string.Equals(this._ch, global::alphatab.importer.AlphaTexImporter.Eof))  )){
										{
											global::alphatab.importer.AlphaTexImporter __temp_dynop445 = this;
											__temp_dynop445._syData = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(__temp_dynop445._syData), this._ch);
										}
										
										this.nextChar();
									}
									
									this.nextChar();
								}
								 else {
									if (string.Equals(this._ch, "-")) {
										if (( this._allowNegatives && this.isDigit(this._ch) )) {
											int number = this.readNumber();
											this._sy = global::alphatab.importer.AlphaTexSymbols.Number;
											this._syData = number;
										}
										 else {
											this._sy = global::alphatab.importer.AlphaTexSymbols.String;
											this._syData = this.readName();
										}
										
									}
									 else {
										if (string.Equals(this._ch, ".")) {
											this._sy = global::alphatab.importer.AlphaTexSymbols.Dot;
											this.nextChar();
										}
										 else {
											if (string.Equals(this._ch, ":")) {
												this._sy = global::alphatab.importer.AlphaTexSymbols.DoubleDot;
												this.nextChar();
											}
											 else {
												if (string.Equals(this._ch, "(")) {
													this._sy = global::alphatab.importer.AlphaTexSymbols.LParensis;
													this.nextChar();
												}
												 else {
													if (string.Equals(this._ch, "\\")) {
														this.nextChar();
														string name = this.readName();
														this._sy = global::alphatab.importer.AlphaTexSymbols.MetaCommand;
														this._syData = name;
													}
													 else {
														if (string.Equals(this._ch, ")")) {
															this._sy = global::alphatab.importer.AlphaTexSymbols.RParensis;
															this.nextChar();
														}
														 else {
															if (string.Equals(this._ch, "{")) {
																this._sy = global::alphatab.importer.AlphaTexSymbols.LBrace;
																this.nextChar();
															}
															 else {
																if (string.Equals(this._ch, "}")) {
																	this._sy = global::alphatab.importer.AlphaTexSymbols.RBrace;
																	this.nextChar();
																}
																 else {
																	if (string.Equals(this._ch, "|")) {
																		this._sy = global::alphatab.importer.AlphaTexSymbols.Pipe;
																		this.nextChar();
																	}
																	 else {
																		if (string.Equals(this._ch, "*")) {
																			this._sy = global::alphatab.importer.AlphaTexSymbols.Multiply;
																			this.nextChar();
																		}
																		 else {
																			if (this.isDigit(this._ch)) {
																				double number1 = ((double) (this.readNumber()) );
																				this._sy = global::alphatab.importer.AlphaTexSymbols.Number;
																				this._syData = number1;
																			}
																			 else {
																				if (global::alphatab.importer.AlphaTexImporter.isLetter(this._ch)) {
																					string name1 = this.readName();
																					if (global::alphatab.model.Tuning.isTuning(name1)) {
																						this._sy = global::alphatab.importer.AlphaTexSymbols.Tuning;
																						this._syData = name1.ToLower();
																					}
																					 else {
																						this._sy = global::alphatab.importer.AlphaTexSymbols.String;
																						this._syData = name1;
																					}
																					
																				}
																				 else {
																					this.error("symbol", global::alphatab.importer.AlphaTexSymbols.String, new global::haxe.lang.Null<bool>(false, true));
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
								
							}
							
						}
						
					}
					
				}
				while (( this._sy == global::alphatab.importer.AlphaTexSymbols.No ));
			}
		}
		
		
		public virtual   bool isDigit(string ch){
			unchecked {
				int code = global::haxe.lang.StringExt.charCodeAt(ch, 0).@value;
				return ( ( ( code >= 48 ) && ( code <= 57 ) ) || ( string.Equals(ch, "-") && this._allowNegatives ) );
			}
		}
		
		
		public virtual   string readName(){
			unchecked {
				string str = "";
				do {
					str = global::haxe.lang.Runtime.concat(str, this._ch);
					this.nextChar();
				}
				while (( global::alphatab.importer.AlphaTexImporter.isLetter(this._ch) || this.isDigit(this._ch) ));
				return str;
			}
		}
		
		
		public virtual   int readNumber(){
			unchecked {
				string str = "";
				do {
					str = global::haxe.lang.Runtime.concat(str, this._ch);
					this.nextChar();
				}
				while (this.isDigit(this._ch));
				return global::haxe.root.Std.parseInt(str).@value;
			}
		}
		
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1111114639:
					{
						this._syData = ((object) (@value) );
						return @value;
					}
					
					
					case 1424663982:
					{
						this._curChPos = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties){
			unchecked {
				switch (hash){
					case 1405029166:
					{
						this._currentDuration = ((global::alphatab.model.Duration) (@value) );
						return @value;
					}
					
					
					case 1686416180:
					{
						this._allowNegatives = global::haxe.lang.Runtime.toBool(@value);
						return @value;
					}
					
					
					case 1111114639:
					{
						this._syData = ((object) (@value) );
						return @value;
					}
					
					
					case 4750021:
					{
						this._sy = ((global::alphatab.importer.AlphaTexSymbols) (@value) );
						return @value;
					}
					
					
					case 1424663982:
					{
						this._curChPos = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 4746436:
					{
						this._ch = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 302437836:
					{
						this._track = ((global::alphatab.model.Track) (@value) );
						return @value;
					}
					
					
					case 1958787731:
					{
						this._score = ((global::alphatab.model.Score) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties){
			unchecked {
				switch (hash){
					case 452356799:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readNumber") ), ((int) (452356799) ))) );
					}
					
					
					case 1895255233:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readName") ), ((int) (1895255233) ))) );
					}
					
					
					case 1984794979:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("isDigit") ), ((int) (1984794979) ))) );
					}
					
					
					case 422637862:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("newSy") ), ((int) (422637862) ))) );
					}
					
					
					case 1837892969:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("nextChar") ), ((int) (1837892969) ))) );
					}
					
					
					case 59370440:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("parseTuning") ), ((int) (59370440) ))) );
					}
					
					
					case 1242376748:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("parseKeySignature") ), ((int) (1242376748) ))) );
					}
					
					
					case 1231600925:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("parseClef") ), ((int) (1231600925) ))) );
					}
					
					
					case 676522989:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("createDefaultScore") ), ((int) (676522989) ))) );
					}
					
					
					case 179703352:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("barMeta") ), ((int) (179703352) ))) );
					}
					
					
					case 1505576615:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("parseDuration") ), ((int) (1505576615) ))) );
					}
					
					
					case 1640216304:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("noteEffects") ), ((int) (1640216304) ))) );
					}
					
					
					case 1225398258:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("note") ), ((int) (1225398258) ))) );
					}
					
					
					case 784731061:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("applyBeatEffect") ), ((int) (784731061) ))) );
					}
					
					
					case 108520940:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("beatEffects") ), ((int) (108520940) ))) );
					}
					
					
					case 1091821942:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("beat") ), ((int) (1091821942) ))) );
					}
					
					
					case 4895187:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("bar") ), ((int) (4895187) ))) );
					}
					
					
					case 1091626816:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("bars") ), ((int) (1091626816) ))) );
					}
					
					
					case 720573327:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("metaData") ), ((int) (720573327) ))) );
					}
					
					
					case 2027516754:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("score") ), ((int) (2027516754) ))) );
					}
					
					
					case 1932118984:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("error") ), ((int) (1932118984) ))) );
					}
					
					
					case 1237368860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), ((string) ("readScore") ), ((int) (1237368860) ))) );
					}
					
					
					case 1405029166:
					{
						return this._currentDuration;
					}
					
					
					case 1686416180:
					{
						return this._allowNegatives;
					}
					
					
					case 1111114639:
					{
						return this._syData;
					}
					
					
					case 4750021:
					{
						return this._sy;
					}
					
					
					case 1424663982:
					{
						return this._curChPos;
					}
					
					
					case 4746436:
					{
						return this._ch;
					}
					
					
					case 302437836:
					{
						return this._track;
					}
					
					
					case 1958787731:
					{
						return this._score;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties){
			unchecked {
				switch (hash){
					case 1111114639:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this._syData)) );
					}
					
					
					case 1424663982:
					{
						return ((double) (this._curChPos) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   object __hx_invokeField(string field, int hash, global::haxe.root.Array dynargs){
			unchecked {
				switch (hash){
					case 1237368860:
					{
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 452356799:
					{
						return this.readNumber();
					}
					
					
					case 1895255233:
					{
						return this.readName();
					}
					
					
					case 1984794979:
					{
						return this.isDigit(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 422637862:
					{
						this.newSy();
						break;
					}
					
					
					case 1837892969:
					{
						this.nextChar();
						break;
					}
					
					
					case 59370440:
					{
						return this.parseTuning(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1242376748:
					{
						return this.parseKeySignature(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 1231600925:
					{
						return this.parseClef(global::haxe.lang.Runtime.toString(dynargs[0]));
					}
					
					
					case 676522989:
					{
						this.createDefaultScore();
						break;
					}
					
					
					case 179703352:
					{
						this.barMeta(((global::alphatab.model.Bar) (dynargs[0]) ));
						break;
					}
					
					
					case 1505576615:
					{
						return this.parseDuration(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					}
					
					
					case 1640216304:
					{
						this.noteEffects(((global::alphatab.model.Note) (dynargs[0]) ));
						break;
					}
					
					
					case 1225398258:
					{
						return this.note(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 784731061:
					{
						return this.applyBeatEffect(((global::alphatab.model.Beat) (dynargs[0]) ));
					}
					
					
					case 108520940:
					{
						this.beatEffects(((global::alphatab.model.Beat) (dynargs[0]) ));
						break;
					}
					
					
					case 1091821942:
					{
						this.beat(((global::alphatab.model.Voice) (dynargs[0]) ));
						break;
					}
					
					
					case 4895187:
					{
						this.bar();
						break;
					}
					
					
					case 1091626816:
					{
						this.bars();
						break;
					}
					
					
					case 720573327:
					{
						this.metaData();
						break;
					}
					
					
					case 2027516754:
					{
						this.score();
						break;
					}
					
					
					case 1932118984:
					{
						this.error(global::haxe.lang.Runtime.toString(dynargs[0]), ((global::alphatab.importer.AlphaTexSymbols) (dynargs[1]) ), global::haxe.lang.Null<object>.ofDynamic<bool>(dynargs[2]));
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
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr){
			unchecked {
				baseArr.push("_currentDuration");
				baseArr.push("_allowNegatives");
				baseArr.push("_syData");
				baseArr.push("_sy");
				baseArr.push("_curChPos");
				baseArr.push("_ch");
				baseArr.push("_track");
				baseArr.push("_score");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


