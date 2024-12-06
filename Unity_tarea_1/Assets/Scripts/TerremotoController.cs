using System.Collections;
using UnityEngine;

public class TerremotoController : MonoBehaviour
{
    GameObject[] modulos;
    [SerializeField] float fuerza = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        modulos = GameObject.FindGameObjectsWithTag("item_terremoto");
        Debug.Log("Elementos del terremoto: " + modulos.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Terremoto!!");
            StartCoroutine("Terremoto");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Fin terremoto");
            StopCoroutine("Terremoto");
        }
        
    }
    IEnumerator Terremoto()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1f, 5f));
            for (int i = 0; i < modulos.Length; i++)
            {
                Vector3 direccion = new Vector3(Random.Range(-1f,1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
                modulos[i].GetComponent<Rigidbody>().AddForce(direccion * fuerza, ForceMode.Impulse);
            }
            //mover cámara
        }
    }
}
