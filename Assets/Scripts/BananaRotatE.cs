using UnityEngine;

public class BananaRotatE : MonoBehaviour
{
  public bool rotateX = false;
	public bool rotateY = true;
	public bool rotateZ = false;
	public float speed = 50f;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
		Vector3 rotation = Vector3.zero;
		if (rotateX)
		{
			rotation += Vector3.right;
		}
		if (rotateY)
		{
			rotation += Vector3.up;
		}
		if (rotateZ)
		{
			rotation += Vector3.forward;
		}
		transform.Rotate(rotation * speed * Time.deltaTime);
  }
}
