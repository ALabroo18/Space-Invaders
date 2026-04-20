using UnityEngine;
using System;

public class Laser : MonoBehaviour
{

    // private Rigidbody2D rb2d;

    [SerializeField] private float moveSpeed;
    [SerializeField] Vector3 direction;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] float lifetime = 2f;

    private float lifeTimer = 0f;

    public Action destroyAction;
    //void Start()
    //{
    // rb2d = GetComponent<Rigidbody2D>();

    //}

    // private Transform location;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnEnable()
    {
        lifeTimer = 0f;
    }

    private void OnDisable()
    {
        lifeTimer = -1f;
    }

    void Update()
    {
        transform.position +=  moveSpeed * Time.deltaTime * direction;

        if (lifeTimer > -1f && lifeTimer >= lifetime)
        {
            Disable();
        }
        else
        {
            lifeTimer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collision's layer is in the enemy LayerMask
        if ((enemyMask.value & 1<< other.gameObject.layer) != 0)
        {
            Disable();
        }
    }

    private void Disable()
    {
        destroyAction?.Invoke();
        gameObject.SetActive(false);
    }
}
