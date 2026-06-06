using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class stroeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text coinText;

    void Start()
    {
        coinText.text = valueManeger.instance.mony.ToString();
    }
/*
    void buyItem()
    {
        
    }

    void selectItem()
    {
        
    }
*/
}
