using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileRoomManager : MonoBehaviour
{

    public GameObject[] tiles;
    public int numberOfTilesInSequence;

    public GameObject[] doors;

    private GameObject activeTile;
    private int progress;

    private void activateRandomTile()
    {
        int index;
        do
        {
            index = Random.Range(0, tiles.Length);
        }
        while (tiles[index] == activeTile);
        tiles[index].GetComponent<Tile>().Target();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        activateRandomTile();
    }

    public void registerTileCompletion()
    {
        progress++; // tile complete so increase progress

        if(progress >= numberOfTilesInSequence) // end point for room
        {
            // open door
            foreach (GameObject door in doors)
            {
                door.GetComponent<DoorToggle>().ToggleDoor();
            }
        }
        else // continue puzzle
        {
            activateRandomTile();
        }
    }
    
}
