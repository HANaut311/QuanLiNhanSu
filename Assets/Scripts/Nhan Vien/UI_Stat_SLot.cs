
// using TMPro;
// using UnityEngine;


// public class UI_Stat_SLot : MonoBehaviour
// {   
//     [SerializeField] private string statName;

//     [SerializeField] private StatType statType;
//     [SerializeField] private TextMeshProUGUI statValueText;

//     private void OnValidate()
//     {
//         gameObject.name = statName;

//     }
//     void Start()
//     {
//         UpdateStatValueUI();

//     }

//     public void UpdateStatValueUI()
//     {
//         NhanVienStats playerStats = PlayerManager.instance.GetComponent<NhanVienStats>();
//         if(playerStats != null)
//         {
//             statValueText.text = playerStats.GetStat(statType).GetValue().ToString();
//         }

//     }


// }
