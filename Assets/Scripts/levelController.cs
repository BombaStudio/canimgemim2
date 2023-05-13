using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelController : MonoBehaviour
{
    public static GameState gameState;

    public int level = 0;
    public float particle = 0;
    public float particleCount = 10;
    public int score = 0;
    
    [SerializeField]
    GameObject portal;

    [SerializeField]
    GameObject spr2d;

    GameObject player;

    [SerializeField]
    GameObject mesh2d,mesh3d,mesh3dhigh;
    GameObject[] lambs;

    [SerializeField] GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        gameState = GameState.BeforeStart;
        player = GameObject.FindGameObjectWithTag("Player");
        lambs = GameObject.FindGameObjectsWithTag("sokak");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(particle);
        if (particle > particleCount)
        {
            
            //StartCoroutine("createPortal");
            if (level < 3)
            {
                spr2d.transform.localScale = new Vector3(0, 1, 1);
                particle = 0;
                createPortal();
            }
            if (level == 3)
            {
                bg.GetComponent<Animator>().enabled = true;
            }
            
        }
        if (level == 1)
        {
            mesh2d.SetActive(true);
            mesh3d.SetActive(false);
            mesh3dhigh.SetActive(false);
            for (int i = 0; i < lambs.Length; i++)
            {
                lambs[i].SetActive(false);
            }
        }
        if (level == 2)
        {
            mesh2d.SetActive(false);
            mesh3d.SetActive(true);
            mesh3dhigh.SetActive(false);
            for (int i = 0; i < lambs.Length; i++)
            {
                lambs[i].SetActive(false);
            }
        }
        if (level == 3)
        {
            mesh2d.SetActive(false);
            mesh3d.SetActive(false);
            mesh3dhigh.SetActive(true);
            for (int i = 0; i < lambs.Length; i++)
            {
                lambs[i].SetActive(true);
            }
        }
        //Debug.Log(particle);
    }
    void createPortal()
    {
        if (level < 3)
        {
            Instantiate(portal, new Vector3(0, 0, Random.Range(player.transform.position.z + 15f, player.transform.position.z + 25f)), Quaternion.identity);
        }
    }
}
