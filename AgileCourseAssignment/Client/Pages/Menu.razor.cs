﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Xml.Serialization;

namespace AgileCourseAssignment.Client.Pages
{
    public partial class Menu
    {
        public Menu()
        { 

        }

 


        //TEST
        private bool isImg;
        private string imgTop = "0px";
        



        private void NavigateToPlayground()
        {
            Navigation.NavigateTo("/playground");
        }

        private void NavigateToHome()
        {
            Navigation.NavigateTo("/");
        }
        private void ActivateImg(int currentButon)
        {
            if (currentButon == 1) {
                isImg = true;
                imgTop = "-5px";

            }
            else if (currentButon == 2)
            {

                isImg = true;
                imgTop = "45px";
            }
            else if (currentButon == 3)
            {
                isImg = true;
                imgTop = "95px";
            }
           
        }

        private void DeactivateImg()
        {
            isImg = false;
        }

    }
}