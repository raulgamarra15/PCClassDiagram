// <copyright file="Hardware.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace PCclasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Hardware: Physical components of the computer
    /// </summary>
    public class Hardware
    {
        /// <summary>
        /// Color of the case
        /// </summary>
        private string color;

        /// <summary>
        /// company that produces the device
        /// </summary>
        private string brand;

        /// <summary>
        /// data transfer speed
        /// </summary>
        private string transSpeed;

        /// <summary>
        /// connection type
        /// </summary>
        private string connType;

        /// <summary>
        /// data transfer between input devices, output devices and the computer
        /// </summary>
        /// <returns>
        /// returns the transferred value
        /// </returns>
        private string DataTransfer()
        {
            return string.Empty;
        }
    }   
}
