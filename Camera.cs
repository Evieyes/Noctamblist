using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public Transform player;
    public float smooth = 0.5f;
    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.position;
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, player.position + offset , smooth * Time.deltaTime);
	
	}
}
