//This script is used in the Main Menu to randomly generate pictures and display them on the screen
using UnityEngine;
using System.Collections;


public class changePicture : MonoBehaviour {

    //public Texture2D imgDisplay;//tetsing to find what the gameobject was
    public UnityEngine.UI.RawImage imgD;
    //public Sprite t;
    public SpriteRenderer x;
    // Use this for initialization
    void Start () {
        imgD.texture =  Resources.Load<Texture>("pic");
        Sprite newSprite = Resources.Load<Sprite>("pic");
        Debug.Log("Result: " + Resources.Load<Sprite>("pic"));
        Debug.Log("Result: " + Resources.Load<Texture>("pic.jpg"));
        // t = newSprite;//Sprite.Create((Texture2D)myTextures[0], new Rect(0, 0, 170, 170),new Vector2(0, 0),100.0f);
        //SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        //Sprite sprite = new Sprite();
        x.sprite = newSprite;//Sprite.Create(www.texture, new Rect(0, 0, 170, 170),new Vector2(0, 0),100.0f);


    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    //returns an image to display of the memory
    public Texture2D getDisplayImage()
    {
       /* DirectoryInfo dir;//determine which directory to use
        if (isMale)
        {
            dir = new DirectoryInfo("Assets/Resources/People Pictures/Male Pictures");
        }
        else
        {
            dir = new DirectoryInfo("Assets/Resources/People Pictures/Female Pictures");
        }
        //var image = new Texture2D(2, 2);//2's will be replaced in next line
        //image.LoadImage(dir.GetFiles().GetValue(indexOfImage));

        //var images = dir.GetFiles();
        //image.LoadImage (files [2]);
        //		var myTexture = Resources.Load(images[2]);
        var myTexture = (Texture2D)Resources.Load("Female Pictures/093.jpg");*/
        return null;

    }
}
