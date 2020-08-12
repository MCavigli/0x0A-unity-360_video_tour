using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script contains each room's info boxes as well as the buttons used
/// to navigate between rooms.
/// </summary>
public class InfoBoxes : MonoBehaviour
{
	// --- Living Room ---

	/// <summary>
	/// The panel that text is displayed on.
	/// </summary>
	public GameObject whitePanel;

	/// <summary>
	/// A button that gives information on the security guard, Bob.
	/// </summary>
	public GameObject bobButton;

	/// <summary>
	/// The information text that appears when the Bob button is selected.
	/// </summary>
	public GameObject bobPanel;

	/// <summary>
	/// The button that gives information about the library. 
	/// </summary>
	public GameObject libButton;

	/// <summary>
	/// The information text that appears when the library button is selected.
	/// </summary>
	public GameObject libPanel;

	// --- Cube ---

	/// <summary>
	/// The button that gives information about the cube.
	/// </summary>
	public GameObject cubeButton;

	/// <summary>
	/// The information text that appears when the cube button is selected.
	/// </summary>
	public GameObject cubePanel;

	// --- Cantina ---

	/// <summary>
	/// The button that gives information about the cantina.
	/// </summary>
	public GameObject cantinaButton;

	/// <summary>
	/// The information text that appears when the cantina button is selected.
	/// </summary>
	public GameObject cantinaPanel;

	// --- Mezzanine ---

	/// <summary>
	/// The button that gives information about the iMac matrix.
	/// </summary>
	public GameObject imacButton;

	/// <summary>
	/// The information text that appears when the iMac button is selected.
	/// </summary>
	public GameObject imacPanel;

	/// <summary>
	/// The button that gives information about the booths.
	/// </summary>
	public GameObject boothButton;

	/// <summary>
	/// The information text that appears when the booth button is selected.
	/// </summary>
	public GameObject boothPanel;

	// --- Living Room ---

	/// <summary>
	/// Activates and deactivates the panel for the whiteboards.
	/// </summary>
	public void WhiteboardPanel()
	{
		if (whitePanel.activeSelf)
			whitePanel.SetActive(false);
		else
			whitePanel.SetActive(true);
	}

	/// <summary>
	/// Activbates and deactivates the panel for Bob.
	/// </summary>
	public void BobPanel()
	{
		if (bobPanel.activeSelf)
			bobPanel.SetActive(false);
		else
			bobPanel.SetActive(true);
	}

	/// <summary>
	/// Activates and deactivates the panel for the library.
	/// </summary>
	public void LibraryPanel()
	{
		if (libPanel.activeSelf)
			libPanel.SetActive(false);
		else
			libPanel.SetActive(true);
	}

	// --- Cube ---

	/// <summary>
	/// Activates and deactivates the panel for the cube.
	/// </summary>
	public void CubePanel()
	{
		if (cubePanel.activeSelf)
			cubePanel.SetActive(false);
		else
			cubePanel.SetActive(true);
	}

	// --- Cantina ---

	/// <summary>
	/// Activates and deactivates the panel for the cantina.
	/// </summary>
	public void CantinaPanel()
	{
		if (cantinaPanel.activeSelf)
			cantinaPanel.SetActive(false);
		else
			cantinaPanel.SetActive(true);
	}

	// --- Mezzanine ---

	/// <summary>
	/// Activates and deactivates the panel for the iMac matrix.
	/// </summary>
	public void ImacPanel()
	{
		if (imacPanel.activeSelf)
			imacPanel.SetActive(false);
		else
			imacPanel.SetActive(true);
	}

	/// <summary>
	/// Activates and deactivates the panel for the booths.
	/// </summary>
	public void BoothPanel()
	{
		if (boothPanel.activeSelf)
			boothPanel.SetActive(false);
		else
			boothPanel.SetActive(true);
	}
}
