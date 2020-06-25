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
    public partial class TrainDisplay : Form,ITrainDisplay
    {
        private ITrainJourney trainJourney;

        public TrainDisplay(ITrainJourney trainJourney)
        {
            InitializeComponent();
            this.trainJourney = trainJourney;
            trainJourney.AddObserver(this);
            this.Show();
        }

        private void TrainDisplay_Load(object sender, EventArgs e)
        {

        }   
        public void Update(Station station)
        {
            lblname.Text = station.Name;
            lbltrack.Text = station.Arrivaltrack;
            lblat.Text = station.Arrivaltime.ToString();
            lbldt.Text = station.Departuretime.ToString();

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
    }
}
