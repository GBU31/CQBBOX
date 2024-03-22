using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class Weapon_Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab; 
    public float bulletForce = 20f;
    public float fireRate = 0.5f;

    private bool canShoot = true;

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && canShoot)
        {
            StartCoroutine(ShootWithDelay()); 
        }
    }

    IEnumerator ShootWithDelay()
    {
        canShoot = false;

        Shoot();
        yield return new WaitForSeconds(fireRate);

        canShoot = true;
    }

    void Shoot()
    {
        Vector3 direction = (firePoint.position - Camera.main.transform.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.LookRotation(direction));

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(direction * bulletForce * 10 *  Time.deltaTime, ForceMode.Force);
        }
        else
        {
            Debug.LogError("Bullet prefab does not contain a Rigidbody component!");
        }
    }
}
