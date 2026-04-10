using System.Collections;
using UnityEngine;

public class Grenade : MonoBehaviour
{
  public float delay = 3.0f; // Delay for grenade's explosion.
  public float blastRadius = 5.0f; // Blast radius size.
  public float explosionForce = 700.0f; // How powerful the explosion is.
  public float damageAmount = 50.0f; // Grenade's damage.
  public LayerMask damageableLayer; // Layers affected by grenade.
  private bool hasExploded = false;

  void Start()
  {
    StartCoroutine(ExplodeAfterDelay());
  }

  IEnumerator ExplodeAfterDelay()
  {
    yield return new WaitForSeconds(delay);
    Explode();
  }

  void Explode()
  {
    if (hasExploded) return;

    Collider[] colliders = Physics.OverlapSphere(transform.position, blastRadius, damageableLayer);
    foreach (Collider nearbyObject in colliders)
    {
      Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
      if (rb != null)
      {
        rb.AddExplosionForce(explosionForce, transform.position, blastRadius);
      }
      IDamageable damageable = nearbyObject.GetComponent<IDamageable>();
      if (damageable != null)
      {
        damageable.TakeDamage(damageAmount);
      }
    }

    hasExploded = true;
    Destroy(gameObject);
  }

#if UNITY_EDITOR    
  private void OnDrawGizmosSelected()
  {
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(transform.position, blastRadius);
  }
#endif
}
