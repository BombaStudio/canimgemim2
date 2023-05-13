using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMap : MonoBehaviour
{

    public GameObject wallMesh;
    /*
    GameObject[] topMesh;
    GameObject[] bottomMesh;
    */
    GameObject topMesh;
    GameObject bottomMesh;

    public int level = 0;

    [Range(5,10)]
    public int maxMeshCount = 1000;
    public int meshCount = 0;
    public float prefX = 0;
    GameObject prefObjTop;
    GameObject prefObjBottom;
    bool draw = true;

    [SerializeField]
    GameObject coin;
    public int m15, m20, m25;
    public int a = 0;
    GameObject player;

    [SerializeField] GameObject dizzz;

    void Awake()
    {
        /*
        topMesh[0] = Instantiate(wallMesh);
        bottomMesh[0] = Instantiate(wallMesh);
        */
        /*
        topMesh.Add(Instantiate<GameObject>(wallMesh));
        bottomMesh.Add(Instantiate<GameObject>(wallMesh));
        Debug.Log(topMesh.ToArray().Length);
        */
        //wallMesh.SetActive(true);
        /*
        prefObjTop = Instantiate(wallMesh, new Vector3(0, 0, meshCount * 10), Quaternion.identity);
        prefObjBottom = Instantiate(wallMesh, new Vector3(-15, 0, meshCount * 10), Quaternion.identity);
        */
        m15 = 6;
        m20 = 3;
        m25 = 1;
        meshCount = 1;
        /*
        for (int asd = 0; asd < 40; asd++)
        {
            a = Random.Range(-level, level);
            GameObject aa = Instantiate(wallMesh, new Vector3(prefX+a, 0, 5 * asd), Quaternion.identity);
            prefX = aa.transform.position.x;
        }
        */
        
    }
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(death(0.5f));
        //StartCoroutine(bonus(0.2f));
        //Instantiate(dizzz, new Vector3(5, player.transform.position.y, Random.Range(player.transform.position.z + 50, player.transform.position.z + 100)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        a = Random.Range(-level, level);

        //anası s2lmiş kodlar
        #region
        /*

        if (meshCount < maxMeshCount)
        {
        */
        /*
        if (meshCount / 2 > 25)
        {
            topMesh = Instantiate(wallMesh, new Vector3(meshCount, a/100, 0), Quaternion.identity);
            bottomMesh = Instantiate(wallMesh, new Vector3(meshCount, a/100 - Random.Range(meshCount, meshCount / 2), 0), Quaternion.identity);
        }
        else
        {
            topMesh = Instantiate(wallMesh, new Vector3(meshCount, a/100, 0), Quaternion.identity);
            bottomMesh = Instantiate(wallMesh, new Vector3(meshCount, a/100 - 25, 0), Quaternion.identity);
        }
        */
        /*
        topMesh = Instantiate(wallMesh, new Vector3(meshCount, a , 0), Quaternion.identity);
        bottomMesh = Instantiate(wallMesh, new Vector3(meshCount, a  - 25, 0), Quaternion.identity);
        */
        /*
        if (meshCount / 2 > 25)
        {
            topMesh = Instantiate(wallMesh, new Vector3(prefX + a / 10, 0, meshCount), Quaternion.identity);
            bottomMesh = Instantiate(wallMesh, new Vector3(prefX + a / 10 - Random.Range(meshCount, meshCount / 2) - 25, 0, meshCount), Quaternion.identity);
        }
        else
        {
            topMesh = Instantiate(wallMesh, new Vector3(prefX + a / 10, 0, meshCount), Quaternion.identity);
            bottomMesh = Instantiate(wallMesh, new Vector3(prefX + a / 10 - 25, 0, meshCount), Quaternion.identity);
        }
        */
        /*
        topMesh = Instantiate(wallMesh, new Vector3(prefX + a / 4, 0, meshCount), Quaternion.identity);
        bottomMesh = Instantiate(wallMesh, new Vector3(prefX + a / 4 - 15, 0, meshCount), Quaternion.identity);



        topMesh.SetActive(true);
        bottomMesh.SetActive(true);

        topMesh.tag = "topwall";
        bottomMesh.tag = "bottomwall";
        meshCount++;
        //Debug.Log(prefX);
        //prefX = topMesh.transform.position.x;
    }
        */
        /*
        if (meshCount == maxMeshCount)
        {
            int incCount = maxMeshCount;
            meshCount = maxMeshCount;
            maxMeshCount += incCount;
            level++;
            //StartCoroutine("repeatDraw");
        }
        */
        #endregion
        

    }
    IEnumerator bonus(float timerr)
    {
        yield return new WaitForSeconds(timerr);
        a = Random.Range(-level, level);
        int create = Random.Range(0, 1000);
        //Debug.Log(create);
        int c = Random.Range(0, 10);

        if (create > 90)
        {
            if (m25 > 0)
            {
                if (c < 4)
                {
                    GameObject co = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                    co.tag = "multi20";
                    co.SetActive(true);
                }
                if (c > 4)
                {
                    GameObject cu = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                    cu.tag = "multi20";
                    cu.SetActive(true);
                }
                if (c > 7)
                {
                    GameObject cu = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                    cu.tag = "multi20";
                    cu.SetActive(true);
                    GameObject cu1 = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                    cu1.tag = "multi20";
                    cu1.SetActive(true);
                }

                //m25--;
                //GetComponent<levelController>().score++;
            }
        }

        else
        {
            if (create > 800)
            {
                if (m20 > 0)
                {
                    if (c < 4)
                    {
                        GameObject co = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                        co.tag = "multi20";
                        co.SetActive(true);
                    }
                    if (c > 4)
                    {
                        GameObject cu = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                        cu.tag = "multi20";
                        cu.SetActive(true);
                    }
                    if (c > 7)
                    {
                        GameObject cu = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                        cu.tag = "multi20";
                        cu.SetActive(true);
                        GameObject cu1 = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                        cu1.tag = "multi20";
                        cu1.SetActive(true);
                    }
                    //m20--;
                    //GetComponent<levelController>().score++;
                }
            }
            else
            {
                if (create > 700)
                {
                    if (m15 > 0)
                    {
                        if (c < 4)
                        {
                            GameObject co = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                            co.tag = "multi20";
                            co.SetActive(true);
                        }
                        if (c > 4)
                        {
                            GameObject cu = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                            cu.tag = "multi20";
                            cu.SetActive(true);
                        }
                        if (c > 7)
                        {
                            GameObject cu = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                            cu.tag = "multi20";
                            cu.SetActive(true);
                            GameObject cu1 = Instantiate(coin, new Vector3(Random.Range(-15, 15), player.transform.position.y, Random.Range(player.transform.position.z + 15, player.transform.position.z + 25)), Quaternion.identity);
                            cu1.tag = "multi20";
                            cu1.SetActive(true);
                        }
                        //m15--;
                        //GetComponent<levelController>().score++;
                    }
                }
            }
        }
        GetComponent<levelController>().score++;
        StartCoroutine(bonus(Random.Range(0.5f, 1.2f)));
    }

    IEnumerator death(float timerr)
    {
        yield return new WaitForSeconds(timerr);
        a = Random.Range(-level, level);
        int create = Random.Range(0, 1000);
        //Debug.Log(create);
        int c = Random.Range(0, 10);

        if (GetComponent<levelController>().level >= 2)
        {
            if (create > 90)
            {
                if (m25 > 0)
                {
                    if (c < 4)
                    {
                        GameObject co = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                        co.SetActive(true);
                    }
                    if (c > 4)
                    {
                        GameObject cu = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                        cu.SetActive(true);
                    }
                    if (c > 7)
                    {
                        GameObject cu = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                        cu.SetActive(true);
                        GameObject cu1 = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                        cu1.SetActive(true);
                    }

                    //m25--;
                }
            }

            else
            {
                if (create > 800)
                {
                    if (m20 > 0)
                    {
                        if (c < 4)
                        {
                            GameObject co = Instantiate(dizzz, new Vector3(Random.Range(-5,5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                            co.SetActive(true);
                        }
                        if (c > 4)
                        {
                            GameObject cu = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                            cu.SetActive(true);
                        }
                        if (c > 7)
                        {
                            GameObject cu = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                            cu.SetActive(true);
                            GameObject cu1 = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 75, player.transform.position.z + 200)), Quaternion.identity);
                            cu1.SetActive(true);
                        }
                        //m20--;
                    }
                }
                else
                {
                    if (create > 700)
                    {
                        if (m15 > 0)
                        {
                            if (c < 4)
                            {
                                GameObject co = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 50, player.transform.position.z + 100)), Quaternion.identity);
                                co.SetActive(true);
                            }
                            if (c > 4)
                            {
                                GameObject cu = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 50, player.transform.position.z + 100)), Quaternion.identity);
                                cu.SetActive(true);
                            }
                            if (c > 7)
                            {
                                GameObject cu = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 50, player.transform.position.z + 100)), Quaternion.identity);
                                cu.SetActive(true);
                                GameObject cu1 = Instantiate(dizzz, new Vector3(Random.Range(-5, 5), player.transform.position.y, Random.Range(player.transform.position.z + 50, player.transform.position.z + 100)), Quaternion.identity);
                                cu1.SetActive(true);
                            }
                            //m15--;
                        }
                    }
                }
            }
        }

        StartCoroutine(death(Random.Range(1f, 4f)));
    }
    
    /*
    IEnumerator repeatDraw()
    {
    */
    /*
    yield return new WaitForSeconds(1);
    draw = false;
    yield return new WaitForSeconds(1);
    draw = true;
    */
    /*
    yield return new WaitForSeconds(1);
    int incCount = maxMeshCount;
    meshCount = maxMeshCount;
    maxMeshCount += incCount;
}
    */
}
