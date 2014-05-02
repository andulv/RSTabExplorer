using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.audio.generator{
	public  interface IMidiFileHandler : global::haxe.lang.IHxObject {
		   void addTimeSignature(int tick, int timeSignatureNumerator, int timeSignatureDenominator);
		
		   void addRest(int track, int tick, int channel);
		
		   void addNote(int track, int start, int length, int key, global::alphatab.model.DynamicValue dynamicValue, int channel);
		
		   void addControlChange(int track, int tick, int channel, int controller, int @value);
		
		   void addProgramChange(int track, int tick, int channel, int program);
		
		   void addTempo(int tick, int tempo);
		
		   void addBend(int track, int tick, int channel, int @value);
		
		   void addMetronome(int start, int length);
		
	}
}


