using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    [Header("子彈多久被消滅")]
    public float DeleteTime;
    [Header("爆炸特效")]
    public GameObject Effect;
    [Header("爆炸音效")]
    public AudioSource EffectAudio;

    // Start is called before the first frame update
    void Start()
    {
        EffectAudio = GameObject.Find("explosion1").GetComponent<AudioSource>();
        //Destroy(要刪除物件(型態只能為GameObject),多久後物體被消滅);
        Destroy(gameObject, DeleteTime);
    }

    // Update is called once per frame
    void Update()
    {   //Vector3.Up=(0,1,0) Vector3.down=(0,-1,0),Vector3.forward=(0,1,0)
        //transform.Translate(0,speed,0);
        transform.Translate(Vector3.up * speed);
    }
    //穿透行碰撞方式 OnTriggerEnter,OnTriggerStay,OnTriggerExit
    //不穿透行碰撞 OnCollisionEnter,OnCollisionStay,OnCollisionExit
    //Enter兩個物件一碰撞,Function內的程式只執行一次
    //Stay兩個物件一碰撞,沒有分開Function內程式繼續執行到兩個物件分開
    //Exit兩個物件一碰撞且分開，Function內的程式只執行一次
    void OnTriggerEnter2D(Collider2D other)
    {
        //玩家子彈打到有Collider2D物件,就檢測該物體標籤是否為Enemy
        if(other.GetComponent<Collider2D>().tag== "Enemy" && gameObject.tag == "PlayerBullet")
        {
            //動態生成爆炸音效
            //other.transform.position兩個物件碰撞的位置
            //other.transform.rotation兩個物件碰撞的旋轉直
            Instantiate(Effect, other.transform.position, other.transform.rotation);
            //玩家子彈打到敵機,玩家加分
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().Score();
            //爆炸音效
            EffectAudio.Play();
            //敵機消滅
            Destroy(other.gameObject);
            //自己子彈物倩被消滅
            Destroy(gameObject);
        }

        //玩家子彈打到敵機子彈,互相刪除
        if (other.GetComponent<Collider2D>().tag == "EnemyBullet" && gameObject.tag== "PlayerBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
        //敵機子彈打到玩家
        if (other.GetComponent<Collider2D>().tag =="Player" && gameObject.tag == "EnemyBullet")
        {
            //敵機打到玩家呼叫玩家物件身上的Player腳本中的HurtPlayer進行扣血
            other.GetComponent<Player>().HurtPlayer(10f);
        }



    }



}

