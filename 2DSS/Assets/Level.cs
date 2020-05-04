using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [Header("下一關的名稱")]
    public string NextSceneName;
    public void NextScene()
    {
        //如果場景名稱為Menu
        if (NextSceneName == "Menu")
        {
            //Destroy刪除物件
            Destroy(GameObject.Find("Bgm").gameObject);
        }
        if (NextSceneName == "Movie")
        {
            //GameObject.Find(物件名稱).SetActive判斷物件是否要開啟
            //GameObject.Find("Bgm").SetActive(false);
            //GameObject.Find(物件名稱GetComponent<元件名稱>()
            GameObject.Find("Bgm").GetComponent<AudioSource>().enabled = false;
        }
        if (NextSceneName == "Game")
        {
            GameObject.Find("Bgm").GetComponent<AudioSource>().enabled = true;
        }

            Application.LoadLevel(NextSceneName);
    }
       
    
}
