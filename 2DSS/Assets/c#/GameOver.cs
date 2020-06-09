using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    //分數儲存欄位
    string SaveScore = "SaveScore";
    public Text ScoreText;
    string SaveHeightScore = "SaveHeightScore";
    string SaveLevelID = "SaveLevelID";
    public Text HeightScoreText;
    [Header("重新遊戲的按鈕")]
    public Button RegameButton;
    [Header("下一關的按鈕")]
    public Button NextButton;


    void Start()
    {
        ScoreText.text = "Score:" + PlayerPrefs.GetFloat(SaveScore);
        HeightScoreText.text = "Height Score" + PlayerPrefs.GetFloat(SaveHeightScore + PlayerPrefs.GetFloat(SaveLevelID));
        //如果目標分數>目前得分數=失敗
        if (PlayerPrefs.GetFloat(SaveHeightScore + PlayerPrefs.GetString(SaveLevelID))> PlayerPrefs.GetFloat(SaveScore))
        {
            NextButton.interactable = false;
        }
        //如果目標分數<目前得分數=成功
        else
        {
            NextButton.interactable = true;
        }
        //顯示滑鼠屬標
        Cursor.visible = true;
    }
    //下一關
    public void NextGame()
    {
        if (PlayerPrefs.GetFloat(SaveLevelID) >= Level.OpenLevelID)
        Level.OpenLevelID++;
        Application.LoadLevel("Level");
    }
    public void ReGame()
    {
        Application.LoadLevel("Game");
    }
    public void Menu()
    {
        Application.LoadLevel("Menu");
    }




    // Update is called once per frame
    void Update()
    {
        //設定九個關卡的最高得分數
        //如果第一筆最高分數=null,if得分<如果最高得分,挑戰失敗,開啟下一關>
        //如果第一筆最高分數=null,if得分<如果最高得分,挑戰成功,只有重新開始按鈕>
    }
}
