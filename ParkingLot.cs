using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementProgram
{
    internal class ParkingLot
    {
        public const int ROW = 5;
        public const int COL = 5;
        private int _availableParkingSpace = ROW * COL;
        private Car[,] _parkedCars = new Car[ROW, COL];

        /// <summary>
        /// 입차
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        public virtual bool Park(Car car)
        {
            for (int i = 0; i < ROW; i++)
            {
                for (int j = 0; j < COL; j++)
                {
                    if (_parkedCars[i, j] != null && _parkedCars[i, j].CarNumber == car.CarNumber)
                    {
                        MessageBox.Show("차량번호 " + car.CarNumber + "는 이미 주차된 차량번호입니다.");
                        Console.WriteLine("차량번호 {0}는 이미 주차된 차량번호입니다.", car.CarNumber);

                        return false;
                    }
                    else if (_parkedCars[i, j] == null)
                    {
                        _parkedCars[i, j] = car;
                        _availableParkingSpace--;

                        MessageBox.Show("차량번호 " + car.CarNumber + "가 주차되었습니다.");
                        Console.WriteLine("차량번호 {0}가 주차되었습니다.", car.CarNumber);
                        return true;
                    }
                }
            }

            MessageBox.Show("주차장이 가득 찼습니다.");
            Console.WriteLine("주차장이 가득 찼습니다.");
            return false;
        }

        /// <summary>
        /// 출차
        /// </summary>
        /// <param name="carNumber"></param>
        public virtual bool Unpark(string carNumber)
        {
            /*
            SmallSizeCar sCar = new SmallSizeCar();
            MiddleSizeCar mCar = new MiddleSizeCar();
            FullSizeCar fCar = new FullSizeCar();
            */

            Car car = null;


            int charge = 0;
            string carSize = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (_parkedCars[i, j] != null && _parkedCars[i, j].CarNumber == carNumber)
                    {
                        if (_parkedCars[i, j].CarSize == "소형차")
                        {
                            car = _parkedCars[i, j];
                            charge = car.GetCharge();
                            carSize = car.Size();
                        }
                        else if (_parkedCars[i, j].CarSize == "중형차")
                        {
                            car = _parkedCars[i, j];
                            charge = car.GetCharge();
                            carSize = car.Size();
                        }
                        else
                        {
                            car = _parkedCars[i, j];
                            charge = car.GetCharge();
                            carSize = car.Size();
                        }

                        _parkedCars[i, j] = null;
                        _availableParkingSpace++;

                        MessageBox.Show("차량번호 " + carNumber + "가 출차되었습니다. " + carSize + "의 정산금액은 " + charge + "원 입니다.");
                        Console.WriteLine("차량번호 {0}가 출차되었습니다.", carNumber);
                        return true;
                    }
                }
            }
            MessageBox.Show("해당 차량은 주차장에 없습니다.");
            Console.WriteLine("해당 차량은 주차장에 없습니다.");

            return false;
        }

        /// <summary>
        /// 검색
        /// </summary>
        /// <param name="GetCarNumber"></param>
        /// <returns></returns>
        public virtual bool IsParked(string carNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                    if (_parkedCars[i, j] != null && _parkedCars[i, j].CarNumber == carNumber)
                    {
                        int getPosionI = i + 1;
                        int getPosionJ = j + 1;

                        string getPosion = "[" + getPosionI + "," + getPosionJ + "]";   
                        MessageBox.Show("차량번호 : " + carNumber + "는 " + getPosion + " 주차장에 있습니다.");
                        Console.WriteLine("차량번호 {0}는 [{1}, {2}] 주차장에 있습니다.", carNumber, getPosionI, getPosionJ);
                        return true;
                    }
                }
            }
            MessageBox.Show("차량번호" + carNumber + "는 주차장에 없습니다.");
            Console.WriteLine("차량번호 {0}는 주차장에 없습니다.", carNumber);
            return false;
        }

        /// <summary>
        /// 주차현황
        /// </summary>
        public virtual void PrintParkStatus()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("주차된 차량 목록");
            Console.WriteLine("=======================================");
            Console.WriteLine("번호\t차량번호\t차종");

            int spotNumber = 1;
            string[,] parkingGrid = new string[5, 10];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (_parkedCars[i, j] != null)
                    {
                        ICar car = _parkedCars[i, j];
                        parkingGrid[i, j] = car.CarNumber;
                        Console.WriteLine("{0}\t{1}\t\t{2}", spotNumber, car.CarNumber, car.CarModel);
                        spotNumber++;
                    }
                }
            }

            Console.WriteLine("=======================================");

            Console.WriteLine("주차장 현황");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (parkingGrid[i, j] == null)
                    {
                        Console.Write("□");
                    }
                    else
                    {
                        Console.Write("■");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("=======================================");
        }
    }
}
