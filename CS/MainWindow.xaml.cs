using System;
using System.Windows;

namespace RichEditWordCountStatusBarWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            UpdateStatusBar();
        }

        private void richEditControl1_ContentChanged(object sender, EventArgs e) {
            UpdateStatusBar();
        }

        private void UpdateStatusBar() {
            siWords.Content = richEditControl1.WordCount;
        }
    }
}