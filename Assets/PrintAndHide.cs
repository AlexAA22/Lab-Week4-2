using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int randomNum;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i==100)
        {
            gameObject.SetActive(false);
        }
       else if (gameObject.tag == "Blue" && i == randomNum)
        {
            rend.enabled = false;

        }


    }
}
