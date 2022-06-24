using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    int i = 0;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        if(i < enemies.Count)
        Instantiate(enemies[i],transform.position,Quaternion.identity);
        else 
            StopCoroutine(Spawn());
        i++;
        yield return new WaitForSeconds(5f);
    }
 
}
