// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

using Kopernicus.MaterialWrapper;

namespace Kopernicus
{
    namespace Configuration
    {
        public class NormalBumpedLoader : NormalBumped
        {
            // Main Color, default = (1,1,1,1)
            [ParserTarget("color", optional = true)]
            private ColorParser colorSetter
            {
                set { base.color = value.value; }
            }

            // Base (RGB), default = "white" {}
            [ParserTarget("mainTex", optional = true)]
            private Texture2DParser mainTexSetter
            {
                set { base.mainTex = value.value; }
            }

            [ParserTarget("mainTexScale", optional = true)]
            private Vector2Parser mainTexScaleSetter
            {
                set { base.mainTexScale = value.value; }
            }

            [ParserTarget("mainTexOffset", optional = true)]
            private Vector2Parser mainTexOffsetSetter
            {
                set { base.mainTexOffset = value.value; }
            }

            // Normalmap, default = "bump" {}
            [ParserTarget("bumpMap", optional = true)]
            private Texture2DParser bumpMapSetter
            {
                set { base.bumpMap = value.value; }
            }

            [ParserTarget("bumpMapScale", optional = true)]
            private Vector2Parser bumpMapScaleSetter
            {
                set { base.bumpMapScale = value.value; }
            }

            [ParserTarget("bumpMapOffset", optional = true)]
            private Vector2Parser bumpMapOffsetSetter
            {
                set { base.bumpMapOffset = value.value; }
            }

            // Constructors
            public NormalBumpedLoader () : base() { }
            public NormalBumpedLoader (string contents) : base (contents) { }
            public NormalBumpedLoader (Material material) : base(material) { }
        }
    }
}
