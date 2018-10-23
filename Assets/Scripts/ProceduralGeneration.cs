using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGeneration : MonoBehaviour {

	public GameObject GrassPath;
	public GameObject WaterPath;
	public GameObject RoadPath;

	public Transform[] floorPrefabs;
	public int maxFloorSize = 12;
	public int minFloorSize = 5;

	public GameObject player;

	int distanceToPlayer = 10;
	int randomFloorType;
	int randomFloorSize;

	void Start ()
	{
		
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			if ((player.transform.position.x - (distanceToPlayer-15)) < 0)
				return;	

			randomFloorType = Random.Range(0, floorPrefabs.Length);
			randomFloorSize = Random.Range(minFloorSize , maxFloorSize);
			for (int i = 0; i < randomFloorSize; i++)
			{
				Transform newFloor = floorPrefabs[randomFloorType];
				Vector3 newFloorPosition = new Vector3(distanceToPlayer++, newFloor.transform.position.y, newFloor.transform.position.z);
				Instantiate(newFloor, newFloorPosition, newFloor.rotation, transform);
			}
		}
	}﻿
}
