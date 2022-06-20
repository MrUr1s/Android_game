using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    static Vector3 force = Vector3.up;
    public static void oneShot(GameObject bullet,int power)
    {
        GameObject b = Instantiate(bullet);
        b.GetComponent<Rigidbody>().AddForce(force * power, ForceMode.Impulse);
    }
    public static void twoShot(GameObject bullet, int power)
    {
        GameObject b = Instantiate(bullet,bullet.transform.position+new Vector3(-0.25f,0),Quaternion.identity);
        b.GetComponent<Rigidbody>().AddForce(force * power, ForceMode.Impulse);
        b = Instantiate(bullet, bullet.transform.position + new Vector3(0.25f, 0), Quaternion.identity);
        b.GetComponent<Rigidbody>().AddForce(force * power, ForceMode.Impulse);
    }
    public static void threeShot(GameObject bullet, int power)
    {
        GameObject b = Instantiate(bullet, bullet.transform.position + new Vector3(-.5f, 0), Quaternion.identity);
        b.GetComponent<Rigidbody>().AddForce(force * power, ForceMode.Impulse);
        b = Instantiate(bullet, bullet.transform.position + new Vector3(0, 0), Quaternion.identity);
        b.GetComponent<Rigidbody>().AddForce(force * power, ForceMode.Impulse);
        b = Instantiate(bullet, bullet.transform.position + new Vector3(0.5f, 0), Quaternion.identity);
        b.GetComponent<Rigidbody>().AddForce(force * power, ForceMode.Impulse);
    }

}
