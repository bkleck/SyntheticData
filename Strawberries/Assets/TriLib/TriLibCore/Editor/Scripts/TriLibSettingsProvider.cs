﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TriLibCore.Mappers;
using UnityEditor;
using UnityEngine;

namespace TriLibCore.Editor
{
    public class TriLibSettingsProvider : SettingsProvider
    {
        private class Styles
        {
            public static readonly GUIStyle Group = new GUIStyle { padding = new RectOffset(10, 10, 5, 5) };
        }

        private static string _settingsFilePath;

        public TriLibSettingsProvider(string path, SettingsScope scopes = SettingsScope.User, IEnumerable<string> keywords = null) : base(path, scopes, keywords)
        {
            var settingsAssetGuids = AssetDatabase.FindAssets("TriLibReaders");
            if (settingsAssetGuids.Length > 0)
            {
                _settingsFilePath = AssetDatabase.GUIDToAssetPath(settingsAssetGuids[0]);
            }
            else
            {
                throw new Exception("Could not find TriLibReaders.cs file. Please re-import TriLib package.");
            }
        }

        public override void OnGUI(string searchContext)
        {
            EditorGUILayout.Space();
            var contentWidth = GUILayoutUtility.GetLastRect().width * 0.5f;
            EditorGUIUtility.labelWidth = contentWidth;
            EditorGUIUtility.fieldWidth = contentWidth;
            GUILayout.BeginVertical(Styles.Group);
            GUILayout.Label("Runtime Importing", EditorStyles.boldLabel);
            GUILayout.Label("You can disable runtime file-formats importing here");
            EditorGUILayout.Space();
            ShowConditionalToggle("Disable runtime FBX importing", "TRILIB_DISABLE_FBX_IMPORT");
            ShowConditionalToggle("Disable runtime gLTF2 importing", "TRILIB_DISABLE_GLTF_IMPORT");
            ShowConditionalToggle("Disable runtime OBJ importing", "TRILIB_DISABLE_OBJ_IMPORT");
            ShowConditionalToggle("Disable runtime STL importing", "TRILIB_DISABLE_STL_IMPORT");
            ShowConditionalToggle("Disable runtime PLY importing", "TRILIB_DISABLE_PLY_IMPORT");
            ShowConditionalToggle("Disable runtime 3MF importing", "TRILIB_DISABLE_3MF_IMPORT");
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            GUILayout.Label("Editor Importing", EditorStyles.boldLabel);
            GUILayout.Label("You can disable in editor file-formats importing to avoid conflicts with other editor importers");
            EditorGUILayout.Space();
            ShowConditionalToggle("Disable in editor gLTF2 importing", "TRILIB_DISABLE_EDITOR_GLTF_IMPORT");
            ShowConditionalToggle("Disable in editor PLY importing", "TRILIB_DISABLE_EDITOR_PLY_IMPORT");
            ShowConditionalToggle("Disable in editor 3MF importing", "TRILIB_DISABLE_EDITOR_3MF_IMPORT");
            ShowConditionalToggle("Disable in editor STL importing", "TRILIB_DISABLE_EDITOR_STL_IMPORT");
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            GUILayout.Label("Material Mappers", EditorStyles.boldLabel);
            GUILayout.Label("Select the Material Mappers according to your project rendering pipeline");
            EditorGUILayout.Space();
            foreach (var materialMapperName in MaterialMapper.RegisteredMappers)
            {
                var value = TriLibSettings.GetBool(materialMapperName);
                var newValue = EditorGUILayout.Toggle(materialMapperName, value);
                if (newValue != value)
                {
                    TriLibSettings.SetBool(materialMapperName, newValue);
                }
            }
            EditorGUILayout.Space();
            EditorGUILayout.Space();
            GUILayout.Label("Misc Options", EditorStyles.boldLabel);
            GUILayout.Label("Advanced and experimental options");
            EditorGUILayout.Space();
            ShowConditionalToggle("Enable gLTF2 Draco decompression (Experimental)", "TRILIB_DRACO");
            ShowConditionalToggle("Force synchronous loading", "TRILIB_FORCE_SYNC");
            ShowConditionalToggle("Change thread names (Debug purposes only)", "TRILIB_USE_THREAD_NAMES");
            EditorGUILayout.Space();
            GUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Version Notes"))
            {
                TriLibVersionNotes.ShowWindow();
            }
            if (GUILayout.Button("API Reference"))
            {
                Application.OpenURL("https://ricardoreis.net/trilib/trilib2/docs/");
            }
            if (GUILayout.Button("Wiki"))
            {
                Application.OpenURL("https://ricardoreis.net/trilibwiki");
            }
            if (GUILayout.Button("Support"))
            {
                Application.OpenURL("mailto:contato@ricardoreis.net");
            }
            if (GUILayout.Button("Bug Tracking"))
            {
                Application.OpenURL("https://trello.com/b/sVB86wh9/public");
            }
            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
            CheckMappers.Initialize();
            base.OnGUI(searchContext);
        }

        private void ShowConditionalToggle(string label, string symbol)
        {
            var currentValue = TriLibDefineSymbolsHelper.IsSymbolDefined(symbol);
            var newValue = EditorGUILayout.Toggle(label, currentValue);
            if (newValue != currentValue)
            {
                TriLibDefineSymbolsHelper.UpdateSymbol(symbol, newValue);
            }
        }

        [SettingsProvider]
        public static SettingsProvider TriLib()
        {
            var provider = new TriLibSettingsProvider("Project/TriLib", SettingsScope.Project)
            {
                keywords = GetSearchKeywordsFromGUIContentProperties<Styles>()
            };
            return provider;
        }
    }
}