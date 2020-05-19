using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("設定幾秒產生一顆子彈")]
    public float CreatTime;
    [Header("子彈物件")]
    public GameObject Bullet;
    [Header("子彈生成點")]
    public Transform CreatObject;
    [Header("射擊音效")]
    public AudioSource ShootingSound;
    // Start is called before the first frame update
    void Start()
    {
        ShootingSound = GameObject.Find("Shoot").GetComponent<AudioSource>();
        InvokeRepeating("CreateBullet", CreatTime, CreatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateBullet()
    {
        //動態生成Instantiate(要生成的物件, 生成出來後的位置, 生成出來後的角度);
        Instantiate(Bullet, CreatObject.position, CreatObject.rotation);
        ShootingSound.Play();
    }
}   
