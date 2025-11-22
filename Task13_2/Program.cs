using System;

namespace Task13_2
{
    internal class Program
    {
        public delegate void StateChanger(string device, string state, decimal val);  //создаем делегат

        public class SmartHomeSystem
        {
            private decimal _temp;

            public string LightCondition { get; private set; }
            public string DoorCondition { get; private set; }
            public decimal Temp 
            {
                get => _temp;
                set 
                {
                    if (value < 10)
                        throw new ArgumentException("Слишком холодно");
                    _temp = value;
                }
            }
            private string[] devices = ["Light", "Door", "Thermostat"];  //создаем список устройств


            public event StateChanger DeviceStateChanged; //создаем событие, привязываем к делегату
            public SmartHomeSystem()
            {
                LightCondition = "выключен";
                DoorCondition = "заперта";
                Temp = 20;

                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Умный дом создан. Свет {LightCondition}, дверь {DoorCondition}, температура {Temp}");

            }

            public void SwitchLight()
            {
                if (LightCondition == "выключен")
                    LightCondition = "включен";
                else LightCondition = "выключен";

                DeviceStateChanged?.Invoke(devices[0], LightCondition, Temp);       
            }

            public void OpenDoor()
            {
                if (DoorCondition == "заперта")
                    DoorCondition = "открыта";
                else DoorCondition = "заперта";

                DeviceStateChanged?.Invoke(devices[1], DoorCondition, Temp);      
            }

            public void SetTemperature(int value)
            {
                Temp = value;

                DeviceStateChanged?.Invoke(devices[2]," Температура изменена на ",Temp);       
            }

            public void ShowInfo()
            {
                Console.WriteLine($"{devices[0]}: {LightCondition}, {devices[1]}: {DoorCondition}, температура {Temp}");
            }


        }
        static void Main(string[] args)
        {
            var myHome = new SmartHomeSystem();

            myHome.DeviceStateChanged += (device, condition, temp) =>       //подписываемся на событие
            {
                if (device == "Thermostat")
                    Console.WriteLine ($"[{DateTime.Now:HH:mm:ss}] {device} : {condition} {temp}");
                else Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {device} : {condition}");

            };
            myHome.SwitchLight();
            myHome.OpenDoor();
            myHome.SetTemperature(28);
            myHome.ShowInfo();

            try
            {
                myHome.SetTemperature(0);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка:{ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
