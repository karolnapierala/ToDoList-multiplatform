using System;
using ToDoList.Core;
using ToDoList.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WorkTasksPage();

            var database = new ToDoListDbContext();

            database.Database.EnsureCreated();
            DatabaseLocator.DataBase = database;

            BindingContext = new WorkTasksPageViewModel();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
