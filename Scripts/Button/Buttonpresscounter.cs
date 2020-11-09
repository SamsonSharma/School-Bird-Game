using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Buttonpresscounter : MonoBehaviour
{

    public Text text;
    private int bruh = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        text.text = bruh.ToString();

    }

    public void Buttonpress()
    {

        bruh += 1;

    }

}
