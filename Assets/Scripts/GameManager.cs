using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public GameObject Nave;

    public GameObject Canvas;

    public Camera Camera;

    bool ejecting = false;

    void Start()
    {
        
    }


    public void Ejection(){

        
        Canvas.SetActive(false);
        StartCoroutine(Cinematic());
        

    }

    IEnumerator Cinematic(){


        float startTime= 0.0f;
        while (true){
            startTime += Time.deltaTime;
            Camera.gameObject.transform.position = Vector3.Lerp(Camera.gameObject.transform.position, Camera.gameObject.transform.position + new Vector3 (0,0,3), 0.02f);  

            if(startTime > .5f) {
                  break;
            }

             yield return null;
        }

        Nave.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,1000));

    }

}
