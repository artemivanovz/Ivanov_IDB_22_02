using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public float Speed =10f;
    public int a;
    public int b;
    public int c;
    public Text x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      if (c <= 0)
      {
        this.gameObject.SetActive(false);
        x.text = "Game Over";
      }
      else x.text = c.ToString();
      if (Input.GetKey(KeyCode.W))
      {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.S))
      {
        transform.Translate(Vector3.back * Speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.A))
      {
        transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.D))
      {
        transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
      }
    }
    private void OnCollisionEnter(Collision collision)
      {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
      }
    private void OnCollisionExit(Collision collision)
      {
        Debug.Log("CT");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
      }  
    private void OnCollisionStay(Collision collision)
      {
        Debug.Log("CS");
      }  
    private void OnTriggerEnter(Collider other)
      {
        Debug.Log("TEN");
      } 
    private void OnTriggerStay(Collider other)
      {
        Debug.Log("TS");
      } 
    private void OnTriggerExit(Collider other)
      {
        Debug.Log("TEX");
      } 
    public void heal()
    {
      c=5;
    }
  
}
