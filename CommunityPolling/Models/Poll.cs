using System.Collections.Generic;

namespace CommunityPolling.Models
{
    public class Poll
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string>();

        // Optional: store votes in-memory for demo (not persisted)
        public List<int> Votes { get; set; } = new List<int>();
    }
}