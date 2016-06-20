using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * 1 * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += transform.right * 1 * Input.GetAxis("Horizontal") * Time.deltaTime;
        float yAxis = transform.rotation.eulerAngles.y + (150.0F * Input.GetAxis("Mouse X") * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, yAxis, 0);
    }
}
