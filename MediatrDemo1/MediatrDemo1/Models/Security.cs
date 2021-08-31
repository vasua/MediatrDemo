using System;

namespace MediatrDemo1.Models
{
    public record Security
    {
        public Guid Ik { get; } = Guid.NewGuid();
        public string Id { get; init; }
        public string Name { get; init; }
        public double IssuePrice { get; init; }
    }
}