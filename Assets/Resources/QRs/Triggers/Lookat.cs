using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lookat : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("JUAN");
        transform.LookAt(target.transform.position);
        transform.Rotate(new Vector3(transform.rotation.x,transform.rotation.y + 180f, transform.rotation.z ));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


