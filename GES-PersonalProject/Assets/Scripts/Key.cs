using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    // Use this for initialization
    void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        spriteRenderer.enabled = false;
        boxCollider2D.enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        CheckCollect();
	}

    void CheckCollect ()
    {
        if (Gem_Collect.count == 5 && Collect.count == 5)
        {
            spriteRenderer.enabled = true;
            boxCollider2D.enabled = true;
        }
    }
}
