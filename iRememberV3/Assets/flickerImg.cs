using UnityEngine;
using System.Collections;

public class flickerImg : MonoBehaviour {
	public Sprite[] images;
	public SpriteRenderer imageDisplay;
	// Use this for initialization
	double timeOfLastFlick = 0;
	const double DELAY = .5;// 2 secinds between each image
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Time.time > (timeOfLastFlick + DELAY)) {
			Sprite newSprite = images [Random.Range (0, images.Length - 1)];//pick random image

			//scale image
			//UnityEngine.Bounds bounds = newSprite.bounds;
			//double  factor = 300 /  bounds.size.y;
			//newSprite.localScale = Vector3(factor, factor, factor);

			imageDisplay.sprite = newSprite;//display image
			imageDisplay.transform.localScale = new Vector3(imageDisplay.bounds., lineWidth, lineInstance.transform.localScale.z);
			timeOfLastFlick += DELAY;
		}
	}        
		             
}
		