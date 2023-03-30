using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputReader input;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float fireRate = 0.5f;
    [SerializeField] int maxAmmo = 10;
    [SerializeField] float reloadTime = 1f;

    [SerializeField] float dashSpeed = 10f; // dash speed
    [SerializeField] float dashTime = 0.5f; // duration of dash in seconds
    [SerializeField] float dashCooldownTime = 0f;


    // Input
    private Vector2 _moveDirection;
    private Vector3 _dashDirection;
    [SerializeField]private bool _isShooting, _dashButtonClicked,_isReloading;
    private float _nextFireTime = 0f;
    private float _dashCooldownTimeLeft = 0f;
    private int _currentAmmo;
    [SerializeField]private bool _reloading, 
    _canDash = true;




    private Rigidbody2D _rb;

    // Different Inputs Handle
    private void HandleMove(Vector2 dir) => _moveDirection = dir;

    private void HandleShoot() => _isShooting = true;

    private void HandleCancelShoot() => _isShooting = false;

    private void HandleReload() => _reloading = true;

    private void HandleDash() => _dashButtonClicked = true;

    void Start()
    {
        _currentAmmo = maxAmmo;
        _rb = GetComponent<Rigidbody2D>();
        input.MoveEvent += HandleMove;
        input.shootEvent += HandleShoot;
        input.reloadEvent += HandleReload;
        input.shootCancelEvent += HandleCancelShoot;
        input.dashEvent += HandleDash;
    }

    private void Update()
    {
        Move();
        ShootLogic();
        DashLogic();
    }

    private void Move()
    {
        if (_moveDirection == Vector2.zero)
            return;

        Vector2 movement = new Vector2(_moveDirection.x, _moveDirection.y);
        movement = movement.normalized * moveSpeed * Time.deltaTime;
        _rb.MovePosition(_rb.position + movement);
    }

    void ShootLogic(){
        //This Shoot feature will be implimented in a gun later
        if (_reloading)
        {
            if (_currentAmmo < maxAmmo && !_isReloading)
            {
                StartCoroutine(Reload());
            }
            _reloading = false;
        }
        else if (_isShooting && Time.time > _nextFireTime && _currentAmmo > 0 && !_isReloading)
        {
            _nextFireTime = Time.time + fireRate;
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
        _currentAmmo--;
    }
    IEnumerator Reload()
    {
        _isReloading = true;
        yield return new WaitForSeconds(reloadTime);
        _currentAmmo = maxAmmo;
        _isReloading = false;
    }

 void DashLogic(){
// maybe th same logic as shoot
if(_dashButtonClicked && _canDash ){
    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
    _dashDirection = (mousePos - currentPosition).normalized;
    StartCoroutine(Dash());
}
 }

    IEnumerator Dash(){
        _canDash = false;
        float dashTimer = 0f;
        while(dashTimer < dashTime){
            transform.position += _dashDirection * dashSpeed * Time.deltaTime;
            dashTimer += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(dashCooldownTime);
        _dashButtonClicked = false;
        _canDash = true;

    }
}

// dash mechanics

//  public float dashSpeed = 10f;
//     public float dashTime = 0.5f;
//     public float dashCooldown = 1f;

//     private bool canDash = true;
//     private Vector3 dashDirection;

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0) && canDash)
//         {
//             Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//             dashDirection = (mousePos - transform.position).normalized;
//             StartCoroutine(Dash());
//         }
//     }

//     IEnumerator Dash()
//     {
//         canDash = false;
//         float dashTimer = 0f;

//         while (dashTimer < dashTime)
//         {
//             transform.position += dashDirection * dashSpeed * Time.deltaTime;
//             dashTimer += Time.deltaTime;
//             yield return null;
//         }

//         yield return new WaitForSeconds(dashCooldown);
//         canDash = true;
//     }