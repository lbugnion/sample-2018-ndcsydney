﻿using Data.ViewModel;
using System;
using UIKit;

namespace HelloIos
{
	public class Application
	{
        private static ViewModelLocator _locator;

        public static ViewModelLocator Locator 
            => _locator ?? (_locator = new ViewModelLocator());

		// This is the main entry point of the application.
		static void Main(string[] args)
		{
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            try
            {
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch (Exception ex)
            {

            }

        }
	}
}