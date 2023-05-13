using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = player.transform.position;
    }
    private void Update()
    {
        
    }
    
    public void tryagain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
