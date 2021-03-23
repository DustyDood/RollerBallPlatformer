using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpeed : MonoBehaviour
{
    private PlayerController player;
    public GameObject cm1;
    public GameObject cm2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.attachedRigidbody.AddForce(new Vector3(0f, 0f, 1800f));
            cm1.SetActive(false);
            cm2.SetActive(true);
        }
    }
}
