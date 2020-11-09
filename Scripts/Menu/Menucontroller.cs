using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menucontroller : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject htpMenu;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void HTP()
    {
        htpMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Back()
    {
        htpMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
