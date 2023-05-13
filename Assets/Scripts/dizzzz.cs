using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dizzzz : MonoBehaviour
{
    //[SerializeField] GameObject dizzz;
    GameObject player;
    GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
        if (gameController.GetComponent<levelController>().level < 2)
        {
            gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        try
        {
            if (levelController.gameState == GameState.Normal)
            {
                transform.Translate(0, 0, -player.GetComponent<planeControl>().speed * Time.fixedDeltaTime);
                if (player.transform.position.z - 20 > transform.position.z)
                {
                    Destroy(this.gameObject);
                }
            }
        }
        catch
        {

        }
        if (player.transform.position.z - 20 > transform.position.z)
        {
            if (transform.tag == "multi15")
            {
                gameController.GetComponent<randomMap>().m15++;
            }
            if (transform.tag == "multi2")
            {
                gameController.GetComponent<randomMap>().m20++;
            }
            if (transform.tag == "multi25")
            {
                gameController.GetComponent<randomMap>().m25++;
            }
            Destroy(this.gameObject);
        }
    }
}
