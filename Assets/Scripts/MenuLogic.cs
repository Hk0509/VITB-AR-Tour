using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLogic : MonoBehaviour
{
  public void ExitButton()
  {
    Application.Quit();
  }
  public void PlayButton()
  {
      SceneManager.LoadScene("SampleScene");
  }
  public void AcademicButton()
  {
    SceneManager.LoadScene("AcademicBlock");
  }
  public void BoysHostelButton()
  {
    SceneManager.LoadScene("BoysHostel");
  }
  public void GirlsHostelButton()
  {
    SceneManager.LoadScene("GirlsHostel");
  }
  public void BoysHostelB2Button()
  {
    SceneManager.LoadScene("BoysHostelB2");
  }
  public void LabComplexButton()
  {
    SceneManager.LoadScene("LabComplex");
  }
  public void MulriPurposeButton()
  {
    SceneManager.LoadScene("MultipurposeHall");
  }
  public void MenuButton()
  {
    SceneManager.LoadScene("MainMenuScene");
  }
}
    