using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EGearRatioToor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            int puu, pitch, reductionRatio1, reductionRatio2, encoderPLSRev, maxRPM;

            bool puuValid = int.TryParse(PUUTxtbox.Text, out puu) && (puu > 0);
            bool pitchValid = int.TryParse(ScrewPitchTxtbox.Text, out pitch) && (pitch > 0);
            bool reductionRation1Valid = int.TryParse(ReductionRatioTxtbox1.Text, out reductionRatio1) && (reductionRatio1 > 0);
            bool reductionRation2Valid = int.TryParse(ReductionRatioTxtbox2.Text, out reductionRatio2) && (reductionRatio2 > 0);
            bool encoderPLSRevValid = int.TryParse(EncoderPLSTxtbox.Text, out encoderPLSRev) && (encoderPLSRev > 0);
            bool maxRPMValid = int.TryParse(MaxRPMTxtbox.Text, out maxRPM) && (maxRPM > 0);

            bool allInputValid = puuValid && pitchValid && reductionRation1Valid 
                                        && reductionRation2Valid && encoderPLSRevValid
                                        && maxRPMValid ;

            errorLabel.Text = "";
            if (!allInputValid)
            {
                errorLabel.Text = "輸入數值不正確 (Invalid Input Values)";
                errorLabel.ForeColor = Color.Red;
                return;
            }

            int num = encoderPLSRev * reductionRatio2;
            int den = pitch * puu * reductionRatio1;
            var gcd = Gcd(num, den);

            num /= gcd;
            den /= gcd;

            NumTxtbox.Text = num.ToString();
            DenTxtbox.Text = den.ToString() ;

            int rps = maxRPM / 60;

            double effectiveRPS = rps * 0.8;

            double reductionRatio = ((double)reductionRatio2 / (double)reductionRatio1);
            double totalDist = effectiveRPS * pitch / reductionRatio;

            string totalDistStr = String.Format("{0:0.####} mm",totalDist);

            OneSecondMovementTxtbox.Text = totalDistStr;

            double distPerRev = Math.Round((pitch / reductionRatio), 4, MidpointRounding.AwayFromZero);
            distPerRevTxtbox.Text = String.Format("{0:0.####} mm", distPerRev);
            puuPerRevTxtbox.Text = String.Format("{0:0.####}",((int)(puu * distPerRev)).ToString());


        }

        public static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

    }
}
