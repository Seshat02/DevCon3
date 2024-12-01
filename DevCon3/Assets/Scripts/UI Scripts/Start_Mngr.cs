using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Mngr : MonoBehaviour
{
    public GameObject toRotate;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        toRotate.transform.Rotate(Vector3.up * speed * Time.deltaTime);
        player.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    
}
