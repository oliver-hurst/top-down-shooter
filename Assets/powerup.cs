using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class powerup : MonoBehaviour
{
    [SerializeField] int healthAmount = 25;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TopDownCharacterController characterController = collision.GetComponent<TopDownCharacterController>();

            characterController.takedamage(-healthAmount);

            Destroy(gameObject);
        }
    }
}
