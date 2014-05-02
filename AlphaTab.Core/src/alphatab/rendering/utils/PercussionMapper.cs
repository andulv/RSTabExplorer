using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.rendering.utils{
	public  class PercussionMapper : global::haxe.lang.HxObject {
		public    PercussionMapper(global::haxe.lang.EmptyObject empty){
			unchecked {
				{
				}
				
			}
		}
		
		
		public    PercussionMapper(){
			unchecked {
				global::alphatab.rendering.utils.PercussionMapper.__hx_ctor_alphatab_rendering_utils_PercussionMapper(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_rendering_utils_PercussionMapper(global::alphatab.rendering.utils.PercussionMapper __temp_me291){
			unchecked {
				{
				}
				
			}
		}
		
		
		public static   int mapValue(global::alphatab.model.Note n){
			unchecked {
				int @value = ( n.fret + n.beat.voice.bar.track.tuning[( ( n.beat.voice.bar.track.tuning.length - (( n.@string - 1 )) ) - 1 )] );
				if (( ( @value == 61 ) || ( @value == 66 ) )) {
					return 50;
				}
				 else {
					if (( ( @value == 60 ) || ( @value == 65 ) )) {
						return 52;
					}
					 else {
						if (( ( ( @value >= 35 ) && ( @value <= 36 ) ) || ( @value == 44 ) )) {
							return 53;
						}
						 else {
							if (( ( @value == 41 ) || ( @value == 64 ) )) {
								return 55;
							}
							 else {
								if (( ( @value == 43 ) || ( @value == 62 ) )) {
									return 57;
								}
								 else {
									if (( ( @value == 45 ) || ( @value == 63 ) )) {
										return 59;
									}
									 else {
										if (( ( @value == 47 ) || ( @value == 54 ) )) {
											return 62;
										}
										 else {
											if (( ( @value == 48 ) || ( @value == 56 ) )) {
												return 64;
											}
											 else {
												if (( @value == 50 )) {
													return 65;
												}
												 else {
													if (( ( ( ( ( @value == 42 ) || ( @value == 46 ) ) || ( ( @value >= 49 ) && ( @value <= 53 ) ) ) || ( @value == 57 ) ) || ( @value == 59 ) )) {
														return 67;
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
				
				return 60;
			}
		}
		
		
		public static  new object __hx_createEmpty(){
			unchecked {
				return new global::alphatab.rendering.utils.PercussionMapper(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr){
			unchecked {
				return new global::alphatab.rendering.utils.PercussionMapper();
			}
		}
		
		
	}
}


