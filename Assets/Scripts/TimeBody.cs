using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TimeBody : MonoBehaviour {
	bool shouldStop = false;
	bool isRewinding = false;
	bool stopRecording = false;
	//bool goingtoRewind = false;
	// public InputActionAsset playerControls;
	// private InputAction menubutton;
	// private InputAction xrgrip;
	[SerializeField] private InputActionReference rwonot;
	//UserInput uinput;
	public float recordTime = 1f;

	List<PointInTime> pointsInTime;

	Rigidbody rb;


	// void Awake(){
	// 	var gameplayActionMap = playerControls.FindActionMap("Player");

	// 	menubutton = gameplayActionMap.FindAction("ReplayOrNot");
	// 	menubutton.Enable();

	// 	xrgrip = gameplayActionMap.FindAction("PauseOrNot");
	// 	xrgrip.Enable();
	// }
	// Use this for initialization
	void Start () {
		pointsInTime = new List<PointInTime>();
		rb = GetComponent<Rigidbody>();
		//rwonot.Enable();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))//||  menubutton.wasPressedThisFrame)
			StartRewind();
		if (Input.GetKeyUp(KeyCode.Return)){
		rb.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.green);
			StopRewind();}


		if (Input.GetKeyDown(KeyCode.RightShift)){
			shouldStop = !shouldStop;
			stopThis();
		}
	}


	void RewindOrNot(InputValue RewindOrNot){
		Debug.Log("REWIND OR NOT ACTIVATED");
	}
	void stopThis(){
		if(shouldStop){
			stopRecording = true;
			rb.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.blue);
			rb.constraints = RigidbodyConstraints.FreezePosition;
		} else if (!shouldStop){
			stopRecording = false;
			rb.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.green);
			rb.constraints = RigidbodyConstraints.None;
		}
	}

	void FixedUpdate ()
	{
		if (isRewinding)
			Rewind();
		else
			Record();
	}

	void Rewind ()
	{
		if (pointsInTime.Count > 0)
		{
			rb.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.red);
			PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
			transform.rotation = pointInTime.rotation;
			pointsInTime.RemoveAt(0);
		} else
		{
			StopRewind();
			rb.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", Color.green);

		}
		
	}

	void Record ()
	{ 
		if (!stopRecording){

		
		if (pointsInTime.Count > Mathf.Round(recordTime / Time.fixedDeltaTime)) 
		{
			pointsInTime.RemoveAt(pointsInTime.Count - 1);
		}

		pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
		} 
	}

	public void StartRewind ()
	{
		isRewinding = true;
		rb.isKinematic = true;
	}

	public void StopRewind ()
	{
		isRewinding = false;
		rb.isKinematic = false;
	}
}