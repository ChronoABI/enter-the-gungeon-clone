using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private InputReader input;

    [SerializeField]
    private float moveSpeed = 5f;

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private float bulletSpeed = 10f;

    [SerializeField]
    private float fireRate = 0.5f;

    [SerializeField]
    private int maxAmmo = 10;

    [SerializeField]
    private float reloadTime = 1f;

    // Input
    private Vector2 _moveDirection;
    private bool _isShooting;
    private bool _reload = false;

    private bool isReloading = false;
    private float nextFireTime = 0f;
    private int currentAmmo;

    private Rigidbody2D rb;

    // Different Handle Inputs
    private void HandleMove(Vector2 dir) => _moveDirection = dir;

    private void HandleShoot() => _isShooting = true;

    private void HandleCancelShoot() => _isShooting = false;

    private void HandleReload() => _reload = true;

    void Start()
    {
        currentAmmo = maxAmmo;
        rb = GetComponent<Rigidbody2D>();
        input.MoveEvent += HandleMove;
        input.shootEvent += HandleShoot;
        input.reloadEvent += HandleReload;
        input.shootCancelEvent += HandleCancelShoot;
    }

    private void Update()
    {
        Move();

        //This Shoot feature will be implimented in a gun later
        if (_reload)
        {
            if (currentAmmo < maxAmmo && !isReloading)
            {
                StartCoroutine(Reload());
            }
            _reload = false;
        }
        else if (_isShooting && Time.time > nextFireTime && currentAmmo > 0 && !isReloading)
        {
            nextFireTime = Time.time + fireRate;
            Shoot();
        }
    }

    private void Move()
    {
        if (_moveDirection == Vector2.zero)
            return;

        Vector2 movement = new Vector2(_moveDirection.x, _moveDirection.y);
        movement = movement.normalized * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void Shoot()
    {
        Debug.Log(message: "shooting");
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
        currentAmmo--;
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
    }
}
