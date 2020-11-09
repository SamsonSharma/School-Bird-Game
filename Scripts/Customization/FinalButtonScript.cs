using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalButtonScript : MonoBehaviour
{

    public FoodScript FS;

    //BAD CODE DONE LATE AT NIGHT DON'T READ!


    //Was working on making this easier as you would see in teh test script but i had to move on.


    public int[] Cost;
    public Button[] Button;
    public bool[] Isbought;
    public RubCash Birb;

    // Start is called before the first frame update
    void Start()
    {
        
        //Isboughts
        Isbought[0] = false;
        Isbought[1] = false;
        Isbought[2] = false;
        Isbought[3] = false;
        //End

      


    }

    // Update is called once per frame
    void Update()
    {

        Button[0].onClick.AddListener(button0);
        Button[1].onClick.AddListener(button1);
        Button[2].onClick.AddListener(button2);
        Button[3].onClick.AddListener(button3);


        //Interactability conditions

        if (Birb.bubby < Cost[0] || Isbought[0] == true)
        {

            Button[0].interactable = false;

        }
        else
        {

            Button[0].interactable = true;

        }

        if (Birb.bubby < Cost[1] || Isbought[1] == true)
        {

            Button[1].interactable = false;

        }
        else
        {

            Button[1].interactable = true;

        }

        if (Birb.bubby < Cost[2] || Isbought[2] == true)
        {

            Button[2].interactable = false;

        }
        else
        {

            Button[2].interactable = true;

        }

        if (Birb.bubby < Cost[3] || Isbought[3] == true)
        {

            Button[3].interactable = false;

        }
        else
        {

            Button[3].interactable = true;

        }

        //End

    }



    void button0()
    {

        if (Birb.bubby >= Cost[0])
        {

            Birb.bubby -= Cost[0];
            Isbought[0] = true;
            Button[0].interactable = false;
            var newColor = Button[0].colors;
            newColor.disabledColor = Color.green;
            Button[0].colors = newColor;
            Birb.multiplier = 10;
            

        }

    }

    void button1()
    {
        if (Birb.bubby >= Cost[1])
        {

            Birb.bubby -= Cost[1];
            Isbought[1] = true;
            Button[1].interactable = false;
            var newColor = Button[1].colors;
            newColor.disabledColor = Color.green;
            Button[1].colors = newColor;
            Birb.multiplier = 200;

        }
    }

    void button2()
    {
        if (Birb.bubby >= Cost[2])
        {

            Birb.bubby -= Cost[2];
            Isbought[2] = true;
            Button[2].interactable = false;
            var newColor = Button[2].colors;
            newColor.disabledColor = Color.green;
            Button[2].colors = newColor;
            Birb.multiplier = 500;
            
        }
    }

    void button3()
    {
        if (Birb.bubby >= Cost[3])
        {

            Birb.bubby -= Cost[3];
            Isbought[3] = true;
            Button[3].interactable = false;
            var newColor = Button[0].colors;
            newColor.disabledColor = Color.green;
            Button[3].colors = newColor;
            Birb.multiplier = 1000;
            
        }
    }


}
