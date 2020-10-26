using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingDestroy : MonoBehaviour
{
    int count = 0;
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
            //Debug.Log("destroy");
            count++;
        }
        if (collision.gameObject.tag == "EnemyShell")
        {
            //Debug.Log("destroy");
            count++;
        }
        if (count >= 3)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerShell")
        {
            // Debug.Log("destroy");
            count++;
        }
        if (other.gameObject.tag == "EnemyShell")
        {
            //Debug.Log("destroy");
            count++;
        }
        if (count >= 3)
        {
            Destroy(this.gameObject);
        }
    }
}
