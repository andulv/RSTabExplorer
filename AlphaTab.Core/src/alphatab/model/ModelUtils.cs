using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace alphatab.model
{
	public  class ModelUtils : global::haxe.lang.HxObject 
	{
		public    ModelUtils(global::haxe.lang.EmptyObject empty)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public    ModelUtils()
		{
			unchecked 
			{
				global::alphatab.model.ModelUtils.__hx_ctor_alphatab_model_ModelUtils(this);
			}
		}
		
		
		public static   void __hx_ctor_alphatab_model_ModelUtils(global::alphatab.model.ModelUtils __temp_me80)
		{
			unchecked 
			{
				{
				}
				
			}
		}
		
		
		public static   int getDurationValue(global::alphatab.model.Duration duration)
		{
			unchecked 
			{
				switch (global::haxe.root.Type.enumIndex(duration))
				{
					case 0:
					{
						return 1;
					}
					
					
					case 1:
					{
						return 2;
					}
					
					
					case 2:
					{
						return 4;
					}
					
					
					case 3:
					{
						return 8;
					}
					
					
					case 4:
					{
						return 16;
					}
					
					
					case 5:
					{
						return 32;
					}
					
					
					case 6:
					{
						return 64;
					}
					
					
				}
				
				return default(int);
			}
		}
		
		
		public static   int getDurationIndex(global::alphatab.model.Duration duration)
		{
			unchecked 
			{
				int index = 0;
				int @value = global::alphatab.model.ModelUtils.getDurationValue(duration);
				while (( (@value = ( @value >> 1 )) > 0 ))
				{
					index++;
				}
				
				return index;
			}
		}
		
		
		public static   bool keySignatureIsFlat(int ks)
		{
			unchecked 
			{
				return ( ks < 0 );
			}
		}
		
		
		public static   bool keySignatureIsNatural(int ks)
		{
			unchecked 
			{
				return ( ks == 0 );
			}
		}
		
		
		public static   bool keySignatureIsSharp(int ks)
		{
			unchecked 
			{
				return ( ks > 0 );
			}
		}
		
		
		public static   int getClefIndex(global::alphatab.model.Clef clef)
		{
			unchecked 
			{
				switch (global::haxe.root.Type.enumIndex(clef))
				{
					case 0:
					{
						return 0;
					}
					
					
					case 1:
					{
						return 1;
					}
					
					
					case 2:
					{
						return 2;
					}
					
					
					case 3:
					{
						return 3;
					}
					
					
					case 4:
					{
						return 4;
					}
					
					
				}
				
				return default(int);
			}
		}
		
		
		public static  new object __hx_createEmpty()
		{
			unchecked 
			{
				return new global::alphatab.model.ModelUtils(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			}
		}
		
		
		public static  new object __hx_create(global::haxe.root.Array arr)
		{
			unchecked 
			{
				return new global::alphatab.model.ModelUtils();
			}
		}
		
		
	}
}


