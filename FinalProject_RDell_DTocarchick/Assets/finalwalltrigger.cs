using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalwalltrigger : MonoBehaviour
{
    public GameObject chooseObject;
    public GameObject Wallremoval;
    public GameObject lightout;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject == chooseObject)
        {

            Debug.Log("Player Leaving Game!! GEORGE BE SAFE OUT THERE");
            this.gameObject.SetActive(false);
            Wallremoval.SetActive(false);
            lightout.SetActive(true);
        }
    }
}
