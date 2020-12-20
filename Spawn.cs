using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Generer des spheres
public class Spawn : MonoBehaviour
{
    public Transform[] spawnP;
    public GameObject[] cubes;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(StartSpawn());
    }
   IEnumerator StartSpawn(){
       yield return new WaitForSeconds(4);

       for(int i =0; i<3; i++){
           Instantiate(cubes[i], spawnP[i].position, Quaternion.identity);
       }
       StartCoroutine(StartSpawn());
   }
}
