using UnityEngine;
using System;
public class Enemy : MonoBehaviour
{
    public Action killed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("laser"))
        {
            killed.Invoke();
            this.gameObject.SetActive(false);
        }
    }
}
