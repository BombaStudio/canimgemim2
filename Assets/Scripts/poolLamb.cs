using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolLamb : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -160)
        {
            transform.position = new Vector3(0,0,160);
            
        }
        if (levelController.gameState == GameState.Normal)
        {
            transform.Translate(0, 0, -player.GetComponent<planeControl>().speed * Time.fixedDeltaTime);
        }
    }
}
