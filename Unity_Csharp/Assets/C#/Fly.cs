using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : Monster
{
    [Header("飛行範圍"), Range(1, 30)]
    public float range;

    /// <summary>
    /// 飛行
    /// </summary>
    private void FlyAway()
    {   //Time.timeSinceLevelLoad載入後的遊戲時間 從0增加
        //Mathf.Sin() 曲線
        transform.Translate(0, range * Time.deltaTime * Mathf.Sin(Time.timeSinceLevelLoad * 5), 0);
    }

    protected override void Update()
    {
        base.Update();
        FlyAway(); //保留父類別內容
    }

}







