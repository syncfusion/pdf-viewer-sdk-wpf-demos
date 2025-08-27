﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace syncfusion.pdfviewerdemos.wpf
{
    public class PdfViewerEventAttachUtil
    {
        public static DependencyProperty WindowLoaded = DependencyProperty.RegisterAttached("WindowLoaded", typeof(bool), typeof(PdfViewerEventAttachUtil), new PropertyMetadata(new PropertyChangedCallback(WindowLoadedChanged)));

        public static void SetWindowLoaded(DependencyObject sender, bool command)
        {
            sender.SetValue(WindowLoaded, command);
        }

        public static void WindowLoadedChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Grid grid = sender as Grid;
            if (grid != null)
            {
                Window view = grid.Parent as Window;
                if (view != null)
                {
                    if (view.ToString().Contains("MultiTabbedViewer"))
                    {
                        MultiTabbedViewerViewModel viewModel = view.DataContext as MultiTabbedViewerViewModel;
                        if (viewModel != null)
                        {
                            view.Loaded += new RoutedEventHandler(viewModel.Loaded);
                            view.Closed += new EventHandler(viewModel.Closed);
                        }
                    }
                    else if (view.ToString().Contains("CustomToolbar"))
                    {
                        CustomToolbarViewModel viewModel = view.DataContext as CustomToolbarViewModel;
                        if (viewModel != null)
                        {
                            view.Loaded += new RoutedEventHandler(viewModel.Loaded);
                            view.Closed += new EventHandler(viewModel.Closed);
                        }
                    }
                }
                else if(grid.Parent is Control)
                {
                    Control control = grid.Parent as Control;
                    EncryptionViewModel viewModel = control.DataContext as EncryptionViewModel;
                    SmartFillViewModel smartFillViewModel = control.DataContext as SmartFillViewModel;
                    SmartRedactionViewModel smartRedactionViewModel = control.DataContext as SmartRedactionViewModel;
                    SummarizerViewModel summarizerViewModel = control.DataContext as SummarizerViewModel;
                    if (viewModel != null)
                    {
                        control.Loaded += new RoutedEventHandler(viewModel.Loaded);
                        control.Unloaded += new RoutedEventHandler(viewModel.Closed);
                    }
                    else if (smartFillViewModel != null)
                    {
                        control.Loaded += new RoutedEventHandler(smartFillViewModel.Loaded);
                        control.Unloaded += new RoutedEventHandler(smartFillViewModel.Closed);
                    }
                    else if (smartRedactionViewModel != null)
                    {
                        control.Loaded += new RoutedEventHandler(smartRedactionViewModel.Loaded);
                        control.Unloaded += new RoutedEventHandler(smartRedactionViewModel.Closed);
                    }
                    else if (summarizerViewModel != null)
                    {
                        control.Loaded += new RoutedEventHandler(summarizerViewModel.Loaded);
                        control.Unloaded += new RoutedEventHandler(summarizerViewModel.Closed);
                    }
                }
            }
        }
    }
}
