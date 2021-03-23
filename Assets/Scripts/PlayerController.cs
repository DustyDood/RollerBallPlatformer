using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Vector3 checkpointPosition;

    private Rigidbody rbd;
    private float moveHorizontal;
    private float moveVertical;
    
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        checkpointPosition = new Vector3(0f, 1.1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        rbd.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * speed);

        if (transform.position.y < -20)
        {
            transform.position = checkpointPosition;
            rbd.velocity = Vector3.zero;
            rbd.angularVelocity = Vector3.zero;
        }
    }
}
