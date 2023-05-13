using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getScore : MonoBehaviour
{
    [SerializeField]
    GameObject calc;
    GameObject player;

    [SerializeField]
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(calc.GetComponent<calcMeter>().Meter() * player.GetComponent<planeControl>().scoreMultiplies);
    }
}
