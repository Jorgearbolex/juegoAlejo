using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
  
    float speed = 3;
    public static Vector3 pos;
   

    void Start()
    {
        GameObject empty = new GameObject();
        empty.name = "Camera";
        empty.AddComponent<Camera>();
        empty.AddComponent<GiraCam>();
        empty.transform.SetParent(transform);
        empty.transform.localPosition = Vector3.zero;
        //gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);


    }
    void Update()
    {
        MueveNave();
    }
    void MueveNave()
    {
        transform.eulerAngles = new Vector3(0, GiraCam.rotY, 0);
        if (Input.GetKey(KeyCode.W)) { transform.position += transform.forward * (speed / 20); }
        if (Input.GetKey(KeyCode.S)) { transform.position -= transform.forward * (speed / 20); }
        if (Input.GetKey(KeyCode.D)) { transform.position += transform.right * (speed / 20); }
        if (Input.GetKey(KeyCode.A)) { transform.position -= transform.right * (speed / 20); }
        pos = transform.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene("Gonorr");
        }
    }

    
}
