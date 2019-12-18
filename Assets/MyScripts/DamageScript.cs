using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] float damageAmount = 10;

    private void OnCollisionEnter(Collision collision)
    {
        HealthScript health = collision.gameObject.GetComponent<HealthScript>();
        if (health)
        {
            health.ApplyDamage(damageAmount);            
        }
    }
}
