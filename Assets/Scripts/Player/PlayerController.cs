using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Transform laserLocation;
    [SerializeField] GameObject laser;

    // Laser reference
    private Laser laserComponent;

    // For position and movement
    private Vector2 moveInput;
    private Rigidbody2D rb2d;
    private bool isActive = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (laser != null) laserComponent = laser.GetComponent<Laser>();
        if (laserComponent != null) laserComponent.destroyAction += EnableShooting;
    }

    void Update()
    {
        rb2d.linearVelocity = moveSpeed * moveInput;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        moveInput = ctx.ReadValue<Vector2>();
    }

    public void Shoot(InputAction.CallbackContext ctx)
    {
        if(isActive == false)
        {
            laser.SetActive(true);
            laser.transform.position = laserLocation.position;
            isActive = true;
        }
    }

    private void EnableShooting()
    {
        isActive = false;
    }
}
