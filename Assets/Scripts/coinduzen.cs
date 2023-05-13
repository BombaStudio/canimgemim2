using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinduzen : MonoBehaviour
{
    GameObject[] coins;
    [SerializeField] GameObject o;
    [SerializeField] float startPos, endPos, count;

    private void Awake()
    {
        for (float i = startPos; i < endPos; i += ((endPos - startPos) / count))
        {
            GameObject x = Instantiate(o);
            x.transform.parent = transform;
            x.transform.localPosition = new Vector3(0, 0, i);
        }
        randomcoin();
    }
    public void randomcoin()
    {
        coins = GameObject.FindGameObjectsWithTag("multi15");
        foreach (GameObject coin in coins)
        {
            coin.transform.position = new Vector3(Random.Range(-4.5f, 5.5f), coin.transform.position.y, coin.transform.position.z);
        }
    }

}
