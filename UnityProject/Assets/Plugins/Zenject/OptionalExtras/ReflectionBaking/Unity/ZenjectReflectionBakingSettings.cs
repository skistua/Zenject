using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using ModestTree;
using UnityEngine;
using UnityEditor;

namespace Zenject.ReflectionBaking
{
    public class ZenjectReflectionBakingSettings : ScriptableObject
    {
        [SerializeField]
        bool _isEnabledInBuilds;

        [SerializeField]
        bool _isEnabledInEditor;

        [SerializeField]
        bool _allGeneratedAssemblies;

        [SerializeField]
        List<string> _weavedAssemblies;

        [SerializeField]
        List<string> _namespacePatterns;

        public List<string> NamespacePatterns
        {
            get { return _namespacePatterns; }
        }

        public List<string> WeavedAssemblies
        {
            get { return _weavedAssemblies; }
        }

        public bool IsEnabledInEditor
        {
            get { return _isEnabledInEditor; }
        }

        public bool IsEnabledInBuilds
        {
            get { return _isEnabledInBuilds; }
        }

        public bool AllGeneratedAssemblies
        {
            get { return _allGeneratedAssemblies; }
        }
    }
}
