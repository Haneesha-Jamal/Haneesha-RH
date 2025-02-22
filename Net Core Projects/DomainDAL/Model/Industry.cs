﻿namespace DomainDAL.Model
{
    public partial class Industry
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
