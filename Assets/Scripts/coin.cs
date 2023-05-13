using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{

    GameObject player;
    GameObject gameController;

    [SerializeField] GameObject vr2d, vr3d,light;
    // Start is called before the first frame update
    private void Awake()
    {
        //transform.position = new Vector3(Random.Range(-4.5f, 5.5f), transform.position.y, transform.position.z);
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            if (levelController.gameState == GameState.Normal)
            {
                transform.Translate(0, 0, -player.GetComponent<planeControl>().speed * Time.fixedDeltaTime);
                //if (player.transform.position.z - 20 > transform.position.z)
                //{
                //    Destroy(this.gameObject);
                //}
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
        if (gameController.GetComponent<levelController>().level > 1)
        {
            vr2d.SetActive(false);
            vr3d.SetActive(true);
        }
        else
        {
            vr2d.SetActive(true);
            vr3d.SetActive(false);
        }
        if (gameController.GetComponent<levelController>().level > 2)
        {
            light.SetActive(true);
        }
    }
}
