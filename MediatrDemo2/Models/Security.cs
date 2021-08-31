using System;

namespace MediatrDemo2.Models
{
    public record Security
    {
        public Guid Ik { get; } = Guid.NewGuid();
        public string Id { get; init; }
        public string Name { get; init; }
        public double IssuePrice { get; init; }
        public string Status { get; set; }
    }
}