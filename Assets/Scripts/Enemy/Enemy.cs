using UnityEngine;
using System;
using System.Collections;
public class Enemy : MonoBehaviour
{
    public Action killed;

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
