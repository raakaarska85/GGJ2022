using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBlock : MonoBehaviour
{
    GameObject collidingBullet;
    public bool isblue;
    public bool isred;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        Bullet collidingBullet = other.gameObject.GetComponent<Bullet>();
        if (!collidingBullet.isplayerbullet)
        {
            if (collidingBullet.hurtsBlue == false && isblue)
            {
                collidingBullet.DestroyBullet();
            }
            else if (collidingBullet.hurtsRed == false && isred)
            {
                collidingBullet.DestroyBullet();
            }
        }
        
    }
}
