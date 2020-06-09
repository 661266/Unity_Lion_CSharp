using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("敵機移動速度")]
    public float Speed;
    [Header("敵機多久被消滅")]
    public float DeleteTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, DeleteTime);
    }

    // Update is called once per frame
    void Update()
    {
        //敵機向下移動
        transform.Translate(Vector3.down * Speed);
    }
}
