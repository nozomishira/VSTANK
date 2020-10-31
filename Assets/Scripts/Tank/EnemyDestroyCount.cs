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
    //public GameObject Tank;
    int Level;

    void Start()
    {
        int level = PlayerPrefs.GetInt("LEVEL");
        Level = level;
        DestroyedEnemyCount = 0;
        //Instantiate(Tank, new Vector3(-10.3f, 0.0f, -11.12f), Quaternion.identity);

        if (level==1)
        {
            Instantiate(EnemyWhite, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 2)
        {
            Instantiate(EnemyRed, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 3)
        {
            Instantiate(EnemyRed, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyWhite, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 4)
        {
            Instantiate(EnemyRed, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 5)
        {
            Instantiate(EnemyBlack, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 6)
        {
            Instantiate(EnemyBlack, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyRed, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 7)
        {
            Instantiate(EnemyBlack, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 8)
        {
            Instantiate(EnemyGold, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 9)
        {
            Instantiate(EnemyGold, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyGold, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyBlack, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }
        else if (level == 10)
        {
            Instantiate(EnemyGold, new Vector3(-10.6f, 0.0f, 10.1f), Quaternion.identity);
            Instantiate(EnemyGold, new Vector3(11.4f, 0.0f, 14.8f), Quaternion.identity);
            Instantiate(EnemyGold, new Vector3(13.4f, 0.0f, -9.5f), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if ((Level == 10)||(Level==9))
        {
            if (DestroyedEnemyCount > 4)
            {
                //Debug.Log("over");
                SceneManager.LoadScene("WinResultScene");
            }
        }else if (Level == 8)
        {
            if (DestroyedEnemyCount > 3)
            {
                //Debug.Log("over");
                SceneManager.LoadScene("WinResultScene");
            }
        }
        else
        {
            if (DestroyedEnemyCount >= 3)
            {
                //Debug.Log("over");
                SceneManager.LoadScene("WinResultScene");
            }
        }
    }
}
