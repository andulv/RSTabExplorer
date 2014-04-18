using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio
{
	public  class GeneralMidi : global::haxe.lang.HxObject 
	{
		public    GeneralMidi(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    GeneralMidi()
		{
			unchecked 
			{
				global::alphatab.audio.GeneralMidi.__hx_ctor_alphatab_audio_GeneralMidi(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_GeneralMidi(global::alphatab.audio.GeneralMidi __temp_me52)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static  global::haxe.ds.StringMap<int> _values;
		
		public static   int getValue(string name)
		{
			unchecked 
			{
				if (( global::alphatab.audio.GeneralMidi._values == default(global::haxe.ds.StringMap<int>) )) 
				{
					global::alphatab.audio.GeneralMidi._values = new global::haxe.ds.StringMap<int>();
					global::alphatab.audio.GeneralMidi._values.@set("acousticgrandpiano", 0);
					global::alphatab.audio.GeneralMidi._values.@set("brightacousticpiano", 1);
					global::alphatab.audio.GeneralMidi._values.@set("electricgrandpiano", 2);
					global::alphatab.audio.GeneralMidi._values.@set("honkytonkpiano", 3);
					global::alphatab.audio.GeneralMidi._values.@set("electricpiano1", 4);
					global::alphatab.audio.GeneralMidi._values.@set("electricpiano2", 5);
					global::alphatab.audio.GeneralMidi._values.@set("harpsichord", 6);
					global::alphatab.audio.GeneralMidi._values.@set("clavinet", 7);
					global::alphatab.audio.GeneralMidi._values.@set("celesta", 8);
					global::alphatab.audio.GeneralMidi._values.@set("glockenspiel", 9);
					global::alphatab.audio.GeneralMidi._values.@set("musicbox", 10);
					global::alphatab.audio.GeneralMidi._values.@set("vibraphone", 11);
					global::alphatab.audio.GeneralMidi._values.@set("marimba", 12);
					global::alphatab.audio.GeneralMidi._values.@set("xylophone", 13);
					global::alphatab.audio.GeneralMidi._values.@set("tubularbells", 14);
					global::alphatab.audio.GeneralMidi._values.@set("dulcimer", 15);
					global::alphatab.audio.GeneralMidi._values.@set("drawbarorgan", 16);
					global::alphatab.audio.GeneralMidi._values.@set("percussiveorgan", 17);
					global::alphatab.audio.GeneralMidi._values.@set("rockorgan", 18);
					global::alphatab.audio.GeneralMidi._values.@set("churchorgan", 19);
					global::alphatab.audio.GeneralMidi._values.@set("reedorgan", 20);
					global::alphatab.audio.GeneralMidi._values.@set("accordion", 21);
					global::alphatab.audio.GeneralMidi._values.@set("harmonica", 22);
					global::alphatab.audio.GeneralMidi._values.@set("tangoaccordion", 23);
					global::alphatab.audio.GeneralMidi._values.@set("acousticguitarnylon", 24);
					global::alphatab.audio.GeneralMidi._values.@set("acousticguitarsteel", 25);
					global::alphatab.audio.GeneralMidi._values.@set("electricguitarjazz", 26);
					global::alphatab.audio.GeneralMidi._values.@set("electricguitarclean", 27);
					global::alphatab.audio.GeneralMidi._values.@set("electricguitarmuted", 28);
					global::alphatab.audio.GeneralMidi._values.@set("overdrivenguitar", 29);
					global::alphatab.audio.GeneralMidi._values.@set("distortionguitar", 30);
					global::alphatab.audio.GeneralMidi._values.@set("guitarharmonics", 31);
					global::alphatab.audio.GeneralMidi._values.@set("acousticbass", 32);
					global::alphatab.audio.GeneralMidi._values.@set("electricbassfinger", 33);
					global::alphatab.audio.GeneralMidi._values.@set("electricbasspick", 34);
					global::alphatab.audio.GeneralMidi._values.@set("fretlessbass", 35);
					global::alphatab.audio.GeneralMidi._values.@set("slapbass1", 36);
					global::alphatab.audio.GeneralMidi._values.@set("slapbass2", 37);
					global::alphatab.audio.GeneralMidi._values.@set("synthbass1", 38);
					global::alphatab.audio.GeneralMidi._values.@set("synthbass2", 39);
					global::alphatab.audio.GeneralMidi._values.@set("violin", 40);
					global::alphatab.audio.GeneralMidi._values.@set("viola", 41);
					global::alphatab.audio.GeneralMidi._values.@set("cello", 42);
					global::alphatab.audio.GeneralMidi._values.@set("contrabass", 43);
					global::alphatab.audio.GeneralMidi._values.@set("tremolostrings", 44);
					global::alphatab.audio.GeneralMidi._values.@set("pizzicatostrings", 45);
					global::alphatab.audio.GeneralMidi._values.@set("orchestralharp", 46);
					global::alphatab.audio.GeneralMidi._values.@set("timpani", 47);
					global::alphatab.audio.GeneralMidi._values.@set("stringensemble1", 48);
					global::alphatab.audio.GeneralMidi._values.@set("stringensemble2", 49);
					global::alphatab.audio.GeneralMidi._values.@set("synthstrings1", 50);
					global::alphatab.audio.GeneralMidi._values.@set("synthstrings2", 51);
					global::alphatab.audio.GeneralMidi._values.@set("choiraahs", 52);
					global::alphatab.audio.GeneralMidi._values.@set("voiceoohs", 53);
					global::alphatab.audio.GeneralMidi._values.@set("synthvoice", 54);
					global::alphatab.audio.GeneralMidi._values.@set("orchestrahit", 55);
					global::alphatab.audio.GeneralMidi._values.@set("trumpet", 56);
					global::alphatab.audio.GeneralMidi._values.@set("trombone", 57);
					global::alphatab.audio.GeneralMidi._values.@set("tuba", 58);
					global::alphatab.audio.GeneralMidi._values.@set("mutedtrumpet", 59);
					global::alphatab.audio.GeneralMidi._values.@set("frenchhorn", 60);
					global::alphatab.audio.GeneralMidi._values.@set("brasssection", 61);
					global::alphatab.audio.GeneralMidi._values.@set("synthbrass1", 62);
					global::alphatab.audio.GeneralMidi._values.@set("synthbrass2", 63);
					global::alphatab.audio.GeneralMidi._values.@set("sopranosax", 64);
					global::alphatab.audio.GeneralMidi._values.@set("altosax", 65);
					global::alphatab.audio.GeneralMidi._values.@set("tenorsax", 66);
					global::alphatab.audio.GeneralMidi._values.@set("baritonesax", 67);
					global::alphatab.audio.GeneralMidi._values.@set("oboe", 68);
					global::alphatab.audio.GeneralMidi._values.@set("englishhorn", 69);
					global::alphatab.audio.GeneralMidi._values.@set("bassoon", 70);
					global::alphatab.audio.GeneralMidi._values.@set("clarinet", 71);
					global::alphatab.audio.GeneralMidi._values.@set("piccolo", 72);
					global::alphatab.audio.GeneralMidi._values.@set("flute", 73);
					global::alphatab.audio.GeneralMidi._values.@set("recorder", 74);
					global::alphatab.audio.GeneralMidi._values.@set("panflute", 75);
					global::alphatab.audio.GeneralMidi._values.@set("blownbottle", 76);
					global::alphatab.audio.GeneralMidi._values.@set("shakuhachi", 77);
					global::alphatab.audio.GeneralMidi._values.@set("whistle", 78);
					global::alphatab.audio.GeneralMidi._values.@set("ocarina", 79);
					global::alphatab.audio.GeneralMidi._values.@set("lead1square", 80);
					global::alphatab.audio.GeneralMidi._values.@set("lead2sawtooth", 81);
					global::alphatab.audio.GeneralMidi._values.@set("lead3calliope", 82);
					global::alphatab.audio.GeneralMidi._values.@set("lead4chiff", 83);
					global::alphatab.audio.GeneralMidi._values.@set("lead5charang", 84);
					global::alphatab.audio.GeneralMidi._values.@set("lead6voice", 85);
					global::alphatab.audio.GeneralMidi._values.@set("lead7fifths", 86);
					global::alphatab.audio.GeneralMidi._values.@set("lead8bassandlead", 87);
					global::alphatab.audio.GeneralMidi._values.@set("pad1newage", 88);
					global::alphatab.audio.GeneralMidi._values.@set("pad2warm", 89);
					global::alphatab.audio.GeneralMidi._values.@set("pad3polysynth", 90);
					global::alphatab.audio.GeneralMidi._values.@set("pad4choir", 91);
					global::alphatab.audio.GeneralMidi._values.@set("pad5bowed", 92);
					global::alphatab.audio.GeneralMidi._values.@set("pad6metallic", 93);
					global::alphatab.audio.GeneralMidi._values.@set("pad7halo", 94);
					global::alphatab.audio.GeneralMidi._values.@set("pad8sweep", 95);
					global::alphatab.audio.GeneralMidi._values.@set("fx1rain", 96);
					global::alphatab.audio.GeneralMidi._values.@set("fx2soundtrack", 97);
					global::alphatab.audio.GeneralMidi._values.@set("fx3crystal", 98);
					global::alphatab.audio.GeneralMidi._values.@set("fx4atmosphere", 99);
					global::alphatab.audio.GeneralMidi._values.@set("fx5brightness", 100);
					global::alphatab.audio.GeneralMidi._values.@set("fx6goblins", 101);
					global::alphatab.audio.GeneralMidi._values.@set("fx7echoes", 102);
					global::alphatab.audio.GeneralMidi._values.@set("fx8scifi", 103);
					global::alphatab.audio.GeneralMidi._values.@set("sitar", 104);
					global::alphatab.audio.GeneralMidi._values.@set("banjo", 105);
					global::alphatab.audio.GeneralMidi._values.@set("shamisen", 106);
					global::alphatab.audio.GeneralMidi._values.@set("koto", 107);
					global::alphatab.audio.GeneralMidi._values.@set("kalimba", 108);
					global::alphatab.audio.GeneralMidi._values.@set("bagpipe", 109);
					global::alphatab.audio.GeneralMidi._values.@set("fiddle", 110);
					global::alphatab.audio.GeneralMidi._values.@set("shanai", 111);
					global::alphatab.audio.GeneralMidi._values.@set("tinklebell", 112);
					global::alphatab.audio.GeneralMidi._values.@set("agogo", 113);
					global::alphatab.audio.GeneralMidi._values.@set("steeldrums", 114);
					global::alphatab.audio.GeneralMidi._values.@set("woodblock", 115);
					global::alphatab.audio.GeneralMidi._values.@set("taikodrum", 116);
					global::alphatab.audio.GeneralMidi._values.@set("melodictom", 117);
					global::alphatab.audio.GeneralMidi._values.@set("synthdrum", 118);
					global::alphatab.audio.GeneralMidi._values.@set("reversecymbal", 119);
					global::alphatab.audio.GeneralMidi._values.@set("guitarfretnoise", 120);
					global::alphatab.audio.GeneralMidi._values.@set("breathnoise", 121);
					global::alphatab.audio.GeneralMidi._values.@set("seashore", 122);
					global::alphatab.audio.GeneralMidi._values.@set("birdtweet", 123);
					global::alphatab.audio.GeneralMidi._values.@set("telephonering", 124);
					global::alphatab.audio.GeneralMidi._values.@set("helicopter", 125);
					global::alphatab.audio.GeneralMidi._values.@set("applause", 126);
					global::alphatab.audio.GeneralMidi._values.@set("gunshot", 127);
				}
				
				name = global::haxe.root.StringTools.replace(name.ToLower(), " ", "");
				if (global::alphatab.audio.GeneralMidi._values.exists(name)) 
				{
					return global::alphatab.audio.GeneralMidi._values.@get(name).@value;
				}
				 else 
				{
					return 0;
				}
				
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.audio.GeneralMidi(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.audio.GeneralMidi();
			}
		}
		
		
	}
}


