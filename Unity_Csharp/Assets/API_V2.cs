using UnityEngine;

public class API_V2 : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    public Transform tran1;

    void Start()
    {
        //圖片旋轉
        tran1.Rotate(0, 180,0 );
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

}
