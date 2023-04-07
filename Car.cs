using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementProgram
{
    public interface ICar
    {
        string CarNumber { get; }
        string CarModel { get; }
        string CarSize { get; }
    }

    public abstract class Car : ICar
    {
        public string CarNumber { get; set; }

        public string CarModel { get; set; }
        public string CarSize { get; set; }

        public Car()
        {
            //기본 생성자
        }

        public Car(string carNumber, string carModel, string carSize)
        {
            this.CarNumber = carNumber;
            this.CarModel = carModel;
            this.CarSize= carSize;
        }

        public virtual string Size()
        {
            Console.WriteLine("Car에는 다양한 사이즈가 존재합니다.");
            return "Car에는 다양한 사이즈가 존재합니다.";
        }

        public virtual string Speed()
        {
            Console.WriteLine("Car에는 다양한 cc가 존재합니다.");
            return "Car에는 다양한 cc가 존재합니다.";
        }

        public virtual int GetCharge()
        {
            return 0;
        }
    }

    public class SmallSizeCar : Car
    {
        public SmallSizeCar()
        {
            //기본 생성자
        }

        public override string Size()
        {
            return "소형차";
        }

        public override string Speed()
        {
            return "1,600cc";
        }

        public override int GetCharge()
        {
            return 500;
        }
    }

    public class MiddleSizeCar : Car
    {
        public MiddleSizeCar()
        {
            //기본 생성자
        }

        public override string Size()
        {
            return "중형차";
        }

        public override string Speed()
        {
            return "2,000cc";
        }

        public override int GetCharge()
        {
            return 1000;
        }
    }

    public class FullSizeCar : Car
    {
        public FullSizeCar()
        {
            //기본 생성자
        }

        public override string Size()
        {
            return "대형차";
        }

        public override string Speed()
        {
            return "3,000cc";
        }

        public override int GetCharge()
        {
            return 1500;
        }
    }
}