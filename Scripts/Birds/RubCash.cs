using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RubCash : MonoBehaviour
{

    private Text cash;
    public int bubby;
    public int multiplier;

    // Start is called before the first frame update
    void Start()
    {

        cash= GameObject.FindGameObjectWithTag("Money").GetComponent<Text>();
        //cash.text = PlayerPrefs.GetInt("cash", 0).ToString();

    }

    // Update is called once per frame
    void Update()
    {

        //cash.text = PlayerPrefs.GetInt("cash", bubby).ToString();
        cash.text = "$" + bubby.ToString();


    }

  


    private void OnMouseExit()
    {

        
       // Debug.Log("exit detected");
        bubby += 1 * multiplier;
        //PlayerPrefs.SetInt("cash", bubby);
        cash.text = bubby.ToString();

    }

}
