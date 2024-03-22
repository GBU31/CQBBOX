using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCOnHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Bullet hit me!");
        }
        else
        {
            Debug.Log("None Bullet");
        }
    }
}
