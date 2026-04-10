using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
  public float range = 100.0f;
  public float damage = 25.0f;
  public Camera FPSCamera;
  public LayerMask shootingLayer;
  public ParticleSystem muzzleFlash;

  void Update()
  {
    if (Input.GetButtonDown("Fire1"))
    {
      Shoot();
    }
  }

  void Shoot()
  {
    muzzleFlash.Play();
    AudioManager.instance.PlaySound("Shotgun");
    RaycastHit hit;
    if (Physics.Raycast(FPSCamera.transform.position, FPSCamera.transform.forward, out hit, range, shootingLayer))
    {
      Debug.DrawRay(FPSCamera.transform.position, FPSCamera.transform.forward * range, Color.red, 2.0f);
      
      IDamageable damageable = hit.transform.GetComponent<IDamageable>();
      if (damageable != null)
      {
        damageable.TakeDamage(damage);
      }
    }
  }
}

public interface IDamageable
{
  void TakeDamage(float damageAmount);
}
