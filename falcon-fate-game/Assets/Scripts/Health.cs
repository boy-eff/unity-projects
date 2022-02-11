using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    #region Fields

    private int currentHealth;
    private int maxHealth;

    #endregion

    #region Constructor

    public Health(int health, int maxHealth)
    {
        this.currentHealth = health;
        this.maxHealth = maxHealth;
    }

    #endregion

    #region Properties

    public int CurrentHealth
    {
        get { return currentHealth; }
    }

    #endregion

    #region Methods

    public void AddHealth(int health)
    {
        if (this.currentHealth + health < maxHealth)
        {
            this.currentHealth += health;
        }
        else
        {
            this.currentHealth = maxHealth;
        }

    }

    public void SubtractHealth(int health)
    {
        if (currentHealth - health <= 0)
        {
            currentHealth = 0;
        }  
        else
        {
            currentHealth = currentHealth - health;
        }
    }

    #endregion


}
