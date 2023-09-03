using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Menu
    {
        public Menu()
        { 

        }

        private bool isMouseOn;
        private bool isMouseOn2;
        






        private void NavigateToPlayground()
        {
            Navigation.NavigateTo("/playground");
        }


        private void ActivateImg(int currentButon)
        {
            if(currentButon == 1) {
                isMouseOn = true;
                isMouseOn2 = false;
            }
            else if(currentButon == 2)
            {
                isMouseOn2 = true;
                isMouseOn = false;
            }
           
        }

        private void DeactivateImg()
        {
            isMouseOn = false;
            isMouseOn2 = false;
        }
    }
}
