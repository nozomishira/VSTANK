using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : MonoBehaviour
{
   public float enemySpeed = 1.0f;
    public GameObject targetObj;
    MeshRenderer targetMesh;
    MeshRenderer thisObjMesh;

    Coroutine coroutine;

    float x_Abs;
    float y_Abs;
    float z_Abs;

    [SerializeField] float speedParameter = 1.0f;

    void Start()
    {
        targetMesh = targetObj.GetComponent<MeshRenderer>();
        thisObjMesh = this.gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        x_Abs = Mathf.Abs(this.gameObject.transform.position.x - targetObj.transform.position.x);
        y_Abs = Mathf.Abs(this.gameObject.transform.position.y - targetObj.transform.position.y);
        z_Abs = Mathf.Abs(this.gameObject.transform.position.z - targetObj.transform.position.z);

        if (coroutine == null)
        {
            coroutine = StartCoroutine(MoveCoroutine());
        }
    }

    IEnumerator MoveCoroutine()
    {
        float speed = speedParameter * Time.deltaTime;

        while (x_Abs > 0 || y_Abs > 0 || z_Abs > 0)
        {

            yield return new WaitForEndOfFrame();
            this.transform.LookAt(targetObj.transform);
            this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, targetObj.transform.position, speed);
        }
        
    }

    
}
