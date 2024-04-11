using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsters : MonoBehaviour
{
    [SerializeField] GameObject[] monster;

    private void Awake()
    {
        int monsterID = Random.Range(0, monster.Length);
        Spawn(monsterID);
    }
    public void Spawn(int monsterID)
    {
        Instantiate(monster[monsterID], transform.position, Quaternion.identity);
    }    
}
