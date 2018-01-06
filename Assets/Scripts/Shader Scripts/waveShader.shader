Shader "Custom/waveShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_WaveFreq("Wave Frequency", float) = 25
		_WaveAmp("Wave Amplitude", float) = 0.5
		_WaveScroll("Scroll Speed", float) = 5
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		LOD 100

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			// make fog work
			#pragma multi_compile_fog
			
			#include "UnityCG.cginc"

			struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				UNITY_FOG_COORDS(1)
				float4 vertex : SV_POSITION;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;

			half _WaveFreq; //name is exactly the same as the property above
			fixed _WaveAmp;
			
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.vertex += float4(sin(_Time.x * _WaveFreq + o.vertex.x + o.vertex.z),sin(_Time.x * _WaveFreq + o.vertex.x + o.vertex.z) * _WaveAmp,0,0); //_Time is like Time.time
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				UNITY_TRANSFER_FOG(o,o.vertex);
				return o;
			}
			fixed _WaveScroll;
			fixed4 frag (v2f i) : SV_Target
			{
				// sample the texture
				fixed4 col = tex2D(_MainTex, i.uv + float2(_Time.x, _Time.y) * _WaveScroll);
				// apply fog
				UNITY_APPLY_FOG(i.fogCoord, col);
				return col;
			}
			ENDCG
		}
	}
}
