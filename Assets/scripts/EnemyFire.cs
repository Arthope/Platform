using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    [SerializeField] int _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player Player))
        {
              Player.ApplyDamage(_damage);
        }

        Die();
    }


    private void Die()
    {
        Destroy(gameObject);
    }
}
