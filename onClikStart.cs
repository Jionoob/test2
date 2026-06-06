using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onClikStart : MonoBehaviour
{
    public void GoToLobe()
    {
        SceneManager.LoadScene("lobe");
        //실제 로비로 넘어가는 메뉴
    }
    public void GoToStore()
    {
        SceneManager.LoadScene("store");
        //실제 로비로 넘어가는 메뉴
    }
    
}
