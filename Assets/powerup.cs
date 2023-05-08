using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class powerup : MonoBehaviour
{
    // Start is called before the first frame update
    public healthbar Healthbar;
    public int currenthealth;
    public int maxhealth = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (currenthealth < maxhealth)
        {
            Destroy(gameObject);
            currenthealth += 20;
            Debug .Log ("health");
            Healthbar.sethealth(currenthealth);
        }
    }
}
