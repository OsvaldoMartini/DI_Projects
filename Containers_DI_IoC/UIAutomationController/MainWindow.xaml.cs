using System;
using System.Linq;
using System.Windows;
using System.Threading;
using Automation = System.Windows.Automation;
using System.Windows.Automation;
using System.Windows.Threading;
using UIAutomationController.Util;
using UIAutomationController.ViewModel;

///
/// @author Osvaldo Martini
///


namespace UIAutomationController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        private delegate void SetMessageCallback(string message);

        public NotifyObservableCollection<WindowTitleVM> _WindowTestsViewModel { get; set; }


    
    public MainWindow()
        {
            InitializeComponent();

            this._WindowTestsViewModel = new WindowTitleVmCollection(null);
            this.LstTitles.ItemsSource = this._WindowTestsViewModel;
        }
      
        private void btnStartAutomation_Click(object sender, RoutedEventArgs e)
        {
            Thread automateThread = new Thread(new ThreadStart(Automate));
            automateThread.Start();
        }

        private void Automate()
        {
            LogMessage("Getting RootElement...");
            AutomationElement rootElement = AutomationElement.RootElement;
            if (rootElement != null)
            {
                LogMessage("OK." + Environment.NewLine);

                Automation.Condition condition = new PropertyCondition(AutomationElement.NameProperty, _WindowTestsViewModel.FirstOrDefault().WindowTitle);

                LogMessage("Searching for Test Window...");
                AutomationElement appElement = rootElement.FindFirst(TreeScope.Children, condition);

                if (appElement != null)
                {
                    LogMessage("OK " + Environment.NewLine);
                    LogMessage("Searching for TextBox A control...");
                    AutomationElement txtElementA = GetTextElement(appElement, "txtA");
                    if (txtElementA != null)
                    {
                        LogMessage("OK " + Environment.NewLine);
                        LogMessage("Setting TextBox A value...");
                        try
                        {
                            ValuePattern valuePatternA = txtElementA.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                            valuePatternA.SetValue("10");
                            LogMessage("OK " + Environment.NewLine);
                        }
                        catch
                        {
                            WriteLogError();
                        }
                    }
                    else
                    {
                        WriteLogError();
                    }

                    LogMessage("Searching for TextBox B control...");
                    AutomationElement txtElementB = GetTextElement(appElement, "txtB");
                    if (txtElementA != null)
                    {
                        LogMessage("OK " + Environment.NewLine);
                        LogMessage("Setting TextBox B value...");
                        try
                        {
                            ValuePattern valuePatternB = txtElementB.GetCurrentPattern(ValuePattern.Pattern) as ValuePattern;
                            valuePatternB.SetValue("5");
                            LogMessage("OK " + Environment.NewLine);
                        }
                        catch
                        {
                            WriteLogError();
                        }
                    }
                    else
                    {
                        WriteLogError();
                    }
                }
                else
                {
                    WriteLogError();
                }
            }
        }

        private AutomationElement GetTextElement(AutomationElement parentElement, string value)
        {
            Automation.Condition condition = new PropertyCondition(AutomationElement.AutomationIdProperty, value);
            AutomationElement txtElement = parentElement.FindFirst(TreeScope.Descendants, condition);
            return txtElement;
        }

        private void btnAddWindowTitles_Click(object sender, RoutedEventArgs e)
        {
            var obj = _WindowTestsViewModel.Where(p => p.WindowTitle.Contains(TxtWindowTitle.Text)).FirstOrDefault();
            if (obj == null)
            {
                this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new SetMessageCallback(DisplayListWindowTests), TxtWindowTitle.Text);
            
            TxtWindowTitle.Text = string.Empty;
        }}

        private void DisplayListWindowTests(string message)
        {
            _WindowTestsViewModel.Add(new WindowTitleVM() { WindowTitle = message });
        }


        private void DisplayLogMessage(string message)
        {
            TxtLogs.Text += message;
        }

        
        private void LogMessage(string message)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new SetMessageCallback(DisplayLogMessage), message);
        }

        private void WriteLogError()
        {
            LogMessage("ERROR." + Environment.NewLine);
        }
    }
}
