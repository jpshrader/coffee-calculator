using System;
using System.Windows.Forms;
using System.Threading;

namespace Coffee_Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public static bool isRunning { get; set; }
        private void toAMPM_SelectedIndexChanged(object sender, EventArgs e) {
            Calculate();
        }
        private void fromAMPM_SelectedIndexChanged(object sender, EventArgs e) {
            Calculate();
        }
        private void toMinutes_ValueChanged(object sender, EventArgs e) {
            Calculate();
        }
        private void toHours_ValueChanged(object sender, EventArgs e) {
            Calculate();
        }
        private void fromMinutes_ValueChanged(object sender, EventArgs e) {
            Calculate();
        }
        private void fromHours_ValueChanged(object sender, EventArgs e) {
            Calculate();
        }
        private void fromHours_Click(object sender, EventArgs e) {
            fromHours.Select(0, fromHours.Value.ToString().Length);
        }
        private void fromMinutes_Click(object sender, EventArgs e) {
            fromMinutes.Select(0, fromMinutes.Value.ToString().Length);
        }
        private void toHours_Click(object sender, EventArgs e) {
            toHours.Select(0, toHours.Value.ToString().Length);
        }
        private void toMinutes_Click(object sender, EventArgs e) {
            toMinutes.Select(0, toMinutes.Value.ToString().Length);
        }
        private void useCurrentTime_CheckedChanged(object sender, EventArgs e) {
            if(isRunning) {
                isRunning = false;
                Calculate();
            } else {
                isRunning = true;
                new Thread(() => CalculateRealTime()).Start();
            }
        }
        private void Form1_Load(object sender, EventArgs e) {
            new Thread(() => StartCounting()).Start();
        }

        private void Calculate() {
            DateTime now = DateTime.Now;
            int lastConsumedGum = (int)Convert.ToDouble(consumedgumLbl.Text);
            int lastConsumedCoffee = (int)Convert.ToDouble(consumedcoffeeLbl.Text);
            int currentHour = now.Hour, currentMinutes = now.Minute, currentSeconds = now.Second, consumedCoffee = 0, consumedGum = 0;
            int fromH = (int)fromHours.Value + (fromAMPM.Text == "AM" ? 0 : 12);
            int toH = (int)toHours.Value + (toAMPM.Text == "AM" ? 0 : 12);
            if(fromHours.Value == 12 && fromAMPM.Text == "PM") { fromH = 12; }
            if(toHours.Value == 12 && toAMPM.Text == "PM") { toH = 12; }
            double numCoffee = 0, numGum = 0, coffeePerHour = .375, gumPerHour = .5;
            if(isRunning) {
                numCoffee = (coffeePerHour * ((toH - currentHour) + (((double)(toMinutes.Value - currentMinutes) * .01) * 1.6667) + (((60 - currentSeconds) * .0001) * 1.6667)));
                numGum = (gumPerHour * ((toH - currentHour) + (((double)(toMinutes.Value - currentMinutes) * .01) * 1.6667) + (((60 - currentSeconds) * .0001) * 1.6667)));
            } else {
                numCoffee = (coffeePerHour * ((toH - fromH)) + (((double)(toMinutes.Value - fromMinutes.Value) * .01) * 1.6667));
                numGum = (gumPerHour * ((toH - fromH) + (((double)(toMinutes.Value - fromMinutes.Value) * .01) * 1.6667)));
            }
            coffeeLbl.Text = numCoffee.ToString();
            gumLbl.Text = numGum.ToString();
            consumedcoffeeLbl.Text = ((coffeePerHour * ((toH - fromH)) + (((double)(toMinutes.Value - fromMinutes.Value) * .01) * 1.6667)) - numCoffee).ToString();
            consumedgumLbl.Text = ((gumPerHour * ((toH - fromH) + (((double)(toMinutes.Value - fromMinutes.Value) * .01) * 1.6667))) - numGum).ToString();
            consumedGum = (int)Convert.ToDouble(consumedgumLbl.Text);
            consumedCoffee = (int)Convert.ToDouble(consumedcoffeeLbl.Text);
            if(consumedGum - 1 == lastConsumedGum) {
                Notify("Gum Update", "Joe has finished his " + GetNumberString(consumedGum, Type.Gum) + " piece of gum");
            }
            if(consumedCoffee - 1 == lastConsumedCoffee) {
                Notify("Coffee Update", "Joe has finished his " + GetNumberString(consumedCoffee, Type.Coffee) + " cup of coffee");
            }
        }

        private void IncrementCounter() {
            minuteCounter.Text = DateTime.Now.ToLongTimeString();
        }

        private void CalculateRealTime() {
            try {
                while(isRunning) {
                    Invoke((MethodInvoker)delegate {
                        Calculate();
                    });
                    Thread.Sleep(1000);
                }
            } catch {
                Thread.CurrentThread.Abort();
            }
        }

        private void StartCounting() {
            try {
                while(true) {
                    Invoke((MethodInvoker)delegate {
                        IncrementCounter();
                    });
                    Thread.Sleep(1000);
                }
            } catch {
                Thread.CurrentThread.Abort();
            }
        }

        private void Notify(string balloonTitle, string balloonText) {
            coffeeNotify.BalloonTipTitle = balloonTitle;
            coffeeNotify.BalloonTipText = balloonText;
            coffeeNotify.ShowBalloonTip(1500);
        }

        private string GetNumberString(int num, Type type) {
            if(type == Type.Coffee) {
                if(num == 1) {
                    return "first";
                } else if(num == 2) {
                    return "second";
                } else {
                    return "last";
                }
            } else {
                if(num == 1) {
                    return "first";
                } else if(num == 2) {
                    return "second";
                } else if(num == 3) {
                    return "third";
                } else {
                    return "last";
                }
            }
        }

        enum Type { Coffee, Gum }
    }
}