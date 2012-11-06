using UnityEngine;
using System.Collections;

public class Starscript : MonoBehaviour {
	
	public float orbitRadius;
	public GameObject radius;
	public GameObject r;
	public Color c;
	public Texture t;
	public float starSize = 15f;
	public GameObject lightGameObject;
	public float duration = 20f;
	public float offset;
	public float random;
	
	void Start () {
		this.transform.localScale *= starSize;
		orbitRadius = starSize;
//		r = Instantiate(radius, new Vector3 (this.transform.position.x, this.transform.position.y, 100f), new Quaternion (0, 0, 0, 0)) as GameObject;
//		r.light.range = 2*orbitRadius;
		random = Random.value;
	
	}
	
	void Update() {
		transform.RotateAround(this.transform.position, Vector3.forward, 50*Time.deltaTime*random);
		renderer.material.mainTexture = t;
  //      r.light.color = c;
		//make stars glow
		offset = starSize/5;
        float phi = Time.time / duration + offset;
        float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
    //    r.light.intensity = amplitude*offset + starSize/30;

	}
	
}
