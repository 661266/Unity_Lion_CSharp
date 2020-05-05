
using UnityEngine;
using UnityEngine.UI;

public class suraimu : MonoBehaviour
{
    public int suraimuhealing = (10);
    public int suraimuHP = (100);
    public int suraimuATK = (10);
    public int batHP;
    public bat bat1;
    [Header("文字:訊息顯示")]
    public Text result;


    public void Attack()
    {
        bat1.Hurt(suraimuATK);


    }

    public void Hurt(int batATK)
    {
        suraimuHP -= batATK;
        result.text = (gameObject.name + "受傷:" + batATK + "\n" + gameObject.name + "血量於:" + suraimuHP);

    }
    public void Add()
    {
        suraimuHP += suraimuhealing;
        result.text = (gameObject.name + "回復了:" + suraimuhealing + "\n" + gameObject.name + "血量於:" + suraimuHP);

    }



}
