//This script is used in the Main Menu to randomly generate pictures and display them on the screen
//Credit: forum.unity3d.com/threads/resources-subfolder.36918

using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;//for directoryInfo & FileInfo


public class changePicture : MonoBehaviour {

     
    public UnityEngine.UI.RawImage imgDisplay;

    void Start () {
        //get random picture name
        string imgName = getDisplayImageName();
        //display the picture
        Debug.Log("Looking for..." + imgName);
        Debug.Log("Looking for..." + "Female Pictures/" +imgName );
        imgDisplay.texture = Resources.Load<Texture>("Female Pictures/" + imgName);//"pic" works inside



    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    //returns an image to display of the memory
    public string getDisplayImageName()
    {
        string randomImageName ="";
        DirectoryInfo dir;//determine which directory to use
        //bool isMale = true;
        ////50% Chance memory is female
        //if (UnityEngine.Random.value >= 0.5)
        //{
        //    isMale = false;//switch gender to female
        //}

        //if (isMale)
        //{
        //    dir = new DirectoryInfo("Assets/Resources/Male Pictures");
        //}
        //else
        //{
            dir = new DirectoryInfo("Assets/Resources/Female Pictures");
        //}

        FileInfo[] pictures = dir.GetFiles("*.*");//create a random index based on size of directory
        int randomIndex = UnityEngine.Random.Range(0, pictures.Length - 1);
        Debug.Log("IMG Found:" + pictures[randomIndex]);
       

        randomImageName = pictures[randomIndex].ToString(); // this will look something like this: "Assets\Resources\Male Pictures\file8341308807137.jpg.meta"

        //ocassionally file will have a .meta on the end of their file name. So instead of chopping the last 4 characters off, we look for an end delimeter of either ".jpg" or ".JPG"
        string endDelimiter = "";
        if(randomImageName.IndexOf(".jpg") != -1)
        {
            endDelimiter = ".jpg";
        }
        else if (randomImageName.IndexOf(".JPG") != -1)
        {
            endDelimiter = ".JPG";
        }
        else
        {
            throw new System.ArgumentException("Invalid image file name: [" + randomImageName + "] Does not include .jpg or .JPG");
        }

        int nameLength = (randomImageName.LastIndexOf(endDelimiter) - randomImageName.LastIndexOf("\\"));//distance from where name begins to ".jpg" or ".JPG"
        randomImageName = randomImageName.Substring(randomImageName.LastIndexOf("\\")+1, nameLength-1);//we trim it to  "file8341308807137"

        Debug.Log("Name:" + randomImageName);
        return randomImageName;
    }
}
