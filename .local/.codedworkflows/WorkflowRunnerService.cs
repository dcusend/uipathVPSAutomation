using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace VPSAutomation
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Test Cases for Training/VT-SaleTransaction.xaml
        /// </summary>
        public void VT_SaleTransaction()
        {
            var result = _runWorkflowHandler(@"Test Cases for Training\VT-SaleTransaction.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestOR2.xaml
        /// </summary>
        public void TestOR2(string DesiredBrowser, string Environment)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestOR2.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}, {"Environment", Environment}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestObjectRepository.xaml
        /// </summary>
        public void TestObjectRepository()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestObjectRepository.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestLibraryOR.xaml
        /// </summary>
        public void TestLibraryOR(string DesiredBrowser, string Environment)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestLibraryOR.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}, {"Environment", Environment}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/SetupAndLoginFromLibrary.xaml
        /// </summary>
        public void SetupAndLoginFromLibrary(string DesiredBrowser, string Environment)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\SetupAndLoginFromLibrary.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}, {"Environment", Environment}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestModules.xaml
        /// </summary>
        public void TestModules()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestModules.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestGlobalAssets.xaml
        /// </summary>
        public void TestGlobalAssets(string DesiredBrowser)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestGlobalAssets.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/SuccessfulLogIn-DataDriven.xaml
        /// </summary>
        public void SuccessfulLogIn_DataDriven(string DesiredBrowser)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\SuccessfulLogIn-DataDriven.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Account/TestCaseThree.xaml
        /// </summary>
        public void TestCaseThree()
        {
            var result = _runWorkflowHandler(@"Account\TestCaseThree.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestExceptionHandling(Autosaved).xaml
        /// </summary>
        public void TestExceptionHandling_Autosaved_()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestExceptionHandling(Autosaved).xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestDataDriven.xaml
        /// </summary>
        public void TestDataDriven()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestDataDriven.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/FailedLogIn.xaml
        /// </summary>
        public void FailedLogIn()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\FailedLogIn.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Account/TestCaseOne.xaml
        /// </summary>
        public void TestCaseOne()
        {
            var result = _runWorkflowHandler(@"Account\TestCaseOne.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestSelectors.xaml
        /// </summary>
        public void TestSelectors()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestSelectors.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestDescriptors-Library.xaml
        /// </summary>
        public void TestDescriptors_Library(string DesiredBrowser, string Environment)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestDescriptors-Library.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}, {"Environment", Environment}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestExceptionHandling.xaml
        /// </summary>
        public void TestExceptionHandling()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestExceptionHandling.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestExcel.xaml
        /// </summary>
        public void TestExcel()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestExcel.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestCaseForBrowser.xaml
        /// </summary>
        public void TestCaseForBrowser()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestCaseForBrowser.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Account/TestCaseTwo.xaml
        /// </summary>
        public void TestCaseTwo()
        {
            var result = _runWorkflowHandler(@"Account\TestCaseTwo.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public void TestCase()
        {
            var result = _runWorkflowHandler(@"TestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestExcelAccountNumbers.xaml
        /// </summary>
        public void TestExcelAccountNumbers()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestExcelAccountNumbers.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestCaseForDemo.xaml
        /// </summary>
        public void TestCaseForDemo()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestCaseForDemo.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/TestCase.xaml
        /// </summary>
        public void Test_Cases_AdminSuite_Virtual_Terminal_TestCase()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\TestCase.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/Virtual Terminal/LoginFromLibrary.xaml
        /// </summary>
        public void LoginFromLibrary(string DesiredBrowser, string Environment)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\Virtual Terminal\LoginFromLibrary.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}, {"Environment", Environment}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/Rest/BillLookup-Demo.xaml
        /// </summary>
        public void BillLookup_Demo()
        {
            var result = _runWorkflowHandler(@"Test Cases\Rest\BillLookup-Demo.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestLibraries.xaml
        /// </summary>
        public void TestLibraries()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestLibraries.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/TestGetText.xaml
        /// </summary>
        public void TestGetText()
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\TestGetText.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Test Cases/AdminSuite/SuccessfulLogIn.xaml
        /// </summary>
        public void SuccessfulLogIn(string DesiredBrowser)
        {
            var result = _runWorkflowHandler(@"Test Cases\AdminSuite\SuccessfulLogIn.xaml", new Dictionary<string, object>{{"DesiredBrowser", DesiredBrowser}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Sequence-Imtiaz.xaml
        /// </summary>
        public void Sequence_Imtiaz()
        {
            var result = _runWorkflowHandler(@"Sequence-Imtiaz.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}