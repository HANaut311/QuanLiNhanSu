using UnityEngine;
using System.Linq;

public class SortGameObjects : MonoBehaviour
{
    void OnValidate()
    {
        // Lấy danh sách các GameObject con của GameObject cha
        Transform parentTransform = transform; // Đổi thành biến chứa transform của GameObject cha của bạn
        int childCount = parentTransform.childCount;
        GameObject[] children = new GameObject[childCount];

        for (int i = 0; i < childCount; i++)
        {
            children[i] = parentTransform.GetChild(i).gameObject;
        }

        // Sắp xếp theo tên của GameObject
        var sortedChildren = children.OrderBy(go => go.name).ToArray();

        // Đặt lại vị trí của các GameObject con trong GameObject cha
        for (int i = 0; i < sortedChildren.Length; i++)
        {
            sortedChildren[i].transform.SetSiblingIndex(i);
        }
    }
}
