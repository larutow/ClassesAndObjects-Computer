using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class Computer
    {
        public Motherboard mobo;
        public CPU cpu;
        public GPU gpu;
        public HardDrive hardDrive;
        public RAM ram;
        public AppStore appStore;


        public Computer()
        {
            cpu = new CPU("AMD", "Ryzen 3600X");
            gpu = new GPU("AMD", 16);
            hardDrive = new HardDrive(1000, 500);
            ram = new RAM(16, "Gskill");
            mobo = new Motherboard("MSI", ram, cpu, hardDrive, gpu);
        }

        public void StartComputer()
        {
            Console.WriteLine("~Windows 98 starting sounds~");
            Console.WriteLine("DialUp tones\n...\nInternet Connection Detected\n...\nConnecting to appstore\n...\n");
            appStore = new AppStore();
        }

        public void InstallApps()
        {
            Console.WriteLine("Installing all apps from appstore");
            //installs all apps from app store
            for(int i = 0; i < 3; i++)
            {
                cpu.ProcessInstall(appStore.availableGames[i], hardDrive, ram, gpu);
                cpu.ProcessInstall(appStore.availableMessengers[i], hardDrive, ram);
                cpu.ProcessInstall(appStore.availableTextEditors[i], hardDrive, ram);
            }
            
            Console.ReadLine();
        }
        
    }
}
