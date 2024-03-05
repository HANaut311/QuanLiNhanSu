using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject[] infoContainers;

    public void ShowInfo(int buttonIndex)
    {
        for (int i = 0; i < infoContainers.Length; i++)
        {
            if (i == buttonIndex)
            {
                // Nếu là Button được chọn, hiển thị thông tin
                infoContainers[i].SetActive(true);
            }
            else
            {
                // Ngược lại, ẩn thông tin của các Button khác
                infoContainers[i].SetActive(false);
            }
        }
    }
}