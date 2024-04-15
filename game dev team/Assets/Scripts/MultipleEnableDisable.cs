using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleEnableDisable : MonoBehaviour
{
    [Header("Set this to the objects you want to Enable")]
    public List<GameObject> ObjectsToEnable;

    [Header("Set this to the objects you want to Disable")]
    public List<GameObject> ObjectsToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HandTag"))
        {
            foreach (GameObject obj in ObjectsToEnable)
            {
                obj.SetActive(true);
            }

            foreach (GameObject obj in ObjectsToDisable)
            {
                obj.SetActive(false);
            }
        }
    }
}
