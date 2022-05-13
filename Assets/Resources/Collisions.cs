using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{
    public ParticleSystem Particulas;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Debug.Log("CAPTURED");
            Instantiate(Particulas, transform.position, transform.rotation);
        }
    }

}
