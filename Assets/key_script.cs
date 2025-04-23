using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_script : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    }
  
    
}
