﻿using HW13.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Concurrent;

namespace HW13.Common.Drivers
{
    public class WebDriverFactory
    {
        private static readonly ConcurrentDictionary<string, IWebDriver> DriverCollection = new(); // collection created to isolate threads for possible parallelization
        
        public static IWebDriver Driver
        {
            get
            {
                if (!DriverCollection.ContainsKey(Data.TestContextValues.ExecutableClassName)) // if driver is not initialized yet we do it
                {
                    InitializerDriver();
                }

                return DriverCollection.First(pair => pair.Key == Data.TestContextValues.ExecutableClassName).Value; // return Driver for needs test class 
            }

            private set => DriverCollection.TryAdd(Data.TestContextValues.ExecutableClassName, value); //new DriverCommand will be assigned only if driver collection doesn't contains value by this key
        }

        public static Actions Actions => new(Driver); // return instance of actions

        public static IJavaScriptExecutor JavaScriptExecutor => (IJavaScriptExecutor)Driver; // return instance of Ijavascriptexecutor

        public static void QuitDriver() => Driver.Quit();

        private static void InitializerDriver() //initialization method for driver
        {
            Driver = TestSettings.Browser switch
            {
                Data.Enums.Browsers.Chrome => new ChromeDriver(),
                _ => throw new InvalidOperationException(),
            };

            Driver.Manage().Window.Maximize();
        }
    }
}
