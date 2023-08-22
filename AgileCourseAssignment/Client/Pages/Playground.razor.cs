using AgileCourseAssignment.Shared.Models;
using System.Timers;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Playground
    {

        private int remainingTime = 180;
        private bool countdownComplete = false;
        private List<FlagsModel> flags = new();

        private System.Timers.Timer countdownTimer;


        private async Task EndTimer()
        {
            countdownTimer.Enabled = false;
            Console.WriteLine(remainingTime);
        }

        private void CountdownTick(object sender, ElapsedEventArgs e)
        {
            // decrease by 1
            remainingTime--;

            if (remainingTime <= 0)
            {
                countdownTimer.Enabled = false;
                countdownComplete = true;
            }

            // Update the UI
            InvokeAsync(() => StateHasChanged());
        }

        protected override async void OnInitialized()
        {
            countdownTimer = new System.Timers.Timer(1000);
            countdownTimer.Elapsed += CountdownTick;
            countdownTimer.Enabled = true;
            flags = await flagService.GetRandomFlag();
            
        }
        public void Dispose()
        {
            countdownTimer.Dispose();
        }


    }
}
