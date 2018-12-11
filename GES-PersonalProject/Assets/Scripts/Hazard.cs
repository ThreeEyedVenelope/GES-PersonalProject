using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player entered hazard.");
            CharacterController player = collision.GetComponent<CharacterController>();
            player.Respawn();
        }
        else
        {
            Debug.Log("Something other than the player entered the hazard.");
        }
    }

}
