using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour {

    public Text hoverText;
	// Use this for initialization
	void Start ()
    {
        hoverText.color = Color.black;
	}
	
	// Update is called once per frame
	void Update ()
    {
        OnMouseEnter();
        OnMouseExit();
	}

    void OnMouseEnter()
    {
        hoverText.color = Color.magenta;
    }

    void OnMouseExit()
    {
        hoverText.color = Color.white;
    }
}
