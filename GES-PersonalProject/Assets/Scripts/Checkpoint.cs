using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    [SerializeField]
    private Color inactivatedColor, activatedColor;

    private bool isActivated = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateColor();
    }

    private void UpdateColor()
    {
        Color color = inactivatedColor;

        if (isActivated)
            color = activatedColor;

        spriteRenderer.color = color;
    }

    public void SetIsActivated(bool value)
    {
        isActivated = value;
        UpdateColor();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player entered the checkpoint.");
            CharacterController player = collision.GetComponent<CharacterController>();
            player.SetCurrentCheckpoint(this);
        }
    }
}
