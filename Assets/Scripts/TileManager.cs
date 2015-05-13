using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class TileManager : MonoBehaviour
{
    static public TileManager get;
    public List<GameObject> tiles;
    public float speed;
    public static Vector3 moveVector = new Vector3(0, 0, -1);

    private float tileSize = 50;
    private GameObject lastTile;
    private int id;

    private List<Material> listMaterials;

    void Awake()
    {
        get = this;
        id = 0;

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = InstantiateChunk();
            obj.transform.position = new Vector3(-i * tileSize, 0, 0);

            lastTile = obj;
        }
    }

    // Use this for initialization
    void Start()
    {
        Renderer[] renderers = FindObjectsOfType(typeof(Renderer)) as Renderer[];

        listMaterials = new List<Material>();
        foreach (Renderer _renderer in renderers)
        {
            listMaterials.AddRange(_renderer.sharedMaterials);
        }

        listMaterials = listMaterials.Distinct().ToList();
    }


    // Update is called once per frame
    void Update()
    {

    }

    GameObject InstantiateChunk()
    {
        id += 1;
        if (id == 9)
        {
            id = 0;
        }

        return (GameObject)Instantiate(tiles[id]);
    }

    public void ResetTile(ScrollingTile tile)
    {
        tile.gameObject.SetActive(false);

        Vector3 newPos = lastTile.transform.position;
        newPos.x -= tileSize;

        tile.gameObject.SetActive(true);
        lastTile = tile.gameObject;
        lastTile.transform.position = newPos;

    }
}
