using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Health health;

    // Start is called before the first frame update
    void Start()
    {
        health = new Health(100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health.SubtractHealth(damage);
        if (health.CurrentHealth == 0)
        {
            Destroy(gameObject);
        }
    }
}
