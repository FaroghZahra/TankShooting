using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyScript : MonoBehaviour
{
    public GameObject EnemyBullet;
    public GameObject EnemyBulletPos;

    public Slider enemySlider;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("enemyfire", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
    }
    void enemyfire()
    {
        Instantiate(EnemyBullet, EnemyBulletPos.transform.position, EnemyBulletPos.transform.rotation);
    }

}
