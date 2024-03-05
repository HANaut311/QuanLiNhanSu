// using System.Collections;
// using System.Collections.Generic;
// using System.Linq;
// using UnityEngine;
// using UnityEngine.UI;

// public class PlayerManager : MonoBehaviour
// {
//     public static PlayerManager instance;    
//     public List<Button> buttons;
//     private void Awake()
//     {   
//         if(instance != null)
//             Destroy(instance.gameObject);
//         else
//         {
//             instance = this;
//             DontDestroyOnLoad(gameObject);
//         }
//     }

//     void Start()
//     {
//         // Sắp xếp danh sách các Button theo nội dung của nút (ví dụ: text của nút)
//         List<Button> sortedButtons = buttons.OrderBy(button => button.GetComponentInChildren<Text>().text).ToList();

//         // Di chuyển các button đã sắp xếp vào vị trí mới
//         for (int i = 0; i < sortedButtons.Count; i++)
//         {
//             sortedButtons[i].transform.SetSiblingIndex(i);
//         }
//     }
// }
