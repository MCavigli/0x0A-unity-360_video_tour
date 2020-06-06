using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBoxes : MonoBehaviour
{
	// Living Room
	public GameObject white;
	public GameObject whitePanel;
	public GameObject bobButton;
	public GameObject bobPanel;
	public GameObject libButton;
	public GameObject libPanel;
	// Cube
	public GameObject cubeButton;
	public GameObject cubePanel;
	// Cantina
	public GameObject cantinaButton;
	public GameObject cantinaPanel;
	// Mezzanine
	public GameObject imacButton;
	public GameObject imacPanel;
	public GameObject boothButton;
	public GameObject boothPanel;

	// Living Room
	public void WhiteboardPanel()
	{
		if (whitePanel.activeSelf)
			whitePanel.SetActive(false);
		else
			whitePanel.SetActive(true);
	}
	public void BobPanel()
	{
		if (bobPanel.activeSelf)
			bobPanel.SetActive(false);
		else
			bobPanel.SetActive(true);
	}
	public void LibraryPanel()
	{
		if (libPanel.activeSelf)
			libPanel.SetActive(false);
		else
			libPanel.SetActive(true);
	}

	// Cube
	public void CubePanel()
	{
		if (cubePanel.activeSelf)
			cubePanel.SetActive(false);
		else
			cubePanel.SetActive(true);
	}

	// Cantina
	public void CantinaPanel()
	{
		if (cantinaPanel.activeSelf)
			cantinaPanel.SetActive(false);
		else
			cantinaPanel.SetActive(true);
	}

	//Mezzanine
	public void ImacPanel()
	{
		if (imacPanel.activeSelf)
			imacPanel.SetActive(false);
		else
			imacPanel.SetActive(true);
	}
	public void BoothPanel()
	{
		if (boothPanel.activeSelf)
			boothPanel.SetActive(false);
		else
			boothPanel.SetActive(true);
	}
}
