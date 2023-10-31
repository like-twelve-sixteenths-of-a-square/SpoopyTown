using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumkimControlVeryScary : MonoBehaviour
{
    public Light pumpLight;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            pumpLight.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pumpLight.enabled = false;
        }
    }
}
