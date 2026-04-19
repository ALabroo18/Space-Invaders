using UnityEngine;
using System;
using System.Collections;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("In");
        if(other.gameObject.layer == LayerMask.NameToLayer("Laser"))
        {
            killed.Invoke();
            this.gameObject.SetActive(false);
        }
        // StartCoroutine(WaitSeconds());
    }

    private IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(5f);
        this.gameObject.SetActive(true);
    }
}
