using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int HP;
    public int MaxHP;
    public GameObject bullets;
    [SerializeField]
    float time = .5f;
    public float speed;
    Vector3 dir=Vector3.zero;
    public delegate void d_shot(GameObject bullet, int power);
    public event d_shot e_shot = Hit.oneShot;
    void Start()
    {        
        bullets.transform.position = this.transform.position;
        StartCoroutine(fire());
    }

    private void Update()
    {
        dir =new Vector3(Input.acceleration.x, Input.acceleration.y);
        if (dir.sqrMagnitude > 1)
            dir.Normalize();
        transform.Translate(dir*speed*Time.deltaTime);
        if(Input.GetMouseButtonDown(0))
        {
            e_shot = Hit.twoShot;
        }
    }

    void FixedUpdate()
    {
        bullets.transform.position=this.transform.position;
    }

    IEnumerator fire()
    {
        while (true)
        {
            e_shot(bullets, 10);
            yield return new WaitForSeconds(time);
        }
    }
}
