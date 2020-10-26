using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDestroyCount : MonoBehaviour
{
    static public int DestroyedEnemyCount = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyedEnemyCount >= 3)
        {
            Debug.Log("over");
            SceneManager.LoadScene("WinResultScene");
        }   
    }
}
