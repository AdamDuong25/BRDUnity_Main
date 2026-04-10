using System;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
  public float health = 100.0f;
  public HealthBar healthBar;

  void Start()
  {
    healthBar.SetMaxHealth(health);
  }

  public void TakeDamage(float damageAmount)
  {
    health -= damageAmount;
    healthBar.SetHealth(health);
    if (health <= 0)
    {
      Destroy(gameObject);
    }
  }
}
