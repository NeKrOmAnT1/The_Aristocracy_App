using System.Windows;

namespace CommonLibrarySTI
{
    public class WindowManager
    {
        public static void OpenWindow<T>(object viewModel = null) where T : Window, new()
        {
            var window = new T();
            window.DataContext = viewModel;
            window.Show();

            CloseCurrentWindow();
        }

        private static void CloseCurrentWindow()
        {
            var currentWindow = Application.Current.Windows.OfType<Window>().FirstOrDefault();
            currentWindow?.Close();
        }
    }
}
