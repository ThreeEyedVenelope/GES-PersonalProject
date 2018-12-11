using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_Text : MonoBehaviour {

    public Text winText;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckCollect();
	}

    void CheckCollect()
    {
        if (Gem_Collect.count == 5 && Collect.count == 5)
        {
            winText.text = "Yay! You win!";
        }
    }
}
