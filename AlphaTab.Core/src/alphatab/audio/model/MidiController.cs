using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.model{
	public  class MidiController : global::haxe.lang.HxObject {
		static MidiController() {
			global::alphatab.audio.model.MidiController.AllNotesOff = 123;
			global::alphatab.audio.model.MidiController.Balance = 10;
			global::alphatab.audio.model.MidiController.Chorus = 93;
			global::alphatab.audio.model.MidiController.DataEntryLsb = 38;
			global::alphatab.audio.model.MidiController.DataEntryMsb = 6;
			global::alphatab.audio.model.MidiController.Expression = 11;
			global::alphatab.audio.model.MidiController.Phaser = 95;
			global::alphatab.audio.model.MidiController.Reverb = 91;
			global::alphatab.audio.model.MidiController.RpnLsb = 100;
			global::alphatab.audio.model.MidiController.RpnMsb = 101;
			global::alphatab.audio.model.MidiController.Tremolo = 92;
			global::alphatab.audio.model.MidiController.Volume = 7;
		}
		public    MidiController(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    MidiController(){
			unchecked {
				global::alphatab.audio.model.MidiController.__hx_ctor_alphatab_audio_model_MidiController(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_audio_model_MidiController(global::alphatab.audio.model.MidiController __temp_me61){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static  int AllNotesOff;
		
		public static  int Balance;
		
		public static  int Chorus;
		
		public static  int DataEntryLsb;
		
		public static  int DataEntryMsb;
		
		public static  int Expression;
		
		public static  int Phaser;
		
		public static  int Reverb;
		
		public static  int RpnLsb;
		
		public static  int RpnMsb;
		
		public static  int Tremolo;
		
		public static  int Volume;
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.audio.model.MidiController(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.audio.model.MidiController();
			}
		}
		
		
	}
}


