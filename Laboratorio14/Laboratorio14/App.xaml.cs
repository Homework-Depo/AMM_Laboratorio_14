﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Laboratorio14.Views;
using Laboratorio14.DataContext;

namespace Laboratorio14
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new ProductList();
        }

        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

