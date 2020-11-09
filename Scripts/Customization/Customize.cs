using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using System;

public class Customize : MonoBehaviour
{

    public Test[] possibleTest;

    //private int CurrentCash;

    public Test Theprice;


    // Start is called before the first frame update
    void Start()
    {

        int Cost = Random.Range(0, possibleTest.Length);

        Theprice = possibleTest[Cost];


        Debug.Log(Theprice);
    }


    private void Update()
    {
     

    }

    // Update is called once per frame
    public void Pressedlvlup()
    {

    }




}
