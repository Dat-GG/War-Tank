using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public int time;
    public int speed;
    public GameObject Smoke;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        BulletEx();
    }
    void BulletMove() 
    {
        this.transform.position += transform.up * Time.deltaTime * speed;
    }
    void BulletEx() 
    {
        time += 1;
        if (time == 20) 
        {
            Destroy(this.gameObject);
            Instantiate(Smoke, this.gameObject.transform.position, this.gameObject.transform.rotation);
        }

    }
}
