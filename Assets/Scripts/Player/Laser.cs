using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using System;

public class Laser : MonoBehaviour
{

    // private Rigidbody2D rb2d;

    [SerializeField] private float moveSpeed;
    public Vector3 direction;

    public Action destroyed;

    public LayerMask enemyMask;
    void Start()
    {
        // rb2d = GetComponent<Rigidbody2D>();
        
    }

    // private Transform location;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        // rb2d.linearVelocity = transform.up * Time.deltaTime;
        transform.position +=  direction * moveSpeed * Time.deltaTime;

        // if(Physics2D.Raycast(transform.position, direction, 2f, enemyMask))
        // {
        //     Debug.Log("hi");
        // }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
        destroyed.Invoke();
    }
}
