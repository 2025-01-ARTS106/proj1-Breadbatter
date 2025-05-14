using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class key_script : MonoBehaviour
{
    
    public GameObject BridgeCube;
    public TMP_Text myText; 
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false); 

        if (BridgeCube != null) 
        {
            
            MeshRenderer bridgeRenderer = BridgeCube.GetComponent<MeshRenderer>();
            if (bridgeRenderer != null)
            {
                bridgeRenderer.enabled = true;
            }
            else
            {
                Debug.LogWarning("BridgeCube is missing a MeshRenderer component.");
            }

           
            BoxCollider bridgeCollider = BridgeCube.GetComponent<BoxCollider>();
            if (bridgeCollider != null)
            {
                bridgeCollider.enabled = true;
            }
            else
            {
                Debug.LogWarning("BridgeCube is missing a BoxCollider component.");
            }
        }
        else
        {
            Debug.LogError("BridgeCube GameObject is not assigned in the Inspector!");
        }

       
        if (myText != null)
        {
            myText.text = "1";
        }
        else
        {
            Debug.LogWarning("myText Text component is not assigned in the Inspector!");
        }
    }
}
