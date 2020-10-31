using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{
    int levelSetting;
    

    // Start is called before the first frame update
    void Start()
    {
        EnemyDestroyCount.DestroyedEnemyCount=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickLevel1()
    {
        levelSetting = 1;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel2()
    {
        levelSetting = 2;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel3()
    {
        levelSetting = 3;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel4()
    {
        levelSetting = 4;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }
    public void onClickLevel5()
    {
        levelSetting = 5;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel6()
    {
        levelSetting = 6;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel7()
    {
        levelSetting = 7;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel8()
    {
        levelSetting = 8;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel9()
    {
        levelSetting = 9;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

    public void onClickLevel10()
    {
        levelSetting = 10;
        PlayerPrefs.SetInt("LEVEL", levelSetting);
        PlayerPrefs.Save();

        SceneManager.LoadScene("SampleScene");
    }

}
