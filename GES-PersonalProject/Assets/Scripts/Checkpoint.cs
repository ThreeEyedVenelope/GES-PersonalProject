using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    /*[SerializeField]
    private Color inactivatedColor, activatedColor;*/

    [SerializeField]
    private float inactivatedScale = 1, activatedScale = 1.5f;

    private bool isActivated = false;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //UpdateColor();
    }

    /*private void UpdateColor()
    {
        Color color = inactivatedColor;

        if (isActivated)
            color = activatedColor;

        spriteRenderer.color = color;
    }*/

    private void UpdateScale()
    {
        float scale = inactivatedScale;
        if (isActivated)
            scale = activatedScale;

        transform.localScale = Vector3.one * scale;
    }

    public void SetIsActivated(bool value)
    {
        isActivated = value;
        UpdateScale();
        //UpdateColor();
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
