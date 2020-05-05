
using UnityEngine;
using UnityEngine.UI;

public class bat : MonoBehaviour
{
    public int bathealing = (10);
    public int batHP = (100);
    public int batATK = (10);
    public int seraimuHP;
    [Header("文字:訊息顯示")]
    public Text result;
    

    public void Attack(string batatt)
    {
        print(gameObject.name + "蝙蝠攻擊" + batatt + "攻擊10");
        print("史萊姆受傷HP剩餘:"+ (batATK- seraimuHP));

    }




}






