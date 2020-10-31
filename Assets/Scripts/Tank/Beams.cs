using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Beams : MonoBehaviour
{
    float timer = 0.0f;
    float beamTimer = 0.0f;
    float effectDisplayTime = 0.2f;
    float range = 20.0f;
    Ray shotRay;
    RaycastHit shotHit;
    ParticleSystem beamParticle;
    LineRenderer lineRenderer;
    public GameObject GoldTankShoot;

    // Use this for initialization
    void Awake()
    {
        beamParticle = GetComponent<ParticleSystem>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        beamTimer += Time.deltaTime;

        if (beamTimer > 3.0)
        {
            shot();
            beamTimer = 0.0f;
        }
        
        if (timer >= effectDisplayTime)
        {
            disableEffect();
        }
    }

    private void shot()
    {
        timer = 0f;
        beamParticle.Stop();
        beamParticle.Play();
        lineRenderer.enabled = true;
        lineRenderer.SetPosition(0, GoldTankShoot.transform.position);
        shotRay.origin = GoldTankShoot.transform.position;
        shotRay.direction = transform.forward;
        /*
        int layerMask = LayerMask.GetMask("Player");
        int layerMask2 = LayerMask.GetMask("Thing");
        if (Physics.Raycast(shotRay, out shotHit, range, layerMask))
        {
            // hit
            SceneManager.LoadScene("LoseResultScene");
            //Destroy(shotHit.collider.gameObject);
        }
        
        if (Physics.Raycast(shotRay, out shotHit, range, layerMask2))
        {
            // hit 
            Destroy(shotHit.collider.gameObject);
        }*/

        RaycastHit[] hits = Physics.RaycastAll(shotRay, 20.0f);

        foreach (var obj in hits)
        {
            // 衝突したオブジェクトのタグ毎に色を変え、当てはまらない場合はオブジェクトを非アクティブにする
            switch (obj.collider.tag)
            {
                case "Player":
                    obj.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    Debug.Log("hit");//当たり判定を行う
                    EnemyDestroyCount.RemainTankCount--;
                    //SceneManager.LoadScene("LoseResultScene");
                    //Destroy(obj.collider.gameObject);
                    break;
                case "Thing":
                    obj.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
                    Destroy(obj.collider.gameObject);
                    break;
            }
        }
        lineRenderer.SetPosition(1, shotRay.origin + shotRay.direction * range);


    }

    private void disableEffect()
    {
        beamParticle.Stop();
        lineRenderer.enabled = false;
    }
}
