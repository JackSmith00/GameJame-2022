using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    public Material targetTileMaterial;
    public Material nonTargetTileMaterial;
    public GameObject roomManager;

    [HideInInspector] public bool target = false;

    public void Target()
    {
        this.gameObject.GetComponent<MeshRenderer>().material = targetTileMaterial;
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<MeshRenderer>().material = nonTargetTileMaterial;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        // update manager
        roomManager.GetComponent<TileRoomManager>().registerTileCompletion();
    }

}
