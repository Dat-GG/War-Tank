using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int speed;
    public GameObject gun;
    //public GameObject gun2;
    public GameObject Bullet;
    //public GameObject Bullet2;
    public Transform Transhoot;
    //public Transform Transhoot2;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerdic = Player.transform.position - transform.position;
        TankMove(playerdic);
        RotateGun(playerdic);
        if (Random.Range(0,100) % 4 == 0)
        {
            Shoot();
        }
            
    }
    void TankMove(Vector3 playerDic)
    {
        this.gameObject.transform.position += playerDic * Time.deltaTime * speed;
        if (playerDic != Vector3.zero)
        {
            this.gameObject.transform.up = playerDic;
        }

    }
    void Shoot()
    {
        Instantiate(Bullet, Transhoot.position, Transhoot.rotation);
    }
    //void Shoot2()
    //{
    //    Instantiate(Bullet2, Transhoot2.position, Transhoot2.rotation);
    //}
    void RotateGun(Vector3 playerDic)
    {
        gun.gameObject.transform.up = playerDic;
    }
}
