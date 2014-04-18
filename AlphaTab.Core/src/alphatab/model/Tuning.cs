using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class Tuning : global::haxe.lang.HxObject 
	{
		static Tuning() 
		{
			global::alphatab.model.Tuning.TuningRegex = new global::haxe.root.EReg(global::haxe.lang.Runtime.toString("([a-g]b?)([0-9])"), global::haxe.lang.Runtime.toString("i"));
		}
		public    Tuning(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    Tuning(string name, global::haxe.root.Array<int> tuning, bool isStandard)
		{
			unchecked 
			{
				global::alphatab.model.Tuning.__hx_ctor_alphatab_model_Tuning(this, name, tuning, isStandard);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_Tuning(global::alphatab.model.Tuning __temp_me87, string name, global::haxe.root.Array<int> tuning, bool isStandard)
		{
			unchecked 
			{
				__temp_me87.name = name;
				__temp_me87.tuning = tuning;
				__temp_me87.isStandard = isStandard;
			}
		}
		
		
		public static  global::haxe.root.EReg TuningRegex;
		
		public static  global::haxe.root.Array<object> _sevenStrings;
		
		public static  global::haxe.root.Array<object> _sixStrings;
		
		public static  global::haxe.root.Array<object> _fiveStrings;
		
		public static  global::haxe.root.Array<object> _fourStrings;
		
		public static   bool isTuning(string name)
		{
			unchecked 
			{
				global::haxe.root.EReg regex = global::alphatab.model.Tuning.TuningRegex;
				return regex.match(name);
			}
		}
		
		
		public static   string getTextForTuning(int tuning, bool includeOctave)
		{
			unchecked 
			{
				int octave = default(int);
				{
					double x = global::System.Math.Floor(((double) (( ((double) (tuning) ) / 12 )) ));
					octave = ((int) (x) );
				}
				
				int note = ( tuning % 12 );
				global::haxe.root.Array<object> notes = new global::haxe.root.Array<object>(new object[]{"C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B"});
				string result = global::haxe.lang.Runtime.toString(notes[note]);
				if (includeOctave) 
				{
					result = global::haxe.lang.Runtime.concat(result, global::Std.@string(octave));
				}
				
				return result;
			}
		}
		
		
		public static   int getTuningForText(string str)
		{
			unchecked 
			{
				int @base = 0;
				global::haxe.root.EReg regex = global::alphatab.model.Tuning.TuningRegex;
				if (regex.match(str.ToLower())) 
				{
					string note = regex.matched(1);
					global::haxe.lang.Null<int> octave = global::Std.parseInt(regex.matched(2));
					if (string.Equals(note, "c")) 
					{
						@base = 0;
					}
					 else 
					{
						if (string.Equals(note, "db")) 
						{
							@base = 1;
						}
						 else 
						{
							if (string.Equals(note, "d")) 
							{
								@base = 2;
							}
							 else 
							{
								if (string.Equals(note, "eb")) 
								{
									@base = 3;
								}
								 else 
								{
									if (string.Equals(note, "e")) 
									{
										@base = 4;
									}
									 else 
									{
										if (string.Equals(note, "f")) 
										{
											@base = 5;
										}
										 else 
										{
											if (string.Equals(note, "gb")) 
											{
												@base = 6;
											}
											 else 
											{
												if (string.Equals(note, "g")) 
												{
													@base = 7;
												}
												 else 
												{
													if (string.Equals(note, "ab")) 
													{
														@base = 8;
													}
													 else 
													{
														if (string.Equals(note, "a")) 
														{
															@base = 9;
														}
														 else 
														{
															if (string.Equals(note, "bb")) 
															{
																@base = 10;
															}
															 else 
															{
																if (string.Equals(note, "b")) 
																{
																	@base = 11;
																}
																 else 
																{
																	return -1;
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
					
					@base += ( (( octave.@value + 1 )) * 12 );
				}
				 else 
				{
					return -1;
				}
				
				return @base;
			}
		}
		
		
		public static   global::haxe.root.Array<object> getPresetsFor(int strings)
		{
			unchecked 
			{
				if (( global::alphatab.model.Tuning._sevenStrings == default(global::haxe.root.Array<object>) )) 
				{
					global::alphatab.model.Tuning.initialize();
				}
				
				if (( strings == 7 )) 
				{
					return global::alphatab.model.Tuning._sevenStrings;
				}
				
				if (( strings == 6 )) 
				{
					return global::alphatab.model.Tuning._sixStrings;
				}
				
				if (( strings == 5 )) 
				{
					return global::alphatab.model.Tuning._fiveStrings;
				}
				
				if (( strings == 4 )) 
				{
					return global::alphatab.model.Tuning._fourStrings;
				}
				
				return new global::haxe.root.Array<object>();
			}
		}
		
		
		public static   void initialize()
		{
			unchecked 
			{
				global::alphatab.model.Tuning._sevenStrings = new global::haxe.root.Array<object>();
				global::alphatab.model.Tuning._sixStrings = new global::haxe.root.Array<object>();
				global::alphatab.model.Tuning._fiveStrings = new global::haxe.root.Array<object>();
				global::alphatab.model.Tuning._fourStrings = new global::haxe.root.Array<object>();
				global::alphatab.model.Tuning._sevenStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar 7 strings"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 50, 45, 40, 35})) ))) ), ((bool) (true) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Standard Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 50, 45, 40})) ))) ), ((bool) (true) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Tune down \u00bd step"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{63, 58, 54, 49, 44, 39})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Tune down 1 step"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 53, 48, 43, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Tune down 2 step"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{60, 55, 51, 46, 41, 36})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Dropped D Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Dropped D Tuning variant"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 57, 55, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Double Dropped D Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 59, 55, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Dropped E Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{66, 61, 57, 52, 47, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Dropped C Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 53, 48, 43, 36})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open C Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 60, 55, 48, 43, 36})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Cm Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{63, 60, 55, 48, 43, 36})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open C6 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 57, 55, 48, 43, 36})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Cmaj7 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 52, 43, 36})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open D Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 54, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Dm Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 53, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open D5 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 50, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open D6 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 59, 54, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Dsus4 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 55, 50, 45, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open E Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 56, 52, 47, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Em Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 52, 47, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Esus11 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 52, 45, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open F Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{65, 60, 53, 48, 45, 41})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open G Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 59, 55, 50, 43, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Gm Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 58, 55, 50, 43, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open G6 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 55, 50, 43, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Gsus4 Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 60, 55, 50, 43, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open A Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 61, 57, 52, 45, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Open Am Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 60, 57, 52, 45, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Guitar Nashville Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 67, 62, 57, 52})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass 6 Strings Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{48, 43, 38, 33, 28, 23})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._sixStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Lute or Vihuela Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 59, 54, 50, 45, 40})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fiveStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass 5 Strings Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{43, 38, 33, 28, 23})) ))) ), ((bool) (true) )));
				global::alphatab.model.Tuning._fiveStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Banjo Dropped C Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 59, 55, 48, 67})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fiveStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Banjo Open D Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 54, 50, 69})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fiveStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Banjo Open G Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 59, 55, 50, 67})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fiveStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Banjo G Minor Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 58, 55, 50, 67})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fiveStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Banjo G Modal Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{62, 57, 55, 50, 67})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass Standard Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{43, 38, 33, 28})) ))) ), ((bool) (true) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass Tune down \u00bd step"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{42, 37, 32, 27})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass Tune down 1 step"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{41, 36, 31, 26})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass Tune down 2 step"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{39, 34, 29, 24})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Bass Dropped D Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{43, 38, 33, 26})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Ukulele C Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{45, 40, 36, 43})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Ukulele G Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{52, 47, 43, 38})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Mandolin Standard Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{64, 57, 50, 43})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Mandolin or Violin Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{76, 69, 62, 55})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Viola Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{69, 62, 55, 48})) ))) ), ((bool) (false) )));
				global::alphatab.model.Tuning._fourStrings.push(new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString("Cello Tuning"), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (new global::haxe.root.Array<int>(new int[]{57, 50, 43, 36})) ))) ), ((bool) (false) )));
			}
		}
		
		
		public static   global::alphatab.model.Tuning findTuning(global::haxe.root.Array<int> strings)
		{
			unchecked 
			{
				global::haxe.root.Array<object> tunings = global::alphatab.model.Tuning.getPresetsFor(strings.length);
				{
					int _g = 0;
					while (( _g < tunings.length ))
					{
						global::alphatab.model.Tuning tuning = ((global::alphatab.model.Tuning) (tunings[_g]) );
						 ++ _g;
						bool @equals = true;
						{
							int _g2 = 0;
							int _g1 = strings.length;
							while (( _g2 < _g1 ))
							{
								int i = _g2++;
								if (( strings[i] != tuning.tuning[i] )) 
								{
									@equals = false;
									break;
								}
								
							}
							
						}
						
						if (@equals) 
						{
							return tuning;
						}
						
					}
					
				}
				
				return default(global::alphatab.model.Tuning);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.Tuning(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.Tuning(global::haxe.lang.Runtime.toString(arr[0]), ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (arr[1]) ))) ), ((bool) (arr[2]) ));
			}
		}
		
		
		public  bool isStandard;
		
		public  string name;
		
		public  global::haxe.root.Array<int> tuning;
		
		public override   object __hx_setField(string field, int hash, object @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 139280181:
					{
						this.tuning = ((global::haxe.root.Array<int>) (global::haxe.root.Array<object>.__hx_cast<int>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1224700491:
					{
						this.name = global::haxe.lang.Runtime.toString(@value);
						return @value;
					}
					
					
					case 1697073479:
					{
						this.isStandard = ((bool) (@value) );
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
					case 139280181:
					{
						return this.tuning;
					}
					
					
					case 1224700491:
					{
						return this.name;
					}
					
					
					case 1697073479:
					{
						return this.isStandard;
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
				baseArr.push("tuning");
				baseArr.push("name");
				baseArr.push("isStandard");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


