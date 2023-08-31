using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Timers;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Playground
    {

        // Ui Variables
        string question = "What flag does this country belong to?";
        string isCorrect = "";

        //gameState
        private bool isGameOver = false;

        //gameVariables
        private int currentQuestionIndex = 0;
        private int currentQuestionNumber = 1;

        private int flagPoints = 0;
        private int convertedToTimePonts;
        private int finalResult;

        private int randomFlag1 = new Random().Next(1,25);
        //time
        private int remainingTime = 180;
        private bool countdownComplete = false;
        private System.Timers.Timer countdownTimer;
        ///Data
        private List<FlagsModel> CompletedList = new(); // second list to get 
        private FlagsModel CurrentQuestion = new();

        //test
        List<FlagsModel> ButtonShuffle = new();
        private int pressed = new();

        // TODO flowchart
        // 1. Get data from server and save in List variable
        // 2. Make the order in list random
        // 3. Save that list to a field variable that has access in the file.
        // 4. To Use a object in list we need the single version of the object the class of the list, so we have the index and can iterate through it with each button press
        // 5. 


        protected override async void OnInitialized()
        {
            countdownTimer = new System.Timers.Timer(1000);
            countdownTimer.Elapsed += CountdownTick;
            countdownTimer.Enabled = true;

            //  Gets data from service that gets its data from Api and then we save it in a list
            List<FlagsModel> flags = new();
            flags = await flagService.GetAllFlags();

            // Shuffle the list to get a random order of items
            List<FlagsModel> shuffledFlags = flags.OrderBy(x => Guid.NewGuid()).ToList();

            // Get the first 25 items (randomly selected)
            List<FlagsModel> randomFlags = shuffledFlags.Take(25).ToList();

            // Save the changes to a list that will have accsess everywhere in the file
            CompletedList = randomFlags;

            // Take out a single object from the list and convert it to the class assiociated with
            // also we need index to get where we are at the moment in the list and the standard value 0
            CurrentQuestion = CompletedList[currentQuestionIndex];

            Console.WriteLine(CompletedList.Count);
        }

        // This method is connected to button with the "Onclick"
        private void CheckAnswer(int getAnswer)
        {
            // each time a button is pressed increase the currents question number
             currentQuestionNumber++;

            // if statement to to make sure the index of currentquestionIndex does not go out of bounds
            if(currentQuestionNumber < 25)
            {

                if (getAnswer == currentQuestionIndex)
                {
                    Console.WriteLine($"Correct answer {randomFlag1}");
                    // each time we guess correctly add current flagpoint to itself
                    // it can be written like this also(means the same thing)//  flagpoints = flagpoints + 25;    which means take current value of variable add 25 and then update the variable;
                    flagPoints += 25;
                }
                else
                {
                    Console.WriteLine($"Wrong answer{randomFlag1}");
                }
                currentQuestionIndex++;
                CurrentQuestion = CompletedList[currentQuestionIndex];
            }
            else if(currentQuestionNumber == 25)
            {
                
                    EndTimer();
                    isGameOver = true;
                // re renders ui
                    StateHasChanged();
                

            }

            


            randomFlag1 = new Random().Next(1,25);
            pressed++;
            Console.WriteLine($"pressed {pressed}");
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
        public void Dispose()
        {
            countdownTimer.Dispose();
        }
        private async Task EndTimer()
        {
            countdownTimer.Enabled = false;
            convertedToTimePonts = remainingTime * 5;

            finalResult = convertedToTimePonts + flagPoints;
            Console.WriteLine($"Current time remaining {remainingTime}seconds || converted to points = ({convertedToTimePonts}Points)");
            Console.WriteLine($"Correct flagspoints = {flagPoints}points");
        }


    }
}
