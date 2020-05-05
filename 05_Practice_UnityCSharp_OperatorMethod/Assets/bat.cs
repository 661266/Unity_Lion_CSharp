
using UnityEngine;
using UnityEngine.UI;

public class bat : MonoBehaviour
{
    public int bathealing = (10);
    public int batHP = (100);
    public int batATK = (10);
    public suraimu suraimu1;
    [Header("文字:訊息顯示")]
    public Text result;
    

    public void Attack()
    {
        suraimu1.Hurt(batATK);


    }
    public void Hurt(int suraimuATK) 
    {
        batHP -= suraimuATK;
        result.text = (gameObject.name + "受傷:" + suraimuATK + "\n" + gameObject.name + "血量於:" + batHP);


    }



    public void Add()
    {
        batHP += bathealing;
        result.text = (gameObject.name + "回復了:" + bathealing + "\n" + gameObject.name + "血量於:" + batHP);
        
    }

    }






