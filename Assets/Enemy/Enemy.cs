using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public int level;
    public int HP;
    public int MaxHP;
    public float speed;
    delegate void d_move();
    event d_move enemy_move = delegate { };
    [SerializeField]
    Vector3 pos;
    private void Start()
    {
        pos = new Vector3(0, 1f);
        HP = MaxHP;
        GetComponent<Animator>().SetInteger("Level",level);
    }
    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeSpawn")
            this.transform.position = new Vector3(this.transform.position.x, 20, 0);
    }
  
}
