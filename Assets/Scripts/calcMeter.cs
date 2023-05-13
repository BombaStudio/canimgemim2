using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcMeter : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update

    public int mesafe;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        int mesafe = Meter();
        //Debug.Log(mesafe);
        transform.Translate(0, 0, -player.GetComponent<planeControl>().speed * Time.deltaTime);
    }

    public int Meter()
    {
        return (int)Mathf.Abs(player.transform.position.z - transform.position.z);
    }
}
