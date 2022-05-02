using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public float health = 100f;

    public GameObject deadBody;

    public bool created = false;

    public void ApplyDamage(float amount)
    {
        health -= Mathf.Abs(amount);

        if (health <= 0)
        {
            if (!created)
            {
                Instantiate(deadBody, transform.position, transform.localRotation);
                created = true;
            }
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
