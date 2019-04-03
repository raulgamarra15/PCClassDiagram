// <copyright file="Speakers.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace PCclasses
{
using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// device that sends output data as sound
    /// </summary>
    public class Speakers : OutputDevices
    {
        /// <summary>
        /// volume of the speakers
        /// </summary>
        private string volume;

        /// <summary>
        /// number of speakers connected
        /// </summary>
        private string quantity;

        /// <summary>
        /// changes the volume level to lower or higher
        /// </summary>
        /// <returns>
        /// returns current volume level
        /// </returns>
        private string ChangeVolume()
        {
            return string.Empty;
        }
    }
}
