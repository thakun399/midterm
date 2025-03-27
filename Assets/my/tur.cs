using UnityEngine;

public class tur : MonoBehaviour
{
    public Transform turret;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    public float turretRotationSpeed = 80f;
    public float fireRate = 2f; // ค่าคูลดาวน์ 2 วินาที
    private float nextFireTime = 0f;

    void Update()
    {
        // หันป้อมปืนตามเมาส์
        float mouseX = Input.GetAxis("Mouse X") * turretRotationSpeed * Time.deltaTime;
        turret.Rotate(0, mouseX, 0);

        // ยิงกระสุนเมื่อกดคลิกซ้ายและผ่านคูลดาวน์แล้ว
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.forward * bulletSpeed;
    }
}