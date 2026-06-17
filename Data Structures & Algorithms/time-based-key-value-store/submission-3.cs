public class TimeMap {
    private Dictionary<string, Dictionary<int, string>> dict;
    public TimeMap() {
        dict = new Dictionary<string, Dictionary<int, string>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (dict.ContainsKey(key)) 
        {
            var dict2 = dict[key];
            dict2[timestamp] = value;
        }
        else
        {
            var dict2 = new Dictionary<int, string>(); 
            dict2[timestamp] = value;
            
            dict[key] = dict2;
        }
    }
    
    public string Get(string key, int timestamp) {
        if (!dict.ContainsKey(key)) return string.Empty;

        var dict2 = dict[key];
        int counter = timestamp;
        while (counter >= 0 && !dict2.ContainsKey(counter)) counter--;

        if (counter >= 0) return dict2[counter];
        else return string.Empty;
    }
}
