using System;
using System.Windows.Forms;

namespace Azur_Lane_Exp_Calculator
{
    public partial class Form1 : Form
    {
        int current, target, rarity;
        int[] table;

        readonly int[] experience_table_enjp = {0, 100, 300, 600, 1000, 1500, 2100, 2800, 3600,
        4500, 5500, 6600, 7800, 9100, 10500, 12000, 13600, 15300, 17100, 19000, 21000,
        23100, 25300, 27600, 30000, 32500, 35100, 37800, 40600, 43500, 46500, 49600,
        52800, 56100, 59500, 63000, 66600, 70300, 74100, 78000, 82000, 86200, 90600,
        95200, 100000, 105000, 110200, 115600, 121200, 127000, 133000, 139200, 145600,
        152200, 159000, 166000, 173200, 180600, 188200, 196000, 204000, 212300, 220900,
        229800, 239000, 248500, 258300, 268400, 278800, 289500, 301600, 314140, 327120,
        340540, 354400, 368700, 383440, 398620, 414240, 430300, 447550, 465375, 483775,
        502750, 522300, 542425, 563125, 584400, 606250, 628675, 652675, 677875, 704275,
        733075, 764275, 800275, 842275, 890275, 962275, 1120675, 1170675, 1223675,
        1279675, 1338675, 1400675, 1465675, 1536675, 1613675, 1696675, 1785675,
        1880675, 1985675, 2100675, 2225675, 2360675, 2505675, 2665675, 2840675,
        3030675, 3235675, 3455675, 3696675, 3958675, 4241675, 4545675};

        readonly int[] experience_table_ur = {0, 120, 360, 720, 1200, 1800, 2520, 3360, 4320,
        5400, 6600, 7920, 9360, 10920, 12600, 14400, 16320, 18360, 20520, 22800, 25200,
        27720, 30360, 33120, 36000, 39000, 42120, 45360, 48720, 52200, 55800, 59520,
        63360, 67320, 71400, 75600, 79920, 84360, 88920, 93600, 98400, 103440, 108720,
        114240, 120000, 126000, 132240, 138720, 145440, 152400, 159600, 167040, 174720,
        182640, 190800, 199200, 207840, 216720, 225840, 235200, 244800, 254760, 265080,
        275760, 286800, 298200, 309960, 322080, 334560, 347400, 360600, 374280, 388440,
        403080, 418200, 433800, 449880, 466440, 483480, 501000, 519000, 537600, 556800,
        576600, 597000, 618000, 639600, 661800, 684600, 708000, 734000, 761300, 789900,
        821100, 854900, 893900, 939400, 991400, 1069400, 1241000, 1301000, 1364600,
        1431800, 1502600, 1577000, 1655000, 1740200, 1832600, 1932200, 2039000,
        2153000, 2279000, 2417000, 2567000, 2729000, 2903000, 3095000, 3305000,
        3533000, 3779000, 4043000, 4332200, 4646600, 4986200, 5351000 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int levels = 1; levels <= 125; levels++)
            {
                cmbCurrentLevel.Items.Add("Level " + levels.ToString());
                cmbTargetLevel.Items.Add("Level " + levels.ToString());
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbCurrentLevel.SelectedIndex > -1 && cmbTargetLevel.SelectedIndex > -1)
            {
                current = cmbCurrentLevel.SelectedIndex + 1;
                target = cmbTargetLevel.SelectedIndex + 1;

                if (chkboxUR.Checked)
                {
                    rarity = 1;
                }
                else
                {
                    rarity = 0;
                }
                Calculate_exp(rarity);
            }
            else
            {
                MessageBox.Show("Please Input All The Fields", "Error");
            }
        }

        public void Calculate_exp(int shipRarity)
        {
            switch (shipRarity)
            {
                case 1:
                    table = experience_table_ur;
                    break;
                default:
                    table = experience_table_enjp;
                    break;
            }
            int exp = Get_exp_diff(table, current, target);

            lblExpNeeded.Text = String.Format("{0:n0}", exp);
        }

        public static int Get_total_exp(int[] table, int level)
        {
            if (level > 0 && level <= 125)
            {
                return table[level - 1];
            }
            else
            {
                return 0;
            }
        }

        public static int Get_exp_diff(int[] table, int current, int target)
        {
            current = Get_total_exp(table, current);
            target = Get_total_exp(table, target);

            return target - current;
        }
    }
}