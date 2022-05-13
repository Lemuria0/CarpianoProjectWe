using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawn : MonoBehaviour
{
    public GameObject imageSpawn;
    public Vector3 Vectorwe;
    void Start()
    {
       Vectorwe = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.2f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            Debug.Log("CAPTURED");
            Instantiate(imageSpawn, Vectorwe, transform.rotation);
        }
    }

}
