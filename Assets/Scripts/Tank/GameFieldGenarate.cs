using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFieldGenarate : MonoBehaviour
{

    int randomFieldChoose;
    public GameObject FieldChoose1;
    public GameObject FieldChoose2;
    public GameObject FieldChoose3;

    void Start()
    {
        randomFieldChoose =  Random.Range(0, 3);

        if (randomFieldChoose == 0)
        {
            Instantiate(FieldChoose1, new Vector3(0,0,0), Quaternion.identity);
        }
        else if(randomFieldChoose == 1)
        {
            Instantiate(FieldChoose2, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (randomFieldChoose == 2)
        {
            Instantiate(FieldChoose3, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
