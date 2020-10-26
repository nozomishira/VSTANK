using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyGoldTankShooting : MonoBehaviour
{
    public LayerMask mask;
    float timer = 0.0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 4.0f)
        {
            Ray();
            timer = 0.0f;
        }
    }

    void Ray()
    {

        // 1.
        // Rayの作成
        Ray ray = new Ray(transform.position, transform.forward);
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        // 2.		
        // Rayが衝突したコライダーの情報を得る
        RaycastHit hit;
        // Rayが衝突したかどうか
        if (Physics.Raycast(ray, out hit, 15.0f, mask))
        {
           
            // Examples
            // 衝突したオブジェクトの色を赤に変える
            hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
            // 衝突したオブジェクトを消す
            //Destroy(hit.collider.gameObject);
            // Rayの衝突地点に、このスクリプトがアタッチされているオブジェクトを移動させる
            this.transform.position = hit.point;
            // Rayの原点から衝突地点までの距離を得る
            float dis = hit.distance;
            // 衝突したオブジェクトのコライダーを非アクティブにする
            hit.collider.enabled = false;
        }

        // 3.		
        // Rayが衝突した全てのコライダーの情報を得る。＊順序は保証されない
        ///RaycastHit[] hits = Physics.RaycastAll(ray, Mathf.Infinity);
         RaycastHit[] hits = Physics.RaycastAll(ray, 15.0f);

        foreach (var obj in hits)
        {
            // 衝突したオブジェクトのタグ毎に色を変え、当てはまらない場合はオブジェクトを非アクティブにする
            switch (obj.collider.tag)
            {
                case "Player":
                    obj.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                    Debug.Log("hit");//当たり判定を行う
                    SceneManager.LoadScene("LoseResultScene");
                    //Destroy(obj.collider.gameObject);
                    break;
                case "Thing":
                    obj.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
                    Destroy(obj.collider.gameObject);
                    break;
            }
        }

        // 4.		
        // 球形のRayをとばす
        if (Physics.SphereCast(ray, 5.0f, out hit, 10.0f)) { }

        // 5.		
        // Rayの可視化
       // Debug.DrawRay(ray.origin, ray.direction, Color.red, 3.0f);
        Debug.DrawRay(ray.origin, ray.direction*15, Color.red, 3.0f,false);


    }
}
