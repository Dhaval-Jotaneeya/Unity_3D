using UnityEngine;

public class Collision : MonoBehaviour
{
    public Player_mov pm;
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.name == "wall")
        {
            pm.enabled = false;
        }
    }
}
