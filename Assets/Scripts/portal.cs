using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    GameObject player, gc;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gc = GameObject.FindGameObjectWithTag("GameController");
        if (gc.GetComponent<levelController>().level > 3)
        {
            gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (levelController.gameState == GameState.Normal)
        {
            transform.Translate(0, 0, -player.GetComponent<planeControl>().speed * Time.fixedDeltaTime);
            if (player.transform.position.z - 20 > transform.position.z)
            {
                Destroy(this.gameObject);
            }
        }
        //Debug.Log(gc.GetComponent<levelController>().level);
    }
}
