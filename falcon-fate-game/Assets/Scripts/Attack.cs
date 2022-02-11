using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    bool isAttack;
    MeleeWeapon weapon;

    SpriteRenderer spriteRenderer = new SpriteRenderer();
    BoxCollider2D boxCollider;

    // Start is called before the first frame update
    void Start()
    {
        isAttack = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        weapon = new MeleeWeapon(2f, 1, 50);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !isAttack)
        {
            spriteRenderer.enabled = true;
            boxCollider.enabled = true;
            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
            isAttack = true;
        }
        if (isAttack)
        {
            gameObject.transform.Rotate(new Vector3(0, 0, -weapon.AttackSpeed));
            if (gameObject.transform.rotation.z < 0.000001)
            {
                isAttack = false;
                spriteRenderer.enabled = false;
                boxCollider.enabled = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(weapon.Damage);

        }
    }
}
