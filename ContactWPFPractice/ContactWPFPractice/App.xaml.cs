﻿using System.Configuration;
using System.Data;
using System.Windows;

namespace ContactWPFPractice;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    static string databaseName = "ContactTest.db";
    static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);
}

