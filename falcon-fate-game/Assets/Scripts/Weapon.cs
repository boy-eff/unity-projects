using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    #region Fields

    private int damage;
    private float reload;

    #endregion

    #region Constructor

    public Weapon(int damage, float reload)
    {
        this.damage = damage;
        this.reload = reload;
    }

    #endregion

    #region Properties

    public int Damage
    {
        get { return damage; }
    }

    public float Reload
    {
        get { return reload; }
    }

    #endregion
}
