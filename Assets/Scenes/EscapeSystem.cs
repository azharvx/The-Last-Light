using UnityEngine;

public class EscapeSystem : MonoBehaviour
{
    public Transform finalKey;
    public Transform finalDoor;
    public GameObject winScreen;
    public bool hasFinalKey = false;
    public Transform room4Respawn;
    public float waterDeathHeight = -1.0f;
    public Transform key;
    public Transform door1;
    public bool hasKey = false;
    private bool door1Opened = false;

    public Transform crowbar;
    public GameObject planks;
    public Transform door2;
    public bool hasCrowbar = false;
    private bool door2Opened = false;

    void Update()
    {
        if (room4Respawn != null && transform.position.y < waterDeathHeight)
        {
            CharacterController cc = GetComponent<CharacterController>();
            if (cc != null) cc.enabled = false;
            transform.position = room4Respawn.position;
            if (cc != null) cc.enabled = true;
        }
        if (key != null && !hasKey)
        {
            if (Vector3.Distance(transform.position, key.position) < 1.5f)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hasKey = true;
                    key.gameObject.SetActive(false);
                }
            }
        }

        if (door1 != null && hasKey && !door1Opened)
        {
            if (Vector3.Distance(transform.position, door1.position) < 1.5f)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    door1Opened = true;
                    door1.Rotate(0, 90, 0);
                }
            }
        }

if (crowbar != null && !hasCrowbar)
{
    if (Vector3.Distance(transform.position, crowbar.position) < 1.5f)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            hasCrowbar = true;
            crowbar.gameObject.SetActive(false);
        }
    }
}

if (door2 != null && hasCrowbar && !door2Opened)
{
    if (Vector3.Distance(transform.position, door2.position) < 1.5f)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            door2Opened = true;
        
        if (planks != null)
        {
            planks.SetActive(false);
        }

        door2.Rotate(0, 90, 0);
        }
    }
}
if (finalKey != null && !hasFinalKey &&  Vector3.Distance(transform.position, finalKey.position) < 1.5f)
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        hasFinalKey = true;
        finalKey.gameObject.SetActive(false);
    }
}
if (finalDoor != null && hasFinalKey && Vector3.Distance(transform.position, finalDoor.position) < 4.0f)
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        finalDoor.Find("Door").Rotate(0,90,0);
}
    }
    }
}

                

    

