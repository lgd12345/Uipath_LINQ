using Coded_Automation.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Coded_Automation
{
    public class Workflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            // To start using services, use IntelliSense (CTRL + Space) to discover the available services: e.g:
            // 서비스 사용을 시작하려면 IntelliSense(CTRL + Space)를 사용하여 사용 가능한 서비스를 검색합니다: 예:
            
            //  system.GetAsset(...)

            // For accessing UI Elements from Object Repository, you can use the Descriptors class e.g:
            // Object Repository에서 UI Elements에 액세스하는 경우 Descriptors 클래스를 사용할 수 있습니다. 예:
            
            // var screen = uiAutomation.Open(Descriptors.MyApp.FirstScreen);
            // screen.Click(Descriptors.MyApp.FirstScreen.SettingsButton);
            
            var screen = uiAutomation.Open("Main");
            screen.TypeInto("FirstName","Thomas");
            screen.TypeInto("LastName","Janssen");
            
            screen.SelectItem("State","WA");
            
            screen.Click("OrderTab");
            screen.Click("SaveButton");
            screen.Click("OkButton");
            
            
        }
    }
}