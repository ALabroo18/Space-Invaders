// using System.Numerics;
using UnityEngine;
using UnityEngine.Pool;

public class Enemies : MonoBehaviour
{
    public Enemy[] enemies;

    [SerializeField] int rows = 5;
    [SerializeField] int columns = 11;

    [SerializeField] private float speed;
    private Vector3 direction = Vector2.right;
    private void Awake()
    {
        // Set position of all enemies
        for (int row = 0; row < rows; row++)
        {   
            float width = 2.0f * (columns - 1);
            float height = 2.0f * (rows - 1);
            Vector2 center = new Vector2(-width/2, -height /2 );
            Vector3 rowPosition = new Vector3(center.x, center.y +( row* 2.0f), 0.0f);
            
            for(int col = 0; col < columns; col++)
            {
                Enemy enemy = Instantiate(enemies[row], transform);
                enemy.killed += OnKilled;
                Vector3 position = rowPosition; 
                position.x += col * 2.0f;
                enemy.transform.localPosition = position;
            }
            
            // Vector2 cent
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += direction * speed * Time.deltaTime;

        // Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        // Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        // foreach(Transform enemy in transform)
        // {
        //     if(!enemy.gameObject.activeInHierarchy)
        //     {
        //         Debug.Log("entered");
        //         continue;
        //     }
                

        //     if(direction == Vector3.right && enemy.position.x >= (rightEdge.x - 1.0f))
        //         ChangeDirection();
            
        //     if(direction == Vector3.left && enemy.position.x <= (rightEdge.x + 1.0f))
        //         ChangeDirection();
                
        // }
    }


        private void ChangeDirection()
        {
            direction.x *= 1.0f;
            Vector3 position = transform.position;
            position.y -= 1.0f;
            transform.position = position;
        }

        private void OnKilled()
    {
        
    }
}
