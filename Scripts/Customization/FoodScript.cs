using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodScript : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 10;
    public bool takingAway = false;
    public Button buyFood;
    public int foodAmount;
    public int foodCost;
    public RubCash birb;
    public GameObject Ftext;
    public Rigidbody2D rb;
    //public Animator AR;


    // Start is called before the first frame update
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //buyFood.onClick.AddListener(Foods);

       

        if (birb.bubby < foodCost)
        {
            buyFood.interactable = false;

        }
        else
        {
            buyFood.interactable = true;
        }

        Ftext.GetComponent<Text>().text = foodAmount.ToString();

        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(Timertake());
        }

        if (secondsLeft == 1 && foodAmount > 0)
        {

            secondsLeft = 12;
            foodAmount--;

        }
        else
        {
            if (secondsLeft <= 0)
            {
                rb.gravityScale = 1;
                //AR.SetTrigger("Death");         
            }


        }

    }

    public void Foods()
    {
        
            
        
        if (birb.bubby >= foodCost)
        {

            birb.bubby -= foodCost;
            foodAmount++;

        }


    }

    IEnumerator Timertake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        takingAway = false;
    }

}

