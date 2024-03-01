namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Indexer
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        // GetItem and SetItem
        public string GetItem(string key)
        {
            return _dictionary[key];
        }

        public void SetItem(string key, string value)
        {
            _dictionary[key] = value;
        }
    }
}
