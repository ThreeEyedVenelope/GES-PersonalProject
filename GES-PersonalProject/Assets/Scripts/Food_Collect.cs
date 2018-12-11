using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food_Collect : MonoBehaviour
{
    public Text countText;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    private static int count = 0;
    public static string itemName = "";
    public static int itemCount = 0;

	// Use this for initialization
	private void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        SetCountText();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            count++;
            SetCountText();
            audioSource.Play();
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Destroy(gameObject, audioSource.clip.length);
        }
    }
	
    void SetCountText()
    {
        switch (this.gameObject.tag)
        {
            case "Beer":
                itemName = "Beer";
                itemCount = 3;
                break;
            case "Wine":
                itemName = "Wine";
                itemCount = 3;
                break;
            case "Whiskey":
                itemName = "Whiskey";
                itemCount = 3;
                break;
            case "Sake":
                itemName = "Sake";
                itemCount = 5;
                break;
            case "Cherry":
                itemName = "Cherry";
                itemCount = 4;
                break;
                
        }
        countText.text = itemName + " (" + count.ToString() + "/" + itemCount + ")";
            
    }
}
