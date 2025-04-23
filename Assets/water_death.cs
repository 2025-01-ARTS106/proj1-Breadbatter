using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_death : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.transform.position = new Vector3( 11f, 28f, 145f);

                
            }
        }
    }
}
