#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

/*
 * 
 * ButtonClick --> RunWorkerAsync(inputobj) 
 * waarbij je een instantie van een eigen class van inputobj mag invoeren
 * in dit geval is dat BackGroundParams.   
 *                 De code van RunWorkerAsync is niet zichtbaar
 *                  |
 *                  |
 *                  ------->  
 *                  BackGroundWorker_DoWork(object sender, DoWorkEventArgs e)
 *                      |
 *                      |
 *                      ---> OneLoop, InfiniteLoop, ExceptionLoop (grote zelfgecodeerde processen). 
 *                      
 *                  BackGroundWorker_RunWorkerCompleted(object sender,
 *                                   RunWorkerCompletedEventArgs e)
 * 
 */

using BigFormsApplication.Forms.BackGroundParameters;
using BigFormsApplication.Forms.ProgressInfo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmBackGroundProcess : Form
    {

        public FrmBackGroundProcess()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void FrmBackGroundProcess_Load(object sender, EventArgs e)
        {
            MakeInformationLabelsInvisible();
            SetInitialButtons();
            ProgressBar.Value = 0;
            TextBoxNumberSeconds.Text = "";
        }

        private void ButtonStart1Loop_Click(object sender, EventArgs e)
        {
            MakeInformationLabelsInvisible();
            ButtonCancelInfiniteLoop.Enabled = false; // Je kan alleen cancellen bij infinite loop
            TurnOffStartButtons();
            ProgressBar.Value = 0;


            var ok = int.TryParse(TextBoxNumberSeconds.Text, out int nrOfSeconds);
            if (!ok || nrOfSeconds < 5)
            {
                LabelErrorMsg.Visible = true;
                LabelErrorMsg.Text = "Aantal seconden moet 5 of meer zijn";
                SetInitialButtons();
                return;
            }

            if (backgroundWorker.IsBusy == true)
            {
                LabelErrorMsg.Visible = true;
                LabelErrorMsg.Text = "Achtergrond proces loopt nog";
                return;
            }

            // Onze zelfgemaakte object backGroundParams geven we mee aan RunWorkerAsync
            // RunWorkerAsync zit onder water (geen code beschikbaar), deze roept weer
            // BackGroundWorker_DoWork aan. 
            var backGroundParams = new BackGroundParamsInc
            {
                NrOfSeconds = nrOfSeconds,
                KindOfLoop = KindOfLoop.Once
            };

            if (backgroundWorker.IsBusy == false)
            {
                backgroundWorker.RunWorkerAsync(backGroundParams);
            }
        }

        private void ButtonStartInfiniteLoop_Click(object sender, EventArgs e)
        {
            MakeInformationLabelsInvisible();

            ButtonCancelInfiniteLoop.Enabled = true;
            TurnOffStartButtons();
            TextBoxNumberSeconds.Enabled = false;  // idem
            ProgressBar.Value = 0;

            if (TextBoxNumberSeconds.Text.Trim() != "")
            {
                LabelErrorMsg.Visible = true;
                LabelErrorMsg.Text = "Aantal seconden moet leeg zijn";
                SetInitialButtons();

                TextBoxNumberSeconds.Enabled = true;  // idem
                return;
            }

            if (backgroundWorker.IsBusy == true)
            {
                LabelErrorMsg.Visible = true;
                LabelErrorMsg.Text = "Achtergrond proces loopt nog";
                return;
            }

            var backGroundParams = new BackGroundParamsInc
            {
                NrOfSeconds = 0,
                KindOfLoop = KindOfLoop.Infinite
            };

            backgroundWorker.RunWorkerAsync(backGroundParams);
        }

        private void MakeInformationLabelsInvisible()
        {
            LabelStatusMsg.Visible = false;
            LabelErrorMsg.Visible = false;
            LabelPercentage.Visible = false;
        }

        private void SetInitialButtons()
        {
            ButtonStart1Loop.Enabled = true;
            ButtonStartInfiniteLoop.Enabled = true;
            ButtonStartLoopWithException.Enabled = true;
            ButtonCancelInfiniteLoop.Enabled = false;
        }

        private void TurnOffStartButtons()
        {
            ButtonStart1Loop.Enabled = false;
            ButtonStartInfiniteLoop.Enabled = false;
            ButtonStartLoopWithException.Enabled = false;
        }

        private void ButtonStartLoopWithException_Click(object sender, EventArgs e)
        {
            MakeInformationLabelsInvisible();
            TurnOffStartButtons();
            ButtonCancelInfiniteLoop.Enabled = false;
            TextBoxNumberSeconds.Enabled = false;  // idem
            ProgressBar.Value = 0;

            if (TextBoxNumberSeconds.Text.Trim() != "")
            {
                LabelErrorMsg.Visible = true;
                LabelErrorMsg.Text = "Aantal seconden moet leeg zijn";
                SetInitialButtons();
                TextBoxNumberSeconds.Enabled = true;  // idem
                return;
            }

            if (backgroundWorker.IsBusy == true)
            {
                LabelErrorMsg.Visible = true;
                LabelErrorMsg.Text = "Achtergrond proces loopt nog";
                return;
            }

            var backGroundParams = new BackGroundParamsInc
            {
                NrOfSeconds = 0,
                KindOfLoop = KindOfLoop.BuildInException
            };

            backgroundWorker.RunWorkerAsync(backGroundParams);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.WorkerSupportsCancellation)
            {
                backgroundWorker.CancelAsync();
            }
        }

        // --------------------------------------- 
        private void BackGroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var bw = sender as BackgroundWorker;

            // Extract the e argument.
            // Je weet zeker dat e een int is, dus je kan casten

            var backGroundParams = (BackGroundParamsInc)e.Argument;

            int numberOfSeconds = backGroundParams.NrOfSeconds;

            BackGroundResultParams backGroundResultParams;
            switch (backGroundParams.KindOfLoop)
            {
                case KindOfLoop.Once:
                    // Laat LongProcess meerdere gegevens teruggeven
                    // via ProcessDetails: 

                    backGroundResultParams = OneLoop(bw, numberOfSeconds);

                    e.Result = backGroundResultParams;
                    break;
                case KindOfLoop.Infinite:
                    // Alleen via de cancel knop kan je dit proces beëindigen. 
                    InfiniteLoop(bw);
                    break;
                case KindOfLoop.BuildInException:
                    // Beëindigt zichzelf
                    ExceptionLoop(bw);
                    break;

                default:
                    break;
            }

            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        // This event handler demonstrates how to interpret
        // the outcome of the asynchronous operation implemented
        // in the DoWork event handler.
        private void BackGroundWorker_RunWorkerCompleted(
            object sender,
            RunWorkerCompletedEventArgs e)
        {
            LabelStatusMsg.Visible = true;

            if (e.Cancelled)
            {
                // The user canceled the operation.
                // e.Result kan je niet meer ophalen (runtime error)
                // MessageBox.Show($"Achtergrond proces is gecancelled {e.Result.ToString()}");  // runtime exception
                LabelStatusMsg.Text = $"Achtergrond proces is gecancelled";
            }
            else if (e.Error != null)
            {
                // There was an error during the operation.
                LabelStatusMsg.Text = $"Een fout is opzettelijk opgetreden: {e.Error.Message}";
            }
            else
            {
                var backGroundResultParams = (BackGroundResultParams)e.Result;
                var startTime = backGroundResultParams.ProcessStarted.ToString("hh:mm:ss");
                var endTime = backGroundResultParams.ProcessEnded.ToString("hh:mm:ss");
                var author = backGroundResultParams.AuteurVanDitAlles;
                MessageBox.Show($"Proces is goed verlopen. " +
                    $"\nAuteur: {author}" +
                    $"\nStartTijd: {startTime}" +
                    $"\nEindTijd: {endTime}");
            }

            SetInitialButtons();
            TextBoxNumberSeconds.Enabled = true;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Deze event handler komt in aktie als BackGroundWorker.ReportProgress wordt aangeroepen
            LabelPercentage.Visible = true;

            // De infinite loop geeft altijd percentage 0 terug
            // De infinite loop geeft een instantie van VoortgangsInformatie terug in "e"

            // De OneLoop geeft wel percentages terug.
            // De OneLoop geeft een string terug in "e"

            // We krijgen één van deze 2 mogelijkheden terug

            string text = e.UserState as string;
            VoortgangsInformatie voortgangsInformatie = e.UserState as VoortgangsInformatie; 
            if (text != null) // cast via AS is gelukt
            {
                // 
                text += " / " + (e.ProgressPercentage.ToString() + "%");
                this.ProgressBar.Value = e.ProgressPercentage;
                LabelPercentage.Text = text;
                return; 
            };

            if (voortgangsInformatie != null) // cast via AS is gelukt
            {
                text = voortgangsInformatie.WhoAmI + ", ben nu " + voortgangsInformatie.NrOfSecondsProcessed + " seconde bezig";
                this.ProgressBar.Value = 0;  // Geen voortgang balk bij Infinite Loop, progress staat altijd op 0 procent 
                LabelPercentage.Text = text;
                return;
            };

        }


        private BackGroundResultParams OneLoop(BackgroundWorker bw, int nrOfSeconds)
        {

            var startDateTime = DateTime.Now;

            for (int i = 1; i <= nrOfSeconds; i++)
            {
                Thread.Sleep(1000);
                double x1 = ((double)(i) / nrOfSeconds);
                double x2 = x1 * 100;
                var x3 = (int)Math.Round(x2);

                // userState is een object en kan overal naar wijzen, hier wijst het naar string
                string userState = $"One Loop is bezig met seconde nummer {i}....."; 
                bw.ReportProgress((int)x3, userState);
            }

            var endDateTime = DateTime.Now;

            var result = new BackGroundResultParams
            {
                ProcessStarted = startDateTime,
                ProcessEnded = endDateTime
            };
            return result;
        }

        private void InfiniteLoop(BackgroundWorker bw)
        {
            int count = 0;
            var startTime = DateTime.Now; 

            while (!bw.CancellationPending)
            {
                Thread.Sleep(1000);
                count++;
                // ReportProgress: 
                // Infinite loop kent geen percentage: geef 0 mee als percentage 
                // maar geef wel mee extra gegevens via de userState
                var userState = new VoortgangsInformatie
                {
                    NrOfSecondsProcessed = (int)Math.Round((DateTime.Now.Subtract(startTime).TotalSeconds)),
                    WhoAmI = "Ik ben de oneindige loop" 
                };
                // userState is een object en kan overal naar wijzen, hier wijst het naar een instantie van ProgressInformation
                bw.ReportProgress(0, userState); 
            }
        }

        private void ExceptionLoop(BackgroundWorker bw)
        {
            Thread.Sleep(3000);
            throw new Exception("Zelfgemaakte exception occurred");

        }

        private void ButtonVeranderKleur_Click(object sender, EventArgs e)
        {
            var color = ButtonVeranderKleur.BackColor;

            if (!color.Equals(Color.Blue))
            {
                ButtonVeranderKleur.BackColor = Color.Blue;
            }
            else
            {
                ButtonVeranderKleur.BackColor = Color.Red;
            }
        }

    }
}

#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
