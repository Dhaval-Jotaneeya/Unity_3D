using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform Player_Movment;
    public Text Display_Score;

    void Update() 
    {
        Display_Score.text = Player_Movment.position.z.ToString("0");
    }
}
