namespace QueuieSytems.Services
{
    public class BodyClassService
    {

    private string _currentClass = "";

        public event Action<string>? OnClassChanged;

        public void SetBodyClass(string className)
        {
            _currentClass = className;
            OnClassChanged?.Invoke(className);
        }

        public string GetBodyClass() => _currentClass;
    }
}
