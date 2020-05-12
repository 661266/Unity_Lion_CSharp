using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
   [Range(0f,1f)]  public float Speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*//Input.GetKey("a")按下a鍵if條件內的腳本持續執行
        if (Input.GetKey("a"))
        transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z); 
        {
        //Input.GetKeyDown("d")按下d鍵且放開，if條件內的腳本只執行一次
        //Input.GetKeyDown("d")按下d鍵if條件內的腳本只執行一次
        if (Input.GetKey("d"))
        {
        transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        }
        }*/
        //Input.GetAxis("Horizontal")沒有按按鍵的時候回傳值為0
        //Input.GetAxis("Horizontal")按a或是左鍵時回傳為-1
        //Input.GetAxis("Horizontal")按d或是右鍵時回傳為1
        //Input.GetAxis("Vertical")沒有按按鍵的時候回傳值為0
        //Input.GetAxis("Vertical")按a或是左鍵時回傳為-1
        //Input.GetAxis("Vertical")按d或是右鍵時回傳為1
#if UNITY_STANDALONE
        transform.Translate(Speed*Input.GetAxis("Horizontal"), Speed*Input.GetAxis("Vertical"),0f);

#endif
#if UNITY_ANDROID
        //Input.acceleration.x 手機陀螺儀X軸 Input.acceleration.y手機陀螺儀Y軸
    transform.Translate(Speed * Input.acceleration.x, Speed * Input.acceleration.y, 0f);

#endif

        /* if (transform.position.x >= 2.6f)
             transform.position = new Vector3(2.6f, transform.position.y, transform.position.z);
         if (transform.position.x <= 2.6f)
             transform.position = new Vector3(-2.6f, transform.position.y, transform.position.z);
             */

        //限制數值Mathf.Clamp(限制的項目,最小值,最大值)
        transform.position=new Vector3(Mathf.Clamp(transform.position.x,-2.6f,2.6f),Mathf.Clamp(transform.position.y, -4.22f, 4.42f),transform.position.z);               


    }

}


