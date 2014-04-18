using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.importer
{
	public  class GpxRhythm : global::haxe.lang.HxObject 
	{
		public    GpxRhythm(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    GpxRhythm()
		{
			unchecked 
			{
				global::alphatab.importer.GpxRhythm.__hx_ctor_alphatab_importer_GpxRhythm(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_GpxRhythm(global::alphatab.importer.GpxRhythm __temp_me62)
		{
			unchecked 
			{
				__temp_me62.tupletNumerator = 1;
				__temp_me62.tupletDenominator = 1;
				__temp_me62.@value = global::alphatab.model.Duration.Quarter;
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxRhythm(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxRhythm();
			}
		}
		
		
		public  int dots;
		
		public  int tupletDenominator;
		
		public  int tupletNumerator;
		
		public  global::alphatab.model.Duration @value;
		
		public override   double __hx_setField_f(string field, int hash, double @value, bool handleProperties)
		{
			unchecked 
			{
				switch (hash)
				{
					case 438479229:
					{
						this.tupletNumerator = ((int) (@value) );
						return @value;
					}
					
					
					case 1310257562:
					{
						this.tupletDenominator = ((int) (@value) );
						return @value;
					}
					
					
					case 1114502602:
					{
						this.dots = ((int) (@value) );
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
					case 834174833:
					{
						this.@value = ((global::alphatab.model.Duration) (@value) );
						return @value;
					}
					
					
					case 438479229:
					{
						this.tupletNumerator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1310257562:
					{
						this.tupletDenominator = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 1114502602:
					{
						this.dots = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 834174833:
					{
						return this.@value;
					}
					
					
					case 438479229:
					{
						return this.tupletNumerator;
					}
					
					
					case 1310257562:
					{
						return this.tupletDenominator;
					}
					
					
					case 1114502602:
					{
						return this.dots;
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
					case 438479229:
					{
						return ((double) (this.tupletNumerator) );
					}
					
					
					case 1310257562:
					{
						return ((double) (this.tupletDenominator) );
					}
					
					
					case 1114502602:
					{
						return ((double) (this.dots) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override   void __hx_getFields(global::haxe.root.Array<object> baseArr)
		{
			unchecked 
			{
				baseArr.push("value");
				baseArr.push("tupletNumerator");
				baseArr.push("tupletDenominator");
				baseArr.push("dots");
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
	public  class GpxParser : global::haxe.lang.HxObject 
	{
		static GpxParser() 
		{
			global::alphatab.importer.GpxParser.InvalidId = "-1";
			global::alphatab.importer.GpxParser.BendPointPositionFactor = 0.6;
			global::alphatab.importer.GpxParser.BendPointValueFactor = 0.04;
		}
		public    GpxParser(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    GpxParser()
		{
			unchecked 
			{
				global::alphatab.importer.GpxParser.__hx_ctor_alphatab_importer_GpxParser(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_importer_GpxParser(global::alphatab.importer.GpxParser __temp_me63)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  string InvalidId;
		
		public static  double BendPointPositionFactor;
		
		public static  double BendPointValueFactor;
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxParser(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.importer.GpxParser();
			}
		}
		
		
		public  global::alphatab.model.Score score;
		
		public  global::haxe.ds.StringMap<object> _automations;
		
		public  global::haxe.root.Array<object> _tracksMapping;
		
		public  global::haxe.ds.StringMap<object> _tracksById;
		
		public  global::haxe.root.Array<object> _masterBars;
		
		public  global::haxe.root.Array<object> _barsOfMasterBar;
		
		public  global::haxe.ds.StringMap<object> _barsById;
		
		public  global::haxe.ds.StringMap<object> _voicesOfBar;
		
		public  global::haxe.ds.StringMap<object> _voiceById;
		
		public  global::haxe.ds.StringMap<object> _beatsOfVoice;
		
		public  global::haxe.ds.StringMap<object> _rhythmOfBeat;
		
		public  global::haxe.ds.StringMap<object> _beatById;
		
		public  global::haxe.ds.StringMap<object> _rhythmById;
		
		public  global::haxe.ds.StringMap<object> _noteById;
		
		public  global::haxe.ds.StringMap<object> _notesOfBeat;
		
		public  global::haxe.ds.StringMap<bool> _tappedNotes;
		
		public virtual   void parseXml(string xml)
		{
			unchecked 
			{
				this._automations = new global::haxe.ds.StringMap<object>();
				this._tracksMapping = new global::haxe.root.Array<object>();
				this._tracksById = new global::haxe.ds.StringMap<object>();
				this._masterBars = new global::haxe.root.Array<object>();
				this._barsOfMasterBar = new global::haxe.root.Array<object>();
				this._voicesOfBar = new global::haxe.ds.StringMap<object>();
				this._barsById = new global::haxe.ds.StringMap<object>();
				this._voiceById = new global::haxe.ds.StringMap<object>();
				this._beatsOfVoice = new global::haxe.ds.StringMap<object>();
				this._beatById = new global::haxe.ds.StringMap<object>();
				this._rhythmOfBeat = new global::haxe.ds.StringMap<object>();
				this._rhythmById = new global::haxe.ds.StringMap<object>();
				this._notesOfBeat = new global::haxe.ds.StringMap<object>();
				this._noteById = new global::haxe.ds.StringMap<object>();
				this._tappedNotes = new global::haxe.ds.StringMap<bool>();
				global::haxe.root.Xml dom = global::haxe.root.Xml.parse(xml);
				this.parseDom(dom);
			}
		}
		
		
		public virtual   void parseDom(global::haxe.root.Xml xml)
		{
			unchecked 
			{
				if (( xml.nodeType == global::haxe.root.Xml.Document )) 
				{
					xml = xml.firstElement();
				}
				
				if (string.Equals(xml._get_nodeName(), "GPIF")) 
				{
					this.score = new global::alphatab.model.Score();
					{
						object __temp_iterator416 = xml.iterator();
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator416, "hasNext", 407283053, default(global::haxe.root.Array))) ))
						{
							global::haxe.root.Xml n = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator416, "next", 1224901875, default(global::haxe.root.Array))) );
							if (( n.nodeType == global::haxe.root.Xml.Element )) 
							{
								string _g = n._get_nodeName();
								switch (_g)
								{
									case "Score":
									{
										this.parseScoreNode(n);
										break;
									}
									
									
									case "MasterTrack":
									{
										this.parseMasterTrackNode(n);
										break;
									}
									
									
									case "Tracks":
									{
										this.parseTracksNode(n);
										break;
									}
									
									
									case "MasterBars":
									{
										this.parseMasterBarsNode(n);
										break;
									}
									
									
									case "Bars":
									{
										this.parseBars(n);
										break;
									}
									
									
									case "Voices":
									{
										this.parseVoices(n);
										break;
									}
									
									
									case "Beats":
									{
										this.parseBeats(n);
										break;
									}
									
									
									case "Notes":
									{
										this.parseNotes(n);
										break;
									}
									
									
									case "Rhythms":
									{
										this.parseRhythms(n);
										break;
									}
									
									
								}
								
							}
							
						}
						
					}
					
				}
				 else 
				{
					throw global::haxe.lang.HaxeException.wrap(global::alphatab.importer.ScoreImporter.UnsupportedFormat);
				}
				
				this.buildModel();
			}
		}
		
		
		public virtual   string getValue(global::haxe.root.Xml n)
		{
			unchecked 
			{
				if (( ( n.nodeType == global::haxe.root.Xml.Element ) || ( n.nodeType == global::haxe.root.Xml.Document ) )) 
				{
					global::haxe.root.StringBuf txt = new global::haxe.root.StringBuf();
					{
						object __temp_iterator417 = n.iterator();
						while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator417, "hasNext", 407283053, default(global::haxe.root.Array))) ))
						{
							global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator417, "next", 1224901875, default(global::haxe.root.Array))) );
							object x = this.getValue(c);
							txt.b.Append(((object) (global::Std.@string(x)) ));
						}
						
					}
					
					{
						string s = txt.toString();
						return s.Trim();
					}
					
				}
				 else 
				{
					return n._get_nodeValue();
				}
				
			}
		}
		
		
		public virtual   global::haxe.root.Xml findChildElement(global::haxe.root.Xml node, string name)
		{
			unchecked 
			{
				{
					object __temp_iterator418 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator418, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator418, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							if (string.Equals(c._get_nodeName(), name)) 
							{
								return c;
							}
							
						}
						
					}
					
				}
				
				return default(global::haxe.root.Xml);
			}
		}
		
		
		public virtual   void parseScoreNode(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator419 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator419, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator419, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Title":
								{
									this.score.title = this.getValue(c.firstChild());
									break;
								}
								
								
								case "SubTitle":
								{
									this.score.subTitle = this.getValue(c.firstChild());
									break;
								}
								
								
								case "Artist":
								{
									this.score.artist = this.getValue(c.firstChild());
									break;
								}
								
								
								case "Album":
								{
									this.score.album = this.getValue(c.firstChild());
									break;
								}
								
								
								case "Words":
								{
									this.score.words = this.getValue(c.firstChild());
									break;
								}
								
								
								case "Music":
								{
									this.score.music = this.getValue(c.firstChild());
									break;
								}
								
								
								case "WordsAndMusic":
								{
									if (( ( c.firstChild() != default(global::haxe.root.Xml) ) &&  ! (string.Equals(c.firstChild().toString(), ""))  )) 
									{
										this.score.words = this.getValue(c.firstChild());
										this.score.music = this.getValue(c.firstChild());
									}
									
									break;
								}
								
								
								case "Copyright":
								{
									this.score.copyright = this.getValue(c.firstChild());
									break;
								}
								
								
								case "Tabber":
								{
									this.score.tab = this.getValue(c.firstChild());
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseMasterTrackNode(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator420 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator420, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator420, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Automations":
								{
									this.parseAutomations(c);
									break;
								}
								
								
								case "Tracks":
								{
									this._tracksMapping = global::haxe.lang.StringExt.split(this.getValue(c), " ");
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseAutomations(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator421 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator421, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator421, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Automation":
								{
									this.parseAutomation(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseAutomation(global::haxe.root.Xml node)
		{
			unchecked 
			{
				string type = default(string);
				bool isLinear = false;
				string barId = default(string);
				double ratioPosition = ((double) (0) );
				double @value = ((double) (0) );
				int reference = 0;
				string text = default(string);
				{
					object __temp_iterator422 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator422, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator422, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Type":
								{
									type = this.getValue(c);
									break;
								}
								
								
								case "Linear":
								{
									isLinear = string.Equals(this.getValue(c).ToLower(), "true");
									break;
								}
								
								
								case "Bar":
								{
									barId = this.getValue(c);
									break;
								}
								
								
								case "Position":
								{
									ratioPosition = global::Std.parseFloat(this.getValue(c));
									break;
								}
								
								
								case "Value":
								{
									global::haxe.root.Array<object> parts = global::haxe.lang.StringExt.split(this.getValue(c), " ");
									@value = global::Std.parseFloat(global::haxe.lang.Runtime.toString(parts[0]));
									reference = global::Std.parseInt(global::haxe.lang.Runtime.toString(parts[1])).@value;
									break;
								}
								
								
								case "Text":
								{
									text = this.getValue(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				if (string.Equals(type, default(string))) 
				{
					return ;
				}
				
				global::alphatab.model.Automation automation = default(global::alphatab.model.Automation);
				switch (type)
				{
					case "Tempo":
					{
						automation = global::alphatab.model.Automation.builtTempoAutomation(isLinear, ratioPosition, @value, reference);
						break;
					}
					
					
				}
				
				automation.text = text;
				if (( automation != default(global::alphatab.model.Automation) )) 
				{
					if ( ! (this._automations.exists(barId)) ) 
					{
						this._automations.@set(barId, new global::haxe.root.Array<object>());
					}
					
					((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._automations.@get(barId).@value) ))) ).push(automation);
				}
				
			}
		}
		
		
		public virtual   void parseTracksNode(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator423 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator423, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator423, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Track":
								{
									this.parseTrack(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseTrack(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.Track track = new global::alphatab.model.Track();
				string trackId = node.@get("id");
				{
					object __temp_iterator424 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator424, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator424, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Name":
								{
									track.name = this.getValue(c);
									break;
								}
								
								
								case "ShortName":
								{
									track.shortName = this.getValue(c);
									break;
								}
								
								
								case "Properties":
								{
									this.parseTrackProperties(track, c);
									break;
								}
								
								
								case "GeneralMidi":
								{
									this.parseGeneralMidi(track, c);
									break;
								}
								
								
								case "PlaybackState":
								{
									string state = this.getValue(c);
									track.playbackInfo.isSolo = string.Equals(state, "Solo");
									track.playbackInfo.isMute = string.Equals(state, "Mute");
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._tracksById.@set(trackId, track);
			}
		}
		
		
		public virtual   void parseDiagramCollection(global::alphatab.model.Track track, global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::haxe.root.Xml items = this.findChildElement(node, "Items");
				{
					object __temp_iterator425 = items.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator425, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator425, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Item":
								{
									this.parseDiagramItem(track, c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseDiagramItem(global::alphatab.model.Track track, global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.Chord chord = new global::alphatab.model.Chord();
				string chordId = node.@get("id");
				chord.name = node.@get("name");
				track.chords.@set(chordId, chord);
			}
		}
		
		
		public virtual   void parseTrackProperties(global::alphatab.model.Track track, global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator426 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator426, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator426, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Property":
								{
									this.parseTrackProperty(track, c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseTrackProperty(global::alphatab.model.Track track, global::haxe.root.Xml node)
		{
			unchecked 
			{
				string propertyName = node.@get("name");
				switch (propertyName)
				{
					case "Tuning":
					{
						global::haxe.root.Array<object> tuningParts = global::haxe.lang.StringExt.split(this.getValue(this.findChildElement(node, "Pitches")), " ");
						{
							int _g = 0;
							while (( _g < tuningParts.length ))
							{
								string s = global::haxe.lang.Runtime.toString(tuningParts[_g]);
								 ++ _g;
								track.tuning.push(global::Std.parseInt(s).@value);
							}
							
						}
						
						track.tuning.reverse();
						break;
					}
					
					
					case "DiagramCollection":
					{
						this.parseDiagramCollection(track, node);
						break;
					}
					
					
					case "CapoFret":
					{
						track.capo = global::Std.parseInt(this.getValue(this.findChildElement(node, "Fret"))).@value;
						break;
					}
					
					
				}
				
			}
		}
		
		
		public virtual   void parseGeneralMidi(global::alphatab.model.Track track, global::haxe.root.Xml node)
		{
			unchecked 
			{
				track.playbackInfo.port = global::Std.parseInt(this.getValue(this.findChildElement(node, "Port"))).@value;
				track.playbackInfo.program = global::Std.parseInt(this.getValue(this.findChildElement(node, "Program"))).@value;
				track.playbackInfo.primaryChannel = global::Std.parseInt(this.getValue(this.findChildElement(node, "PrimaryChannel"))).@value;
				track.playbackInfo.secondaryChannel = global::Std.parseInt(this.getValue(this.findChildElement(node, "SecondaryChannel"))).@value;
				track.isPercussion = string.Equals(node.@get("table"), "Percussion");
			}
		}
		
		
		public virtual   void parseMasterBarsNode(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator427 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator427, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator427, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "MasterBar":
								{
									this.parseMasterBar(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseMasterBar(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.MasterBar masterBar = new global::alphatab.model.MasterBar();
				{
					object __temp_iterator428 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator428, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator428, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Time":
								{
									global::haxe.root.Array<object> timeParts = global::haxe.lang.StringExt.split(this.getValue(c), "/");
									masterBar.timeSignatureNumerator = global::Std.parseInt(global::haxe.lang.Runtime.toString(timeParts[0])).@value;
									masterBar.timeSignatureDenominator = global::Std.parseInt(global::haxe.lang.Runtime.toString(timeParts[1])).@value;
									break;
								}
								
								
								case "DoubleBar":
								{
									masterBar.isDoubleBar = true;
									break;
								}
								
								
								case "Section":
								{
									masterBar.section = new global::alphatab.model.Section();
									masterBar.section.marker = this.getValue(this.findChildElement(c, "Letter"));
									masterBar.section.text = this.getValue(this.findChildElement(c, "Text"));
									break;
								}
								
								
								case "Repeat":
								{
									if (string.Equals(c.@get("start").ToLower(), "true")) 
									{
										masterBar.isRepeatStart = true;
									}
									
									if (( string.Equals(c.@get("end").ToLower(), "true") &&  ! (string.Equals(c.@get("count"), default(string)))  )) 
									{
										masterBar.repeatCount = global::Std.parseInt(c.@get("count")).@value;
									}
									
									break;
								}
								
								
								case "AlternateEndings":
								{
									global::haxe.root.Array<object> alternateEndings = global::haxe.lang.StringExt.split(this.getValue(c), " ");
									int i = 0;
									{
										int _g2 = 0;
										int _g1 = alternateEndings.length;
										while (( _g2 < _g1 ))
										{
											int k = _g2++;
											i |= ( 1 << ( -1 + global::Std.parseInt(global::haxe.lang.Runtime.toString(alternateEndings[i])).@value ) );
										}
										
									}
									
									masterBar.alternateEndings = i;
									break;
								}
								
								
								case "Bars":
								{
									this._barsOfMasterBar.push(global::haxe.lang.StringExt.split(this.getValue(c), " "));
									break;
								}
								
								
								case "TripletFeel":
								{
									string _g11 = this.getValue(c);
									switch (_g11)
									{
										case "NoTripletFeel":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.NoTripletFeel;
											break;
										}
										
										
										case "Triplet8th":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.Triplet8th;
											break;
										}
										
										
										case "Triplet16th":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.Triplet16th;
											break;
										}
										
										
										case "Dotted8th":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.Dotted8th;
											break;
										}
										
										
										case "Dotted16th":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.Dotted16th;
											break;
										}
										
										
										case "Scottish8th":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.Scottish8th;
											break;
										}
										
										
										case "Scottish16th":
										{
											masterBar.tripletFeel = global::alphatab.model.TripletFeel.Scottish16th;
											break;
										}
										
										
									}
									
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._masterBars.push(masterBar);
			}
		}
		
		
		public virtual   void parseBars(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator429 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator429, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator429, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Bar":
								{
									this.parseBar(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseBar(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.Bar bar = new global::alphatab.model.Bar();
				string barId = node.@get("id");
				{
					object __temp_iterator430 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator430, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator430, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Voices":
								{
									this._voicesOfBar.@set(barId, global::haxe.lang.StringExt.split(this.getValue(c), " "));
									break;
								}
								
								
								case "Clef":
								{
									string _g1 = this.getValue(c);
									switch (_g1)
									{
										case "Neutral":
										{
											bar.clef = global::alphatab.model.Clef.Neutral;
											break;
										}
										
										
										case "G2":
										{
											bar.clef = global::alphatab.model.Clef.G2;
											break;
										}
										
										
										case "F4":
										{
											bar.clef = global::alphatab.model.Clef.F4;
											break;
										}
										
										
										case "C4":
										{
											bar.clef = global::alphatab.model.Clef.C4;
											break;
										}
										
										
										case "C3":
										{
											bar.clef = global::alphatab.model.Clef.C3;
											break;
										}
										
										
									}
									
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._barsById.@set(barId, bar);
			}
		}
		
		
		public virtual   void parseVoices(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator431 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator431, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator431, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Voice":
								{
									this.parseVoice(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseVoice(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.Voice voice = new global::alphatab.model.Voice();
				string voiceId = node.@get("id");
				{
					object __temp_iterator432 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator432, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator432, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Beats":
								{
									this._beatsOfVoice.@set(voiceId, global::haxe.lang.StringExt.split(this.getValue(c), " "));
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._voiceById.@set(voiceId, voice);
			}
		}
		
		
		public virtual   void parseBeats(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator433 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator433, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator433, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Beat":
								{
									this.parseBeat(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseBeat(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.Beat beat = new global::alphatab.model.Beat();
				string beatId = node.@get("id");
				{
					object __temp_iterator434 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator434, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator434, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Notes":
								{
									this._notesOfBeat.@set(beatId, global::haxe.lang.StringExt.split(this.getValue(c), " "));
									break;
								}
								
								
								case "Rhythm":
								{
									this._rhythmOfBeat.@set(beatId, c.@get("ref"));
									break;
								}
								
								
								case "Fadding":
								{
									if (string.Equals(this.getValue(c), "FadeIn")) 
									{
										beat.fadeIn = true;
									}
									
									break;
								}
								
								
								case "Tremolo":
								{
									string _g1 = this.getValue(c);
									switch (_g1)
									{
										case "1/2":
										{
											beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(new global::haxe.lang.Null<global::alphatab.model.Duration>(global::alphatab.model.Duration.Eighth, true).@value, true);
											break;
										}
										
										
										case "1/4":
										{
											beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(new global::haxe.lang.Null<global::alphatab.model.Duration>(global::alphatab.model.Duration.Sixteenth, true).@value, true);
											break;
										}
										
										
										case "1/8":
										{
											beat.tremoloSpeed = new global::haxe.lang.Null<global::alphatab.model.Duration>(new global::haxe.lang.Null<global::alphatab.model.Duration>(global::alphatab.model.Duration.ThirtySecond, true).@value, true);
											break;
										}
										
										
									}
									
									break;
								}
								
								
								case "Chord":
								{
									beat.chordId = this.getValue(c);
									break;
								}
								
								
								case "Hairpin":
								{
									string _g11 = this.getValue(c);
									switch (_g11)
									{
										case "Crescendo":
										{
											beat.crescendo = global::alphatab.rendering.glyphs.CrescendoType.Crescendo;
											break;
										}
										
										
										case "Decrescendo":
										{
											beat.crescendo = global::alphatab.rendering.glyphs.CrescendoType.Decrescendo;
											break;
										}
										
										
									}
									
									break;
								}
								
								
								case "Arpeggio":
								{
									if (string.Equals(this.getValue(c), "Up")) 
									{
										beat.brushType = global::alphatab.model.BrushType.ArpeggioUp;
									}
									 else 
									{
										beat.brushType = global::alphatab.model.BrushType.ArpeggioDown;
									}
									
									break;
								}
								
								
								case "Properties":
								{
									this.parseBeatProperties(c, beat);
									break;
								}
								
								
								case "FreeText":
								{
									beat.text = this.getValue(c);
									break;
								}
								
								
								case "Dynamic":
								{
									string _g12 = this.getValue(c);
									switch (_g12)
									{
										case "PPP":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.PPP;
											break;
										}
										
										
										case "PP":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.PP;
											break;
										}
										
										
										case "P":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.P;
											break;
										}
										
										
										case "MP":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.MP;
											break;
										}
										
										
										case "MF":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.MF;
											break;
										}
										
										
										case "F":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.F;
											break;
										}
										
										
										case "FF":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.FF;
											break;
										}
										
										
										case "FFF":
										{
											beat.dynamicValue = global::alphatab.model.DynamicValue.FFF;
											break;
										}
										
										
									}
									
									break;
								}
								
								
								case "GraceNotes":
								{
									string _g13 = this.getValue(c);
									switch (_g13)
									{
										case "OnBeat":
										{
											beat.graceType = global::alphatab.model.GraceType.OnBeat;
											break;
										}
										
										
										case "BeforeBeat":
										{
											beat.graceType = global::alphatab.model.GraceType.BeforeBeat;
											break;
										}
										
										
									}
									
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._beatById.@set(beatId, beat);
			}
		}
		
		
		public virtual   void parseBeatProperties(global::haxe.root.Xml node, global::alphatab.model.Beat beat)
		{
			unchecked 
			{
				bool isWhammy = false;
				global::alphatab.model.BendPoint whammyOrigin = default(global::alphatab.model.BendPoint);
				global::haxe.lang.Null<int> whammyMiddleValue = default(global::haxe.lang.Null<int>);
				global::haxe.lang.Null<int> whammyMiddleOffset1 = default(global::haxe.lang.Null<int>);
				global::haxe.lang.Null<int> whammyMiddleOffset2 = default(global::haxe.lang.Null<int>);
				global::alphatab.model.BendPoint whammyDestination = default(global::alphatab.model.BendPoint);
				{
					object __temp_iterator435 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator435, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator435, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Property":
								{
									string name = c.@get("name");
									switch (name)
									{
										case "Brush":
										{
											if (string.Equals(this.getValue(this.findChildElement(c, "Direction")), "Up")) 
											{
												beat.brushType = global::alphatab.model.BrushType.BrushUp;
											}
											 else 
											{
												beat.brushType = global::alphatab.model.BrushType.BrushDown;
											}
											
											break;
										}
										
										
										case "PickStroke":
										{
											if (string.Equals(this.getValue(this.findChildElement(c, "Direction")), "Up")) 
											{
												beat.pickStroke = global::alphatab.model.PickStrokeType.Up;
											}
											 else 
											{
												beat.pickStroke = global::alphatab.model.PickStrokeType.Down;
											}
											
											break;
										}
										
										
										case "Slapped":
										{
											if (( this.findChildElement(c, "Enable") != default(global::haxe.root.Xml) )) 
											{
												beat.slap = true;
											}
											
											break;
										}
										
										
										case "Popped":
										{
											if (( this.findChildElement(c, "Enable") != default(global::haxe.root.Xml) )) 
											{
												beat.pop = true;
											}
											
											break;
										}
										
										
										case "VibratoWTremBar":
										{
											string _g1 = this.getValue(this.findChildElement(c, "Strength"));
											switch (_g1)
											{
												case "Wide":
												{
													beat.vibrato = global::alphatab.model.VibratoType.Wide;
													break;
												}
												
												
												case "Slight":
												{
													beat.vibrato = global::alphatab.model.VibratoType.Slight;
													break;
												}
												
												
											}
											
											break;
										}
										
										
										case "WhammyBar":
										{
											isWhammy = true;
											break;
										}
										
										
										case "WhammyBarExtend":
										{
											{
											}
											
											break;
										}
										
										
										case "WhammyBarOriginValue":
										{
											if (( whammyOrigin == default(global::alphatab.model.BendPoint) )) 
											{
												whammyOrigin = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.04 );
												whammyOrigin.@value = ((int) (x) );
											}
											
											break;
										}
										
										
										case "WhammyBarOriginOffset":
										{
											if (( whammyOrigin == default(global::alphatab.model.BendPoint) )) 
											{
												whammyOrigin = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x1 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
												whammyOrigin.offset = ((int) (x1) );
											}
											
											break;
										}
										
										
										case "WhammyBarMiddleValue":
										{
											double x2 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.04 );
											whammyMiddleValue = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(((int) (x2) ), true).@value, true);
											break;
										}
										
										
										case "WhammyBarMiddleOffset1":
										{
											double x3 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
											whammyMiddleOffset1 = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(((int) (x3) ), true).@value, true);
											break;
										}
										
										
										case "WhammyBarMiddleOffset2":
										{
											double x4 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
											whammyMiddleOffset2 = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(((int) (x4) ), true).@value, true);
											break;
										}
										
										
										case "WhammyBarDestinationValue":
										{
											if (( whammyDestination == default(global::alphatab.model.BendPoint) )) 
											{
												whammyDestination = new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(60, true), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x5 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.04 );
												whammyDestination.@value = ((int) (x5) );
											}
											
											break;
										}
										
										
										case "WhammyBarDestinationOffset":
										{
											if (( whammyDestination == default(global::alphatab.model.BendPoint) )) 
											{
												whammyDestination = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x6 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
												whammyDestination.offset = ((int) (x6) );
											}
											
											break;
										}
										
										
									}
									
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				if (isWhammy) 
				{
					if (( whammyOrigin == default(global::alphatab.model.BendPoint) )) 
					{
						whammyOrigin = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
					}
					
					if (( whammyDestination == default(global::alphatab.model.BendPoint) )) 
					{
						whammyDestination = new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(60, true), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
					}
					
					global::haxe.root.Array<object> whammy = new global::haxe.root.Array<object>();
					whammy.push(whammyOrigin);
					if (( ( ! (global::haxe.lang.Runtime.eq((whammyMiddleOffset1).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) && ( ! (global::haxe.lang.Runtime.eq((whammyMiddleValue).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) )) 
					{
						whammy.push(new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (whammyMiddleOffset1) ), ((global::haxe.lang.Null<int>) (whammyMiddleValue) )));
					}
					
					if (( ( ! (global::haxe.lang.Runtime.eq((whammyMiddleOffset2).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) && ( ! (global::haxe.lang.Runtime.eq((whammyMiddleValue).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) )) 
					{
						whammy.push(new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (whammyMiddleOffset2) ), ((global::haxe.lang.Null<int>) (whammyMiddleValue) )));
					}
					
					if (( ( global::haxe.lang.Runtime.eq((whammyMiddleOffset1).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) && global::haxe.lang.Runtime.eq((whammyMiddleOffset2).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) ) && ( ! (global::haxe.lang.Runtime.eq((whammyMiddleValue).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) )) 
					{
						whammy.push(new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(30, true), ((global::haxe.lang.Null<int>) (whammyMiddleValue) )));
					}
					
					whammy.push(whammyDestination);
					beat.whammyBarPoints = whammy;
				}
				
			}
		}
		
		
		public virtual   void parseNotes(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator436 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator436, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator436, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Note":
								{
									this.parseNote(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseNote(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.model.Note note = new global::alphatab.model.Note();
				string noteId = node.@get("id");
				{
					object __temp_iterator437 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator437, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator437, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Properties":
								{
									this.parseNoteProperties(c, note, noteId);
									break;
								}
								
								
								case "AntiAccent":
								{
									if (string.Equals(this.getValue(c).ToLower(), "normal")) 
									{
										note.isGhost = true;
									}
									
									break;
								}
								
								
								case "LetRing":
								{
									note.isLetRing = true;
									break;
								}
								
								
								case "Trill":
								{
									note.trillValue = global::Std.parseInt(this.getValue(c)).@value;
									note.trillSpeed = global::alphatab.model.Duration.Sixteenth;
									break;
								}
								
								
								case "Accent":
								{
									global::haxe.lang.Null<int> accentFlags = global::Std.parseInt(this.getValue(c));
									if (( (( accentFlags.@value & 1 )) != 0 )) 
									{
										note.isStaccato = true;
									}
									
									if (( (( accentFlags.@value & 4 )) != 0 )) 
									{
										note.accentuated = global::alphatab.model.AccentuationType.Heavy;
									}
									
									if (( (( accentFlags.@value & 8 )) != 0 )) 
									{
										note.accentuated = global::alphatab.model.AccentuationType.Normal;
									}
									
									break;
								}
								
								
								case "Tie":
								{
									if (string.Equals(c.@get("origin").ToLower(), "true")) 
									{
										note.isTieOrigin = true;
									}
									
									if (string.Equals(c.@get("destination").ToLower(), "true")) 
									{
										note.isTieDestination = true;
									}
									
									break;
								}
								
								
								case "Vibrato":
								{
									string _g1 = this.getValue(c);
									switch (_g1)
									{
										case "Slight":
										{
											note.vibrato = global::alphatab.model.VibratoType.Slight;
											break;
										}
										
										
										case "Wide":
										{
											note.vibrato = global::alphatab.model.VibratoType.Wide;
											break;
										}
										
										
									}
									
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._noteById.@set(noteId, note);
			}
		}
		
		
		public virtual   void parseNoteProperties(global::haxe.root.Xml node, global::alphatab.model.Note note, string noteId)
		{
			unchecked 
			{
				bool isBended = false;
				global::alphatab.model.BendPoint bendOrigin = default(global::alphatab.model.BendPoint);
				global::haxe.lang.Null<int> bendMiddleValue = default(global::haxe.lang.Null<int>);
				global::haxe.lang.Null<int> bendMiddleOffset1 = default(global::haxe.lang.Null<int>);
				global::haxe.lang.Null<int> bendMiddleOffset2 = default(global::haxe.lang.Null<int>);
				global::alphatab.model.BendPoint bendDestination = default(global::alphatab.model.BendPoint);
				{
					object __temp_iterator438 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator438, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator438, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Property":
								{
									string name = c.@get("name");
									switch (name)
									{
										case "String":
										{
											note.@string = ( global::Std.parseInt(this.getValue(this.findChildElement(c, "String"))).@value + 1 );
											break;
										}
										
										
										case "Fret":
										{
											note.fret = global::Std.parseInt(this.getValue(this.findChildElement(c, "Fret"))).@value;
											break;
										}
										
										
										case "Tapped":
										{
											this._tappedNotes.@set(noteId, true);
											break;
										}
										
										
										case "HarmonicType":
										{
											global::haxe.root.Xml htype = this.findChildElement(c, "HType");
											if (( htype != default(global::haxe.root.Xml) )) 
											{
												string _g1 = this.getValue(htype);
												switch (_g1)
												{
													case "NoHarmonic":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.None;
														break;
													}
													
													
													case "Natural":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.Natural;
														break;
													}
													
													
													case "Artificial":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.Artificial;
														break;
													}
													
													
													case "Pinch":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.Pinch;
														break;
													}
													
													
													case "Tap":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.Tap;
														break;
													}
													
													
													case "Semi":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.Semi;
														break;
													}
													
													
													case "Feedback":
													{
														note.harmonicType = global::alphatab.model.HarmonicType.Feedback;
														break;
													}
													
													
												}
												
											}
											
											break;
										}
										
										
										case "HarmonicFret":
										{
											global::haxe.root.Xml hfret = this.findChildElement(c, "HFret");
											if (( hfret != default(global::haxe.root.Xml) )) 
											{
												note.harmonicValue = global::Std.parseFloat(this.getValue(hfret));
											}
											
											break;
										}
										
										
										case "PalmMuted":
										{
											if (( this.findChildElement(c, "Enable") != default(global::haxe.root.Xml) )) 
											{
												note.isPalmMute = true;
											}
											
											break;
										}
										
										
										case "Octave":
										{
											note.octave = global::Std.parseInt(this.getValue(this.findChildElement(c, "Number"))).@value;
											break;
										}
										
										
										case "Bended":
										{
											isBended = true;
											break;
										}
										
										
										case "BendOriginValue":
										{
											if (( bendOrigin == default(global::alphatab.model.BendPoint) )) 
											{
												bendOrigin = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.04 );
												bendOrigin.@value = ((int) (x) );
											}
											
											break;
										}
										
										
										case "BendOriginOffset":
										{
											if (( bendOrigin == default(global::alphatab.model.BendPoint) )) 
											{
												bendOrigin = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x1 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
												bendOrigin.offset = ((int) (x1) );
											}
											
											break;
										}
										
										
										case "BendMiddleValue":
										{
											double x2 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.04 );
											bendMiddleValue = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(((int) (x2) ), true).@value, true);
											break;
										}
										
										
										case "BendMiddleOffset1":
										{
											double x3 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
											bendMiddleOffset1 = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(((int) (x3) ), true).@value, true);
											break;
										}
										
										
										case "BendMiddleOffset2":
										{
											double x4 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
											bendMiddleOffset2 = new global::haxe.lang.Null<int>(new global::haxe.lang.Null<int>(((int) (x4) ), true).@value, true);
											break;
										}
										
										
										case "BendDestinationValue":
										{
											if (( bendDestination == default(global::alphatab.model.BendPoint) )) 
											{
												bendDestination = new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(60, true), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x5 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.04 );
												bendDestination.@value = ((int) (x5) );
											}
											
											break;
										}
										
										
										case "BendDestinationOffset":
										{
											if (( bendDestination == default(global::alphatab.model.BendPoint) )) 
											{
												bendDestination = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
											}
											
											{
												double x6 = ( global::Std.parseFloat(this.getValue(this.findChildElement(c, "Float"))) * 0.6 );
												bendDestination.offset = ((int) (x6) );
											}
											
											break;
										}
										
										
										case "HopoOrigin":
										{
											if (( this.findChildElement(c, "Enable") != default(global::haxe.root.Xml) )) 
											{
												note.isHammerPullOrigin = true;
											}
											
											break;
										}
										
										
										case "HopoDestination":
										{
											{
											}
											
											break;
										}
										
										
										case "Slide":
										{
											global::haxe.lang.Null<int> slideFlags = global::Std.parseInt(this.getValue(this.findChildElement(c, "Flags")));
											if (( (( slideFlags.@value & 1 )) != 0 )) 
											{
												note.slideType = global::alphatab.model.SlideType.Shift;
											}
											
											if (( (( slideFlags.@value & 2 )) != 0 )) 
											{
												note.slideType = global::alphatab.model.SlideType.Legato;
											}
											
											if (( (( slideFlags.@value & 4 )) != 0 )) 
											{
												note.slideType = global::alphatab.model.SlideType.OutDown;
											}
											
											if (( (( slideFlags.@value & 8 )) != 0 )) 
											{
												note.slideType = global::alphatab.model.SlideType.OutUp;
											}
											
											if (( (( slideFlags.@value & 16 )) != 0 )) 
											{
												note.slideType = global::alphatab.model.SlideType.IntoFromBelow;
											}
											
											if (( (( slideFlags.@value & 32 )) != 0 )) 
											{
												note.slideType = global::alphatab.model.SlideType.IntoFromAbove;
											}
											
											break;
										}
										
										
									}
									
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				if (isBended) 
				{
					if (( bendOrigin == default(global::alphatab.model.BendPoint) )) 
					{
						bendOrigin = new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
					}
					
					if (( bendDestination == default(global::alphatab.model.BendPoint) )) 
					{
						bendDestination = new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(60, true), ((global::haxe.lang.Null<int>) (default(global::haxe.lang.Null<int>)) ));
					}
					
					global::haxe.root.Array<object> bend = new global::haxe.root.Array<object>();
					bend.push(bendOrigin);
					if (( ( ! (global::haxe.lang.Runtime.eq((bendMiddleOffset1).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) && ( ! (global::haxe.lang.Runtime.eq((bendMiddleValue).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) )) 
					{
						bend.push(new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (bendMiddleOffset1) ), ((global::haxe.lang.Null<int>) (bendMiddleValue) )));
					}
					
					if (( ( ! (global::haxe.lang.Runtime.eq((bendMiddleOffset2).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) && ( ! (global::haxe.lang.Runtime.eq((bendMiddleValue).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) )) 
					{
						bend.push(new global::alphatab.model.BendPoint(((global::haxe.lang.Null<int>) (bendMiddleOffset2) ), ((global::haxe.lang.Null<int>) (bendMiddleValue) )));
					}
					
					if (( ( global::haxe.lang.Runtime.eq((bendMiddleOffset1).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) && global::haxe.lang.Runtime.eq((bendMiddleOffset2).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic()) ) && ( ! (global::haxe.lang.Runtime.eq((bendMiddleValue).toDynamic(), (default(global::haxe.lang.Null<int>)).toDynamic())) ) )) 
					{
						bend.push(new global::alphatab.model.BendPoint(new global::haxe.lang.Null<int>(30, true), ((global::haxe.lang.Null<int>) (bendMiddleValue) )));
					}
					
					bend.push(bendDestination);
					note.bendPoints = bend;
				}
				
			}
		}
		
		
		public virtual   void parseRhythms(global::haxe.root.Xml node)
		{
			unchecked 
			{
				{
					object __temp_iterator439 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator439, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator439, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "Rhythm":
								{
									this.parseRhythm(c);
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
			}
		}
		
		
		public virtual   void parseRhythm(global::haxe.root.Xml node)
		{
			unchecked 
			{
				global::alphatab.importer.GpxRhythm rhythm = new global::alphatab.importer.GpxRhythm();
				string rhythmId = node.@get("id");
				{
					object __temp_iterator440 = node.iterator();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator440, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						global::haxe.root.Xml c = ((global::haxe.root.Xml) (global::haxe.lang.Runtime.callField(__temp_iterator440, "next", 1224901875, default(global::haxe.root.Array))) );
						if (( c.nodeType == global::haxe.root.Xml.Element )) 
						{
							string _g = c._get_nodeName();
							switch (_g)
							{
								case "NoteValue":
								{
									string _g1 = this.getValue(c);
									switch (_g1)
									{
										case "Whole":
										{
											rhythm.@value = global::alphatab.model.Duration.Whole;
											break;
										}
										
										
										case "Half":
										{
											rhythm.@value = global::alphatab.model.Duration.Half;
											break;
										}
										
										
										case "Quarter":
										{
											rhythm.@value = global::alphatab.model.Duration.Quarter;
											break;
										}
										
										
										case "Eighth":
										{
											rhythm.@value = global::alphatab.model.Duration.Eighth;
											break;
										}
										
										
										case "16th":
										{
											rhythm.@value = global::alphatab.model.Duration.Sixteenth;
											break;
										}
										
										
										case "32nd":
										{
											rhythm.@value = global::alphatab.model.Duration.ThirtySecond;
											break;
										}
										
										
										case "64th":
										{
											rhythm.@value = global::alphatab.model.Duration.SixtyFourth;
											break;
										}
										
										
									}
									
									break;
								}
								
								
								case "PrimaryTuplet":
								{
									rhythm.tupletNumerator = global::Std.parseInt(c.@get("num")).@value;
									rhythm.tupletDenominator = global::Std.parseInt(c.@get("den")).@value;
									break;
								}
								
								
								case "AugmentationDot":
								{
									rhythm.dots = global::Std.parseInt(c.@get("count")).@value;
									break;
								}
								
								
							}
							
						}
						
					}
					
				}
				
				this._rhythmById.@set(rhythmId, rhythm);
			}
		}
		
		
		public virtual   void buildModel()
		{
			unchecked 
			{
				{
					object __temp_iterator441 = this._beatById.keys();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator441, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string beatId = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator441, "next", 1224901875, default(global::haxe.root.Array)));
						global::alphatab.model.Beat beat = ((global::alphatab.model.Beat) (this._beatById.@get(beatId).@value) );
						string rhythmId = global::haxe.lang.Runtime.toString(this._rhythmOfBeat.@get(beatId).@value);
						global::alphatab.importer.GpxRhythm rhythm = ((global::alphatab.importer.GpxRhythm) (this._rhythmById.@get(rhythmId).@value) );
						beat.duration = rhythm.@value;
						beat.dots = rhythm.dots;
						beat.tupletNumerator = rhythm.tupletNumerator;
						beat.tupletDenominator = rhythm.tupletDenominator;
						if (this._notesOfBeat.exists(beatId)) 
						{
							int _g = 0;
							global::haxe.root.Array<object> _g1 = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._notesOfBeat.@get(beatId).@value) ))) );
							while (( _g < _g1.length ))
							{
								string noteId = global::haxe.lang.Runtime.toString(_g1[_g]);
								 ++ _g;
								if ( ! (string.Equals(noteId, "-1")) ) 
								{
									beat.addNote(((global::alphatab.model.Note) (this._noteById.@get(noteId).@value) ));
									if (this._tappedNotes.exists(noteId)) 
									{
										beat.tap = true;
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
				{
					object __temp_iterator442 = this._voiceById.keys();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator442, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string voiceId = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator442, "next", 1224901875, default(global::haxe.root.Array)));
						global::alphatab.model.Voice voice = ((global::alphatab.model.Voice) (this._voiceById.@get(voiceId).@value) );
						if (this._beatsOfVoice.exists(voiceId)) 
						{
							int _g2 = 0;
							global::haxe.root.Array<object> _g11 = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._beatsOfVoice.@get(voiceId).@value) ))) );
							while (( _g2 < _g11.length ))
							{
								string beatId1 = global::haxe.lang.Runtime.toString(_g11[_g2]);
								 ++ _g2;
								if ( ! (string.Equals(beatId1, "-1")) ) 
								{
									voice.addBeat(((global::alphatab.model.Beat) (this._beatById.@get(beatId1).@value) ).clone());
								}
								
							}
							
						}
						
					}
					
				}
				
				{
					object __temp_iterator443 = this._barsById.keys();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator443, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string barId = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator443, "next", 1224901875, default(global::haxe.root.Array)));
						global::alphatab.model.Bar bar = ((global::alphatab.model.Bar) (this._barsById.@get(barId).@value) );
						if (this._voicesOfBar.exists(barId)) 
						{
							int _g3 = 0;
							global::haxe.root.Array<object> _g12 = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._voicesOfBar.@get(barId).@value) ))) );
							while (( _g3 < _g12.length ))
							{
								string voiceId1 = global::haxe.lang.Runtime.toString(_g12[_g3]);
								 ++ _g3;
								if ( ! (string.Equals(voiceId1, "-1")) ) 
								{
									bar.addVoice(((global::alphatab.model.Voice) (this._voiceById.@get(voiceId1).@value) ));
								}
								
							}
							
						}
						
					}
					
				}
				
				int trackIndex = 0;
				{
					int _g4 = 0;
					global::haxe.root.Array<object> _g13 = this._tracksMapping;
					while (( _g4 < _g13.length ))
					{
						string trackId = global::haxe.lang.Runtime.toString(_g13[_g4]);
						 ++ _g4;
						global::alphatab.model.Track track = ((global::alphatab.model.Track) (this._tracksById.@get(trackId).@value) );
						this.score.addTrack(track);
						{
							int _g21 = 0;
							global::haxe.root.Array<object> _g31 = this._barsOfMasterBar;
							while (( _g21 < _g31.length ))
							{
								global::haxe.root.Array<object> barIds = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (_g31[_g21]) ))) );
								 ++ _g21;
								string barId1 = global::haxe.lang.Runtime.toString(barIds[trackIndex]);
								if ( ! (string.Equals(barId1, "-1")) ) 
								{
									track.addBar(((global::alphatab.model.Bar) (this._barsById.@get(barId1).@value) ));
								}
								
							}
							
						}
						
						trackIndex++;
					}
					
				}
				
				{
					object __temp_iterator444 = this._automations.keys();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator444, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string barId2 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator444, "next", 1224901875, default(global::haxe.root.Array)));
						global::alphatab.model.Bar bar1 = ((global::alphatab.model.Bar) (this._barsById.@get(barId2).@value) );
						{
							int _g5 = 0;
							global::haxe.root.Array<object> _g14 = bar1.voices;
							while (( _g5 < _g14.length ))
							{
								global::alphatab.model.Voice v = ((global::alphatab.model.Voice) (_g14[_g5]) );
								 ++ _g5;
								if (( v.beats.length > 0 )) 
								{
									int _g22 = 0;
									global::haxe.root.Array<object> _g32 = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._automations.@get(barId2).@value) ))) );
									while (( _g22 < _g32.length ))
									{
										global::alphatab.model.Automation automation = ((global::alphatab.model.Automation) (_g32[_g22]) );
										 ++ _g22;
										((global::alphatab.model.Beat) (v.beats[0]) ).automations.push(automation);
									}
									
								}
								
							}
							
						}
						
					}
					
				}
				
				{
					int _g6 = 0;
					global::haxe.root.Array<object> _g15 = this._masterBars;
					while (( _g6 < _g15.length ))
					{
						global::alphatab.model.MasterBar masterBar = ((global::alphatab.model.MasterBar) (_g15[_g6]) );
						 ++ _g6;
						this.score.addMasterBar(masterBar);
					}
					
				}
				
				{
					object __temp_iterator445 = this._automations.keys();
					while (((bool) (global::haxe.lang.Runtime.callField(__temp_iterator445, "hasNext", 407283053, default(global::haxe.root.Array))) ))
					{
						string barId3 = global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.callField(__temp_iterator445, "next", 1224901875, default(global::haxe.root.Array)));
						global::haxe.root.Array<object> automations = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (this._automations.@get(barId3).@value) ))) );
						global::alphatab.model.Bar bar2 = ((global::alphatab.model.Bar) (this._barsById.@get(barId3).@value) );
						{
							int _g7 = 0;
							while (( _g7 < automations.length ))
							{
								global::alphatab.model.Automation automation1 = ((global::alphatab.model.Automation) (automations[_g7]) );
								 ++ _g7;
								if (( automation1.type == global::alphatab.model.AutomationType.Tempo )) 
								{
									if (string.Equals(barId3, "0")) 
									{
										this.score.tempo = ((int) (automation1.@value) );
										this.score.tempoLabel = automation1.text;
									}
									
									((global::alphatab.model.MasterBar) (bar2.track.score.masterBars[bar2.index]) ).tempoAutomation = automation1;
								}
								
							}
							
						}
						
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
					case 223988822:
					{
						this._tappedNotes = ((global::haxe.ds.StringMap<bool>) (global::haxe.ds.StringMap<object>.__hx_cast<bool>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 2001890127:
					{
						this._notesOfBeat = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 401348099:
					{
						this._noteById = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 169770535:
					{
						this._rhythmById = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1408430471:
					{
						this._beatById = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1790892546:
					{
						this._rhythmOfBeat = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1952851773:
					{
						this._beatsOfVoice = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1524598821:
					{
						this._voiceById = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1940366524:
					{
						this._voicesOfBar = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1715971153:
					{
						this._barsById = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1395480923:
					{
						this._barsOfMasterBar = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1522424353:
					{
						this._masterBars = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 1341358681:
					{
						this._tracksById = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 1077438631:
					{
						this._tracksMapping = ((global::haxe.root.Array<object>) (global::haxe.root.Array<object>.__hx_cast<object>(((global::haxe.root.Array) (@value) ))) );
						return @value;
					}
					
					
					case 202704573:
					{
						this._automations = ((global::haxe.ds.StringMap<object>) (global::haxe.ds.StringMap<object>.__hx_cast<object>(((global::haxe.ds.StringMap) (@value) ))) );
						return @value;
					}
					
					
					case 2027516754:
					{
						this.score = ((global::alphatab.model.Score) (@value) );
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
					case 550203803:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("buildModel"), ((int) (550203803) ))) );
					}
					
					
					case 1105941737:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseRhythm"), ((int) (1105941737) ))) );
					}
					
					
					case 1811871594:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseRhythms"), ((int) (1811871594) ))) );
					}
					
					
					case 1234579992:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseNoteProperties"), ((int) (1234579992) ))) );
					}
					
					
					case 1353738693:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseNote"), ((int) (1353738693) ))) );
					}
					
					
					case 1236017934:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseNotes"), ((int) (1236017934) ))) );
					}
					
					
					case 465864860:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseBeatProperties"), ((int) (465864860) ))) );
					}
					
					
					case 1220162377:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseBeat"), ((int) (1220162377) ))) );
					}
					
					
					case 1513270538:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseBeats"), ((int) (1513270538) ))) );
					}
					
					
					case 1691905151:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseVoice"), ((int) (1691905151) ))) );
					}
					
					
					case 1485210388:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseVoices"), ((int) (1485210388) ))) );
					}
					
					
					case 1449966432:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseBar"), ((int) (1449966432) ))) );
					}
					
					
					case 1219967251:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseBars"), ((int) (1219967251) ))) );
					}
					
					
					case 1134013342:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseMasterBar"), ((int) (1134013342) ))) );
					}
					
					
					case 1998021559:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseMasterBarsNode"), ((int) (1998021559) ))) );
					}
					
					
					case 250834870:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseGeneralMidi"), ((int) (250834870) ))) );
					}
					
					
					case 625209805:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseTrackProperty"), ((int) (625209805) ))) );
					}
					
					
					case 1936847723:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseTrackProperties"), ((int) (1936847723) ))) );
					}
					
					
					case 1517203539:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseDiagramItem"), ((int) (1517203539) ))) );
					}
					
					
					case 336701854:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseDiagramCollection"), ((int) (336701854) ))) );
					}
					
					
					case 1073796440:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseTrack"), ((int) (1073796440) ))) );
					}
					
					
					case 1580906429:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseTracksNode"), ((int) (1580906429) ))) );
					}
					
					
					case 1273099754:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseAutomation"), ((int) (1273099754) ))) );
					}
					
					
					case 433403721:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseAutomations"), ((int) (433403721) ))) );
					}
					
					
					case 1390889528:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseMasterTrackNode"), ((int) (1390889528) ))) );
					}
					
					
					case 485419969:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseScoreNode"), ((int) (485419969) ))) );
					}
					
					
					case 1967318617:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("findChildElement"), ((int) (1967318617) ))) );
					}
					
					
					case 294620923:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("getValue"), ((int) (294620923) ))) );
					}
					
					
					case 1450069007:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseDom"), ((int) (1450069007) ))) );
					}
					
					
					case 1451063140:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(((object) (this) ), global::haxe.lang.Runtime.toString("parseXml"), ((int) (1451063140) ))) );
					}
					
					
					case 223988822:
					{
						return this._tappedNotes;
					}
					
					
					case 2001890127:
					{
						return this._notesOfBeat;
					}
					
					
					case 401348099:
					{
						return this._noteById;
					}
					
					
					case 169770535:
					{
						return this._rhythmById;
					}
					
					
					case 1408430471:
					{
						return this._beatById;
					}
					
					
					case 1790892546:
					{
						return this._rhythmOfBeat;
					}
					
					
					case 1952851773:
					{
						return this._beatsOfVoice;
					}
					
					
					case 1524598821:
					{
						return this._voiceById;
					}
					
					
					case 1940366524:
					{
						return this._voicesOfBar;
					}
					
					
					case 1715971153:
					{
						return this._barsById;
					}
					
					
					case 1395480923:
					{
						return this._barsOfMasterBar;
					}
					
					
					case 1522424353:
					{
						return this._masterBars;
					}
					
					
					case 1341358681:
					{
						return this._tracksById;
					}
					
					
					case 1077438631:
					{
						return this._tracksMapping;
					}
					
					
					case 202704573:
					{
						return this._automations;
					}
					
					
					case 2027516754:
					{
						return this.score;
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
					case 550203803:
					{
						this.buildModel();
						break;
					}
					
					
					case 1105941737:
					{
						this.parseRhythm(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1811871594:
					{
						this.parseRhythms(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1234579992:
					{
						this.parseNoteProperties(((global::haxe.root.Xml) (dynargs[0]) ), ((global::alphatab.model.Note) (dynargs[1]) ), global::haxe.lang.Runtime.toString(dynargs[2]));
						break;
					}
					
					
					case 1353738693:
					{
						this.parseNote(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1236017934:
					{
						this.parseNotes(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 465864860:
					{
						this.parseBeatProperties(((global::haxe.root.Xml) (dynargs[0]) ), ((global::alphatab.model.Beat) (dynargs[1]) ));
						break;
					}
					
					
					case 1220162377:
					{
						this.parseBeat(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1513270538:
					{
						this.parseBeats(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1691905151:
					{
						this.parseVoice(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1485210388:
					{
						this.parseVoices(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1449966432:
					{
						this.parseBar(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1219967251:
					{
						this.parseBars(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1134013342:
					{
						this.parseMasterBar(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1998021559:
					{
						this.parseMasterBarsNode(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 250834870:
					{
						this.parseGeneralMidi(((global::alphatab.model.Track) (dynargs[0]) ), ((global::haxe.root.Xml) (dynargs[1]) ));
						break;
					}
					
					
					case 625209805:
					{
						this.parseTrackProperty(((global::alphatab.model.Track) (dynargs[0]) ), ((global::haxe.root.Xml) (dynargs[1]) ));
						break;
					}
					
					
					case 1936847723:
					{
						this.parseTrackProperties(((global::alphatab.model.Track) (dynargs[0]) ), ((global::haxe.root.Xml) (dynargs[1]) ));
						break;
					}
					
					
					case 1517203539:
					{
						this.parseDiagramItem(((global::alphatab.model.Track) (dynargs[0]) ), ((global::haxe.root.Xml) (dynargs[1]) ));
						break;
					}
					
					
					case 336701854:
					{
						this.parseDiagramCollection(((global::alphatab.model.Track) (dynargs[0]) ), ((global::haxe.root.Xml) (dynargs[1]) ));
						break;
					}
					
					
					case 1073796440:
					{
						this.parseTrack(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1580906429:
					{
						this.parseTracksNode(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1273099754:
					{
						this.parseAutomation(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 433403721:
					{
						this.parseAutomations(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1390889528:
					{
						this.parseMasterTrackNode(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 485419969:
					{
						this.parseScoreNode(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1967318617:
					{
						return this.findChildElement(((global::haxe.root.Xml) (dynargs[0]) ), global::haxe.lang.Runtime.toString(dynargs[1]));
					}
					
					
					case 294620923:
					{
						return this.getValue(((global::haxe.root.Xml) (dynargs[0]) ));
					}
					
					
					case 1450069007:
					{
						this.parseDom(((global::haxe.root.Xml) (dynargs[0]) ));
						break;
					}
					
					
					case 1451063140:
					{
						this.parseXml(global::haxe.lang.Runtime.toString(dynargs[0]));
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
				baseArr.push("_tappedNotes");
				baseArr.push("_notesOfBeat");
				baseArr.push("_noteById");
				baseArr.push("_rhythmById");
				baseArr.push("_beatById");
				baseArr.push("_rhythmOfBeat");
				baseArr.push("_beatsOfVoice");
				baseArr.push("_voiceById");
				baseArr.push("_voicesOfBar");
				baseArr.push("_barsById");
				baseArr.push("_barsOfMasterBar");
				baseArr.push("_masterBars");
				baseArr.push("_tracksById");
				baseArr.push("_tracksMapping");
				baseArr.push("_automations");
				baseArr.push("score");
				{
					base.__hx_getFields(baseArr);
				}
				
			}
		}
		
		
	}
}


