using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDestroyCount : MonoBehaviour
{
    static public int DestroyedEnemyCount = 0;
    public GameObject EnemyWhite;
    public GameObject EnemyRed;
    public GameObject EnemyBlack;
    public GameObject EnemyGold;

    void Start()
    {
        int level = PlayerPrefs.GetInt("LEVEL");

        if (level==1)
        {
            Instantiate(EnemyWhite, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 2)
        {
            Instantiate(EnemyRed, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 3)
        {
            Instantiate(EnemyRed, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 4)
        {
            Instantiate(EnemyRed, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 5)
        {
            Instantiate(EnemyBlack, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 6)
        {
            Instantiate(EnemyBlack, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 7)
        {
            Instantiate(EnemyBlack, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 8)
        {
            Instantiate(EnemyGold, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 9)
        {
            Instantiate(EnemyGold, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyGold, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }
        else if (level == 10)
        {
            Instantiate(EnemyGold, new Vector3(-90.6f, 0.0f, 24.5f), Quaternion.identity);
            Instantiate(EnemyGold, new Vector3(-90.3f, 0.0f, -1.9f), Quaternion.identity);
            Instantiate(EnemyGold, new Vector3(-66.9f, 0.0f, -1.6f), Quaternion.identity);
        }

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
