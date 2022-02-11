using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeWeapon : Weapon
{
    #region Fields

    private float attackSpeed;

    #endregion

    #region Constructor

    public MeleeWeapon(float attackSpeed, float reload, int damage) : base(damage, reload)
    {
        this.attackSpeed = attackSpeed;
    }

    #endregion

    #region Properties

    public float AttackSpeed
    {
        get { return attackSpeed; }
    }

    #endregion

}
