using AgileCourseAssignment.Client.Services;
using AgileCourseAssignment.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Timers;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Playground2
    {
        [Inject]
        private IHighScoreService HighScoreService { get; set; }
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

        private int randomFlag1 = new Random().Next(1, 25);

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
        private int test = new Random().Next(1, 25);
        private int test2 = new Random().Next(1, 25);
        private FlagsModel randomTestFlag = new();
        private FlagsModel randomTestFlag2 = new();

        private bool isRegistred = false;
        private string responsemessage;
        private bool wrongRegisterTypo = false;
        private bool nameAlreadyExist = false;


        List<FlagsModel> playListCompleted = new List<FlagsModel>();
        // TODO flowchart
        // 1. Get data from server and save in List variable
        // 2. Make the order in list random
        // 3. Save that list to a field variable that has access in the file.
        // 4. To Use a object in list we need the single version of the object the class of the list, so we have the index and can iterate through it with each button press
        // 5. 


        private List<string> chosenCountries = new List<string>();
        private List<string> userAnswers = new List<string>();

        protected override async void OnInitialized()
        {

            //  Gets data from service that gets its data from Api and then we save it in a list
            List<FlagsModel> flags = new();
            flags = await flagService.GetAllFlags();

            // Shuffle the list to get a random order of items
            List<FlagsModel> shuffledFlags = flags.OrderBy(x => Guid.NewGuid()).ToList();

            // Get the first 25 items (randomly selected)
            List<FlagsModel> randomFlags = shuffledFlags.Take(26).ToList();

            // Save the changes to a list that will have accsess everywhere in the file
            CompletedList = randomFlags;

            // Take out a single object from the list and convert it to the class assiociated with
            // also we need index to get where we are at the moment in the list and the standard value 0
            CurrentQuestion = CompletedList[currentQuestionIndex];

            test = new Random().Next(1, 25);

            while (currentQuestionIndex == test)
            {
                test = new Random().Next(1, 25);
            }
            randomTestFlag = CompletedList[test];

            test2 = new Random().Next(1, 25);
            while (currentQuestionIndex == test2 || test == test2)
            {
                if (test2 == test)
                {

                    test2 = new Random().Next(1, 25);
                }
                if (test2 == currentQuestionIndex)
                {

                    test2 = new Random().Next(1, 25);
                }
            }
            randomTestFlag2 = CompletedList[test2];

            List<FlagsModel> shuffleThePlayList = new List<FlagsModel>();
            shuffleThePlayList.Add(CurrentQuestion);
            shuffleThePlayList.Add(randomTestFlag);
            shuffleThePlayList.Add(randomTestFlag2);

            List<FlagsModel> randomizePlayList = shuffleThePlayList.OrderBy(x => Guid.NewGuid()).ToList();
            playListCompleted = randomizePlayList;

            countdownTimer = new System.Timers.Timer(1000);
            countdownTimer.Elapsed += CountdownTick;
            countdownTimer.Enabled = true;

            StateHasChanged();
        }

        // This method is connected to button with the "Onclick"
        private void CheckAnswer(int getAnswer)
        {
            // each time a button is pressed increase the currents question number
            playListCompleted.Clear();
            List<FlagsModel> shuffleThePlayList = new List<FlagsModel>();
            currentQuestionNumber++;

            // if statement to to make sure the index of currentquestionIndex does not go out of bounds
            if (currentQuestionNumber < 26)

            {

                if (getAnswer == CurrentQuestion.Id)
                {
                    Console.WriteLine($"Correct answer {randomFlag1}");
                    // each time we guess correctly add current flagpoint to itself
                    // it can be written like this also(means the same thing)//  flagpoints = flagpoints + 25;    which means take current value of variable add 25 and then update the variable;
                    flagPoints += 25;
                    userAnswers.Add(CurrentQuestion.CountryName);
                    chosenCountries.Add(CurrentQuestion.CountryName);
                }
                else
                {
                    FlagsModel wrongFlag = CompletedList.Where(x => x.Id == getAnswer).FirstOrDefault();
                    chosenCountries.Add(wrongFlag.CountryName);
                    Console.WriteLine($"Wrong answer{randomFlag1}");
                    userAnswers.Add(CurrentQuestion.CountryName);
                }
                currentQuestionIndex++;
                CurrentQuestion = CompletedList[currentQuestionIndex];
                shuffleThePlayList.Add(CurrentQuestion);
            }

            else if (currentQuestionNumber == 26)
            {

                EndTimer();
                isGameOver = true;
                // re renders ui
                StateHasChanged();
            }
            test = new Random().Next(1, 25);

            while (currentQuestionIndex == test)
            {
                test = new Random().Next(1, 25);
            }
            randomTestFlag = CompletedList[test];

            test2 = new Random().Next(1, 25);
            while (currentQuestionIndex == test2 || test == test2)
            {
                if (test2 == test)
                {

                    test2 = new Random().Next(1, 25);
                }
                if (test2 == currentQuestionIndex)
                {

                    test2 = new Random().Next(1, 25);
                }
            }
            randomTestFlag2 = CompletedList[test2];


            shuffleThePlayList.Add(randomTestFlag);
            shuffleThePlayList.Add(randomTestFlag2);

            List<FlagsModel> randomizePlayList = shuffleThePlayList.OrderBy(x => Guid.NewGuid()).ToList();
            playListCompleted = randomizePlayList;

            Console.WriteLine(playListCompleted.Count);
            pressed++;
            Console.WriteLine($"pressed {pressed}");

            var correctCountryName = CompletedList[currentQuestionIndex].CountryName;

            StateHasChanged();

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

        /// <summary> Insert score in the database  </summary>

        private string playerName = "";
        private string errorMessageDisplay = "";
        private async Task RegisterScoreAsync()
        {
            wrongRegisterTypo = false;
            nameAlreadyExist = false;

            var playerScore = new HighScoreModel
            {
                Name = playerName,
                Time = remainingTime,
                Score = finalResult
            };
            if (string.IsNullOrWhiteSpace(playerName))
            {
                wrongRegisterTypo = true;
                errorMessageDisplay = "Name can't be null";
            }
            else if (playerName.Length < 3)
            {
                wrongRegisterTypo = true;
                errorMessageDisplay = "Must be more than three characters!";
            }
            else if (playerName.Contains("@") || playerName.Contains("#"))
            {
                wrongRegisterTypo = true;
                errorMessageDisplay = "Can't contain special characters";
            }
            else
            {

                if (await HighScoreService.AddScoreAsync(playerScore) != null)
                {
                    responsemessage = "The score has been successfully added!";
                    isRegistred = true;
                }
                else
                {
                    nameAlreadyExist = true; 
                    responsemessage = "Sorry, that name already exists.";
                };
            }
        }

        private void ToMenu()
        {
            navigation.NavigateTo("/Menu");
        }

    }
}

