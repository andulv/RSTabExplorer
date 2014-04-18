using haxe.root;
#pragma warning disable 109, 114, 219, 429, 168, 162
public  class Math 
{
	static Math() 
	{
		{
			global::Math.PI = global::System.Math.PI;
			global::Math.NaN = double.NaN;
			global::Math.NEGATIVE_INFINITY = double.NegativeInfinity;
			global::Math.POSITIVE_INFINITY = double.PositiveInfinity;
			global::Math.rand = new global::System.Random();
		}
		
	}
	public    Math()
	{
		unchecked 
		{
			{
			}
			
		}
	}
	
	
	public static  global::System.Random rand;
	
	public static  double PI;
	
	public static  double NaN;
	
	public static  double NEGATIVE_INFINITY;
	
	public static  double POSITIVE_INFINITY;
	
	public static   int round(double v)
	{
		unchecked 
		{
			int vint = ((int) (v) );
			double dec = ( v - vint );
			if (( ( dec >= 1 ) || ( dec <= -1 ) )) 
			{
				return vint;
			}
			
			if (( dec >= .5 )) 
			{
				return ( vint + 1 );
			}
			
			if (( dec < -.5 )) 
			{
				return ( vint - 1 );
			}
			
			return vint;
		}
	}
	
	
}


