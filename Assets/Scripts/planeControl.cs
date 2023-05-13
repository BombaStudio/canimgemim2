using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planeControl : MonoBehaviour
{
    [SerializeField]
    GameObject Camera2D;
    [SerializeField]
    GameObject Camera3D;

    GameObject gameController;
    public float speed = 80f;
    public float Gamespeed = 45f;
    [SerializeField]
    GameObject gameOver;

    public bool changeCam;

    public float scoreMultiplies = 1;
    public bool movement;

    [SerializeField]
    GameObject calc;
    [SerializeField]
    Text score;
    [SerializeField]
    GameObject Scl2D;
    [SerializeField]
    GameObject canvas2d;

    [SerializeField] GameObject lm, rm, pm, part, coincase;
    Transform collided,triggered;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        //level = gameController<randomMap>().level;
        StartCoroutine("hiz");
    }

    
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            0,0
        );
        if (changeCam)
        {
            Camera3D.SetActive(true);
            Camera2D.SetActive(false);
        }
        /*
        else
        {
            Camera3D.SetActive(false);
            Camera2D.SetActive(true);
        }
        */

        if (InputPanel.instance.pointerDown)
        {
            transform.Translate(-Gamespeed * 2 * Time.deltaTime, 0, 0);
            movement = true;
            //transform.position += new Vector3(-speed * Time.deltaTime, 0, speed * Time.deltaTime);
            //speed += 0.01f;
        }
        /*
        
        if (Input.GetMouseButton(0))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //transform.position += new Vector3(-speed * Time.deltaTime, 0, speed * Time.deltaTime);
            //speed += 0.01f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //transform.position += new Vector3(-speed * Time.deltaTime, 0, speed * Time.deltaTime);
            //speed += 0.01f;
        }
        */
        else
        {
            if (movement)
            {
                transform.Translate(Gamespeed * 2 * Time.deltaTime, 0, 0);
            }
            //transform.position += new Vector3(speed * Time.deltaTime, 0, speed * Time.deltaTime);
            //speed += 0.01f;
        }
        //transform.Translate(0, 0, speed * Time.fixedDeltaTime);
        
        //if (speed < 100)
        //{
        //    speed += 0.02f;
        //}
        #region new collision
        //RaycastHit hit;
        //Ray r = new Ray(transform.position - new Vector3(0, transform.localScale.y / 3, 0), transform.right);
        //Ray rr = new Ray(transform.position - new Vector3(0, transform.localScale.y / 3, 0), -transform.right);

        //Debug.DrawRay(transform.position - new Vector3(0, transform.localScale.y / 3, 0), transform.right, Color.red, transform.localScale.x);
        //Debug.DrawRay(transform.position - new Vector3(0, transform.localScale.y / 3, 0), -transform.right,Color.blue, transform.localScale.x);

        //if (Physics.Raycast(r, out hit, transform.localScale.x) || Physics.Raycast(rr, out hit, transform.localScale.x))
        //{
        //    collided = hit.transform;
        //    if (collided.transform.tag == "topwall")
        //    {
        //        canvas2d.SetActive(false);
        //        GetComponent<MeshRenderer>().material.color = Color.red;
        //        gameOver.SetActive(true);
        //        Camera3D.SetActive(false);
        //        Camera2D.SetActive(false);
        //        score.text = gameController.GetComponent<levelController>().score.ToString();
        //        gameOver.GetComponent<Animator>().Play(0);
        //        gameOver.GetComponent<gameOver>().enabled = true;
        //        GetComponent<MeshRenderer>().enabled = false;
        //        GetComponent<planeControl>().enabled = false;
        //        gameObject.SetActive(false);
        //    }
        //    if (collided.transform.tag == "bottomwall")
        //    {
        //        canvas2d.SetActive(false);
        //        GetComponent<MeshRenderer>().material.color = Color.red;
        //        gameOver.SetActive(true);
        //        Camera3D.SetActive(false);
        //        Camera2D.SetActive(false);
        //        score.text = gameController.GetComponent<levelController>().score.ToString();
        //        gameOver.GetComponent<Animator>().Play(0);
        //        gameOver.GetComponent<gameOver>().enabled = true;
        //        GetComponent<MeshRenderer>().enabled = false;
        //        GetComponent<planeControl>().enabled = false;
        //        gameObject.SetActive(false);
        //    }
        //}
        #endregion
        #region new trigger
        //RaycastHit hit2;
        //Ray r2 = new Ray(transform.position - new Vector3(0, transform.localScale.y / 3, 0), transform.forward);
        ////Debug.DrawRay(transform.position - new Vector3(0, transform.localScale.y / 3, 0), transform.forward, Color.red, transform.localScale.z/2);
        ////if (Physics.Raycast(r2, out hit2, transform.localScale.z / 2))
        //if (Physics.SphereCast(transform.position, GetComponent<CapsuleCollider>().radius, transform.forward, out hit2, GetComponent<CapsuleCollider>().radius))
        //{
        //    triggered = hit2.transform;
        //    if (triggered.transform.tag == "multi15")
        //    {
        //        gameController.GetComponent<levelController>().particle += 0.7f;
        //        //Debug.Log(gameController.GetComponent<levelController>().particle);
        //        Scl2D.transform.localScale += new Vector3(0.07f, 0, 0);
        //        scoreMultiplies *= 1.1f;
        //        Destroy(triggered.gameObject);
        //        gameController.GetComponent<randomMap>().m15++;
        //        gameController.GetComponent<levelController>().score += 10;
        //        //gameObject.GetComponent<levelController>().score++;
        //        //Debug.Log("multi15");

        //    }
        //    if (triggered.transform.tag == "multi20")
        //    {
        //        gameController.GetComponent<levelController>().particle += 0.7f;
        //        //Debug.Log(gameController.GetComponent<levelController>().particle);
        //        Scl2D.transform.localScale += new Vector3(0.07f, 0, 0);
        //        scoreMultiplies *= 1.3f;
        //        Destroy(triggered.gameObject);
        //        gameController.GetComponent<randomMap>().m20++;
        //        gameController.GetComponent<levelController>().score += 10;
        //        //gameObject.GetComponent<levelController>().score++;
        //        //Debug.Log("multi20");
        //    }
        //    if (triggered.transform.tag == "multi25")
        //    {
        //        gameController.GetComponent<levelController>().particle += 0.7f;
        //        //Debug.Log(gameController.GetComponent<levelController>().particle);
        //        Scl2D.transform.localScale += new Vector3(0.07f, 0, 0);
        //        scoreMultiplies *= 1.5f;
        //        Destroy(triggered.gameObject);
        //        gameController.GetComponent<randomMap>().m25++;
        //        gameController.GetComponent<levelController>().score += 10;
        //        //gameObject.GetComponent<levelController>().score++;
        //        //Debug.Log("multi25");
        //    }
        //    if (triggered.transform.tag == "portal")
        //    {
        //        Scl2D.transform.localScale = new Vector3(0, 1, 1);
        //        gameController.GetComponent<levelController>().level++;
        //        Debug.Log("level " + gameController.GetComponent<levelController>().level);
        //        //gameObject.GetComponent<levelController>().score += 10;
        //        if (gameController.GetComponent<levelController>().level == 2)
        //        {
        //            lm.GetComponent<MeshRenderer>().material.color = new Color32(29, 8, 161, 1);
        //            rm.GetComponent<MeshRenderer>().material.color = new Color32(29, 8, 161, 1);
        //            pm.GetComponent<MeshRenderer>().material.color = new Color32(0, 153, 220, 1);
        //            RenderSettings.fog = true;
        //        }
        //        StartCoroutine("smoke");
        //        Destroy(triggered.gameObject);
        //    }
        //}
        #endregion
    }
    IEnumerator hiz()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            speed += 0.1f;
        }
        //StartCoroutine("hiz");
    }
    #region old collision
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.tag == "topwall")
        {
            canvas2d.SetActive(false);
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameOver.SetActive(true);
            //GameObject.FindGameObjectWithTag("MainCamera").SetActive(false);
            //gameOver.transform.position = Vector3.Lerp(gameOver.transform.position, new Vector3(0,40,0),3);
            Camera3D.SetActive(false);
            Camera2D.SetActive(false);
            //gameOver.transform.position = new Vector3(-7.5f, 0, 0);
            //gameObject.GetComponent<gameOver>().aaaa();
            //score.text = ((int)(calc.GetComponent<calcMeter>().Meter() * scoreMultiplies)).ToString();
            score.text = gameController.GetComponent<levelController>().score.ToString();
            gameOver.GetComponent<Animator>().Play(0);
            gameOver.GetComponent<gameOver>().enabled = true;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<planeControl>().enabled = false;
            gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
        }
        if (collision.transform.tag == "bottomwall")
        {
            canvas2d.SetActive(false);
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameOver.SetActive(true);
            //GameObject.FindGameObjectWithTag("MainCamera").SetActive(false);
            //gameOver.transform.position = Vector3.Lerp(gameOver.transform.position, new Vector3(0, 40, 0), 3);
            Camera3D.SetActive(false);
            Camera2D.SetActive(false);
            //gameOver.transform.position = new Vector3(-7.5f,0,0);
            //gameObject.GetComponent<gameOver>().aaaa();
            score.text = gameController.GetComponent<levelController>().score.ToString();
            gameOver.GetComponent<Animator>().Play(0);
            gameOver.GetComponent<gameOver>().enabled = true;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<planeControl>().enabled = false;
            gameObject.SetActive(false);
            //this.gameObject.SetActive(false);
        }
        

    }
    #endregion
    #region old trigger
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "multi15")
        {
            gameController.GetComponent<levelController>().particle += 0.7f;
            //Debug.Log(gameController.GetComponent<levelController>().particle);
            Scl2D.transform.localScale += new Vector3(0.07f, 0, 0);
            scoreMultiplies *= 1.1f;
            Destroy(collision.gameObject);
            gameController.GetComponent<randomMap>().m15++;
            gameController.GetComponent<levelController>().score += 10;
            //gameObject.GetComponent<levelController>().score++;
            //Debug.Log("multi15");
            
        }
        if (collision.transform.tag == "multi20")
        {
            gameController.GetComponent<levelController>().particle += 0.7f;
            //Debug.Log(gameController.GetComponent<levelController>().particle);
            Scl2D.transform.localScale += new Vector3(0.07f, 0, 0);
            scoreMultiplies *= 1.3f;
            Destroy(collision.gameObject);
            gameController.GetComponent<randomMap>().m20++;
            gameController.GetComponent<levelController>().score += 10;
            //gameObject.GetComponent<levelController>().score++;
            //Debug.Log("multi20");
        }
        if (collision.transform.tag == "multi25")
        {
            gameController.GetComponent<levelController>().particle += 0.7f;
            //Debug.Log(gameController.GetComponent<levelController>().particle);
            Scl2D.transform.localScale += new Vector3(0.07f, 0, 0);
            scoreMultiplies *= 1.5f;
            Destroy(collision.gameObject);
            gameController.GetComponent<randomMap>().m25++;
            gameController.GetComponent<levelController>().score += 10;
            //gameObject.GetComponent<levelController>().score++;
            //Debug.Log("multi25");
        }
        if (collision.transform.tag == "portal")
        {
            Scl2D.transform.localScale = new Vector3(0, 1, 1);
            gameController.GetComponent<levelController>().level++;
            Debug.Log("level " + gameController.GetComponent<levelController>().level);
            //gameObject.GetComponent<levelController>().score += 10;
            if (gameController.GetComponent<levelController>().level == 2)
            {
                lm.GetComponent<MeshRenderer>().material.color = new Color32(29, 8, 161,1);
                rm.GetComponent<MeshRenderer>().material.color = new Color32(29, 8, 161,1);
                pm.GetComponent<MeshRenderer>().material.color = new Color32(0, 153, 220,1);
                RenderSettings.fog = true;
            }
            StartCoroutine("smoke");
            Destroy(collision.gameObject);
        }
    }
    #endregion

    IEnumerator smoke()
    {
        part.SetActive(true);
        yield return new WaitForSeconds(2);
        part.SetActive(false);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Gizmos.DrawRay(new Ray(transform.position - new Vector3(0, transform.localScale.y / 3, 0), transform.forward));
        ////Gizmos.DrawRay(new Ray(transform.position - new Vector3(transform.localScale.x / 3, transform.localScale.y / 3, 0), transform.right));
        //Gizmos.DrawRay(new Ray(transform.position + new Vector3(transform.localScale.x / 2, -transform.localScale.y / 3, 0), -transform.right));
        Gizmos.DrawSphere(transform.position, GetComponent<CapsuleCollider>().radius);
    }
}
