using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem_Collect : MonoBehaviour {

    public Text countText;

    private AudioSource audioSource;

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    public static int count = 0;

	// Use this for initialization
	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
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
            animator.enabled = false;
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Destroy(gameObject, audioSource.clip.length);
        }
    }

    void SetCountText()
    {
        countText.text = "Gems (" + count.ToString() + "/5)";
    }
}
