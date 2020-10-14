using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects_Computer
{
    class CPU
    {
        //member variables
        public string manufacturer;
        public string name;

        public CPU(string manufacturer, string name)
        {
            this.manufacturer = manufacturer;
            this.name = name;
        }

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            
            if (CheckRequirements(app, hardDrive, ram))
            {
                UpdateStorage(app, hardDrive);
            }
            
        }

        public void ProcessInstall(Games game, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (CheckRequirements(game, hardDrive, ram, gpu)){
                UpdateStorage(game, hardDrive);
            }
        }

        public void UpdateStorage(Applications app, HardDrive hardDrive)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
            hardDrive.refreshAvailaleStorage();
        }
        public bool CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            bool ableToInstall = false;
            if(app.RequiredRAM > ram.totalGigabytes || app.RequiredStorage > hardDrive.availableStorage)
            {
                Console.WriteLine("Memory or Storage insufficient - unable to install");
            }
            else
            {
                Console.WriteLine($"Computer meets specs - installing {app.ApplicationName}");
                ableToInstall = true;
            }
            return ableToInstall;
        }

        public bool CheckRequirements(Games game, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            bool ableToInstall = false;
            if (game.RequiredRAM > ram.totalGigabytes || game.RequiredStorage > hardDrive.availableStorage)
            {
                Console.WriteLine("Memory or Storage insufficient - unable to install");
            }
            else
            {
                if (game.RequiredEffectiveMemory <= gpu.effectiveMemory)
                {
                    Console.WriteLine($"Computer meets all game specs - installing {game.ApplicationName} to storage");
                    ableToInstall = true;
                }
                else
                {
                    Console.WriteLine($"GPU does not meet specs, unable to install {game.ApplicationName}");
                }
            }
            return ableToInstall;
        }
    }
}
