using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppg11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkTrainButton_Click(object sender, EventArgs e)
        {
          
            Train train = new Train
            {
                CarriageCount = (int)carriageCountNumericUpDown.Value,
                CarriageTypes = carriageTypesTextBox.Text.Split(new[] { 'В' }, StringSplitOptions.RemoveEmptyEntries)
                                                            .Select(type => type.Trim())
                                                            .ToList()
            };

            
            TrainHandler carriageCountHandler = new CarriageCountHandler((int)maxCarriageCountNumericUpDown.Value);
            TrainHandler carriageTypeHandler = new CarriageTypeHandler(allowedCarriageTypesTextBox.Text.Split(new[] { 'М' }, StringSplitOptions.RemoveEmptyEntries)
                                                                                                .Select(type => type.Trim())
                                                                                                .ToList());

            carriageCountHandler.SetNext(carriageTypeHandler);

           
            bool isValid = carriageCountHandler.Handle(train, this);

            if (isValid)
            {
                MessageBox.Show(this, "Потяг дійсний");
            }
        }
    }
 }

