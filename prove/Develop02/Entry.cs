namespace Develop02
{

    public class Entry
    {
        public string _prompt;
        public string _entry;
        public string _dateString;

        public string getPrompt()
        {
            return _prompt;
        }

        public string getEntry()
        {
            return _entry;
        }

        public void StorePrompt(string prompt)
        {
            this._prompt = prompt;
        }

        public void StoreResponse(string entry)
        {
            this._entry = entry;
        }

        public void StoreDateString(string dateString)
        {
            this._dateString = dateString;
        }

        public string getDateString()
        {
            DateTime currentTime = DateTime.Now;
            string currentDate = currentTime.ToShortDateString();
            return currentDate;
        }
    }
}