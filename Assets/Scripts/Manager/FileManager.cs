using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro; // Import Unity UI library
using System.Windows.Forms;
public class FileManager : MonoBehaviour
{
    string path;
    public TextMeshProUGUI pathText; // Reference to your Text UI element
//     public void OpenExplorer()
//     {
// #if UNITY_EDITOR
//         path = EditorUtility.SaveFilePanel("Overwrite with xlsx", "", name, "xlsx");

//         if (pathText != null)
//         {
//             pathText.text = path;
//         }
// #else
//         SaveFileDialog saveFileDialog = new SaveFileDialog();
//         saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
//         saveFileDialog.Title = "Save Excel File";
        
//         if (saveFileDialog.ShowDialog() == DialogResult.OK)
//         {
//             string path = saveFileDialog.FileName;
//             if (pathText != null)
//             {
//                 pathText.text = path;
//             }
//         }

// #endif
//     }
    

    public void OpenExplorer()
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
        saveFileDialog.Title = "Save Excel File";
        
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string path = saveFileDialog.FileName;
            if (pathText != null)
            {
                pathText.text = path;
            }
        }
    }

}
