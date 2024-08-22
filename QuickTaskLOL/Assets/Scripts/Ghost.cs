using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float vertical;
    private bool colliding = false;
    public bool swap = false;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + vertical, transform.position.z);
        if (swap)
        {
            if (Input.GetKeyDown(KeyCode.E) && !colliding)
            {
                Vector3 origin = transform.position;

                transform.position = player.transform.position;
                player.transform.position = origin;


            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        colliding = true;
    }

    private void OnTriggerExit(Collider other)
    {
        colliding = false;
    }
}
