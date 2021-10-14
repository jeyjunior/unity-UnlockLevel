using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelManager : MonoBehaviour
{

    //public bool[] level;
    public Button[] btnLevel;
    public int btnActive = 0; //Valor dessa var é igual ao valor da fase carregada (fase1 = 1, fase2 = 2...)

    private void Start()
    {
        //Recuperamos da key LevelComplete o valor (int) do total de fases liberadas
        btnActive = PlayerPrefs.GetInt("LevelComplete");
    }

    private void Update()
    {

        //valor de i sempre é inicializado com o valor que esta na var btnActive
        //esse valor de inicialização reflete em qual btn do array btnLevel, sera habilitado
        //os botões habilitados representam as fases que foram concluidas
        for (int i = btnActive; i < btnLevel.Length; i++) {

            btnLevel[i].interactable = false;
        }
    }


    //level select btn
    public void LoadLevel(Button btnName)
    {
        SceneManager.LoadScene(btnName.name);
    }

    //
    public void ZerarSaves()
    {
        PlayerPrefs.DeleteAll();
    }
}
