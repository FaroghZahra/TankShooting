using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 0.3f, transform.position.y , transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy"))
        {
            if(other.gameObject.GetComponent<EnemyScript>().enemySlider.value != 0)
            {
                other.gameObject.GetComponent<EnemyScript>().enemySlider.value -= 1;
            }
            else
            {
                FindObjectOfType<GamePlayScript>().scoreCounter();
                other.gameObject.SetActive(false);
            }
           gameObject.SetActive(false);
        }
    }
}
