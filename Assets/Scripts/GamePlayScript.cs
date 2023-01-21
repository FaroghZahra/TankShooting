using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamePlayScript : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] enemiesPos;
    int x;
    int score;
    public Text scoretext;
    string previoustext;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        score = 0;
        previoustext = scoretext.text;
        InvokeRepeating("StartEnemy", 1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartEnemy()
    {
        x = Random.Range(0, 3);
        Instantiate(enemy,enemiesPos[x].transform.position, enemiesPos[x].transform.rotation);
    }
    public void scoreCounter()
    {
        score++;
        scoretext.text = previoustext + score.ToString();
    }
}
