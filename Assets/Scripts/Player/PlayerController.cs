using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput input;
    private InputAction shootAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnEnable()
    {
        
    }

    void OnDisable()
    {
        
    }
}
