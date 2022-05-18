using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    IEnumerator OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "MyCoin")
        {
            ScoreNum += 1;
            Coin.gameObject.SetActive(false);
            MyscoreText.text = "Score : " + ScoreNum;
            yield return new WaitForSeconds(3);
            Coin.gameObject.SetActive(true);
        }
    }
    

}
