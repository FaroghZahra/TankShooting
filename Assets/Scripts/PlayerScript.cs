using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool isLeft;
    bool isRight;
    public float speed;

    public GameObject Player;
    public GameObject Bullet;
    public GameObject BulletPos;

    public Slider healthSlider;
    public GameObject Reloadbtn;

    int TotalBullets;
    int MagBullets;

    public Text BulletCounterText;
    void Start()
    {
        isLeft = false;
        isRight = false;

        healthSlider.value = 5;
        TotalBullets = 12;
        MagBullets = 6;
        BulletCounterText.text = (MagBullets + "/" + TotalBullets ).ToString();

    }

    // Update is called once per frame
    void Update()
    {
        if(isLeft == true)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + speed);
        }
        if (isRight == true)
        {
            Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - speed);
        }
    }
    public void isLeftClickedDown()
    {
        isLeft = true;
    }
    public void isLeftClickedUp()
    {
        isLeft = false;
    }
    public void isRightClickedDown()
    {
        isRight = true;
    }
    public void isRightClickedUp()
    {
        isRight = false;
    }
    public void firebtnClicked()
    {
        if(MagBullets != 0)
        {
            MagBullets -= 1;
            BulletCounterText.text = (MagBullets + "/" + TotalBullets).ToString();
            Instantiate(Bullet, BulletPos.transform.position, BulletPos.transform.rotation);
        }
        if(MagBullets == 0)
        {
            Reloadbtn.GetComponent<Button>().enabled = true;
            Reloadbtn.GetComponent<Animator>().enabled = true;
        }
    }
    public void reloadBtnClick()
    {

        if (TotalBullets != 0)
        {
            MagBullets = 6;
            TotalBullets = TotalBullets - 6;
            BulletCounterText.text = (MagBullets + "/" + TotalBullets).ToString();

            Reloadbtn.GetComponent<Button>().enabled = false;
            Reloadbtn.GetComponent<Animator>().enabled = false;
        }

    }
    public void playerHealth()
    {
        healthSlider.value = healthSlider.value - 1;
        if(healthSlider.value == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
