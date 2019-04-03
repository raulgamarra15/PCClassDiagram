// <copyright file="Mouse.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace PCclasses
{
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Device used to input data as location and button pressing
/// </summary>
    public class Mouse : InputDevices
    {
        /// <summary>
        /// size of the device
        /// </summary>
        private string size;

        /// <summary>
        /// number of buttons
        /// </summary>
        private string buttons;

        /// <summary>
        /// method used to identify the current location of the mouse by the movements of the device
        /// </summary>
        /// <returns>
        /// current location of the mouse
        /// </returns>
        private string Movement()
        {
            return string.Empty;
        }
    }
}
