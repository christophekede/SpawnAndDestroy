using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Supprimer les spheres
public class Touch : MonoBehaviour
{


    public GameObject arCam;

    public void touch(){
        RaycastHit hit;
        if(Physics.Raycast(arCam.transform.position, arCam.transform.forward, out hit)){
            if(hit.transform.name == "sp1(Clone)" || hit.transform.name == "sp2(Clone)" || hit.transform.name == "sp3(Clone)"){
                Destroy(hit.transform.gameObject);
            }
        }
    }
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
