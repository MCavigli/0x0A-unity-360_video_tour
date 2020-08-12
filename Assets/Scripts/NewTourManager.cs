using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

/// <summary>
/// This script enables a user to move through different rooms in the tour
/// </summary>
public class NewTourManager : MonoBehaviour
{
	/// <summary>
	/// The camera that is placed in the middle of a room. This is the point of
	/// view the user experiences the tour from.
	/// </summary>
	public OVRCameraRig cam;

	/// <summary>
	/// The living room and starting point of the tour.
	/// </summary>
	public GameObject liv;

	/// <summary>
	/// The cantina.
	/// </summary>
	public GameObject cant;

	/// <summary>
	/// The cube.
	/// </summary>
	public GameObject cube;

	/// <summary>
	/// The mezzanine.
	/// </summary>
	public GameObject mez;

	/// <summary>
	/// This is the starting point of the tour. It places the user in the living
	/// room and turns off all other cameras to save resources.
	/// </summary>
	public void EnterLivingRoom()
	{
		cam.transform.position = new Vector3(-18, 0, 0);
		liv.GetComponent<VideoPlayer>().enabled = true;
		cant.GetComponent<VideoPlayer>().enabled = false;
		cube.GetComponent<VideoPlayer>().enabled = false;
		mez.GetComponent<VideoPlayer>().enabled = false;
	}

	/// <summary>
	/// Deactivates all cameras but the cantina's.
	/// </summary>
	public void EnterCantina()
	{
		cam.transform.position = new Vector3(81, 0, 0);
		liv.GetComponent<VideoPlayer>().enabled = false;
		cant.GetComponent<VideoPlayer>().enabled = true;
		cube.GetComponent<VideoPlayer>().enabled = false;
		mez.GetComponent<VideoPlayer>().enabled = false;
	}

	/// <summary>
	/// Deactivates all cameras but the cube's.
	/// </summary>
	public void EnterCube()
	{
		cam.transform.position = new Vector3(-18, 0, 90);
		liv.GetComponent<VideoPlayer>().enabled = false;
		cant.GetComponent<VideoPlayer>().enabled = false;
		cube.GetComponent<VideoPlayer>().enabled = true;
		mez.GetComponent<VideoPlayer>().enabled = false;
	}

	/// <summary>
	/// Deactivates all cameras but the mezzanine's.
	/// </summary>
	public void EnterMez()
	{
		cam.transform.position = new Vector3(81, 0, 90);
		liv.GetComponent<VideoPlayer>().enabled = false;
		cant.GetComponent<VideoPlayer>().enabled = false;
		cube.GetComponent<VideoPlayer>().enabled = false;
		mez.GetComponent<VideoPlayer>().enabled = true;
	}
}
