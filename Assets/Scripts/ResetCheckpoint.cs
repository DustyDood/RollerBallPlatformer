using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCheckpoint : MonoBehaviour
{
    private PlayerController player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Testing");
        if (other.tag == "Player")
        {
            Debug.Log("Player recognized");
            player = other.GetComponent<PlayerController>();
            player.checkpointPosition = new Vector3(0f, 1.1f, 19.5f);
        }
    }
}
