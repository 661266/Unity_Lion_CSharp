using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Far : Ground
{
    [Header("停止距離"), Range(0, 10)]
    public float stopDistance;
    [Header("丟物品")]
    public GameObject prop;
    [Header("丟擲CD"), Range(0, 5)]
    public float cd;
    [Header("死亡時間"), Range(3, 7)]
    public float deadTime;
    [Header("傷害直"), Range(10, 500)]
    public float damage;

    /// <summary>
    /// 目標物件
    /// </summary>
    private Transform target;
    /// <summary>
    /// 計時器
    /// </summary>
    private float timer;

    /// <summary>
    /// 繪製圖示的事件:在Scene繪製圖示,遊戲內不會顯示
    /// </summary>
    private void OnDrawGizmos()
    {
        //圖示.顏色 = 顏色 (紅,綠,藍,透明)
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        //圖示.繪製線條(起點,終點)
        Gizmos.DrawLine(transform.position, transform.position + transform.right * stopDistance);

    }
    private void Start()
    {
        target = GameObject.Find("房子").transform; //遊戲物件.尋找("物件名稱").變形元件
    }
    protected override void Update()
    {
        base.Update();
        Throw();
    }
    private void Throw()
    {
        //距離=三維向量.距離(此物件座標,目標座標)
        float dis = Vector3.Distance(transform.position, target.position);
        //如果 距離 <= 停止距離
        if (dis <= stopDistance)
        {
            speed = 0; //移動速度=0

            timer += Time.deltaTime; //計時
            //如果 計時欠 >=CD
            if (timer >= cd)
            {
                timer = 0; //計時器 歸零
                           //生成(丟物品,中心點+右邊+上方,角度)
                GameObject temp = Instantiate(prop, transform.position + transform.right * 0.7f + transform.up * 0.5f, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(600, 200));
                temp.GetComponent<ThrowObject>().damage = damage;
            }
            Invoke("Explosion", deadTime); //延遲呼叫方法("方法名稱,延遲時間")
        }
    }

}
