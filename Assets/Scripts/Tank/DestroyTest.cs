using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerShell")
        {
            Debug.Log("destroy");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerShell")
        {
            Debug.Log("destroy");
            Destroy(this.gameObject);
        }
    }
}
