using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Week_3
{
    //Cannot communicate with TrainJourney, only with controller
    public partial class Form1 : Form
    {
        ITrainController trainController;
        ITrainJourney trainJourney;

        public Form1()
        {
            InitializeComponent();
            trainJourney = new TrainJourney();
            trainController = new TrainController(trainJourney);
            //trainDisplay = new TrainDisplay();
            //trainController.CreateNew(trainDisplay);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ITrainDisplay trainDisplay2 = new TrainDisplay(trainJourney);
            //trainController.CreateNew(trainDisplay2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           trainController.NextStation();     
        }
    }
}
