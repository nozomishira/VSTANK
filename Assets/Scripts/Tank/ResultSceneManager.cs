using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickBackToStart()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void onClickBackToLevel()
    {
        SceneManager.LoadScene("LevelChooseScene");
    }
}
