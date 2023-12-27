using UnityEngine;



public class UIManager : MonoBehaviour
{
	//Метод удаления кнопок
	public void RemoveButton(GameObject buttonToRemove)
	{
		Destroy(buttonToRemove);
	}

	//Метод закрытия окна
	public void CloseWindow(GameObject panel)
	{
		panel.SetActive(false);
	}

	//Метод открытия окна
	public void OpenWindow(GameObject panel)
	{
		panel.SetActive(true);
	}
}
