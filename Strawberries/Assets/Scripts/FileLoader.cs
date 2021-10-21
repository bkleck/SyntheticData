using System.Collections;
using System.Collections.Generic;
using TriLibCore;
using TriLibCore.General;
using UnityEngine;
using UnityEngine.Perception.GroundTruth;
using UnityEngine.UI;

public class FileLoader : MonoBehaviour
{
    private Slider slider;

    // Lets the user load a new model by clicking a GUI button.
    private void OnGUI()
    {
        // Displays a button to begin the model loading process.
        if (GUILayout.Button("Load Model from File"))
        {
            // Creates an AssetLoaderOptions instance.
            // AssetLoaderOptions is a class used to configure many aspects of the loading process.
            // We won't change the default settings this time, so we can use the instance as it is.
            var assetLoaderOptions = AssetLoader.CreateDefaultLoaderOptions();

            // Creates the AssetLoaderFilePicker instance.
            // AssetLoaderFilePicker is a class that allows users to select models from the local file system.
            var assetLoaderFilePicker = AssetLoaderFilePicker.Create();

            // Shows the model selection file-picker.
            assetLoaderFilePicker.LoadModelFromFilePickerAsync("Select a File", OnLoad, OnMaterialsLoad, OnProgress, OnBeginLoad, OnError, null, assetLoaderOptions);
        }
    }

    // This event is called when the model is about to be loaded.
    // You can use this event to do some loading preparation, like showing a loading screen in platforms without threading support.
    // This event receives a Boolean indicating if any file has been selected on the file-picker dialog.
    private void OnBeginLoad(bool anyModelSelected)
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // This event is called when the model loading progress changes.
    // You can use this event to update a loading progress-bar, for instance.
    // The "progress" value comes as a normalized float (goes from 0 to 1).
    // Platforms like UWP and WebGL don't call this method at this moment, since they don't use threads.
    private void OnProgress(AssetLoaderContext assetLoaderContext, float progress)
    {   
            slider.value = progress;
    }

    // This event is called when there is any critical error loading your model.
    // You can use this to show a message to the user.
    private void OnError(IContextualizedError contextualizedError)
    {
        Debug.Log("3D Object cannot be loaded.");
    }

    // This event is called when all model GameObjects and Meshes have been loaded.
    // There may still Materials and Textures processing at this stage.
    private void OnLoad(AssetLoaderContext assetLoaderContext)
    {
        // The root loaded GameObject is assigned to the "assetLoaderContext.RootGameObject" field.
        // If you want to make sure the GameObject will be visible only when all Materials and Textures have been loaded, you can disable it at this step.
        var myLoadedGameObject = assetLoaderContext.RootGameObject;
        myLoadedGameObject.SetActive(false);
    }

    // This event is called after OnLoad when all Materials and Textures have been loaded.
    // This event is also called after a critical loading error, so you can clean up any resource you want to.
    private void OnMaterialsLoad(AssetLoaderContext assetLoaderContext)
    {
        // The root loaded GameObject is assigned to the "assetLoaderContext.RootGameObject" field.
        // You can make the GameObject visible again at this step if you prefer to.
        var myLoadedGameObject = assetLoaderContext.RootGameObject;
        myLoadedGameObject.SetActive(true);

        // Get the object name to add to label config
        string ObjectName = myLoadedGameObject.name;
        Debug.LogFormat("Object name is {0}.", ObjectName);
        Debug.Log("3D Object has completed loading!");

        // Do not destroy object so that next scene it can be referenced
        myLoadedGameObject.name = "LoadedObject";

        // Add a label component to the instantiated object
        // Make use of the user input to set the label ID of the object
        myLoadedGameObject.AddComponent<Labeling>();
        var labeling = myLoadedGameObject.GetComponent<Labeling>();
        Debug.Log(PlayerPrefs.GetString("object"));
        labeling.labels.Add(PlayerPrefs.GetString("object", "NULL"));

        DontDestroyOnLoad(myLoadedGameObject);


    }
}
