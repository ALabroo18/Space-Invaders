using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Input System varibles
    private PlayerInput input;
    private InputAction shootAction;

    // Speed variables
    public float moveSpeed;
    // For position and movement
    private Vector2 moveInput;
    private Rigidbody2D rb2d;

    // Laser
    public Laser laser;
    public Transform laserLocation;
    private bool isActive = false;


    // public InputAction moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<PlayerInput>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {
    }

    // Update is called once per frame
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
        // StartCoroutine(WaitSeconds(2));
        if(isActive == false)
        {
            laser = Instantiate(laser, laserLocation.position, Quaternion.identity);
            isActive = true;
            laser.destroyed += EnableShooting;



        }
        


    }

    private void EnableShooting()
    {
        isActive = false;
    }


    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        
    }

    IEnumerator WaitSeconds (int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
