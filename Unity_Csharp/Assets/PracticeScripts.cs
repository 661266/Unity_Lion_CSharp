using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PracticeScripts : MonoBehaviour
{
    //封裝欄位
    //1.私人欄位
    private float hp;
    //2.屬性:讀寫或唯獨
    public float Hp { get => sliderHP.value; set => hp = value; }
    [Header("滑桿")]
    public Slider sliderHP;
    [Header("滑桿結果")]
    public Text result;

    [Header("輸入欄位")]
    public InputField inputField;
    [Header("輸入欄位結果")]
    public Text resultInputField;

    [Header("方塊")]
    public GameObject cube;

    private void Start()
    {
        #region 練習3
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos = new Vector3(i * 2, j * 2, 0);
                Instantiate(cube, pos, Quaternion.identity);
            }

        }
        #endregion

    }
    private void Update()
    {
        #region 練習1
        if (Hp <= 30)
        {
            result.text = "危險";

        }
        else if (Hp <= 70)
        {
            result.text = "警告";
        }
        else 
        {
            result.text = "安全";
        }
        #endregion

        #region 練習2
        //輸入欄位結果.文字 = 如果 輸入 == 紅水，恢復血量 : 如果 輸入 == 藍水 ? 恢復魔力: "";
        resultInputField.text = inputField.text == "紅水" ? "恢復血量" : inputField.text == "藍水" ? "恢復魔力" : "錯誤的資料";
        #endregion
    }


    

   

}
