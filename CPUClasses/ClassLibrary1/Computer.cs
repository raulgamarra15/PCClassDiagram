// <copyright file="Computer.cs" company="MyCompany.com">
//     MyCompany.com. All rights reserved.
// </copyright>
// <author>Me</author>
namespace PCclasses
{
using System;

    /// <summary>
    /// Computer: Process all the data
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// random access memory size
        /// </summary>
        private string ram="16GB";

        /// <summary>
        /// hard drive disk size
        /// </summary>
        private string hdd="1TB";

        /// <summary>
        /// brand of the computer´s processor
        /// </summary>
        private string procesor;

        /// <summary>
        /// type of operative system (windows, Linux)
        /// </summary>
        private string os;

        /// <summary>
        /// input and output devices available
        /// </summary>
        private string iodevices;

        /// <summary>
        /// voltage of power source
        /// </summary>
        private string powerSupply;

        /// <summary>
        /// device selected for output
        /// </summary>
        private string outputdevices;

        /// <summary>
        /// Gets or sets ram size
        /// </summary>
        public string Ram { get => this.ram; set => this.ram = value; }

        /// <summary>
        /// DataProcess: Process the input data and return a result
        /// </summary>
        /// <returns>
        /// returns the result of processing
        /// </returns>
        private string DataProcess()
        {
            return "result";
        }

        /// <summary>
        /// Storage: Store de input data
        /// </summary>
        private void Storage()
        {
            // to do
        }

        /// <summary>
        /// OutPutSelector: sets the device for output
        /// </summary>
        /// <param name="device">
        /// device: device select for data output
        /// </param>
        private void OutPutSelector(string device)
        {
            // To do
            this.iodevices = device;
        }

        /// <summary>
        /// SendData: sends the input data to the computer for processing or sends the output data to the output devices for the user
        /// </summary>
        private void SendData()
        {
            // To do
        }
    }
}