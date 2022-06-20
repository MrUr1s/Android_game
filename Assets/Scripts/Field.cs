using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    private void OnCollisionExit(Collision collision)
    {
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag== "Bullet")
            Destroy(other.gameObject);
    }
}
