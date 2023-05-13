using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devamaq : MonoBehaviour
{
    GameObject[] l;
    GameObject[] k;
    public GameObject li;
    GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform o in li.GetComponentInChildren<Transform>())
        {
            if (o.position.z < p.transform.position.z - 5) o.transform.position = new Vector3(Random.Range(-4.5f, 5.5f), o.position.y, 876.5f);
        }


        //    try
        //    {
        //        l = GameObject.FindGameObjectsWithTag("multi15");
        //        if (l.Length == 0)
        //        {
        //            try {
        //                k = GameObject.FindGameObjectsWithTag("aaaa");
        //                if (k.Length == 0)
        //                {
        //                    Instantiate(li, new Vector3(0, 0, 10), Quaternion.identity);
        //                }
        //                else
        //                {
        //                    for (int i = 0; i < k.Length; i++)
        //                    {
        //                        //Destroy(k[i]);
        //                    }
        //                }
        //            }
        //            catch {
        //                Instantiate(li, new Vector3(0, 0, 10), Quaternion.identity);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        try
        //        {
        //            k = GameObject.FindGameObjectsWithTag("aaaa");
        //            if (k.Length == 0)
        //            {
        //                Instantiate(li, new Vector3(0, 0, 10), Quaternion.identity);
        //            }
        //            else
        //            {
        //                for (int i = 0; i < k.Length; i++)
        //                {
        //                    Destroy(k[i]);
        //                }
        //            }
        //        }
        //        catch
        //        {
        //            Instantiate(li, new Vector3(0, 0, 10), Quaternion.identity);
        //        }
        //    }
    }
}
