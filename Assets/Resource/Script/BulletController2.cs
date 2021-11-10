using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController2 : MonoBehaviour
{
    public int time2;
    public int speed2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove2();
        BulletEx2();
    }
    void BulletMove2()
    {
        this.transform.position += transform.up * Time.deltaTime * speed2;
    }
    void BulletEx2()
    {
        time2 += 1;
        if (time2 == 40)
        {
            Destroy(this.gameObject);
        }

    }
}
