public class Twitter {

    private int counter;
    private Dictionary<int, HashSet<int>> follows;
    private Dictionary<int,  List<(int, int)>> tweets;

    public Twitter() {
        counter = 0;
        follows = new Dictionary<int, HashSet<int>>();
        tweets = new Dictionary<int,  List<(int, int)>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        if (!tweets.ContainsKey(userId)) tweets[userId] = new List<(int, int)>();     

        tweets[userId].Add((tweetId, counter));
        if (tweets[userId].Count > 10) tweets[userId].RemoveAt(0);

        counter--;
    }
    
    public List<int> GetNewsFeed(int userId) {
        var result = new List<int>();

        if (!follows.ContainsKey(userId)) follows[userId] = new HashSet<int>();
        follows[userId].Add(userId);

        var users = follows[userId].ToList();
        var maxheap = new PriorityQueue<int, int>();

        // users -> на кого підписаний конкретний юзер
        // tweets[user] -> твіти конкретного

        foreach (var user in users)
        {
            if (!tweets.ContainsKey(user)) continue;

            foreach (var (tw, co) in tweets[user])
            {
                maxheap.Enqueue(tw, co);
            }
        }

        for (int i = 0; i < 10 && maxheap.Count > 0; i++)
        {
            result.Add(maxheap.Dequeue());
        }

        return result;
    }
    
    public void Follow(int followerId, int followeeId) {
        if (!follows.ContainsKey(followerId)) 
            follows[followerId] = new HashSet<int>();     

        follows[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        follows[followerId].Remove(followeeId);      
    }
}
