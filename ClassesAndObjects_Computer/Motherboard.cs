using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class Motherboard
    {
        public string manufacturer;
        public CPU processor;
        public RAM temporaryMemory;
        public HardDrive storage;
        public GPU graphics;

        public Motherboard(string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            this.manufacturer = manufacturer;
            temporaryMemory = ram;
            processor = cpu;
            storage = hardDrive;
            graphics = gpu;
        }

        //public void InstallApplication(Applications applicationToInstall)
        //{
        //    if(temporaryMemory.totalGigabytes >= applicationToInstall.RequiredRAM && storage.availableStorage >= applicationToInstall.RequiredStorage)
        //    {
        //        storage.ApplicationsInHardDrive.Add(applicationToInstall);
        //    }
            
        //}
    }
}
