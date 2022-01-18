using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkTask : ViewCell
    {
        public WorkTask()
        {
            InitializeComponent();
        }
    }
}