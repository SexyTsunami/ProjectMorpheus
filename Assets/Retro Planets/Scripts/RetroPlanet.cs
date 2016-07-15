﻿using UnityEngine;
using System.Collections;

public class RetroPlanet : PixelAssetRP {
    private int radius = 32;
    //private int radius = Random.Range(400, 500); //<<always = zero dunno why??
    public Color highlightColor = Color.cyan;
	public Color shadeColor = Color.black;
	[Range(0f, 2.01f)]
	public float shadeWidth = 0.7f;

	protected override void SetupTexture (){
        radius = Random.Range(100, 500);
        texDimensions = (radius*2)+10;
		base.SetupTexture ();
	}

	public override void Draw (){
		int centerX = texture.width/2;
		int centerY = texture.height/2;

		PixelToolRP.DrawFilledCircle(texture, shadeColor, new Vector2(centerX, centerY), radius);

        //print(Random.Range(-5, 5));
        for (int y = -radius; y <= radius; y++) {
			int x1 = (int)Mathf.Sqrt(radius * radius - y * y);
			for(int x = -x1; x <= x1; x++) {
				float n = Random.Range(0, x1) * (2.01f-shadeWidth);
				if (n > x1 + x) {
					texture.SetPixel(x+centerX, y+centerY, highlightColor);
				}
				
			}
		}
	}

}
