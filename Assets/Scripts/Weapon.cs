using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletpre;
    public Transform firepoint;
    public float fireforce = 20f;

    public void fire(){
        GameObject bullet = Instantiate(bulletpre, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * fireforce, ForceMode2D.Impulse);
    }

}
