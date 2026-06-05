using UnityEngine;

public class Cameras: MonoBehaviour
{
    public Camera[] cams;
    public Camera cam;
    public int current;// camera ativa

    void Start()
    {
        //print("oi");
        Debug.Log("O jogo começou!");
        Debug.Log(cams[1]);

    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            
            //cams[2].enabled = true;
            //cams[current].enabled = false;
            //current = 2;

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            cams[3].enabled = true;
            cams[current].enabled = false;
            current = 3;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            cams[0].enabled = true;
            cams[current].enabled = false;
            current = 0;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            cams[1].enabled = true;
            cams[current].enabled = false;
            current = 1;
        }if 

        
    }

    //cam.GetComponent(Transform).<>.rotation.x +=Input.GetAxis("Mouse X");

}
