using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerShow : MonoBehaviour
{
    [SerializeField] GameObject[] players;
    [SerializeField] GameObject particle;
    int c = 0;
    int a = 0;
    void Start()
    {
        StartCoroutine(playerChange());
    }

    IEnumerator playerChange()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (i == c)
            {
                a = (int)Random.Range(0, 2);
                players[i].SetActive(true);
                if (players[i].GetComponent<Animator>() != null)
                {
                    if (a == 0) players[i].GetComponent<Animator>().Play("idle");
                    else players[i].GetComponent<Animator>().Play("run");
                }
            }
            else players[i].SetActive(false);
        }
        Debug.Log(a);
        particle.SetActive(true);
        yield return new WaitForSeconds(5);
        particle.SetActive(false);
        if (c >= players.Length - 1) c = 0;
        else c++;
        StartCoroutine(playerChange());
    }
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void playButton()
    {
        transform.position = new Vector3(0, 300, 0);
        GetComponent<Animator>().enabled = true;
    }
}
