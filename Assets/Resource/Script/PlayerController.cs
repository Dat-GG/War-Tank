using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public GameObject gun;
    //public GameObject gun2;
    public GameObject Bullet;
    //public GameObject Bullet2;
    public Transform Transhoot;
    //public Transform Transhoot2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TankMove();
        RotateGun();       
        if (Input.GetMouseButton(0)) 
        {
            Shoot();
            //Shoot2();
        }
    }

    void TankMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, vertical);
        this.gameObject.transform.position += direction * Time.deltaTime * speed;
        if (direction != Vector3.zero) 
        {
           this.gameObject.transform.up = direction;
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
    void RotateGun() 
    {
        Vector3 GunDirection = new Vector3(
            Input.mousePosition.x - Screen.width / 2,
            Input.mousePosition.y - Screen.height / 2
            );
        gun.gameObject.transform.up = GunDirection;
    }    
}
