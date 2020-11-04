using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFieldGenarate : MonoBehaviour
{

    int randomFieldChoose;
    public GameObject FieldChoose1;
    public GameObject FieldChoose2;
    public GameObject FieldChoose3;
    public GameObject FieldChoose4;
    public GameObject FieldChoose5;
    public GameObject slight;
    float LIntensity;

    void Start()
    {
        LIntensity = slight.GetComponent<Light>().intensity;
        randomFieldChoose =  Random.Range(0, 5);

        if (randomFieldChoose == 0)
        {
            Instantiate(FieldChoose1, new Vector3(0,0,0), Quaternion.identity);
            LIntensity = 0.5f;
            slight.GetComponent<Light>().intensity = LIntensity;
        }
        else if(randomFieldChoose == 1)
        {
            Instantiate(FieldChoose2, new Vector3(0, 0, 0), Quaternion.identity);
            LIntensity = 0.5f;
            slight.GetComponent<Light>().intensity = LIntensity;
        }
        else if (randomFieldChoose == 2)
        {
            Instantiate(FieldChoose3, new Vector3(0, 0, 0), Quaternion.identity);
            LIntensity = 0.5f;
            slight.GetComponent<Light>().intensity = LIntensity;
        }
        else if (randomFieldChoose == 3)
        {
            Instantiate(FieldChoose4, new Vector3(0, 0, 0), Quaternion.identity);
        }
        else if (randomFieldChoose == 4)
        {
            Instantiate(FieldChoose5, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
