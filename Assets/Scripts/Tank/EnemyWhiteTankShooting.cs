using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWhiteTankShooting : MonoBehaviour
{

    private float timercount = 0.0f;
    public Rigidbody enemy_Shell;
    public Transform enemy_FireTransform;
    public float mLaunchForce = 15f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timercount += Time.deltaTime;
        if(timercount > 4.0f)
        {
            fire();
        }
    }

    private void fire()
    {
       
        Rigidbody shellInstance = Instantiate(enemy_Shell, enemy_FireTransform.position, enemy_FireTransform.rotation) as Rigidbody;
        shellInstance.velocity = mLaunchForce * enemy_FireTransform.forward * 2;
        timercount = 0;
    }
}
