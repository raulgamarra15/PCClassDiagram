// <copyright file="Screen.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace PCclasses
{
using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// device that plays images
    /// </summary>
    public class Screen : OutputDevices
    {
        /// <summary>
        /// pixel quantity of the image
        /// </summary>
        private string resolution;

        /// <summary>
        /// screen size 
        /// </summary>
        private string size;

        /// <summary>
        /// type of screen
        /// </summary>
        private string type;

        /// <summary>
        /// screen adjustments such as brightness
        /// </summary>
        /// <returns>
        /// returns the current screen settings
        /// </returns>
        private string Adjustments()
        {            
            return string.Empty;
        }
    }
}
