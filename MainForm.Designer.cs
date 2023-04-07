namespace ParkingManagementProgram
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonPark = new System.Windows.Forms.Button();
            this.ButtonUnPark = new System.Windows.Forms.Button();
            this.ButtonIsPark = new System.Windows.Forms.Button();
            this.ButtonPrintPark = new System.Windows.Forms.Button();
            this.TextBoxIsParkCarName = new System.Windows.Forms.TextBox();
            this.LabelIsParkCarNumber = new System.Windows.Forms.Label();
            this.TextBoxParkCarName = new System.Windows.Forms.TextBox();
            this.LabelCarNumber = new System.Windows.Forms.Label();
            this.LabelUnparkCarNumber = new System.Windows.Forms.Label();
            this.TextBoxUnParkCarName = new System.Windows.Forms.TextBox();
            this.TextBoxParkCarModel = new System.Windows.Forms.TextBox();
            this.LabelCarModel = new System.Windows.Forms.Label();
            this.LabelCarSize = new System.Windows.Forms.Label();
            this.TextBoxParkCarSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonPark
            // 
            this.ButtonPark.Location = new System.Drawing.Point(270, 67);
            this.ButtonPark.Name = "ButtonPark";
            this.ButtonPark.Size = new System.Drawing.Size(61, 77);
            this.ButtonPark.TabIndex = 0;
            this.ButtonPark.Text = "입차";
            this.ButtonPark.UseVisualStyleBackColor = true;
            this.ButtonPark.Click += new System.EventHandler(this.ButtonPark_Click);
            // 
            // ButtonUnPark
            // 
            this.ButtonUnPark.Location = new System.Drawing.Point(270, 164);
            this.ButtonUnPark.Name = "ButtonUnPark";
            this.ButtonUnPark.Size = new System.Drawing.Size(61, 21);
            this.ButtonUnPark.TabIndex = 1;
            this.ButtonUnPark.Text = "출차";
            this.ButtonUnPark.UseVisualStyleBackColor = true;
            this.ButtonUnPark.Click += new System.EventHandler(this.ButtonUnPark_Click);
            // 
            // ButtonIsPark
            // 
            this.ButtonIsPark.Location = new System.Drawing.Point(270, 196);
            this.ButtonIsPark.Name = "ButtonIsPark";
            this.ButtonIsPark.Size = new System.Drawing.Size(61, 21);
            this.ButtonIsPark.TabIndex = 2;
            this.ButtonIsPark.Text = "검색";
            this.ButtonIsPark.UseVisualStyleBackColor = true;
            this.ButtonIsPark.Click += new System.EventHandler(this.ButtonIsPark_Click);
            // 
            // ButtonPrintPark
            // 
            this.ButtonPrintPark.Location = new System.Drawing.Point(402, 107);
            this.ButtonPrintPark.Name = "ButtonPrintPark";
            this.ButtonPrintPark.Size = new System.Drawing.Size(105, 50);
            this.ButtonPrintPark.TabIndex = 3;
            this.ButtonPrintPark.Text = "주차현황";
            this.ButtonPrintPark.UseVisualStyleBackColor = true;
            this.ButtonPrintPark.Click += new System.EventHandler(this.ButtonPrintPark_Click);
            // 
            // TextBoxIsParkCarName
            // 
            this.TextBoxIsParkCarName.Location = new System.Drawing.Point(133, 196);
            this.TextBoxIsParkCarName.Name = "TextBoxIsParkCarName";
            this.TextBoxIsParkCarName.Size = new System.Drawing.Size(114, 21);
            this.TextBoxIsParkCarName.TabIndex = 4;
            // 
            // LabelIsParkCarNumber
            // 
            this.LabelIsParkCarNumber.AutoSize = true;
            this.LabelIsParkCarNumber.Location = new System.Drawing.Point(60, 202);
            this.LabelIsParkCarNumber.Name = "LabelIsParkCarNumber";
            this.LabelIsParkCarNumber.Size = new System.Drawing.Size(53, 12);
            this.LabelIsParkCarNumber.TabIndex = 5;
            this.LabelIsParkCarNumber.Text = "차량번호";
            // 
            // TextBoxParkCarName
            // 
            this.TextBoxParkCarName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxParkCarName.Location = new System.Drawing.Point(133, 94);
            this.TextBoxParkCarName.Name = "TextBoxParkCarName";
            this.TextBoxParkCarName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxParkCarName.Size = new System.Drawing.Size(114, 21);
            this.TextBoxParkCarName.TabIndex = 6;
            // 
            // LabelCarNumber
            // 
            this.LabelCarNumber.AutoSize = true;
            this.LabelCarNumber.Location = new System.Drawing.Point(60, 101);
            this.LabelCarNumber.Name = "LabelCarNumber";
            this.LabelCarNumber.Size = new System.Drawing.Size(53, 12);
            this.LabelCarNumber.TabIndex = 7;
            this.LabelCarNumber.Text = "차량번호";
            // 
            // LabelUnparkCarNumber
            // 
            this.LabelUnparkCarNumber.AutoSize = true;
            this.LabelUnparkCarNumber.Location = new System.Drawing.Point(60, 169);
            this.LabelUnparkCarNumber.Name = "LabelUnparkCarNumber";
            this.LabelUnparkCarNumber.Size = new System.Drawing.Size(53, 12);
            this.LabelUnparkCarNumber.TabIndex = 8;
            this.LabelUnparkCarNumber.Text = "차량번호";
            // 
            // TextBoxUnParkCarName
            // 
            this.TextBoxUnParkCarName.Location = new System.Drawing.Point(133, 164);
            this.TextBoxUnParkCarName.Name = "TextBoxUnParkCarName";
            this.TextBoxUnParkCarName.Size = new System.Drawing.Size(114, 21);
            this.TextBoxUnParkCarName.TabIndex = 9;
            // 
            // TextBoxParkCarModel
            // 
            this.TextBoxParkCarModel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxParkCarModel.Location = new System.Drawing.Point(133, 67);
            this.TextBoxParkCarModel.Name = "TextBoxParkCarModel";
            this.TextBoxParkCarModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxParkCarModel.Size = new System.Drawing.Size(114, 21);
            this.TextBoxParkCarModel.TabIndex = 10;
            // 
            // LabelCarModel
            // 
            this.LabelCarModel.AutoSize = true;
            this.LabelCarModel.Location = new System.Drawing.Point(60, 73);
            this.LabelCarModel.Name = "LabelCarModel";
            this.LabelCarModel.Size = new System.Drawing.Size(53, 12);
            this.LabelCarModel.TabIndex = 11;
            this.LabelCarModel.Text = "차량종류";
            // 
            // LabelCarSize
            // 
            this.LabelCarSize.AutoSize = true;
            this.LabelCarSize.Location = new System.Drawing.Point(60, 129);
            this.LabelCarSize.Name = "LabelCarSize";
            this.LabelCarSize.Size = new System.Drawing.Size(53, 12);
            this.LabelCarSize.TabIndex = 12;
            this.LabelCarSize.Text = "차량크기";
            // 
            // TextBoxParkCarSize
            // 
            this.TextBoxParkCarSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxParkCarSize.Location = new System.Drawing.Point(133, 123);
            this.TextBoxParkCarSize.Name = "TextBoxParkCarSize";
            this.TextBoxParkCarSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxParkCarSize.Size = new System.Drawing.Size(114, 21);
            this.TextBoxParkCarSize.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 303);
            this.Controls.Add(this.TextBoxParkCarSize);
            this.Controls.Add(this.LabelCarSize);
            this.Controls.Add(this.LabelCarModel);
            this.Controls.Add(this.TextBoxParkCarModel);
            this.Controls.Add(this.TextBoxUnParkCarName);
            this.Controls.Add(this.LabelUnparkCarNumber);
            this.Controls.Add(this.LabelCarNumber);
            this.Controls.Add(this.TextBoxParkCarName);
            this.Controls.Add(this.LabelIsParkCarNumber);
            this.Controls.Add(this.TextBoxIsParkCarName);
            this.Controls.Add(this.ButtonPrintPark);
            this.Controls.Add(this.ButtonIsPark);
            this.Controls.Add(this.ButtonUnPark);
            this.Controls.Add(this.ButtonPark);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPark;
        private System.Windows.Forms.Button ButtonUnPark;
        private System.Windows.Forms.Button ButtonIsPark;
        private System.Windows.Forms.Button ButtonPrintPark;
        private System.Windows.Forms.TextBox TextBoxIsParkCarName;
        private System.Windows.Forms.Label LabelIsParkCarNumber;
        private System.Windows.Forms.TextBox TextBoxParkCarName;
        private System.Windows.Forms.Label LabelCarNumber;
        private System.Windows.Forms.Label LabelUnparkCarNumber;
        private System.Windows.Forms.TextBox TextBoxUnParkCarName;
        private System.Windows.Forms.TextBox TextBoxParkCarModel;
        private System.Windows.Forms.Label LabelCarModel;
        private System.Windows.Forms.Label LabelCarSize;
        private System.Windows.Forms.TextBox TextBoxParkCarSize;
    }
}

