using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlackTankShooting : MonoBehaviour
{
    private float timercount = 0.0f;
    private float speed = 0.5f;//弾速度
    public Rigidbody enemy_Shell;
    public Transform enemy_FireTransform;
    public float mLaunchForce = 15f;
    private float moveX = 0f;
    private float moveY = 0f;
    private float moveZ = 0f;
    private Vector3 lastVelocity;//速度ベクトル
    private Rigidbody rb;//Rigidbody用
    private int time = 0;

    void Start()
    {
       
  
      
    }

    // Update is called once per frame
    void Update()
    {
        timercount += Time.deltaTime;
        if (timercount > 4.0f)
        {
            fire();
        }
    }
    /*
    private void FixedUpdate()
    {
        this.lastVelocity = this.rb.velocity;
    }*/

    void fire()
    {
        Rigidbody shellInstance = Instantiate(enemy_Shell, enemy_FireTransform.position, enemy_FireTransform.rotation) as Rigidbody;
        shellInstance.velocity = mLaunchForce * enemy_FireTransform.forward * 2;
        timercount = 0;
    }



    /*
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Cube")//壁と当たった時
        {
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
        }
        if (coll.gameObject.tag == "Cube_Destroy")//破壊出来る壁に当たった時
        {
            Destroy(coll.gameObject);//壁削除
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
        }
        if (coll.gameObject.tag == "Player_Cube")//プレイヤーと当たった時
        {
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
            //Laser_Create.collision = 1;//赤く光らせる用
        }
        
    }*/
}
