using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
    [Header("下一關的名稱")]
    public string NextSceneName;
    public int LevelID;
    public Text Leveltext;
    [Header("設定每個關卡最高得分數")]
    public float SetHeightScore;
    //儲存每個關卡最高得分
    string SaveHeightScore = "SaveHeightScore";
    string SaveLevelID = "SaveLevelID";
    //int memeVale;
    //紀錄要開幾的關卡數量
    static public int OpenLevelID= 1;
    //抓取所有Level的關卡按鈕
    public GameObject[] LevelButton;
    private void Start()
    {
        if (Application.loadedLevelName=="Level"&&GetComponentInChildren<Text>() != null)
        {
            //抓去子物件
            Leveltext = GetComponentInChildren<Text>();
            //字串轉整數值
            LevelID = int.Parse(Leveltext.text);
        }
        //自動抓取TAG為LoadLevel的按鈕放入陣列中
        LevelButton = GameObject.FindGameObjectsWithTag("LevelButton");
        //利用For迴圈開啟按鈕
        for (int i = 0; i <= OpenLevelID-1; i++) { 
            LevelButton[i].GetComponent<Button>().interactable = true;
        }

    }

    public void NextScene()
    {
       /* //如果場景名稱為Menu
        if (NextSceneName == "Menu")
        {
            //Destroy刪除物件
            Destroy(GameObject.Find("Bgm").gameObject);
        }
        */
        if (NextSceneName == "Movie")
        {
            PlayerPrefs.SetFloat(SaveLevelID,LevelID);
            //跳關卡到Game畫面，先將每個關卡最高得分儲存
            PlayerPrefs.SetFloat(SaveHeightScore + LevelID, SetHeightScore);
            //GameObject.Find(物件名稱).SetActive判斷物件是否要開啟
            //GameObject.Find("Bgm").SetActive(false);
            //GameObject.Find(物件名稱GetComponent<元件名稱>()
            GameObject.Find("Bgm").GetComponent<AudioSource>().enabled = false;
        }
        if (NextSceneName == "Game")
        {

            //GameObject.Find("Bgm").SetActive(true);
            GameObject.Find("Bgm").GetComponent<AudioSource>().enabled = true;
        }

            Application.LoadLevel(NextSceneName);
    }
       
    
}
