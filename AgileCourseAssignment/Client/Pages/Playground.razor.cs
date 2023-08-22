using AgileCourseAssignment.Shared.Models;
using System.Timers;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Playground
    {
        FlagsModel theFlag;
        //gameVariables
        string currentCountryName = "";
        string question = "What flag does this country belong to?";
        private int currentQuestionIndex = 0;
        private int currentQuestionNumber = 1;
        //time
        private int remainingTime = 180;
        private bool countdownComplete = false;
        private List<FlagsModel> flags = new();
        private System.Timers.Timer countdownTimer;

        private List<FlagsModel> CompletedList = new();

        string isCorrect = "";
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

            flags = await flagService.GetAllFlags();

            // Shuffle the list to get a random order of items
            List<FlagsModel> shuffledFlags = flags.OrderBy(x => Guid.NewGuid()).ToList();

            // Get the first 25 items (randomly selected)
            List<FlagsModel> randomFlags = shuffledFlags.Take(25).ToList();

            CompletedList = randomFlags;    
        }

        private void CheckAnswer(FlagsModel selectedFlag)
        {
           
            if (selectedFlag.Id == CompletedList[currentQuestionIndex].Id)
            {
                // Handle correct answer logic
                Console.WriteLine("Correct");
                isCorrect = "Correct";
            }
            else
            {
                // Handle incorrect answer logic
                Console.WriteLine("Incorrect");
                isCorrect = "Wrong";
            }

            currentQuestionIndex++;
            currentQuestionNumber++;

            if (currentQuestionIndex < CompletedList.Count)
            {
                currentCountryName = CompletedList[currentQuestionIndex].CountryName;
            }
            else
            {
                // Quiz completed
            }

            //// Update the UI
            //await InvokeAsync(() => StateHasChanged());

        }
        public void Dispose()
        {
            countdownTimer.Dispose();
        }

    }
}
