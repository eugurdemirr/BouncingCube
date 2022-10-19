using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{
 
    public GameObject Platform;
    private Transform tr;
    public int ZeminSayisi;
    public float ZeminGenislik;
    public float MinY,MaxY;



    
   private void Start()
    {
        tr = Platform.GetComponent<Transform>();
        Vector3 newSpawn = new Vector3();
        Vector2 newScale = new Vector2();

        for (int i = 0; i < ZeminSayisi; i++)
        {
            newScale.x = Random.Range(0.7f,0.9f);
            newScale.y = Random.Range(0.7f,0.9f);
            tr.localScale = newScale;

            newSpawn.y += Random.Range(MinY,MaxY);
            newSpawn.x = Random.Range(-ZeminGenislik,ZeminGenislik);

            Instantiate(Platform,newSpawn,Quaternion.identity);
        }
    }

    
}
