using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celebration : MonoBehaviour
{
    public GameObject congratsText;
    public GameObject player;
    private Rigidbody rbd;

    private void Start()
    {
        rbd = player.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        congratsText.SetActive(true);
        rbd.isKinematic = true;
        rbd.velocity = Vector3.zero;
        rbd.angularVelocity = Vector3.zero;


    }
}
