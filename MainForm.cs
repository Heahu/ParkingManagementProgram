using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementProgram
{
    public partial class MainForm : Form
    {
        ParkingLot _parkingLot = new ParkingLot();
      


        public MainForm()
        {
            InitializeComponent();
        }

        //입차
        private void ButtonPark_Click(object sender, EventArgs e)
        {
            Car car = null;

            if (TextBoxParkCarName.Text == "")
            {
                MessageBox.Show("차량번호는 필수로 기입되어야 합니다.");
                return;
            }
            if (TextBoxParkCarModel.Text == "")
            {
                MessageBox.Show("차량종류는 필수로 기입되어야 합니다.");
                return;
            }
            if (TextBoxParkCarSize.Text == "")
            {
                MessageBox.Show("차량크기는 필수로 기입되어야 합니다.");
                return;
            }

            car.CarNumber = TextBoxParkCarName.Text;
            car.CarModel = TextBoxParkCarModel.Text;
            
            if (TextBoxParkCarSize.Text == "소형차")
            {
                car.CarSize = "소형차";
            }
            else if (TextBoxParkCarSize.Text == "중형차")
            {
                car.CarSize = "중형차";
            }
            else
            {
                car.CarSize = "대형차";
            }

            TextBoxParkCarName.Text = "";
            TextBoxParkCarModel.Text = "";
            TextBoxParkCarSize.Text = "";

            _parkingLot.Park(car);
        }

        //출차
        private void ButtonUnPark_Click(object sender, EventArgs e)
        {
            if (TextBoxUnParkCarName.Text == "")
            {
                MessageBox.Show("차량번호는 필수로 기입되어야 합니다.");
                return;
            }

            string UnparkCarNumber = TextBoxUnParkCarName.Text;

            _parkingLot.Unpark(UnparkCarNumber);
        }

        //검색
        private void ButtonIsPark_Click(object sender, EventArgs e)
        {
            if (TextBoxIsParkCarName.Text == "")
            {
                MessageBox.Show("차량번호는 필수로 기입되어야 합니다.");
                return;
            }

            _parkingLot.IsParked(TextBoxIsParkCarName.Text);
        }

        //현황조회
        private void ButtonPrintPark_Click(object sender, EventArgs e)
        {
            _parkingLot.PrintParkStatus();
        }
    }
}
