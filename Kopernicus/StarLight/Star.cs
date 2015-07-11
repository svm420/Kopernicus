﻿/**
 * Kopernicus Planetary System Modifier
 * ====================================
 * Created by: - Bryce C Schroeder (bryce.schroeder@gmail.com)
 * 			   - Nathaniel R. Lewis (linux.robotdude@gmail.com)
 * 
 * Maintained by: - Thomas P.
 * 				  - NathanKell
 * 
* Additional Content by: Gravitasi, aftokino, KCreator, Padishar, Kragrathea, OvenProofMars, zengei, MrHappyFace
 * ------------------------------------------------------------- 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2014 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Kopernicus
{
    // Class to support multiple Lensflares
    public class Star : Sun
    {
        // Name of the CelestialBody
        public string bodyName = "";

        public void Awake()
        {
            // Create the Lensflare
            sunFlare = gameObject.AddComponent<LensFlare>();

            // If we "are" Sun.Instance, save our data to Sun.Instance and kill us
            if (Sun.Instance != null)
            {
                if (Sun.Instance.sun.name == bodyName)
                {
                    // Copy our fields to Sun.Instance
                    Utility.CopyObject<Sun>(this, Sun.Instance, false);
                    Destroy(this);
                }
                else
                {
                    // Copy the Lensflare from Sun.Instance
                    Utility.CopyObject<LensFlare>(Sun.Instance.sunFlare, sunFlare, false);
                }
            }

            // Deactivate localSpaceLight for the moment, so that we can get LensFlares running
            useLocalSpaceSunLight = false;

            // If the body-list works, get the CelestialBody reference
            if (PSystemManager.Instance.localBodies != null)
            {
                sun = PSystemManager.Instance.localBodies.Find(b => b.name == bodyName);
            }
        }
    }
}
