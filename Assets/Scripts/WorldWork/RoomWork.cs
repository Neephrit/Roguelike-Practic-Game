using UnityEngine;

public class RoomWork : MonoBehaviour
{
    public bool CanEscape;

    [SerializeField] private int _curentEnimys = 10;

    private void FixedUpdate()
    {
        if (_curentEnimys <= 0)
            CanEscape = true;
        else
            CanEscape = false;
    }
    public void RemEnimy()
    {
        _curentEnimys--;
    }
}
