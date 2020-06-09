using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [Header("怪物陣列 0狐狸 1老鷹 2老鼠 3青蛙")]
    public GameObject[] monsters;


    public void CreateMonster(int index)
    {
        Instantiate(monsters[index], new Vector3(-10, 2, 0), Quaternion.identity);
    }

}
