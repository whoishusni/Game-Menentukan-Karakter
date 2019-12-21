using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Dropdown resDropdown;
    Resolution[] allResolutions;
    // Start is called before the first frame update
    void Start()
    {
        allResolutions = Screen.resolutions;

        resDropdown.ClearOptions();
        List<string> optionList = new List<string>();
       

        int currentResIndex = 0;
        for(int i = 0; i < allResolutions.Length; i++)
        {
            string option = allResolutions[i].width + " x " + allResolutions[i].height;
            optionList.Add(option);

            if(allResolutions[i].width == Screen.currentResolution.width &&
                allResolutions[i].height == Screen.currentResolution.height)
            {
                currentResIndex = i;
            }
        }

        resDropdown.AddOptions(optionList);
        resDropdown.value = currentResIndex;
        resDropdown.RefreshShownValue();
        
    }

    public void fullScreenOption(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void setResolution(int resolutionSet)
    {
        Resolution resolution = allResolutions[resolutionSet];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
