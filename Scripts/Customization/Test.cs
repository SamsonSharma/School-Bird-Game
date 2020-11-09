using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{

    public RubCash Birb;

    [System.Serializable]
    public class ShopButtons
    {

        public int Cost;
        public Button Button;
        public bool Isbought;
        

    }

    public ShopButtons[] shopButtons;

    private void Start()
    {
        //shopButtons[0].Button.interactable = false;
        //shopButtons[0].Button.onClick.AddListener (testPress);
    }

    private void Update()
    {
        //shopButtons[1].Button.onClick.AddListener(testPress);
        //shopButtons[1].Cost = 10;

        

        foreach (var button in shopButtons)
        {

          //button.Button.interactable = Birb.bubby >= button.Cost;

          

        }

    }

   




}
