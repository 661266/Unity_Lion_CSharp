
using UnityEngine;
using UnityEngine.UI;

public class seraimu : MonoBehaviour
{
    public int seraimuhealing = (10);
    public int seraimuHP = (100);
    public int seraimuATK = (10);
    public int batHP;
    [Header("文字:訊息顯示")]
    public Text result;
    public void Attack(string batatt)
    {
        print(gameObject.name + "史萊姆攻擊" + batatt + "攻擊10");
        print("蝙蝠受傷HP剩餘:" + (seraimuATK - batHP));

    }

}
