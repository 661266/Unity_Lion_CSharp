using UnityEngine;

public class Practice6 : MonoBehaviour
{
    //欄位
    //存放類別和物件
    public SpriteRenderer kid;

    public Rigidbody ball;

    void Start()
    {
        //練習1 時間
        Time.timeScale = 2;

        //練習2
        kid.flipX = true;

        //練習3:靜態方法
        print(Mathf.Floor(1.23456f));

        ball.AddForce(0, 800, 1500);

    }
}
