using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class observer : MonoBehaviour
{
    public Transform player;
    public ending end;
    bool playerInRange=false;
    void OnTriggerEnter(Collider other)
    {
        if(other.transform==player)playerInRange=true;
    }
    void OnTriggerExit(Collider other)
    {
        if(other.transform==player)playerInRange=false;
    }
    void Update()
    {
        if(playerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray= new Ray(transform.position,direction);
            RaycastHit raycasthit;
            if(Physics.Raycast(ray,out raycasthit))
            {
                if(raycasthit.collider.transform==player)end.CaughtPlayer();
            }
        }
    }
}
