using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NewTourManager : MonoBehaviour
{
	public OVRCameraRig cam;
	public GameObject liv;
	public GameObject cant;
	public GameObject cube;
	public GameObject mez;

	public void EnterLivingRoom()
	{
		cam.transform.position = new Vector3(0, 0, 0);
		liv.GetComponent<VideoPlayer>().enabled = true;
		cant.GetComponent<VideoPlayer>().enabled = false;
		cube.GetComponent<VideoPlayer>().enabled = false;
		mez.GetComponent<VideoPlayer>().enabled = false;
	}
	public void EnterCantina()
	{
		cam.transform.position = new Vector3(100, 0, 0);
		liv.GetComponent<VideoPlayer>().enabled = false;
		cant.GetComponent<VideoPlayer>().enabled = true;
		cube.GetComponent<VideoPlayer>().enabled = false;
		mez.GetComponent<VideoPlayer>().enabled = false;
	}

	public void EnterCube()
	{
		cam.transform.position = new Vector3(0, 0, 100);
		liv.GetComponent<VideoPlayer>().enabled = false;
		cant.GetComponent<VideoPlayer>().enabled = false;
		cube.GetComponent<VideoPlayer>().enabled = true;
		mez.GetComponent<VideoPlayer>().enabled = false;
	}

	public void EnterMez()
	{
		cam.transform.position = new Vector3(100, 0, 100);
		liv.GetComponent<VideoPlayer>().enabled = false;
		cant.GetComponent<VideoPlayer>().enabled = false;
		cube.GetComponent<VideoPlayer>().enabled = false;
		mez.GetComponent<VideoPlayer>().enabled = true;
	}
}
